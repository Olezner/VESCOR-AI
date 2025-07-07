Imports MySql.Data.MySqlClient

Public Class frmCalorieTracker
    Private calorieCount As Integer = 0
    Private calorieGoal As Integer = 100
    Dim connString As String = SQL_Connection.ConnectionString

    Private Sub frmCalorieTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFilter.SelectedItem = "Today"

        ' Ensure correct date range for "Today"
        dtpStartingdate.Value = DateTime.Today
        dtpEndingdate.Value = DateTime.Today

        ' Load Data Functions
        LoadCalorieData()
        LoadCalorieGoal()
        CalculateCalorieProgress()
        ApplyFilter("Today") ' Apply "Today" filter immediately
        UpdateGauge() ' Ensure gauge updates on load
    End Sub

    Private Sub LoadCalorieData()
        Try
            Using connection As New MySqlConnection(connString)
                Dim query As String = "SELECT FoodName, Calories, Timestamp FROM tblcaloriecount WHERE USERID = @user_id AND DATE(Timestamp) = CURDATE() ORDER BY Timestamp DESC"
                Dim adapter As New MySqlDataAdapter(query, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@user_id", CurrentUserID)

                Dim table As New DataTable()

                connection.Open()
                adapter.Fill(table)
                connection.Close()

                dgvCaloriecount.DataSource = table

                If table.Rows.Count > 0 Then
                    calorieCount = table.AsEnumerable().Sum(Function(row) If(IsDBNull(row("Calories")), 0, Convert.ToInt32(row("Calories"))))
                Else
                    calorieCount = 0
                End If

                lblCalCounter.Text = calorieCount.ToString() & " KCAL"
                UpdateGauge() ' Ensure gauge updates after setting calorieCount
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateGauge()
        ' Ensure it always uses the correct calorie count
        If Not Integer.TryParse(lblCalCounter.Text.Replace(" KCAL", "").Trim(), calorieCount) Then
            calorieCount = 0
        End If

        ' Make sure calorieGoal is updated properly
        Dim startDate As DateTime = dtpStartingdate.Value
        Dim endDate As DateTime = dtpEndingdate.Value
        Dim days As Integer = (endDate - startDate).Days + 1
        days = Math.Max(1, days)

        Dim totalCalorieGoal As Integer = calorieGoal * days ' Use correct range
        If totalCalorieGoal <= 0 Then totalCalorieGoal = 1

        Dim progressPercentage As Double = (calorieCount / totalCalorieGoal) * 100

        ' Make sure the progress bar does not cap at 100%
        cpbCalorie.Value = CInt(Math.Min(progressPercentage, 100)) ' UI gauge caps at 100%
        lblCaloriePercentage.Text = progressPercentage.ToString("0.00") & "%" ' ✅ Correct value shown

    End Sub

    Private Sub ApplyFilter(filterType As String)
        Try
            Using connection As New MySqlConnection(connString)
                connection.Open() ' Open connection first

                ' Set session timezone to Manila time
                Using timezoneCmd As New MySqlCommand("SET time_zone = '+08:00';", connection)
                    timezoneCmd.ExecuteNonQuery()
                End Using

                Dim query As String = "SELECT FoodName, Calories, Timestamp FROM tblcaloriecount WHERE USERID = @user_id"

                Select Case filterType
                    Case "Today"
                        query &= " AND DATE(Timestamp) = DATE(CONVERT_TZ(NOW(), @@session.time_zone, '+08:00'))"
                    Case "Current Week"
                        query &= " AND Timestamp BETWEEN @startDate AND @endDate"
                    Case "Current Month"
                        query &= " AND MONTH(Timestamp) = MONTH(CONVERT_TZ(UTC_TIMESTAMP(), '+00:00', '+08:00')) AND YEAR(Timestamp) = YEAR(CONVERT_TZ(UTC_TIMESTAMP(), '+00:00', '+08:00'))"
                    Case "Custom Date Range"
                        query &= " AND DATE(Timestamp) BETWEEN @startDate AND @endDate"
                End Select

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@user_id", CurrentUserID)

                    If filterType = "Custom Date Range" OrElse filterType = "Current Week" Then
                        cmd.Parameters.AddWithValue("@startDate", dtpStartingdate.Value.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@endDate", dtpEndingdate.Value.ToString("yyyy-MM-dd"))
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dgvCaloriecount.DataSource = table

                    ' Correctly update calorieCount
                    calorieCount = table.AsEnumerable().Sum(Function(row) If(IsDBNull(row("Calories")), 0, Convert.ToInt32(row("Calories"))))
                    lblCalCounter.Text = calorieCount.ToString() & " KCAL"

                    ' Ensure gauge updates immediately
                    UpdateGauge()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub CalculateCalorieProgress()
        If calorieGoal <= 0 Then
            lblCaloriePercentage.Text = "0.00% KCAL"
            Exit Sub
        End If

        ' Get correct date range
        Dim startDate As DateTime = dtpStartingdate.Value
        Dim endDate As DateTime = dtpEndingdate.Value
        Dim days As Integer = (endDate - startDate).Days + 1 ' Include last day

        days = Math.Max(1, days) ' Ensure at least 1 day is counted
        Dim totalCalorieGoal As Integer = calorieGoal * days ' Use full period’s goal

        Dim currentIntake As Integer
        If Integer.TryParse(lblCalCounter.Text.Replace(" KCAL", "").Replace(",", "").Trim(), currentIntake) Then
            Dim caloriePercentage As Double = (currentIntake / totalCalorieGoal) * 100
            lblCaloriePercentage.Text = caloriePercentage.ToString("0.00") & "% KCAL" ' Ensure " KCAL" is appended
        Else
            lblCaloriePercentage.Text = "0.00% KCAL"
        End If
    End Sub

    Private Sub LoadCalorieGoal()
        Try
            Using connection As New MySqlConnection(connString)
                Dim query As String = "SELECT DailyCalorieGoal FROM tbluserdetails WHERE USERID = @user_id"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@user_id", CurrentUserID)
                    connection.Open()
                    Dim result As Object = cmd.ExecuteScalar()
                    connection.Close()

                    If result IsNot Nothing AndAlso Not IsDBNull(result) AndAlso IsNumeric(result) Then
                        calorieGoal = CInt(result)
                        txtCalorieGoal.Text = calorieGoal.ToString()
                    Else
                        calorieGoal = 0
                        txtCalorieGoal.Text = "0"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading calorie goal: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtpStartingDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartingdate.ValueChanged
        CalculateCalorieProgress()
        ApplyFilter("Custom Date Range")
        UpdateGauge()
    End Sub

    Private Sub dtpEndingDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndingdate.ValueChanged
        CalculateCalorieProgress()
        ApplyFilter("Custom Date Range")
        UpdateGauge()
    End Sub


    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        If cmbFilter.SelectedItem IsNot Nothing Then
            Dim selectedFilter As String = cmbFilter.SelectedItem.ToString()

            Select Case selectedFilter
                Case "Today"
                    dtpStartingdate.Value = DateTime.Today
                    dtpEndingdate.Value = DateTime.Today

                Case "Current Week"
                    Dim today As DateTime = DateTime.Today
                    Dim startOfWeek As DateTime = today.AddDays(-CInt(today.DayOfWeek) + 1) ' Adjusted to always start on Monday
                    Dim endOfWeek As DateTime = startOfWeek.AddDays(6) ' Full 7-day range

                    dtpStartingdate.Value = startOfWeek
                    dtpEndingdate.Value = endOfWeek

                Case "Current Month"
                    Dim today As DateTime = DateTime.Today
                    Dim firstDay As DateTime = New DateTime(today.Year, today.Month, 1) ' First day of the month
                    Dim lastDay As DateTime = firstDay.AddMonths(1).AddDays(-1) ' Last day of the month
                    dtpStartingdate.Value = firstDay
                    dtpEndingdate.Value = lastDay
            End Select

            ApplyFilter(selectedFilter)
        End If
    End Sub


    Private Sub cpbCalorie_ValueChanged(sender As Object, e As EventArgs) Handles cpbCalorie.ValueChanged
        Dim percentage As Double = cpbCalorie.Value
        Dim newColor As Color

        ' Debugging: Check Percentage
        Debug.WriteLine("Gauge Color Update: " & percentage.ToString())

        ' Assign Color
        If percentage = 0 Then
            newColor = Color.White ' No Progress
            pbxcaloriewhite.Visible = True
            pbxcaloriegreen.Visible = False
            pbxcalorieyellow.Visible = False
            pbxcaloriered.Visible = False
        ElseIf percentage <= 50 Then
            newColor = Color.Green ' Green (0-50%)
            pbxcaloriewhite.Visible = False
            pbxcaloriegreen.Visible = True
            pbxcalorieyellow.Visible = False
            pbxcaloriered.Visible = False
        ElseIf percentage <= 75 Then
            newColor = Color.Yellow ' Yellow (51-75%)
            pbxcaloriewhite.Visible = False
            pbxcaloriegreen.Visible = False
            pbxcalorieyellow.Visible = True
            pbxcaloriered.Visible = False
        Else
            newColor = Color.Red ' Red (76-100%)
            pbxcaloriewhite.Visible = False
            pbxcaloriegreen.Visible = False
            pbxcalorieyellow.Visible = False
            pbxcaloriered.Visible = True
        End If

        ' Apply Color Change
        cpbCalorie.ProgressColor = newColor

        ' Refresh UI
        cpbCalorie.Refresh()
    End Sub


    Private Sub lblCaloriePercentage_TextChanged(sender As Object, e As EventArgs) Handles lblCaloriePercentage.TextChanged
        If Double.TryParse(lblCaloriePercentage.Text.Replace("%", "").Trim(), Nothing) Then
            UpdateGauge()
        End If
    End Sub

    Private Sub btnBackCT_Click(sender As Object, e As EventArgs) Handles btnBackCT.Click
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate food name and calorie count if they are entered
        Dim foodName As String = txtFoodname.Text.Trim()
        Dim calorieValue As Integer
        Dim calorieGoalValue As Integer

        ' Validate Daily Calorie Goal input
        If Not Integer.TryParse(txtCalorieGoal.Text, calorieGoalValue) OrElse calorieGoalValue <= 0 Then
            MessageBox.Show("Please enter a valid daily calorie goal.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using connection As New MySqlConnection(connString)
                connection.Open()

                ' Update Daily Calorie Goal in tbluserdetails
                Dim updateGoalQuery As String = "UPDATE tbluserdetails SET DailyCalorieGoal = @calorieGoal WHERE USERID = @user_id"
                Using cmdUpdateGoal As New MySqlCommand(updateGoalQuery, connection)
                    cmdUpdateGoal.Parameters.AddWithValue("@calorieGoal", calorieGoalValue)
                    cmdUpdateGoal.Parameters.AddWithValue("@user_id", CurrentUserID)
                    cmdUpdateGoal.ExecuteNonQuery()
                End Using

                ' If food name and calories are entered, save them in tblcaloriecount
                If Not String.IsNullOrWhiteSpace(foodName) AndAlso Integer.TryParse(txtcaloriecount.Text, calorieValue) AndAlso calorieValue > 0 Then
                    Dim insertFoodQuery As String = "INSERT INTO tblcaloriecount (USERID, FoodName, Calories, Timestamp) VALUES (@user_id, @foodName, @calories, NOW())"
                    Using cmdInsertFood As New MySqlCommand(insertFoodQuery, connection)
                        cmdInsertFood.Parameters.AddWithValue("@user_id", CurrentUserID)
                        cmdInsertFood.Parameters.AddWithValue("@foodName", foodName)
                        cmdInsertFood.Parameters.AddWithValue("@calories", calorieValue)
                        cmdInsertFood.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Food entry and calorie goal updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Daily calorie goal updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                connection.Close()
            End Using

            ' Refresh data
            LoadCalorieData()
            CalculateCalorieProgress()
            LoadCalorieGoal()
            UpdateCaloriePercentage() ' Update the calorie percentage when goal changes

            ' Clear textboxes
            txtFoodname.Clear()
            txtcaloriecount.Clear()
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UpdateCaloriePercentage()
        Try
            Dim totalCalories As Integer = 0

            ' Get total calorie intake from tblcaloriecount
            Using connection As New MySqlConnection(connString)
                Dim query As String = "SELECT SUM(Calories) FROM tblcaloriecount WHERE USERID = @user_id"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@user_id", CurrentUserID)
                    connection.Open()
                    Dim result As Object = cmd.ExecuteScalar()
                    connection.Close()

                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        totalCalories = Convert.ToInt32(result)
                    End If
                End Using
            End Using

            ' Ensure the calorie goal is greater than zero to prevent division by zero
            If calorieGoal > 0 Then
                Dim percentage As Double = (totalCalories / calorieGoal) * 100
                lblCaloriePercentage.Text = percentage.ToString("0.00") & "%"
            Else
                lblCaloriePercentage.Text = "0%"
            End If
        Catch ex As Exception
            MessageBox.Show("Error calculating calorie percentage: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCalorieGoal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCalorieGoal.KeyPress, txtcaloriecount.KeyPress
        ' Allow only numbers and control keys (like Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Only numbers are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtFoodname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFoodname.KeyPress
        ' Allow only letters, spaces, and control keys (like Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Only letters are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class