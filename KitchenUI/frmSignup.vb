Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports ReaLTaiizor.Drawing.Poison.PoisonPaint

Public Class frmSignup
    Dim newdbproject As MySqlConnection
    Dim command As MySqlCommand

    Private Sub frmSignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cooldownTimer = New Timer()
        cooldownTimer.Interval = 1000 ' Set interval to 1 second
        cooldownTimer.Stop() ' Ensure it starts stopped

        ' Set initial visibility of the PictureBox controls
        pbShow.Visible = True
        pbNotShow.Visible = False
        pbShow2.Visible = True
        pbNotShow2.Visible = False

        ' Select Email Textbox
        SIGNUPtxtEmail.Select()

        ' Set initial state of password as hidden
        SIGNUPtxtPassword1.UseSystemPasswordChar = True
        SIGNUPtxtPassword2.UseSystemPasswordChar = True

        ' Initialize labels and group boxes
        lblPassError.Text = ""
        lblPassMatch.Text = ""
        lblusername.Text = ""
        lblemailerror.Text = ""
        gbSignUp2.Visible = False

        lblPassauth.Visible = False

        lblshortusername.Visible = False
        lblVerificationMessage.Visible = False

        Me.AcceptButton = btnCreateAccount

        ' Add event handler for email text changed
        AddHandler SIGNUPtxtEmail.TextChanged, AddressOf SIGNUPtxtEmail_TextChanged
    End Sub
    Private Sub SIGNUPtxtEmail_TextChanged(sender As Object, e As EventArgs)
        Dim email As String = SIGNUPtxtEmail.Text.Trim()

        If String.IsNullOrEmpty(email) Then
            lblemailerror.Text = ""
            lblemailerror.Visible = False
            SIGNUPtxtEmail.BorderColor = Color.Gray
        ElseIf email.Length < 10 OrElse Not email.Contains("@gmail.com") _
            OrElse email.Count(Function(c) c = "@"c) > 1 _
            OrElse email.Count(Function(c) c = "."c) > 1 _
            Then
            lblemailerror.Text = "Email is unavailable"
            lblemailerror.Visible = True
            SIGNUPtxtEmail.BorderColor = Color.Red
        ElseIf EmailExistsInDatabase(email) Then
            lblemailerror.Text = "Email is unavailable"
            lblemailerror.Visible = True
            SIGNUPtxtEmail.BorderColor = Color.Red
        Else
            lblemailerror.Text = ""
            lblemailerror.Visible = False
            SIGNUPtxtEmail.BorderColor = Color.Gray
        End If
    End Sub
    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        ' Clear previous error messages
        lblVerificationMessage.Visible = False
        lblemailerror.Visible = False
        lblPassError.Visible = False
        lblusername.Visible = False

        ' Gather user inputs
        Dim DisplayName As String = SIGNUPtxtDISPLAYNAME.Text.Trim()
        Dim Email As String = SIGNUPtxtEmail.Text.Trim()
        Dim Password1 As String = SIGNUPtxtPassword1.Text.Trim()
        Dim Password2 As String = SIGNUPtxtPassword2.Text.Trim()
        Dim hasError As Boolean = False

        ' Validate that all fields are filled
        If String.IsNullOrEmpty(DisplayName) OrElse String.IsNullOrEmpty(Email) OrElse
       String.IsNullOrEmpty(Password1) OrElse String.IsNullOrEmpty(Password2) Then
            lblVerificationMessage.Text = "Please fill all fields"
            lblVerificationMessage.Visible = True
            hasError = True
        End If

        ' Validate email format
        If Not IsValidEmail(Email) Then
            lblemailerror.Text = "Invalid email"
            lblemailerror.Visible = True
            SIGNUPtxtEmail.Focus()
            hasError = True
        End If

        ' Validate that passwords match
        If Password1 <> Password2 Then
            lblPassError.Text = "Passwords do not match!"
            lblPassError.Visible = True
            hasError = True
        End If

        ' Check for existing email and username in the database
        If EmailExistsInDatabase(Email) Then
            lblemailerror.Text = "Email address already exists"
            lblemailerror.Visible = True
            SIGNUPtxtEmail.Focus()
            hasError = True
        End If

        If UsernameExistsInDatabase(DisplayName) Then
            lblusername.Text = "Username already exists"
            lblusername.Visible = True
            SIGNUPtxtDISPLAYNAME.Focus()
            hasError = True
        End If

        ' Stop execution if there are validation errors
        If hasError Then
            Exit Sub
        End If

        ' Hash the password
        Dim HashedPassword As String = HashPassword(Password1)

        ' Store user details in the database
        Dim connString As String = SQL_Connection.ConnectionString
        Using newdbproject As New MySqlConnection(connString)
            Try
                newdbproject.Open()
                Dim verificationCode As String = GenerateVerificationCode()
                Dim Query As String = "INSERT INTO tbluserdetails (USERNAME, PASSWORD, EMAIL, VerificationCode, CreatedAt) VALUES (@Username, @Password, @Email, @VerificationCode, NOW())"

                Using command As New MySqlCommand(Query, newdbproject)
                    command.Parameters.AddWithValue("@Email", Email)
                    command.Parameters.AddWithValue("@Username", DisplayName)
                    command.Parameters.AddWithValue("@Password", HashedPassword) ' Store hashed password
                    command.Parameters.AddWithValue("@VerificationCode", verificationCode)
                    command.ExecuteNonQuery()
                End Using

                ' Send verification email
                SendVerificationEmail(Email, verificationCode)


                ' Switch to verification panel
                gbSignUp1.Visible = False
                gbSignUp2.Visible = True
                gbSignUp2.Location = gbSignUp1.Location

                MessageBox.Show("Account created. A verification code has been sent to your email.", "Verification Code Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Function to hash the password using SHA-256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function
    Private Function IsValidEmail(email As String) As Boolean ' Function to check if an email is valid
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@gmail\.com$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function
    Private Sub StoreVerificationCode(email As String, verificationCode As String)
        Dim query As String = "UPDATE tbluserdetails SET VerificationCode = @Code, CreatedAt = NOW() WHERE Email = @Email"
        Dim connString As String = SQL_Connection.ConnectionString

        Using conn As New MySqlConnection(connString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Code", verificationCode)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles SIGNUPtxtPassword1.TextChanged, SIGNUPtxtPassword2.TextChanged
        Dim password1 As String = SIGNUPtxtPassword1.Text
        Dim password2 As String = SIGNUPtxtPassword2.Text

        If password1 <> "" Then
            Dim hasSpecialCharacter As Boolean = password1.Any(Function(c) Not Char.IsLetterOrDigit(c))
            Dim hasCapitalLetter As Boolean = password1.Any(Function(c) Char.IsUpper(c))
            Dim hasLowercaseLetter As Boolean = password1.Any(Function(c) Char.IsLower(c))
            Dim hasNumber As Boolean = password1.Any(Function(c) Char.IsDigit(c))
            Dim hasMinLength As Boolean = password1.Length >= 8

            Dim allCriteriaMet As Boolean = hasSpecialCharacter And hasCapitalLetter And hasLowercaseLetter And hasNumber And hasMinLength

            ' Update password authentication label
            lblPassauth.Visible = True
            If allCriteriaMet Then
                lblPassauth.Text = "Strong Password"
                lblPassauth.ForeColor = Color.FromArgb(29, 185, 84)
            Else
                lblPassauth.Text = "Password must have uppercase, lowercase, digit, and symbol."
                lblPassauth.ForeColor = Color.Red
            End If

            ' Change border color based on validation
            SIGNUPtxtPassword1.BorderColor = If(allCriteriaMet, Color.Gray, Color.Red)

            ' Check if passwords match
            Dim passwordsMatch As Boolean = password1 = password2
            btnVerify.Enabled = allCriteriaMet And passwordsMatch

            lblPassMatch.Visible = passwordsMatch
            lblPassError.Visible = Not passwordsMatch
            If passwordsMatch Then
                lblPassMatch.Text = "Passwords match!"
                SIGNUPtxtPassword2.BorderColor = Color.Gray
            Else
                lblPassError.Text = "Passwords do not match!"
                SIGNUPtxtPassword2.BorderColor = Color.Red
            End If
        Else
            lblPassauth.Text = ""
            lblPassauth.Visible = False
            lblPassMatch.Visible = False
            lblPassError.Visible = False
            SIGNUPtxtPassword1.BorderColor = Color.Gray
            SIGNUPtxtPassword2.BorderColor = Color.Gray
        End If
    End Sub
    Private Function EmailExistsInDatabase(email As String) As Boolean
        Dim connString As String = SQL_Connection.ConnectionString
        Dim query As String = "SELECT COUNT(*) FROM tbluserdetails WHERE EMAIL = @Email"
        Using connection As New MySqlConnection(connString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Email", email)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
    Private Function UsernameExistsInDatabase(username As String) As Boolean
        Dim connString As String = SQL_Connection.ConnectionString
        Dim query As String = "SELECT COUNT(*) FROM tbluserdetails WHERE USERNAME = @Username"
        Using connection As New MySqlConnection(connString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
    Private Sub pbShow_Click(sender As Object, e As EventArgs) Handles pbShow.Click
        SIGNUPtxtPassword1.UseSystemPasswordChar = False
        pbShow.Visible = False
        pbNotShow.Visible = True
    End Sub

    Private Sub pbNotShow_Click(sender As Object, e As EventArgs) Handles pbNotShow.Click
        SIGNUPtxtPassword1.UseSystemPasswordChar = True
        pbNotShow.Visible = False
        pbShow.Visible = True
    End Sub

    Private Sub pbShow2_Click(sender As Object, e As EventArgs) Handles pbShow2.Click
        SIGNUPtxtPassword2.UseSystemPasswordChar = False
        pbShow2.Visible = False
        pbNotShow2.Visible = True
    End Sub
    Private Sub pbNotShow2_Click(sender As Object, e As EventArgs) Handles pbNotShow2.Click
        SIGNUPtxtPassword2.UseSystemPasswordChar = True
        pbNotShow2.Visible = False
        pbShow2.Visible = True
    End Sub
    Private Sub SIGNUPtxtDISPLAYNAME_TextChanged(sender As Object, e As EventArgs) Handles SIGNUPtxtDISPLAYNAME.TextChanged
        Dim displayName As String = SIGNUPtxtDISPLAYNAME.Text.Trim()
        If displayName.Length = 0 Then
            lblshortusername.Visible = False
            lblusername.Visible = False
            SIGNUPtxtDISPLAYNAME.BorderColor = Color.Gray
        ElseIf displayName.Length < 3 Then
            lblshortusername.Visible = True
            lblusername.Visible = False
            SIGNUPtxtDISPLAYNAME.BorderColor = Color.Red
        ElseIf UsernameExistsInDatabase(displayName) Then
            lblshortusername.Visible = False
            lblusername.Text = "Username already exists."
            lblusername.Visible = True
            SIGNUPtxtDISPLAYNAME.BorderColor = Color.Red
        Else
            lblshortusername.Visible = False
            lblusername.Text = ""
            lblusername.Visible = False
            SIGNUPtxtDISPLAYNAME.BorderColor = Color.Gray
        End If
    End Sub
    Private Sub btnCancel2_Click(sender As Object, e As EventArgs) Handles btnCancel2.Click
        Dim signInForm As New frmLogin
        signInForm.Show()
        Me.Close()
    End Sub
    Private Sub btnSubmitVerification_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click ' btnSubmitVerification_Click for code verification code
        Dim enteredCode As String = txtVerificationCode.Text.Trim()
        Dim email As String = SIGNUPtxtEmail.Text.Trim()

        If String.IsNullOrEmpty(enteredCode) Then
            lblVerificationMessage.Text = "Please enter the verification code."
            lblVerificationMessage.Visible = True
            Return
        End If

        If VerifyCode(email, enteredCode) Then
            UpdateUserStatus(email)
            lblVerificationMessage.Text = "Email verified successfully!"
            lblVerificationMessage.ForeColor = Color.Green
            lblVerificationMessage.Visible = True

            Dim loginForm As New frmLogin()
            loginForm.Show()
            Me.Close()
        Else
            lblVerificationMessage.Text = "Invalid or expired verification code. Please request a new one."
            lblVerificationMessage.ForeColor = Color.Red
            lblVerificationMessage.Visible = True
        End If

    End Sub
    Private Function VerifyCode(email As String, code As String) As Boolean
        Dim connString As String = SQL_Connection.ConnectionString

        Using connection As New MySqlConnection(connString)
            connection.Open()

            ' Delete expired codes before checking the new one
            Dim deleteQuery As String = "UPDATE tbluserdetails SET VerificationCode = NULL WHERE TIMESTAMPDIFF(SECOND, CreatedAt, NOW()) > 30"
            Using deleteCommand As New MySqlCommand(deleteQuery, connection)
                deleteCommand.ExecuteNonQuery()
            End Using

            ' Check if the entered code is valid and not expired
            Dim query As String = "SELECT COUNT(*) FROM tbluserdetails 
                               WHERE EMAIL = @Email 
                               AND VerificationCode = @VerificationCode 
                               AND TIMESTAMPDIFF(SECOND, CreatedAt, NOW()) <= 30"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@VerificationCode", code)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function


    Private Sub UpdateUserStatus(email As String)
        Dim query As String = "UPDATE tbluserdetails SET IsVerified = 1 WHERE EMAIL = @Email"
        Dim connString As String = SQL_Connection.ConnectionString

        Using connection As New MySqlConnection(connString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Email", email)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Private Function GenerateVerificationCode() As String
        Dim random As New Random()
        Dim code As Integer = random.Next(100000, 1000000)
        Return code.ToString()
    End Function
    Private Sub SendVerificationEmail(email As String, verificationCode As String)
        Dim subject As String = "Email Verification"
        Dim body As String = $"Your verification code is: {verificationCode}"

        Dim smtpClient As New SmtpClient("smtp.gmail.com", 587)
        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network
        smtpClient.Credentials = New Net.NetworkCredential("vescorai1@gmail.com", "okur bhme cyaz zouv") ' Use your App Password
        smtpClient.EnableSsl = True

        Dim mailMessage As New MailMessage()
        mailMessage.From = New MailAddress("vescorai1@gmail.com")
        mailMessage.To.Add(email)
        mailMessage.Subject = subject
        mailMessage.Body = body

        Try
            smtpClient.Send(mailMessage)
        Catch ex As SmtpException
            MessageBox.Show("An error occurred while sending the email: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cooldownTimer_Tick(sender As Object, e As EventArgs) Handles cooldownTimer.Tick
        cooldownTimeRemaining -= 1

        If cooldownTimeRemaining <= 0 Then
            cooldownTimer.Stop()
            resendClickCount = 0 ' Reset click count after cooldown
            btnResend.Enabled = True ' Re-enable the button
            lblVerificationMessage.Text = "You can now request a new code."
            lblVerificationMessage.ForeColor = Color.Green
        Else
            lblVerificationMessage.Text = "Please wait " & cooldownTimeRemaining.ToString() & "s before resending."
            lblVerificationMessage.ForeColor = Color.Red
        End If
        lblVerificationMessage.Visible = True
    End Sub

    ' Variables for cooldown mechanism
    Private resendClickCount As Integer = 0
    Private cooldownTimeRemaining As Integer = 15
    Private WithEvents cooldownTimer As New Timer()
    Private Sub btnResend_Click(sender As Object, e As EventArgs) Handles btnResend.Click
        Dim email As String = SIGNUPtxtEmail.Text.Trim()

        ' Validate if email is provided
        If String.IsNullOrEmpty(email) Then
            lblVerificationMessage.Text = "Please enter your email first."
            lblVerificationMessage.ForeColor = Color.Red
            lblVerificationMessage.Visible = True
            Return
        End If

        ' Check if email exists in the database
        If Not EmailExistsInDatabase(email) Then
            lblVerificationMessage.Text = "Email not found. Please sign up again."
            lblVerificationMessage.ForeColor = Color.Red
            lblVerificationMessage.Visible = True
            Return
        End If

        ' Check if the user has reached 3 resend attempts
        If resendClickCount >= 3 Then
            lblVerificationMessage.Text = "Too many requests. Please wait 15 seconds."
            lblVerificationMessage.ForeColor = Color.Red
            lblVerificationMessage.Visible = True
            btnResend.Enabled = False ' Disable the button during cooldown
            cooldownTimeRemaining = 15
            cooldownTimer.Start()
            Return
        End If

        ' Generate a new verification code
        Dim newVerificationCode As String = GenerateVerificationCode()

        ' Update the new code in the database and reset CreatedAt timestamp
        StoreVerificationCode(email, newVerificationCode)

        ' Send verification email with the new code
        SendVerificationEmail(email, newVerificationCode)

        ' Show success message
        lblVerificationMessage.Text = "A new verification code has been sent to your email."
        lblVerificationMessage.ForeColor = Color.Green
        lblVerificationMessage.Visible = True

        ' Increment click count
        resendClickCount += 1
    End Sub
    Private Sub ResendCode(email As String)
        ' Generate a new verification code
        Dim newVerificationCode As String = GenerateVerificationCode()

        ' Update the new code in the database and reset CreatedAt timestamp
        StoreVerificationCode(email, newVerificationCode)

        ' Send verification email with the new code
        SendVerificationEmail(email, newVerificationCode)

        ' Show success message
        lblVerificationMessage.Text = "A new verification code has been sent to your email."
        lblVerificationMessage.ForeColor = Color.Green
        lblVerificationMessage.Visible = True
    End Sub
    Private Sub btnBackButton_Click(sender As Object, e As EventArgs) Handles btnBackButton.Click
        ' Hide the Email Verification panel
        gbSignUp2.Visible = False

        ' Show the Sign-Up panel
        gbSignUp1.Visible = True
    End Sub
End Class