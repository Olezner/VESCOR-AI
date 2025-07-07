<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblPassError = New System.Windows.Forms.Label()
        Me.buttonLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.buttonSignUp = New Guna.UI2.WinForms.Guna2Button()
        Me.buttonForgotPassword = New Guna.UI2.WinForms.Guna2Button()
        Me.pbNotShow = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pbShow = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.gbSignIn = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.pbSignInLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblSignIn = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelVEscoro = New ReaLTaiizor.Controls.BigLabel()
        Me.pbPassword = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblUserError = New System.Windows.Forms.Label()
        Me.pbUsername = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LOGINtxtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LOGINtxtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.pbNotShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSignIn.SuspendLayout()
        CType(Me.pbSignInLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPassError
        '
        Me.lblPassError.BackColor = System.Drawing.Color.Transparent
        Me.lblPassError.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassError.ForeColor = System.Drawing.Color.Red
        Me.lblPassError.Location = New System.Drawing.Point(43, 353)
        Me.lblPassError.Name = "lblPassError"
        Me.lblPassError.Size = New System.Drawing.Size(214, 18)
        Me.lblPassError.TabIndex = 0
        Me.lblPassError.Text = "Invalid Username or Password"
        Me.lblPassError.Visible = False
        '
        'buttonLogin
        '
        Me.buttonLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonLogin.BackColor = System.Drawing.Color.Transparent
        Me.buttonLogin.BorderRadius = 13
        Me.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.buttonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.buttonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.buttonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.buttonLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.buttonLogin.FocusedColor = System.Drawing.Color.LightSalmon
        Me.buttonLogin.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.buttonLogin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.buttonLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.buttonLogin.Location = New System.Drawing.Point(94, 395)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(245, 45)
        Me.buttonLogin.TabIndex = 3
        Me.buttonLogin.TabStop = False
        Me.buttonLogin.Text = "Sign In"
        '
        'buttonSignUp
        '
        Me.buttonSignUp.BackColor = System.Drawing.Color.Transparent
        Me.buttonSignUp.BorderColor = System.Drawing.Color.Transparent
        Me.buttonSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.buttonSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.buttonSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.buttonSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.buttonSignUp.FillColor = System.Drawing.Color.Transparent
        Me.buttonSignUp.FocusedColor = System.Drawing.Color.LightSalmon
        Me.buttonSignUp.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.buttonSignUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.buttonSignUp.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.buttonSignUp.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.buttonSignUp.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.buttonSignUp.Location = New System.Drawing.Point(237, 450)
        Me.buttonSignUp.Name = "buttonSignUp"
        Me.buttonSignUp.PressedColor = System.Drawing.Color.Transparent
        Me.buttonSignUp.Size = New System.Drawing.Size(70, 21)
        Me.buttonSignUp.TabIndex = 4
        Me.buttonSignUp.TabStop = False
        Me.buttonSignUp.Text = "Sign Up"
        Me.buttonSignUp.UseTransparentBackground = True
        '
        'buttonForgotPassword
        '
        Me.buttonForgotPassword.BackColor = System.Drawing.Color.Transparent
        Me.buttonForgotPassword.BorderColor = System.Drawing.Color.Transparent
        Me.buttonForgotPassword.BorderRadius = 13
        Me.buttonForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonForgotPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.buttonForgotPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.buttonForgotPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.buttonForgotPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.buttonForgotPassword.FillColor = System.Drawing.Color.Transparent
        Me.buttonForgotPassword.FocusedColor = System.Drawing.Color.LightSalmon
        Me.buttonForgotPassword.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonForgotPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.buttonForgotPassword.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.buttonForgotPassword.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.buttonForgotPassword.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.buttonForgotPassword.Location = New System.Drawing.Point(277, 347)
        Me.buttonForgotPassword.Name = "buttonForgotPassword"
        Me.buttonForgotPassword.PressedColor = System.Drawing.Color.Transparent
        Me.buttonForgotPassword.Size = New System.Drawing.Size(134, 24)
        Me.buttonForgotPassword.TabIndex = 2
        Me.buttonForgotPassword.TabStop = False
        Me.buttonForgotPassword.Text = "Forgot Password"
        '
        'pbNotShow
        '
        Me.pbNotShow.BackColor = System.Drawing.Color.Transparent
        Me.pbNotShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbNotShow.BorderRadius = 5
        Me.pbNotShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbNotShow.FillColor = System.Drawing.Color.Transparent
        Me.pbNotShow.Image = CType(resources.GetObject("pbNotShow.Image"), System.Drawing.Image)
        Me.pbNotShow.ImageRotate = 0!
        Me.pbNotShow.Location = New System.Drawing.Point(342, 314)
        Me.pbNotShow.Name = "pbNotShow"
        Me.pbNotShow.Size = New System.Drawing.Size(25, 25)
        Me.pbNotShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbNotShow.TabIndex = 19
        Me.pbNotShow.TabStop = False
        Me.pbNotShow.UseTransparentBackground = True
        '
        'pbShow
        '
        Me.pbShow.BackColor = System.Drawing.Color.Transparent
        Me.pbShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbShow.BorderRadius = 5
        Me.pbShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbShow.FillColor = System.Drawing.Color.Transparent
        Me.pbShow.Image = CType(resources.GetObject("pbShow.Image"), System.Drawing.Image)
        Me.pbShow.ImageRotate = 0!
        Me.pbShow.Location = New System.Drawing.Point(342, 314)
        Me.pbShow.Name = "pbShow"
        Me.pbShow.Size = New System.Drawing.Size(25, 25)
        Me.pbShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbShow.TabIndex = 18
        Me.pbShow.TabStop = False
        Me.pbShow.UseTransparentBackground = True
        '
        'gbSignIn
        '
        Me.gbSignIn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbSignIn.BackColor = System.Drawing.Color.Transparent
        Me.gbSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbSignIn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gbSignIn.BorderRadius = 13
        Me.gbSignIn.BorderThickness = 2
        Me.gbSignIn.Controls.Add(Me.pbSignInLogo)
        Me.gbSignIn.Controls.Add(Me.lblSignIn)
        Me.gbSignIn.Controls.Add(Me.Label2)
        Me.gbSignIn.Controls.Add(Me.LabelVEscoro)
        Me.gbSignIn.Controls.Add(Me.buttonSignUp)
        Me.gbSignIn.Controls.Add(Me.pbPassword)
        Me.gbSignIn.Controls.Add(Me.lblUserError)
        Me.gbSignIn.Controls.Add(Me.pbUsername)
        Me.gbSignIn.Controls.Add(Me.pbShow)
        Me.gbSignIn.Controls.Add(Me.buttonForgotPassword)
        Me.gbSignIn.Controls.Add(Me.pbNotShow)
        Me.gbSignIn.Controls.Add(Me.buttonLogin)
        Me.gbSignIn.Controls.Add(Me.lblPassError)
        Me.gbSignIn.Controls.Add(Me.LOGINtxtPassword)
        Me.gbSignIn.Controls.Add(Me.LOGINtxtUsername)
        Me.gbSignIn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.gbSignIn.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.gbSignIn.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.gbSignIn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gbSignIn.ForeColor = System.Drawing.Color.Transparent
        Me.gbSignIn.Location = New System.Drawing.Point(207, 87)
        Me.gbSignIn.Margin = New System.Windows.Forms.Padding(0)
        Me.gbSignIn.Name = "gbSignIn"
        Me.gbSignIn.Size = New System.Drawing.Size(428, 498)
        Me.gbSignIn.TabIndex = 22
        Me.gbSignIn.Text = "Guna2GroupBox1"
        Me.gbSignIn.UseTransparentBackground = True
        '
        'pbSignInLogo
        '
        Me.pbSignInLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbSignInLogo.FillColor = System.Drawing.Color.Transparent
        Me.pbSignInLogo.Image = CType(resources.GetObject("pbSignInLogo.Image"), System.Drawing.Image)
        Me.pbSignInLogo.ImageRotate = 0!
        Me.pbSignInLogo.Location = New System.Drawing.Point(141, 20)
        Me.pbSignInLogo.Name = "pbSignInLogo"
        Me.pbSignInLogo.Size = New System.Drawing.Size(150, 118)
        Me.pbSignInLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSignInLogo.TabIndex = 24
        Me.pbSignInLogo.TabStop = False
        Me.pbSignInLogo.UseTransparentBackground = True
        '
        'lblSignIn
        '
        Me.lblSignIn.BackColor = System.Drawing.Color.Transparent
        Me.lblSignIn.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignIn.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblSignIn.Location = New System.Drawing.Point(17, 174)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(397, 26)
        Me.lblSignIn.TabIndex = 8
        Me.lblSignIn.Text = "Manage groceries, get recipes, track calories" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(118, 453)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Don't have an account?"
        '
        'LabelVEscoro
        '
        Me.LabelVEscoro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelVEscoro.AutoSize = True
        Me.LabelVEscoro.BackColor = System.Drawing.Color.Transparent
        Me.LabelVEscoro.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVEscoro.ForeColor = System.Drawing.Color.GhostWhite
        Me.LabelVEscoro.Location = New System.Drawing.Point(137, 126)
        Me.LabelVEscoro.Name = "LabelVEscoro"
        Me.LabelVEscoro.Size = New System.Drawing.Size(158, 38)
        Me.LabelVEscoro.TabIndex = 25
        Me.LabelVEscoro.Text = "VescorAI"
        '
        'pbPassword
        '
        Me.pbPassword.FillColor = System.Drawing.Color.Transparent
        Me.pbPassword.Image = CType(resources.GetObject("pbPassword.Image"), System.Drawing.Image)
        Me.pbPassword.ImageRotate = 0!
        Me.pbPassword.Location = New System.Drawing.Point(46, 313)
        Me.pbPassword.Name = "pbPassword"
        Me.pbPassword.Size = New System.Drawing.Size(25, 25)
        Me.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPassword.TabIndex = 25
        Me.pbPassword.TabStop = False
        Me.pbPassword.UseTransparentBackground = True
        '
        'lblUserError
        '
        Me.lblUserError.BackColor = System.Drawing.Color.Transparent
        Me.lblUserError.ForeColor = System.Drawing.Color.Red
        Me.lblUserError.Location = New System.Drawing.Point(3, 468)
        Me.lblUserError.Name = "lblUserError"
        Me.lblUserError.Size = New System.Drawing.Size(100, 23)
        Me.lblUserError.TabIndex = 16
        Me.lblUserError.Visible = False
        '
        'pbUsername
        '
        Me.pbUsername.FillColor = System.Drawing.Color.Transparent
        Me.pbUsername.Image = CType(resources.GetObject("pbUsername.Image"), System.Drawing.Image)
        Me.pbUsername.ImageRotate = 0!
        Me.pbUsername.Location = New System.Drawing.Point(47, 258)
        Me.pbUsername.Name = "pbUsername"
        Me.pbUsername.Size = New System.Drawing.Size(25, 25)
        Me.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUsername.TabIndex = 24
        Me.pbUsername.TabStop = False
        Me.pbUsername.UseTransparentBackground = True
        '
        'LOGINtxtPassword
        '
        Me.LOGINtxtPassword.BorderColor = System.Drawing.Color.DarkCyan
        Me.LOGINtxtPassword.BorderRadius = 9
        Me.LOGINtxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LOGINtxtPassword.DefaultText = ""
        Me.LOGINtxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LOGINtxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LOGINtxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LOGINtxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LOGINtxtPassword.FillColor = System.Drawing.Color.Snow
        Me.LOGINtxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LOGINtxtPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGINtxtPassword.ForeColor = System.Drawing.Color.Black
        Me.LOGINtxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LOGINtxtPassword.Location = New System.Drawing.Point(41, 309)
        Me.LOGINtxtPassword.MaxLength = 15
        Me.LOGINtxtPassword.Name = "LOGINtxtPassword"
        Me.LOGINtxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LOGINtxtPassword.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.LOGINtxtPassword.PlaceholderText = "Password"
        Me.LOGINtxtPassword.SelectedText = ""
        Me.LOGINtxtPassword.Size = New System.Drawing.Size(351, 36)
        Me.LOGINtxtPassword.TabIndex = 1
        Me.LOGINtxtPassword.TextOffset = New System.Drawing.Point(27, 0)
        '
        'LOGINtxtUsername
        '
        Me.LOGINtxtUsername.BorderColor = System.Drawing.Color.DarkCyan
        Me.LOGINtxtUsername.BorderRadius = 9
        Me.LOGINtxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LOGINtxtUsername.DefaultText = ""
        Me.LOGINtxtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LOGINtxtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LOGINtxtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LOGINtxtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LOGINtxtUsername.FillColor = System.Drawing.Color.Snow
        Me.LOGINtxtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LOGINtxtUsername.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LOGINtxtUsername.ForeColor = System.Drawing.Color.Black
        Me.LOGINtxtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LOGINtxtUsername.Location = New System.Drawing.Point(41, 256)
        Me.LOGINtxtUsername.MaxLength = 20
        Me.LOGINtxtUsername.Name = "LOGINtxtUsername"
        Me.LOGINtxtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LOGINtxtUsername.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.LOGINtxtUsername.PlaceholderText = "Username"
        Me.LOGINtxtUsername.SelectedText = ""
        Me.LOGINtxtUsername.Size = New System.Drawing.Size(351, 36)
        Me.LOGINtxtUsername.TabIndex = 0
        Me.LOGINtxtUsername.TextOffset = New System.Drawing.Point(27, 0)
        '
        'frmLogin
        '
        Me.AcceptButton = Me.buttonLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(835, 680)
        Me.Controls.Add(Me.gbSignIn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VescorAI"
        CType(Me.pbNotShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSignIn.ResumeLayout(False)
        Me.gbSignIn.PerformLayout()
        CType(Me.pbSignInLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsername, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPassError As Label
    Friend WithEvents buttonLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents buttonSignUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents buttonForgotPassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pbNotShow As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pbShow As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents gbSignIn As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents LOGINtxtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LOGINtxtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblUserError As Label
    Friend WithEvents pbPassword As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pbUsername As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pbSignInLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LabelVEscoro As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSignIn As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
