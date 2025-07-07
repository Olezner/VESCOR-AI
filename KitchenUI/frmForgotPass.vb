Imports System.Net.Mail
Imports System.Net
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class frmForgetPass
    Private verificationCode As String
    Private sendCodeClickCount As Integer = 0
    Private cooldownTimeRemaining As Integer = 0
    Private WithEvents cooldownTimer As New Timer()

    Private Sub frmForgetPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initially hide unnecessary elements
        Me.AcceptButton = Nothing ' Disable Enter key trigger by default

        lblStrongFP.Visible = False
        lblMatchingFP.Visible = False
        lblemailerror.Visible = False
        lblForgotpassauth.Visible = False

        btnSend.Visible = False
        btnSendCode.Visible = False
        btnVerify.Enabled = forgotSecurityCode.Text.Trim().Length = 6 ' Enable if code length is valid


        ' Hide password fields initially
        txtNewPass.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True
        forgotSecurityCode.UseSystemPasswordChar = False

        ' Hide panels
        pnlSQV.Visible = True   ' Verification panel
        pnlSQU.Visible = False   ' Password reset panel

        ' Auto-select email input
        forgotEMAIL.Select()

        ' Initialize cooldown timer (1 second interval)
        cooldownTimer.Interval = 1000
    End Sub
    Private Sub forgotEMAIL_TextChanged(sender As Object, e As EventArgs) Handles forgotEMAIL.TextChanged
        Dim email As String = forgotEMAIL.Text.Trim()

        ' Validate email input format
        If String.IsNullOrWhiteSpace(email) OrElse Not email.Contains("@") OrElse Not email.EndsWith(".com") Then
            lblemailerror.Text = "Email is unavailable."
            lblemailerror.ForeColor = Color.Red
            lblemailerror.Visible = True
            btnSend.Visible = False
            Return
        End If

        ' Check if email is registered
        If IsEmailRegistered(email) Then
            lblemailerror.Visible = False
            btnSend.Visible = True
        Else
            lblemailerror.Text = "Invalid Email."
            lblemailerror.ForeColor = Color.Red
            lblemailerror.Visible = True
            btnSend.Visible = False
        End If
    End Sub

    Private Sub btnSendCode_Click(sender As Object, e As EventArgs) Handles btnSendCode.Click
        Dim email As String = forgotEMAIL.Text.Trim()

        ' Check if the email is valid and registered
        If String.IsNullOrWhiteSpace(email) OrElse Not email.Contains("@") OrElse Not email.EndsWith(".com") Then
            lblerror.Text = "Please enter a valid email address."
            lblerror.ForeColor = Color.Red
            lblerror.Visible = True
            Return
        End If

        If Not IsEmailRegistered(email) Then
            lblerror.Text = "This email is not registered."
            lblerror.ForeColor = Color.Red
            lblerror.Visible = True
            Return
        End If

        ' Check if the user has exceeded the allowed attempts
        If sendCodeClickCount >= 3 Then
            lblerror.Text = "Maximum attempts reached. Please wait 3 minutes."
            lblerror.ForeColor = Color.Red
            lblerror.Visible = True
            Return
        End If

        ' Generate new verification code
        verificationCode = GenerateVerificationCode()

        ' Update verification details in the database
        If UpdateVerificationDetails(email, verificationCode) Then
            Dim subject As String = "Your New Verification Code"
            Dim body As String = $"Your verification code is: {verificationCode}."

            If SendEmail(email, subject, body) Then
                sendCodeClickCount += 1
                lblerror.Text = "New verification code sent. Check your email."
                lblerror.ForeColor = Color.Green
                lblerror.Visible = True

                ' Apply cooldown if user reaches 3 attempts
                If sendCodeClickCount >= 3 Then
                    cooldownTimeRemaining = 15
                    cooldownTimer.Start()
                End If
            Else
                lblerror.Text = "Failed to send verification code. Try again later."
                lblerror.ForeColor = Color.Red
                lblerror.Visible = True
            End If
        Else
            lblerror.Text = "Failed to update verification details."
            lblerror.ForeColor = Color.Red
            lblerror.Visible = True
        End If
    End Sub

    Private Sub forgotSECURITYCODE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles forgotSecurityCode.KeyPress ' Allow only digits in the forgotSECURITYCODE textbox
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub pbShowNew_Click(sender As Object, e As EventArgs) Handles pbShowNew.Click ' When the user clicks on the "eye with slash" picture box (pbnotshownew), show the password
        ' Show password in txtNewPass
        txtNewPass.UseSystemPasswordChar = False
        pbShowNew.Visible = False
        pbNotShowNew.Visible = True
    End Sub
    Private Sub pbNotShowNew_Click(sender As Object, e As EventArgs) Handles pbNotShowNew.Click
        ' Hide password in txtNewPass
        txtNewPass.UseSystemPasswordChar = True
        pbNotShowNew.Visible = False
        pbShowNew.Visible = True
    End Sub
    Private Sub pbShowConfirm_Click(sender As Object, e As EventArgs) Handles pbShowConfirm.Click
        ' Show password in txtConfirmPass
        txtConfirmPass.UseSystemPasswordChar = True
        pbShowConfirm.Visible = False
        pbNotShowConfirm.Visible = True
    End Sub
    Private Sub pbNotShowConfirm_Click(sender As Object, e As EventArgs) Handles pbNotShowConfirm.Click
        ' Hide password in txtConfirmPass
        txtConfirmPass.UseSystemPasswordChar = False
        pbNotShowConfirm.Visible = False
        pbShowConfirm.Visible = True
    End Sub
    Private Sub cooldownTimer_Tick(sender As Object, e As EventArgs) Handles cooldownTimer.Tick
        cooldownTimeRemaining -= 1

        If cooldownTimeRemaining <= 0 Then
            cooldownTimer.Stop()
            sendCodeClickCount = 0
            lblerror.Text = "You can now request a new code."
            lblerror.ForeColor = Color.Green
        Else
            lblerror.Text = "Please wait " & cooldownTimeRemaining.ToString() & "s before requesting a new code."
            lblerror.ForeColor = Color.Red
        End If
        lblerror.Visible = True
    End Sub

    Private Function GenerateVerificationCode() As String
        Dim rand As New Random()
        Return rand.Next(100000, 999999).ToString() ' Generates a 6-digit code
    End Function
    Private Function SendEmail(toEmail As String, subject As String, body As String) As Boolean
        Try
            Dim smtpClient As New SmtpClient("smtp.gmail.com")
            smtpClient.Port = 587
            smtpClient.Credentials = New NetworkCredential("vescorai1@gmail.com", "okur bhme cyaz zouv")
            smtpClient.EnableSsl = True

            Dim mailMessage As New MailMessage()
            mailMessage.From = New MailAddress("vescorai1@gmail.com")
            mailMessage.To.Add(toEmail)
            mailMessage.Subject = subject
            mailMessage.Body = body
            mailMessage.IsBodyHtml = False

            smtpClient.Send(mailMessage)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Function IsEmailRegistered(email As String) As Boolean
        Dim connString As String = SQL_Connection.ConnectionString
        Dim query As String = "SELECT COUNT(*) FROM tbluserdetails WHERE EMAIL = @Email"

        Try
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Email", email)
                    conn.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Sub btnVerifyCode_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim storedCode As String = ""
        Dim createdAt As DateTime
        Dim connString As String = SQL_Connection.ConnectionString

        ' Query to retrieve the latest verification code and timestamp
        Dim query As String = "SELECT VerificationCode, CreatedAt FROM tbluserdetails WHERE email = @Email ORDER BY CreatedAt DESC LIMIT 1"

        Try
            Using newdbproject As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, newdbproject)
                    cmd.Parameters.AddWithValue("@Email", forgotEMAIL.Text.Trim())

                    newdbproject.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            storedCode = If(reader("VerificationCode") IsNot DBNull.Value, reader("VerificationCode").ToString(), "")
                            createdAt = If(reader("CreatedAt") IsNot DBNull.Value, Convert.ToDateTime(reader("CreatedAt")), DateTime.MinValue)
                        Else
                            lblerror.Text = "Email not found."
                            lblerror.ForeColor = Color.Red
                            lblerror.Visible = True
                            Return
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            lblerror.Text = "Database error: " & ex.Message
            lblerror.ForeColor = Color.Red
            lblerror.Visible = True
            Return
        End Try

        ' Ensure a valid timestamp was retrieved
        If createdAt = DateTime.MinValue Then
            lblerror.Text = "Error retrieving verification code timestamp."
            lblerror.ForeColor = Color.Red
            lblerror.Visible = True
            Return
        End If

        ' First, check if the entered code is correct
        If forgotSecurityCode.Text.Trim() <> storedCode Then
            lblerror.Text = "Invalid verification code."
            lblerror.ForeColor = Color.Red
            lblerror.Visible = True
            btnVerify.Enabled = True ' Ensure button is re-enabled for reattempts
            Return
        End If

        ' Then, check if the code is expired
        Dim currentTime As DateTime = DateTime.UtcNow ' Use UTC time for consistency
        Dim timeElapsed As TimeSpan = currentTime - createdAt

        If timeElapsed.TotalSeconds > 30 Then
            lblerror.Text = "The verification code has expired."
            lblerror.ForeColor = Color.Red
            lblerror.Visible = True
            Return
        End If

        ' If everything is valid, proceed
        lblerror.Text = "" ' Clear any previous error message
        pnlSQU.Location = pnlSQV.Location
        pnlSQU.Visible = True
        pnlSQV.Visible = False
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click ' Update Password button click event
        Dim email As String = forgotEMAIL.Text
        Dim newPassword As String = txtNewPass.Text
        Dim confirmPassword As String = txtConfirmPass.Text

        ' Validate input fields
        If String.IsNullOrWhiteSpace(newPassword) OrElse String.IsNullOrWhiteSpace(confirmPassword) Then
            lblpassfieldFP.Text = "Please fill all fields"
            lblpassfieldFP.Visible = True
            lblMatchingFP.Visible = False
            Return
        End If

        If newPassword <> confirmPassword Then
            lblMatchingFP.Text = "Passwords do not match."
            lblMatchingFP.ForeColor = Color.Red
            lblMatchingFP.Visible = True
            lblpassfieldFP.Visible = False
            Return
        End If

        ' Hash the new password
        Dim hashedPassword As String = HashPassword(newPassword)

        ' Update the password in the database
        If UpdatePassword(email, hashedPassword) Then
            lblpassfieldFP.Text = "Password updated successfully."
            lblpassfieldFP.ForeColor = Color.Green
            lblpassfieldFP.Visible = True
            lblMatchingFP.Visible = False

            ' Redirect to login form after successful update
            Dim loginForm As New frmLogin()
            loginForm.Show()
            Me.Close()
        Else
            lblpassfieldFP.Text = "Update failed. Please try again."
            lblpassfieldFP.ForeColor = Color.Red
            lblpassfieldFP.Visible = True
            lblMatchingFP.Visible = False
        End If
    End Sub

    ' Function to update the password in the database
    Private Function UpdatePassword(email As String, newPassword As String) As Boolean
        Dim connString As String = SQL_Connection.ConnectionString
        Dim checkQuery As String = "SELECT PASSWORD FROM tbluserdetails WHERE EMAIL = @Email"
        Dim updateQuery As String = "UPDATE tbluserdetails SET PASSWORD = @NewPassword WHERE EMAIL = @Email"

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' Check the current hashed password
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@Email", email)
                    Dim currentPassword As Object = checkCmd.ExecuteScalar()

                    ' If the new password matches the old one, prevent updating
                    If currentPassword IsNot Nothing AndAlso currentPassword.ToString() = newPassword Then
                        MessageBox.Show("You cannot use your old password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If
                End Using

                ' Proceed with updating the password
                Using updateCmd As New MySqlCommand(updateQuery, conn)
                    updateCmd.Parameters.AddWithValue("@Email", email)
                    updateCmd.Parameters.AddWithValue("@NewPassword", newPassword)
                    Dim rowsAffected = updateCmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Function to hash the password using SHA-256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function
    Private Function UpdateVerificationDetails(email As String, code As String) As Boolean
        Dim connString As String = SQL_Connection.ConnectionString
        Dim query As String = "UPDATE tbluserdetails SET VerificationCode = @Code, CreatedAt = NOW() WHERE EMAIL = @Email"

        Try
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Code", code)
                    cmd.Parameters.AddWithValue("@Email", email)
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Sub btnCancel2_Click(sender As Object, e As EventArgs) Handles btnCancel2.Click
        Dim loginForm As New frmLogin() ' Assuming frmLogin is your sign-in form
        loginForm.Show()
        Me.Close() ' Close the current form
    End Sub
    Private Sub btnBackButton_Click(sender As Object, e As EventArgs) Handles btnBackButton.Click
        pnlSQU.Visible = False   ' Hide the password reset panel
        pnlSQV.Visible = True    ' Show the verification panel
        pnlSQV.Location = pnlSQU.Location ' Ensure it appears in the same location
    End Sub
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim email As String = forgotEMAIL.Text.Trim()
        verificationCode = GenerateVerificationCode()

        ' Update the database with the new verification code and timestamp
        If UpdateVerificationDetails(email, verificationCode) Then
            Dim subject As String = "Your Password Reset Verification Code"
            Dim body As String = $"Your verification code is: {verificationCode}."

            If SendEmail(email, subject, body) Then
                MessageBox.Show("Verification code sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnSend.Visible = False
                btnSendCode.Visible = True
            Else
                MessageBox.Show("Failed to send verification code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Failed to update verification details.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub forgotSecurityCode_TextChanged(sender As Object, e As EventArgs) Handles forgotSecurityCode.TextChanged
        ' Enable the Verify button only if the code matches
        If forgotSecurityCode.Text.Length = 6 Then ' Assuming code length is 6 digits
            btnVerify.Enabled = True
        Else
            btnVerify.Enabled = False
        End If
    End Sub
    Private Sub txtNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtNewPass.TextChanged, txtConfirmPass.TextChanged
        Dim newPassword As String = txtNewPass.Text.Trim()
        Dim confirmPassword As String = txtConfirmPass.Text.Trim()

        If newPassword <> "" Then
            Dim hasSpecialCharacter As Boolean = newPassword.Any(Function(c) Not Char.IsLetterOrDigit(c))
            Dim hasCapitalLetter As Boolean = newPassword.Any(Function(c) Char.IsUpper(c))
            Dim hasLowercaseLetter As Boolean = newPassword.Any(Function(c) Char.IsLower(c))
            Dim hasNumber As Boolean = newPassword.Any(Function(c) Char.IsDigit(c))
            Dim hasMinLength As Boolean = newPassword.Length >= 8

            Dim allCriteriaMet As Boolean = hasSpecialCharacter And hasCapitalLetter And hasLowercaseLetter And hasNumber And hasMinLength
            Dim passwordsMatch As Boolean = newPassword = confirmPassword

            lblForgotpassauth.Visible = True

            If allCriteriaMet Then
                lblForgotpassauth.Text = "Strong Password"
                lblForgotpassauth.ForeColor = Color.Green
                txtNewPass.BorderColor = Color.Gray
            Else
                lblForgotpassauth.Text = "Password must have uppercase, lowercase, digit, and symbol."
                lblForgotpassauth.ForeColor = Color.Red
                txtNewPass.BorderColor = Color.Red
            End If

            txtConfirmPass.BorderColor = If(passwordsMatch, Color.Gray, Color.Red)
            btnUpdate.Enabled = allCriteriaMet And passwordsMatch

        Else
            lblForgotpassauth.Visible = False
            txtNewPass.BorderColor = Color.Gray
            txtConfirmPass.BorderColor = Color.Gray
            btnUpdate.Enabled = False
        End If
    End Sub
    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        Dim newPassword As String = txtNewPass.Text.Trim()
        Dim confirmPassword As String = txtConfirmPass.Text.Trim()

        If confirmPassword <> "" Then
            If newPassword = confirmPassword Then
                lblMatchingFP.Text = "Passwords match!"
                lblMatchingFP.ForeColor = Color.Green
                lblMatchingFP.Visible = True
                txtConfirmPass.BorderColor = Color.Gray
            Else
                lblMatchingFP.Text = "Passwords do not match!"
                lblMatchingFP.ForeColor = Color.Red
                lblMatchingFP.Visible = True
                txtConfirmPass.BorderColor = Color.Red
            End If
        Else
            ' Reset the label if confirm password input is empty
            lblMatchingFP.Visible = False
            txtConfirmPass.BorderColor = Color.Gray
        End If
    End Sub
End Class
