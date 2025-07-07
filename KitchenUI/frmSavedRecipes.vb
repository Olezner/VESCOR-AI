Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class frmSavedRecipes
    Private panelList As New Dictionary(Of Button, Panel) ' Store buttons & panels
    Private buttonList As New List(Of Button) ' Store buttons for position adjustment
    Private addedDishes As New List(Of String)() ' Track added dishes to avoid repetition


    Private Sub frmSavedRecipes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Nothing
        PnlDishTitle.AutoScroll = True
        PnlDishTitle.HorizontalScroll.Enabled = False ' Disable horizontal scrolling
        PnlDishTitle.AutoScrollMinSize = New Size(0, PnlDishTitle.Height) ' Ensure vertical scroll

        ' Add event handler for search bar
        AddHandler txtSearch.TextChanged, AddressOf SearchRecipes

        LoadSavedRecipes()

        btnSaveRecipe.Visible = False ' Hide save button initially
    End Sub

    Private Sub frmSavedRecipes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent default behavior
        End If
    End Sub

    Private Sub SearchRecipes(sender As Object, e As EventArgs)
        Dim searchText As String = txtSearch.Text.Trim().ToLower()
        Dim yOffset As Integer = 10 ' Adjust starting position for alignment

        ' Iterate through all buttons inside PnlDishTitle
        For Each btn As Button In PnlDishTitle.Controls.OfType(Of Button)()
            If btn.Text.Trim().ToLower().Contains(searchText) Then
                btn.Visible = True
                btn.Top = yOffset
                yOffset += btn.Height + 5 ' Adjust for spacing
            Else
                btn.Visible = False
            End If
        Next

        ' Force UI to refresh after filtering
        PnlDishTitle.Refresh()
    End Sub
    Private Sub LoadSavedRecipes()
        Dim connString As String = SQL_Connection.ConnectionString
        Dim query As String = "SELECT DishName FROM tblsavedrecipes WHERE USERID=@user_id ORDER BY timelog DESC"

        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@user_id", Module1.CurrentUserID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Clear previous buttons before reloading
                PnlDishTitle.Controls.Clear()
                buttonList.Clear() ' Reset button list
                addedDishes.Clear()

                Dim yPos As Integer = 5 ' Start position for buttons

                While reader.Read()
                    Dim dishName As String = reader("DishName").ToString()

                    ' Ensure the dish is not added twice
                    If Not addedDishes.Contains(dishName) Then
                        addedDishes.Add(dishName)

                        ' Create button for the recipe
                        Dim btnRecipe As New Button()
                        btnRecipe.Text = dishName
                        btnRecipe.Width = 238
                        btnRecipe.Height = 51
                        btnRecipe.AutoSize = False
                        btnRecipe.TextAlign = ContentAlignment.MiddleCenter
                        btnRecipe.Padding = New Padding(5)

                        ' Apply styles
                        btnRecipe.BackColor = Color.Teal
                        btnRecipe.ForeColor = Color.GhostWhite
                        btnRecipe.FlatStyle = FlatStyle.Flat
                        btnRecipe.FlatAppearance.BorderSize = 0
                        btnRecipe.Font = New Font(btnRecipe.Font.FontFamily, 10, FontStyle.Bold)

                        ' Apply rounded corners
                        AddHandler btnRecipe.Paint, Sub(s, e)
                                                        Dim btn As Button = DirectCast(s, Button)
                                                        Dim radius As Integer = 13
                                                        Dim path As GraphicsPath = GetRoundedRectanglePath(New Rectangle(0, 0, btn.Width, btn.Height), radius)
                                                        btn.Region = New Region(path)
                                                    End Sub
                        ' Add event handler
                        AddHandler btnRecipe.Click, AddressOf ShowRecipeDetails

                        ' Store button in global list
                        buttonList.Add(btnRecipe)

                        ' Set position and add to panel
                        btnRecipe.Location = New Point(10, yPos)
                        PnlDishTitle.Controls.Add(btnRecipe)
                        yPos += btnRecipe.Height + 10 ' Adjust spacing
                    End If
                End While
            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("General error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function GetRoundedRectanglePath(rect As Rectangle, radius As Integer) As GraphicsPath ' Function for rounded rectangle
        Dim path As New GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Return path
    End Function
    ' Show recipe details in the PnlDishIngredients panel when a dish title is clicked
    ' Store references to controls for editing
    Private txtIngredients As TextBox
    Private txtInstructions As TextBox
    Private lblDetails As Label
    Private selectedDish As String = ""
    Private isEditing As Boolean = False ' Flag to track editing mode
    Private previousSelectedButton As Button = Nothing

    Private Sub ShowRecipeDetails(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        selectedDish = btn.Text ' Store the selected dish name
        isEditing = False ' Reset editing mode

        ' Reset the previous button color if it exists
        If previousSelectedButton IsNot Nothing AndAlso previousSelectedButton IsNot btn Then
            previousSelectedButton.BackColor = Color.Teal ' Default color
            previousSelectedButton.ForeColor = Color.GhostWhite
        End If

        ' Change the selected button color
        btn.BackColor = Color.FromArgb(181, 231, 160) ' Soft Mint Green
        btn.ForeColor = Color.Black

        ' Update the previous selected button reference
        previousSelectedButton = btn

        Dim connString As String = SQL_Connection.ConnectionString
        Dim query As String = "SELECT Ingredients, Instructions, timelog FROM tblsavedrecipes WHERE DishName=@dishName AND USERID=@user_id"

        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@dishName", selectedDish)
                cmd.Parameters.AddWithValue("@user_id", Module1.CurrentUserID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' Get values from the database
                    Dim timelog As String = reader("timelog").ToString()
                    Dim ingredients As String = reader("Ingredients").ToString()
                    Dim instructions As String = reader("Instructions").ToString()

                    ' Display the recipe details inside txtRecipe
                    txtRecipe.Text = $"Time: {timelog}{vbCrLf}{vbCrLf}" &
                                 $"Ingredients:{vbCrLf}{ingredients}{vbCrLf}{vbCrLf}" &
                                 $"Instructions:{vbCrLf}{instructions}"

                    ' Ensure the TextBox is properly formatted
                    txtRecipe.Visible = True
                    txtRecipe.Multiline = True
                    txtRecipe.ScrollBars = ScrollBars.Vertical
                    txtRecipe.ReadOnly = True ' Prevent accidental editing
                    txtRecipe.ForeColor = Color.GhostWhite
                Else
                    txtRecipe.Text = "Recipe not found."
                End If

                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("General error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Check if this form has an MDI parent (frmMain)
        If Me.MdiParent IsNot Nothing AndAlso TypeOf Me.MdiParent Is frmMain Then
            ' Reference the MDI parent (frmMain)
            Dim mainForm As frmMain = CType(Me.MdiParent, frmMain)

            ' Hide this form instead of closing it
            Me.Hide()

            ' Show the main panel of frmMain
            mainForm.pnlHome.Visible = True
            mainForm.pnlHome.BringToFront() ' Ensure it's in focus
        Else
            ' If not an MDI child, just hide this form
            Me.Hide()
        End If
    End Sub

    Private Sub btnSaveRecipe_Click(sender As Object, e As EventArgs) Handles btnSaveRecipe.Click
        If String.IsNullOrEmpty(selectedDish) OrElse Not isEditing Then
            MessageBox.Show("No recipe selected or not in edit mode.")
            Return
        End If

        ' Read and clean the text input
        Dim recipeText As String = txtRecipe.Text.Trim()

        ' Ensure it contains both "Ingredients:" and "Instructions:"
        If Not recipeText.Contains("Ingredients:") OrElse Not recipeText.Contains("Instructions:") Then
            MessageBox.Show("Invalid recipe format. Make sure the recipe includes both 'Ingredients:' and 'Instructions:'")
            Return
        End If

        ' Extract ingredients and instructions
        Dim ingredientsStart As Integer = recipeText.IndexOf("Ingredients:") + "Ingredients:".Length
        Dim instructionsStart As Integer = recipeText.IndexOf("Instructions:")

        If ingredientsStart >= instructionsStart Then
            MessageBox.Show("Invalid recipe format. Make sure 'Instructions:' comes after 'Ingredients:'.")
            Return
        End If

        Dim updatedIngredients As String = recipeText.Substring(ingredientsStart, instructionsStart - ingredientsStart).Trim()
        Dim updatedInstructions As String = recipeText.Substring(instructionsStart + "Instructions:".Length).Trim()

        ' Ensure extracted data is not empty
        If String.IsNullOrWhiteSpace(updatedIngredients) OrElse String.IsNullOrWhiteSpace(updatedInstructions) Then
            MessageBox.Show("Ingredients or Instructions cannot be empty.")
            Return
        End If

        ' Database update query
        Dim connString As String = SQL_Connection.ConnectionString
        Dim query As String = "UPDATE tblsavedrecipes SET Ingredients=@ingredients, Instructions=@instructions WHERE DishName=@dishName AND USERID=@user_id"
        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@ingredients", updatedIngredients)
                cmd.Parameters.AddWithValue("@instructions", updatedInstructions)
                cmd.Parameters.AddWithValue("@dishName", selectedDish.Trim())
                cmd.Parameters.AddWithValue("@user_id", Module1.CurrentUserID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    ' Maintain format after saving
                    txtRecipe.Text = $"Time: {DateTime.Now}{vbCrLf}{vbCrLf}" &
                                 $"Ingredients:{vbCrLf}{updatedIngredients}{vbCrLf}{vbCrLf}" &
                                 $"Instructions:{vbCrLf}{updatedInstructions}"

                    txtRecipe.ReadOnly = True
                    btnSaveRecipe.Visible = False
                    btnEditRecipe.Enabled = True
                    isEditing = False

                    ' Re-enable all recipe selection buttons after saving
                    For Each btn As Button In buttonList
                        btn.Enabled = True
                    Next
                Else
                    MessageBox.Show("No changes detected or failed to update the recipe.")
                End If
            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("General error: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub btnEditRecipe_Click(sender As Object, e As EventArgs) Handles btnEditRecipe.Click
        If String.IsNullOrEmpty(selectedDish) Then
            MessageBox.Show("Please select a recipe to edit.")
            Return
        End If

        ' Enable editing mode
        txtRecipe.ReadOnly = False ' Allow editing
        btnSaveRecipe.Visible = True ' Show save button
        btnEditRecipe.Enabled = False ' Disable edit button while editing
        isEditing = True

        ' Disable all other recipe selection buttons
        For Each btn As Button In buttonList
            btn.Enabled = False
        Next
    End Sub
    Private Sub btnDeleteRecipe_Click(sender As Object, e As EventArgs) Handles btnDeleteRecipe.Click
        If String.IsNullOrEmpty(selectedDish) Then
            MessageBox.Show("Please select a recipe to delete.")
            Return
        End If

        Dim connString As String = SQL_Connection.ConnectionString
        Dim query As String = "DELETE FROM tblsavedrecipes WHERE DishName=@dishName AND USERID=@user_id"
        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@dishName", selectedDish)
                cmd.Parameters.AddWithValue("@user_id", Module1.CurrentUserID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Recipe deleted successfully.")

                    ' Refresh the saved recipes list
                    LoadSavedRecipes()

                    ' Clear details panel
                    txtRecipe.Text = ""
                    selectedDish = ""
                    btnSaveRecipe.Visible = False
                    btnEditRecipe.Enabled = False ' Keep disabled if no selection

                    ' Re-enable Edit button only if there are remaining recipes
                    If PnlDishTitle.Controls.OfType(Of Button)().Any(Function(b) b.Visible) Then
                        btnEditRecipe.Enabled = True
                    End If

                Else
                    MessageBox.Show("Failed to delete the recipe.")
                End If
            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("General error: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub RearrangeButtons()
        Dim yOffset As Integer = 10 ' Adjust based on padding/margins

        For Each btn As Button In buttonList
            btn.Top = yOffset
            yOffset += btn.Height + 5 ' Adjust spacing
        Next

        ' Refresh panel layout
        PnlDishTitle.PerformLayout()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchRecipes(sender, e)
    End Sub
End Class