Imports MySql.Data.MySqlClient

Public Class frmMyIngredients

    Public Property UserId As Integer ' Property to hold the User ID
    Private selectedItemName As String ' To store the selected item name for deletion or updating
    Private Sub frmMyIngredients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure UserId is set before loading data
        If UserId = -1 Then
            MessageBox.Show("User ID is not set.")
            Me.Close()
            Return
        End If
        LoadData()

        lblfillallfield.Visible = False
        txtsearch.Select()
    End Sub

    Public Sub LoadData()
        Dim query As String = "SELECT item_name, quantity, unit FROM tblinventory WHERE USERID=@user_id"
        Dim connString As String = SQL_Connection.ConnectionString
        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()
                Dim adapter As New MySqlDataAdapter(query, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@user_id", UserId)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgMyIngredients.DataSource = table

                ' Disable the empty new row
                dgMyIngredients.AllowUserToAddRows = False

                dgMyIngredients.BackgroundColor = System.Drawing.Color.FromArgb(128, 180, 172)
                dgMyIngredients.DefaultCellStyle.BackColor = Color.FromArgb(128, 180, 172)
                dgMyIngredients.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(128, 180, 172)
                dgMyIngredients.DefaultCellStyle.ForeColor = Color.GhostWhite
                dgMyIngredients.GridColor = System.Drawing.Color.FromArgb(189, 252, 251)
                dgMyIngredients.CellBorderStyle = DataGridViewCellBorderStyle.Single
                dgMyIngredients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

                ' Column Headers
                dgMyIngredients.ColumnHeadersHeight = 52
                If dgMyIngredients.Columns.Contains("item_name") Then
                    dgMyIngredients.Columns("item_name").HeaderText = "Item Name"
                End If
                If dgMyIngredients.Columns.Contains("quantity") Then
                    dgMyIngredients.Columns("quantity").HeaderText = "Quantity"
                End If
                If dgMyIngredients.Columns.Contains("unit") Then
                    dgMyIngredients.Columns("unit").HeaderText = "Unit"
                End If

                ' read-only
                dgMyIngredients.ReadOnly = True

                ' Column Header Style
                With dgMyIngredients.ColumnHeadersDefaultCellStyle
                    .BackColor = System.Drawing.Color.FromArgb(8, 60, 76)
                    .ForeColor = Color.GhostWhite
                    .Font = New Font("Tahoma", 13, FontStyle.Bold)
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                End With

                ' Selection color
                dgMyIngredients.DefaultCellStyle.SelectionBackColor = Color.Teal
                dgMyIngredients.DefaultCellStyle.SelectionForeColor = Color.GhostWhite
                dgMyIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgMyIngredients.MultiSelect = False

            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("General error: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub dgMyIngredients_SelectionChanged(sender As Object, e As EventArgs) Handles dgMyIngredients.SelectionChanged
        ' Check if any row is selected
        If dgMyIngredients.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgMyIngredients.SelectedRows(0)

            ' Populate textboxes with selected row's data
            txtItemName.Text = selectedRow.Cells("item_name").Value.ToString()
            txtQuantity.Text = selectedRow.Cells("quantity").Value.ToString()
            cmbboxunits.SelectedItem = selectedRow.Cells("unit").Value.ToString()

            ' Store the selected item name for deletion or updating
            selectedItemName = selectedRow.Cells("item_name").Value.ToString()
        End If
    End Sub
    Private Sub txtItemName_TextChanged(sender As Object, e As EventArgs) Handles txtItemName.TextChanged
        ' Ensure only letters are allowed in txtItemName
        Dim regex As New Text.RegularExpressions.Regex("^[a-zA-Z\s]*$")
        If Not regex.IsMatch(txtItemName.Text) Then
            MessageBox.Show("Only letters are allowed in the Item Name field.")
            txtItemName.Text = txtItemName.Text.Remove(txtItemName.Text.Length - 1)
            txtItemName.SelectionStart = txtItemName.Text.Length
        End If
    End Sub
    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        ' Ensure only numbers are allowed in txtQuantity
        Dim regex As New Text.RegularExpressions.Regex("^[0-9]*$")
        If Not regex.IsMatch(txtQuantity.Text) Then
            MessageBox.Show("Only numbers are allowed in the Quantity field.")
            txtQuantity.Text = txtQuantity.Text.Remove(txtQuantity.Text.Length - 1)
            txtQuantity.SelectionStart = txtQuantity.Text.Length
        End If
    End Sub
    Private Sub btnAddIngredient_Click(sender As Object, e As EventArgs) Handles btnaddingredient.Click
        ' Ensure all fields are filled
        If String.IsNullOrEmpty(txtItemName.Text) OrElse String.IsNullOrEmpty(txtQuantity.Text) OrElse cmbboxunits.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If
        ' Capitalize first letter of the item name
        Dim itemName As String = txtItemName.Text.Trim()
        If Not String.IsNullOrEmpty(itemName) Then
            itemName = Char.ToUpper(itemName(0)) & itemName.Substring(1).ToLower()
        End If

        ' Get DataTable from DataGridView
        Dim dt As DataTable = CType(dgMyIngredients.DataSource, DataTable)

        ' Check if item already exists in the DataTable
        For Each row As DataRow In dt.Rows
            If row("item_name").ToString().Equals(itemName, StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("This ingredient is already in your list.")
                Return
            End If
        Next
        ' Insert into database
        Dim insertQuery As String = "INSERT INTO tblinventory (USERID, item_name, quantity, unit) VALUES (@user_id, @item_name, @quantity, @unit)"
        Dim connString As String = SQL_Connection.ConnectionString
        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()
                Using insertCommand As New MySqlCommand(insertQuery, connection)
                    insertCommand.Parameters.AddWithValue("@user_id", UserId)
                    insertCommand.Parameters.AddWithValue("@item_name", itemName)
                    insertCommand.Parameters.AddWithValue("@quantity", txtQuantity.Text)
                    insertCommand.Parameters.AddWithValue("@unit", cmbboxunits.SelectedItem.ToString())
                    insertCommand.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message)
                Return
            End Try
        End Using
        ' Add new row to the DataTable
        Dim newRow As DataRow = dt.NewRow()
        newRow("item_name") = itemName
        newRow("quantity") = txtQuantity.Text
        newRow("unit") = cmbboxunits.SelectedItem.ToString()
        dt.Rows.Add(newRow)

        ' Clear input fields
        txtItemName.Clear()
        txtQuantity.Clear()
        cmbboxunits.SelectedIndex = -1
    End Sub
    Private Sub btndeleteingredient_Click(sender As Object, e As EventArgs) Handles btndeleteingredient.Click
        ' Check if any row is selected
        If String.IsNullOrEmpty(selectedItemName) Then
            MessageBox.Show("No item selected for deletion.")
            Return
        End If
        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show("Do you want to delete this ingredient?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Delete the selected ingredient from the database
            Dim query As String = "DELETE FROM tblinventory WHERE USERID=@user_id AND item_name=@item_name"
            Dim connString As String = SQL_Connection.ConnectionString
            Using connection As New MySqlConnection(connString)
                Try
                    connection.Open()
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@user_id", UserId)
                        command.Parameters.AddWithValue("@item_name", selectedItemName)
                        command.ExecuteNonQuery()
                    End Using

                    ' Reload data to reflect the deletion
                    LoadData()

                    ' Clear the textboxes and combo box
                    txtItemName.Clear()
                    txtQuantity.Clear()
                    cmbboxunits.SelectedIndex = -1
                    selectedItemName = String.Empty

                Catch ex As MySqlException
                    MessageBox.Show("Database error: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("General error: " & ex.Message)
                End Try
            End Using
        End If
    End Sub
    Private Sub btnUpdateIngredient_Click(sender As Object, e As EventArgs) Handles btnUpdateIngredient.Click
        ' Ensure all fields are filled and an item is selected
        If String.IsNullOrEmpty(txtItemName.Text) OrElse String.IsNullOrEmpty(txtQuantity.Text) OrElse cmbboxunits.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If
        ' Check if item name is being changed
        If Not String.Equals(txtItemName.Text, selectedItemName, StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("Item name cannot be updated.")
            Return
        End If
        ' Confirm update
        Dim result As DialogResult = MessageBox.Show("Do you want to update this ingredient?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Update the selected ingredient in the database
            Dim query As String = "UPDATE tblinventory SET quantity=@quantity, unit=@unit WHERE USERID=@user_id AND item_name=@item_name"
            Dim connString As String = SQL_Connection.ConnectionString
            Using connection As New MySqlConnection(connString)
                Try
                    connection.Open()
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@user_id", UserId)
                        command.Parameters.AddWithValue("@item_name", selectedItemName)
                        command.Parameters.AddWithValue("@quantity", txtQuantity.Text)
                        command.Parameters.AddWithValue("@unit", cmbboxunits.SelectedItem.ToString())
                        command.ExecuteNonQuery()
                    End Using

                    ' Reload data to reflect the update
                    LoadData()

                    ' Optionally, you can clear the textboxes and combo box after updating the ingredient
                    txtItemName.Clear()
                    txtQuantity.Clear()
                    cmbboxunits.SelectedIndex = -1
                    selectedItemName = String.Empty

                Catch ex As MySqlException
                    MessageBox.Show("Database error: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("General error: " & ex.Message)
                End Try
            End Using
        End If
    End Sub
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        ' Ensure the UserId is set before performing the search
        If UserId = -1 Then
            MessageBox.Show("User ID is not set.")
            Return
        End If
        ' Get the search text
        Dim searchText As String = txtsearch.Text.Trim()

        ' Prepare the SQL query to filter records based on the search text
        Dim query As String = "SELECT item_name, quantity, unit FROM tblinventory WHERE USERID=@user_id AND item_name LIKE @search_text"

        ' Use parameterized query to prevent SQL injection
        Dim connString As String = SQL_Connection.ConnectionString
        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()
                Dim adapter As New MySqlDataAdapter(query, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@user_id", UserId)
                adapter.SelectCommand.Parameters.AddWithValue("@search_text", "%" & searchText & "%") ' Use % for partial matching
                Dim table As New DataTable()
                adapter.Fill(table)
                dgMyIngredients.DataSource = table

                ' Change column names if needed
                If dgMyIngredients.Columns.Contains("item_name") Then
                    dgMyIngredients.Columns("item_name").HeaderText = "Item Name"
                End If

                If dgMyIngredients.Columns.Contains("quantity") Then
                    dgMyIngredients.Columns("quantity").HeaderText = "Quantity"
                End If

                If dgMyIngredients.Columns.Contains("unit") Then
                    dgMyIngredients.Columns("unit").HeaderText = "Unit"
                End If

            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("General error: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub ShowMyIngredients()
        ' Show the ingredients form again when navigating back
        Me.Show()
        Me.BringToFront()
    End Sub
    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        ' Hide frmMyIngredients controls if needed
        Me.Hide()

        ' Create an instance of frmImageRecog
        Dim imageRecogForm As New frmImageRecog(Me)

        ' Remove borders to make it look embedded
        imageRecogForm.FormBorderStyle = FormBorderStyle.None
        imageRecogForm.TopLevel = False
        imageRecogForm.StartPosition = FormStartPosition.Manual

        ' Position it relative to frmMyIngredients
        imageRecogForm.Location = New Point(Me.Width - imageRecogForm.Width - 8, 1)

        ' Add to the main form
        Me.Controls.Add(imageRecogForm)
        imageRecogForm.BringToFront()
        imageRecogForm.Show()  ' Use Show() instead of ShowDialog()

        ' Optionally show frmMyIngredients again after embedding
        Me.Show()
    End Sub
    Public Sub AddIngredient(itemName As String, quantity As String, unit As String)
        ' Check if the ingredient is recognized before adding
        If String.IsNullOrEmpty(itemName) OrElse String.IsNullOrEmpty(quantity) OrElse String.IsNullOrEmpty(unit) Then
            MessageBox.Show("The ingredient was not recognized and cannot be added.")
            Return
        End If

        ' Capitalize first letter of the item name
        If Not String.IsNullOrEmpty(itemName) Then
            itemName = Char.ToUpper(itemName(0)) & itemName.Substring(1).ToLower()
        End If

        ' Insert into database to persist the ingredient
        Dim connString As String = SQL_Connection.ConnectionString
        Dim insertQuery As String = "INSERT INTO tblinventory (USERID, item_name, quantity, unit) VALUES (@user_id, @item_name, @quantity, @unit)"
        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()
                Using insertCommand As New MySqlCommand(insertQuery, connection)
                    insertCommand.Parameters.AddWithValue("@user_id", UserId)
                    insertCommand.Parameters.AddWithValue("@item_name", itemName)
                    insertCommand.Parameters.AddWithValue("@quantity", quantity)
                    insertCommand.Parameters.AddWithValue("@unit", unit)
                    insertCommand.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message)
                Return
            End Try
        End Using
        ' Reload the DataGridView to reflect changes
        LoadData()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Check if this form has an MDI parent (frmMain)
        If Me.MdiParent IsNot Nothing AndAlso TypeOf Me.MdiParent Is frmMain Then
            ' Reference the MDI parent (frmMain)
            Dim mainForm As frmMain = CType(Me.MdiParent, frmMain)

            ' Close this form
            Me.Close()

            ' Show the main panel of frmMain
            mainForm.pnlHome.Visible = True
        Else
            ' If not an MDI child, open a new instance of frmMain (as a fallback)
            Dim mainForm As New frmMain()
            mainForm.Show()
            Me.Close()
        End If
    End Sub
End Class