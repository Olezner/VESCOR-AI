Imports System.Diagnostics
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmImageRecog
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog.FileName
            pbShowImage.Image = Image.FromFile(imagePath)
            Dim detectedClasses As String = RunPythonScript(imagePath)
            txtItemName.Text = detectedClasses
        End If
    End Sub

    Private Sub frmImageRecog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlUpload.AllowDrop = True
    End Sub

    Private Sub pnlUpload_DragEnter(sender As Object, e As DragEventArgs) Handles pnlUpload.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
            If files.Length > 0 AndAlso IsImageFile(files(0)) Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.None
            End If
        End If
    End Sub

    Private Sub pnlUpload_DragDrop(sender As Object, e As DragEventArgs) Handles pnlUpload.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        If files.Length > 0 AndAlso IsImageFile(files(0)) Then
            Dim imagePath As String = files(0)
            pbShowImage.Image = Image.FromFile(imagePath)
            Dim detectedClasses As String = RunPythonScript(imagePath)
            txtItemName.Text = detectedClasses
        End If
    End Sub

    Private Function IsImageFile(filePath As String) As Boolean
        Dim extensions As String() = {".jpg", ".jpeg", ".png", ".bmp"}
        Dim ext As String = Path.GetExtension(filePath).ToLower()
        Return extensions.Contains(ext)
    End Function

    Private Function RunPythonScript(imagePath As String) As String 'Python script for image recognition
        Try
            Dim psi As New ProcessStartInfo()
            psi.FileName = "python"
            Dim scriptPath As String = "C:\Users\Windows 11\source\repos\KitchenUI\roboflow.py"
            psi.Arguments = $" ""{scriptPath}"" ""{imagePath}"""
            psi.RedirectStandardOutput = True
            psi.RedirectStandardError = True
            psi.UseShellExecute = False
            psi.CreateNoWindow = True

            Dim process As New Process()
            process.StartInfo = psi
            process.Start()
            Dim output As String = process.StandardOutput.ReadToEnd().Trim()
            process.WaitForExit()
            Return If(String.IsNullOrEmpty(output), "No objects detected", output)
        Catch ex As Exception
            lblError.Text = "Error running Python script."
            lblError.ForeColor = Color.Red
            Return "Error"
        End Try
    End Function

    Public Event BackButtonClicked()

    Private Sub btnImageRecBack_Click(sender As Object, e As EventArgs) Handles btnImageRecBack.Click
        ' Ensure the previous form is shown properly before closing this one
        If ingredientsForm IsNot Nothing Then
            ingredientsForm.Show()
            ingredientsForm.BringToFront() ' Ensure it's in focus
        End If

        ' Close the current form
        Me.Dispose()
    End Sub

    Private Sub btnIncrease_Click(sender As Object, e As EventArgs) Handles btnIncrease.Click
        Dim amount As Integer
        If Integer.TryParse(txtAmount.Text, amount) Then
            amount += 1
            txtAmount.Text = amount.ToString()
        Else
            txtAmount.Text = "1"
        End If
    End Sub

    Private Sub btnDecrease_Click(sender As Object, e As EventArgs) Handles btnDecrease.Click
        Dim amount As Integer
        If Integer.TryParse(txtAmount.Text, amount) Then
            If amount > 0 Then
                amount -= 1
            End If
            txtAmount.Text = amount.ToString()
        Else
            txtAmount.Text = "0"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        pbShowImage.Image = Nothing
        txtAmount.Text = ""
        ddUnit.SelectedIndex = -1
        txtItemName.Text = ""
        lblError.Text = ""
        lblError.ForeColor = Color.Black
    End Sub

    Private ingredientsForm As frmMyIngredients

    Public Sub New(ingredientsForm As frmMyIngredients)
        InitializeComponent()
        Me.ingredientsForm = ingredientsForm
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Get values from the controls
        Dim itemName As String = txtItemName.Text
        Dim unit As String = If(ddUnit.SelectedItem IsNot Nothing, ddUnit.SelectedItem.ToString(), "")
        Dim amount As String = txtAmount.Text

        ' Show the error label only when the button is clicked
        lblError.Visible = True

        ' Check if an object was detected
        If itemName = "No objects detected" OrElse String.IsNullOrWhiteSpace(itemName) Then
            lblError.Text = "No valid object detected."
            lblError.ForeColor = Color.Red
            Return
        End If

        ' Check if the amount is empty or not a valid number
        Dim numericAmount As Integer
        If String.IsNullOrWhiteSpace(amount) OrElse Not Integer.TryParse(amount, numericAmount) OrElse numericAmount <= 0 Then
            lblError.Text = "Please enter a valid amount."
            lblError.ForeColor = Color.Red
            Return
        End If

        ' Check if a unit is selected
        If String.IsNullOrWhiteSpace(unit) Then
            lblError.Text = "Please select a unit."
            lblError.ForeColor = Color.Red
            Return
        End If

        ' Check if the ingredient already exists in the DataGridView
        Dim ingredientExists As Boolean = False
        For Each row As DataGridViewRow In ingredientsForm.dgMyIngredients.Rows
            If Not row.IsNewRow AndAlso row.Cells(0).Value.ToString().Equals(itemName, StringComparison.OrdinalIgnoreCase) Then
                ' Update the existing ingredient in DataGridView
                row.Cells(1).Value = numericAmount  ' Assuming the second column is Quantity
                row.Cells(2).Value = unit           ' Assuming the third column is Unit

                ' Update the existing ingredient in the database
                Dim query As String = "UPDATE tblinventory SET quantity = @quantity, unit = @unit WHERE item_name = @item_name AND USERID = @userid"
                Using connection As New MySqlConnection("server=vescorai.c5ym6yyiapd5.ap-southeast-2.rds.amazonaws.com;userid=admin;password=#connect123;database=vescorai"),
              command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@quantity", numericAmount)
                    command.Parameters.AddWithValue("@unit", unit)
                    command.Parameters.AddWithValue("@item_name", itemName)
                    command.Parameters.AddWithValue("@userid", CurrentUserID) ' Replace with actual USERID

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show("Error updating ingredient in database: " & ex.Message)
                    End Try
                End Using

                ingredientExists = True
                Exit For
            End If
        Next

        ' If the ingredient does not exist, add it as a new entry
        If Not ingredientExists Then
            ingredientsForm.AddIngredient(itemName, amount, unit)

            ' Add the new ingredient to the database
            Dim query As String = "INSERT INTO tblinventory (USERID, item_name, quantity, unit) VALUES (@userid, @item_name, @quantity, @unit)"
            Using connection As New MySqlConnection("server=vescorai.c5ym6yyiapd5.ap-southeast-2.rds.amazonaws.com;userid=admin;password=#connect123;database=vescorai"), 'Database path
          command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@userid", CurrentUserID)
                command.Parameters.AddWithValue("@item_name", itemName)
                command.Parameters.AddWithValue("@quantity", numericAmount)
                command.Parameters.AddWithValue("@unit", unit)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error adding ingredient to database: " & ex.Message)
                End Try
            End Using
        End If

        ' Success message
        lblError.Text = "Ingredient saved successfully!"
        lblError.ForeColor = Color.Green
        ' Clear the input fields after saving
        txtAmount.Clear()
        txtItemName.Text = String.Empty
        ddUnit.SelectedIndex = -1 ' Reset the ComboBox selection
    End Sub

End Class
