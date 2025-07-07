Imports System.Security.Cryptography
Imports System.Text
Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class frmLogin
    Dim newdbproject As MySqlConnection
    Dim command As MySqlCommand
    Private isDragging As Boolean = False
    Private startPoint As Point

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial visibility of the PictureBox controls for password toggle
        pbShow.Visible = True
        pbNotShow.Visible = False

        ' Select the username textbox on load
        LOGINtxtUsername.Select()

        ' Set the password textbox to mask the input
        LOGINtxtPassword.UseSystemPasswordChar = True
    End Sub
    Private Sub buttonSignUp_Click(sender As Object, e As EventArgs) Handles buttonSignUp.Click ' Event handler for the Sign Up link/button
        Dim nextForm As New frmSignup()
        nextForm.Show()
        Me.Hide()
    End Sub
    Private Sub buttonForgotPassword_Click(sender As Object, e As EventArgs) Handles buttonForgotPassword.Click ' Event handler for the Forgot Password button
        Dim nextForm As New frmForgetPass()
        nextForm.Show()
        Me.Hide()
    End Sub
    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        ResetBorderColors()

        If LOGINtxtUsername.Text.Trim() = "" OrElse LOGINtxtPassword.Text.Trim() = "" Then
            If LOGINtxtUsername.Text.Trim() = "" Then LOGINtxtUsername.BorderColor = Color.Red
            If LOGINtxtPassword.Text.Trim() = "" Then LOGINtxtPassword.BorderColor = Color.Red
            lblPassError.Text = "Please enter username and password."
            lblPassError.Show()
            Return
        End If

        Dim connString As String = SQL_Connection.ConnectionString
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Step 1: Retrieve the stored hashed password for the user
                Dim selectQuery As String = "SELECT USERID, USERNAME, EMAIL, ISVERIFIED, PASSWORD FROM tbluserdetails WHERE USERNAME=@Username"
                Dim userID As Integer = -1
                Dim username As String = ""
                Dim email As String = ""
                Dim isVerified As Integer = 0
                Dim storedHashedPassword As String = ""

                Using command As New MySqlCommand(selectQuery, conn)
                    command.Parameters.AddWithValue("@Username", LOGINtxtUsername.Text.Trim())

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            userID = reader.GetInt32("USERID")
                            username = reader.GetString("USERNAME")
                            email = reader.GetString("EMAIL")
                            isVerified = reader.GetInt32("ISVERIFIED")
                            storedHashedPassword = reader.GetString("PASSWORD") ' Retrieve hashed password
                        End If
                    End Using
                End Using

                ' Step 2: Validate user and password
                If userID = -1 Then
                    LOGINtxtUsername.BorderColor = Color.Red
                    LOGINtxtPassword.BorderColor = Color.Red
                    lblPassError.Text = "Invalid username or password."
                    lblPassError.Show()
                    Return
                End If

                ' Step 3: Hash input password and compare with stored hash
                If Not VerifyPassword(LOGINtxtPassword.Text.Trim(), storedHashedPassword) Then
                    LOGINtxtUsername.BorderColor = Color.Red
                    LOGINtxtPassword.BorderColor = Color.Red
                    lblPassError.Text = "Invalid username or password."
                    lblPassError.Show()
                    Return
                End If

                ' Step 4: Check if the account is verified
                If isVerified = 0 Then
                    LOGINtxtUsername.BorderColor = Color.Red
                    LOGINtxtPassword.BorderColor = Color.Red
                    lblPassError.Text = "Please verify your email before logging in."
                    lblPassError.Show()
                    Return
                End If

                ' Step 5: Log login attempt after reader is closed
                Dim loginTime As DateTime = DateTime.Now
                Dim insertQuery As String = "INSERT INTO tblloginlogs (USERID, LOGINTIME, USERNAME, EMAIL) VALUES (@UserID, @LoginTime, @Username, @Email)"
                Using logCommand As New MySqlCommand(insertQuery, conn)
                    logCommand.Parameters.AddWithValue("@UserID", userID)
                    logCommand.Parameters.AddWithValue("@LoginTime", loginTime)
                    logCommand.Parameters.AddWithValue("@Username", username)
                    logCommand.Parameters.AddWithValue("@Email", email)
                    logCommand.ExecuteNonQuery()
                End Using

                Module1.SetCurrentUserID(userID)

                ' Step 6: Open main form
                Dim mainForm As New frmMain()
                mainForm.UserId = userID
                mainForm.Show()
                Me.Hide()

            Catch ex As Exception
                MessageBox.Show("Error logging in: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub
    Private Function VerifyPassword(inputPassword As String, storedHash As String) As Boolean
        Dim inputHash As String = ComputeSHA256Hash(inputPassword) ' Hash input password
        Return inputHash = storedHash ' Compare hashes
    End Function

    ' Function to compute SHA-256 hash
    Private Function ComputeSHA256Hash(rawData As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2")) ' Convert to hexadecimal format
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub ResetBorderColors() ' Resets border colors to default
        LOGINtxtUsername.BorderColor = Color.Gray
        LOGINtxtPassword.BorderColor = Color.Gray
    End Sub
    Private Sub pbShow_Click(sender As Object, e As EventArgs) Handles pbShow.Click ' PictureBox click event: Show password
        LOGINtxtPassword.UseSystemPasswordChar = False
        pbShow.Visible = False
        pbNotShow.Visible = True
        LOGINtxtPassword.Focus()
    End Sub
    Private Sub pbNotShow_Click(sender As Object, e As EventArgs) Handles pbNotShow.Click ' PictureBox click event: Hide password
        LOGINtxtPassword.UseSystemPasswordChar = True
        pbNotShow.Visible = False
        pbShow.Visible = True
        LOGINtxtPassword.Focus()
    End Sub
End Class
