<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tmrReduce = New System.Windows.Forms.Timer(Me.components)
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnIngredients = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBookmarked = New Guna.UI2.WinForms.Guna2Button()
        Me.tmrIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.pnlHome = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblSaved = New ReaLTaiizor.Controls.BigLabel()
        Me.btnSaveRecipe = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSend1 = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlSideMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlCalorieTrack = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCalorieTrack = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlBookmarks = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlIngredients = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlLogout = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlSubHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblBrand = New ReaLTaiizor.Controls.BigLabel()
        Me.btnSideMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlAiResponse = New Guna.UI2.WinForms.Guna2Panel()
        Me.Generating = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtairesponse = New System.Windows.Forms.RichTextBox()
        Me.txtPrompt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tmrLabel = New System.Windows.Forms.Timer(Me.components)
        Me.pnlHome.SuspendLayout()
        Me.pnlSideMenu.SuspendLayout()
        Me.pnlCalorieTrack.SuspendLayout()
        Me.pnlBookmarks.SuspendLayout()
        Me.pnlIngredients.SuspendLayout()
        Me.pnlLogout.SuspendLayout()
        Me.pnlSubHeader.SuspendLayout()
        Me.pnlAiResponse.SuspendLayout()
        CType(Me.Generating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrReduce
        '
        Me.tmrReduce.Interval = 1
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BorderColor = System.Drawing.Color.Transparent
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnLogout.Location = New System.Drawing.Point(0, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnLogout.PressedColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnLogout.Size = New System.Drawing.Size(226, 56)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.TabStop = False
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.TextOffset = New System.Drawing.Point(-10, 0)
        '
        'btnIngredients
        '
        Me.btnIngredients.BackColor = System.Drawing.Color.Transparent
        Me.btnIngredients.BorderColor = System.Drawing.Color.Transparent
        Me.btnIngredients.BorderRadius = 9
        Me.btnIngredients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngredients.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnIngredients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnIngredients.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnIngredients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnIngredients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnIngredients.FillColor = System.Drawing.Color.Transparent
        Me.btnIngredients.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngredients.ForeColor = System.Drawing.Color.White
        Me.btnIngredients.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnIngredients.Image = CType(resources.GetObject("btnIngredients.Image"), System.Drawing.Image)
        Me.btnIngredients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnIngredients.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnIngredients.Location = New System.Drawing.Point(0, 0)
        Me.btnIngredients.Name = "btnIngredients"
        Me.btnIngredients.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnIngredients.PressedColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnIngredients.Size = New System.Drawing.Size(226, 52)
        Me.btnIngredients.TabIndex = 0
        Me.btnIngredients.TabStop = False
        Me.btnIngredients.Text = "My Ingredients"
        Me.btnIngredients.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnIngredients.TextOffset = New System.Drawing.Point(-25, 0)
        '
        'btnBookmarked
        '
        Me.btnBookmarked.BackColor = System.Drawing.Color.Transparent
        Me.btnBookmarked.BorderColor = System.Drawing.Color.Transparent
        Me.btnBookmarked.BorderRadius = 9
        Me.btnBookmarked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookmarked.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBookmarked.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBookmarked.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBookmarked.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBookmarked.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBookmarked.FillColor = System.Drawing.Color.Transparent
        Me.btnBookmarked.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookmarked.ForeColor = System.Drawing.Color.White
        Me.btnBookmarked.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnBookmarked.Image = CType(resources.GetObject("btnBookmarked.Image"), System.Drawing.Image)
        Me.btnBookmarked.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBookmarked.ImageSize = New System.Drawing.Size(44, 44)
        Me.btnBookmarked.Location = New System.Drawing.Point(0, 0)
        Me.btnBookmarked.Name = "btnBookmarked"
        Me.btnBookmarked.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnBookmarked.PressedColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnBookmarked.Size = New System.Drawing.Size(226, 52)
        Me.btnBookmarked.TabIndex = 4
        Me.btnBookmarked.TabStop = False
        Me.btnBookmarked.Text = "Bookmarks"
        Me.btnBookmarked.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBookmarked.TextOffset = New System.Drawing.Point(2, 0)
        '
        'tmrIncrease
        '
        Me.tmrIncrease.Interval = 1
        '
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.pnlHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlHome.Controls.Add(Me.lblSaved)
        Me.pnlHome.Controls.Add(Me.btnSaveRecipe)
        Me.pnlHome.Controls.Add(Me.btnSend1)
        Me.pnlHome.Controls.Add(Me.pnlSideMenu)
        Me.pnlHome.Controls.Add(Me.pnlAiResponse)
        Me.pnlHome.Controls.Add(Me.txtPrompt)
        Me.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHome.FillColor = System.Drawing.Color.Transparent
        Me.pnlHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(1424, 861)
        Me.pnlHome.TabIndex = 66
        '
        'lblSaved
        '
        Me.lblSaved.AutoSize = True
        Me.lblSaved.BackColor = System.Drawing.Color.Transparent
        Me.lblSaved.Font = New System.Drawing.Font("Yu Gothic UI", 13.0!)
        Me.lblSaved.ForeColor = System.Drawing.Color.Lime
        Me.lblSaved.Location = New System.Drawing.Point(1149, 784)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(0, 25)
        Me.lblSaved.TabIndex = 30
        Me.lblSaved.Visible = False
        '
        'btnSaveRecipe
        '
        Me.btnSaveRecipe.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSaveRecipe.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveRecipe.BorderColor = System.Drawing.Color.Transparent
        Me.btnSaveRecipe.BorderRadius = 13
        Me.btnSaveRecipe.BorderThickness = 2
        Me.btnSaveRecipe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveRecipe.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSaveRecipe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSaveRecipe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSaveRecipe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSaveRecipe.FillColor = System.Drawing.Color.Transparent
        Me.btnSaveRecipe.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveRecipe.ForeColor = System.Drawing.Color.Transparent
        Me.btnSaveRecipe.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnSaveRecipe.Image = CType(resources.GetObject("btnSaveRecipe.Image"), System.Drawing.Image)
        Me.btnSaveRecipe.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnSaveRecipe.Location = New System.Drawing.Point(1109, 780)
        Me.btnSaveRecipe.Name = "btnSaveRecipe"
        Me.btnSaveRecipe.PressedColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnSaveRecipe.PressedDepth = 20
        Me.btnSaveRecipe.Size = New System.Drawing.Size(34, 41)
        Me.btnSaveRecipe.TabIndex = 9
        Me.btnSaveRecipe.TabStop = False
        Me.btnSaveRecipe.UseTransparentBackground = True
        '
        'btnSend1
        '
        Me.btnSend1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSend1.BackColor = System.Drawing.Color.Transparent
        Me.btnSend1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSend1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSend1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSend1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSend1.FillColor = System.Drawing.Color.White
        Me.btnSend1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSend1.ForeColor = System.Drawing.Color.White
        Me.btnSend1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnSend1.Image = CType(resources.GetObject("btnSend1.Image"), System.Drawing.Image)
        Me.btnSend1.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnSend1.Location = New System.Drawing.Point(1055, 783)
        Me.btnSend1.Name = "btnSend1"
        Me.btnSend1.Size = New System.Drawing.Size(37, 35)
        Me.btnSend1.TabIndex = 7
        Me.btnSend1.TabStop = False
        Me.btnSend1.UseTransparentBackground = True
        '
        'pnlSideMenu
        '
        Me.pnlSideMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlSideMenu.BorderColor = System.Drawing.Color.Transparent
        Me.pnlSideMenu.Controls.Add(Me.pnlCalorieTrack)
        Me.pnlSideMenu.Controls.Add(Me.pnlBookmarks)
        Me.pnlSideMenu.Controls.Add(Me.pnlIngredients)
        Me.pnlSideMenu.Controls.Add(Me.pnlLogout)
        Me.pnlSideMenu.Controls.Add(Me.pnlSubHeader)
        Me.pnlSideMenu.Controls.Add(Me.Guna2Button7)
        Me.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSideMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.pnlSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlSideMenu.Name = "pnlSideMenu"
        Me.pnlSideMenu.Size = New System.Drawing.Size(226, 861)
        Me.pnlSideMenu.TabIndex = 66
        Me.pnlSideMenu.UseTransparentBackground = True
        '
        'pnlCalorieTrack
        '
        Me.pnlCalorieTrack.Controls.Add(Me.btnCalorieTrack)
        Me.pnlCalorieTrack.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCalorieTrack.Location = New System.Drawing.Point(0, 230)
        Me.pnlCalorieTrack.Name = "pnlCalorieTrack"
        Me.pnlCalorieTrack.Size = New System.Drawing.Size(226, 52)
        Me.pnlCalorieTrack.TabIndex = 67
        '
        'btnCalorieTrack
        '
        Me.btnCalorieTrack.BackColor = System.Drawing.Color.Transparent
        Me.btnCalorieTrack.BorderColor = System.Drawing.Color.Transparent
        Me.btnCalorieTrack.BorderRadius = 9
        Me.btnCalorieTrack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalorieTrack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCalorieTrack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCalorieTrack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCalorieTrack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCalorieTrack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCalorieTrack.FillColor = System.Drawing.Color.Transparent
        Me.btnCalorieTrack.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalorieTrack.ForeColor = System.Drawing.Color.White
        Me.btnCalorieTrack.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnCalorieTrack.Image = CType(resources.GetObject("btnCalorieTrack.Image"), System.Drawing.Image)
        Me.btnCalorieTrack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCalorieTrack.ImageSize = New System.Drawing.Size(44, 44)
        Me.btnCalorieTrack.Location = New System.Drawing.Point(0, 0)
        Me.btnCalorieTrack.Name = "btnCalorieTrack"
        Me.btnCalorieTrack.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCalorieTrack.PressedColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnCalorieTrack.Size = New System.Drawing.Size(226, 52)
        Me.btnCalorieTrack.TabIndex = 13
        Me.btnCalorieTrack.TabStop = False
        Me.btnCalorieTrack.Text = "Calorie Tracker"
        Me.btnCalorieTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCalorieTrack.TextOffset = New System.Drawing.Point(2, 0)
        '
        'pnlBookmarks
        '
        Me.pnlBookmarks.Controls.Add(Me.btnBookmarked)
        Me.pnlBookmarks.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBookmarks.Location = New System.Drawing.Point(0, 178)
        Me.pnlBookmarks.Name = "pnlBookmarks"
        Me.pnlBookmarks.Size = New System.Drawing.Size(226, 52)
        Me.pnlBookmarks.TabIndex = 67
        '
        'pnlIngredients
        '
        Me.pnlIngredients.Controls.Add(Me.btnIngredients)
        Me.pnlIngredients.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlIngredients.Location = New System.Drawing.Point(0, 126)
        Me.pnlIngredients.Name = "pnlIngredients"
        Me.pnlIngredients.Size = New System.Drawing.Size(226, 52)
        Me.pnlIngredients.TabIndex = 14
        '
        'pnlLogout
        '
        Me.pnlLogout.Controls.Add(Me.btnLogout)
        Me.pnlLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlLogout.Location = New System.Drawing.Point(0, 805)
        Me.pnlLogout.Name = "pnlLogout"
        Me.pnlLogout.Size = New System.Drawing.Size(226, 56)
        Me.pnlLogout.TabIndex = 11
        '
        'pnlSubHeader
        '
        Me.pnlSubHeader.Controls.Add(Me.lblBrand)
        Me.pnlSubHeader.Controls.Add(Me.btnSideMenu)
        Me.pnlSubHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSubHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.pnlSubHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlSubHeader.Name = "pnlSubHeader"
        Me.pnlSubHeader.Size = New System.Drawing.Size(226, 126)
        Me.pnlSubHeader.TabIndex = 10
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.BackColor = System.Drawing.Color.Transparent
        Me.lblBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.ForeColor = System.Drawing.Color.White
        Me.lblBrand.Location = New System.Drawing.Point(59, 43)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(158, 38)
        Me.lblBrand.TabIndex = 29
        Me.lblBrand.Text = "VescorAI"
        '
        'btnSideMenu
        '
        Me.btnSideMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnSideMenu.BorderColor = System.Drawing.Color.Transparent
        Me.btnSideMenu.BorderRadius = 9
        Me.btnSideMenu.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.btnSideMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSideMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSideMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSideMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSideMenu.FillColor = System.Drawing.Color.Transparent
        Me.btnSideMenu.Font = New System.Drawing.Font("Tahoma", 25.0!)
        Me.btnSideMenu.ForeColor = System.Drawing.Color.White
        Me.btnSideMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnSideMenu.Image = CType(resources.GetObject("btnSideMenu.Image"), System.Drawing.Image)
        Me.btnSideMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSideMenu.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSideMenu.Location = New System.Drawing.Point(4, 39)
        Me.btnSideMenu.Name = "btnSideMenu"
        Me.btnSideMenu.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSideMenu.PressedColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnSideMenu.Size = New System.Drawing.Size(49, 51)
        Me.btnSideMenu.TabIndex = 15
        Me.btnSideMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSideMenu.UseTransparentBackground = True
        '
        'Guna2Button7
        '
        Me.Guna2Button7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button7.BorderRadius = 13
        Me.Guna2Button7.BorderThickness = 2
        Me.Guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button7.FillColor = System.Drawing.Color.White
        Me.Guna2Button7.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button7.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button7.Location = New System.Drawing.Point(1064, 25)
        Me.Guna2Button7.Name = "Guna2Button7"
        Me.Guna2Button7.Size = New System.Drawing.Size(152, 25)
        Me.Guna2Button7.TabIndex = 9
        Me.Guna2Button7.Text = "Save this Recipe"
        '
        'pnlAiResponse
        '
        Me.pnlAiResponse.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pnlAiResponse.BackColor = System.Drawing.Color.Transparent
        Me.pnlAiResponse.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.pnlAiResponse.BorderRadius = 13
        Me.pnlAiResponse.BorderThickness = 3
        Me.pnlAiResponse.Controls.Add(Me.Generating)
        Me.pnlAiResponse.Controls.Add(Me.txtairesponse)
        Me.pnlAiResponse.FillColor = System.Drawing.Color.GhostWhite
        Me.pnlAiResponse.Location = New System.Drawing.Point(252, 56)
        Me.pnlAiResponse.Name = "pnlAiResponse"
        Me.pnlAiResponse.Size = New System.Drawing.Size(1146, 698)
        Me.pnlAiResponse.TabIndex = 65
        Me.pnlAiResponse.UseTransparentBackground = True
        '
        'Generating
        '
        Me.Generating.BackColor = System.Drawing.Color.Transparent
        Me.Generating.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Generating.Image = CType(resources.GetObject("Generating.Image"), System.Drawing.Image)
        Me.Generating.ImageRotate = 0!
        Me.Generating.Location = New System.Drawing.Point(0, 0)
        Me.Generating.Name = "Generating"
        Me.Generating.Size = New System.Drawing.Size(1146, 698)
        Me.Generating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Generating.TabIndex = 7
        Me.Generating.TabStop = False
        Me.Generating.UseTransparentBackground = True
        '
        'txtairesponse
        '
        Me.txtairesponse.BackColor = System.Drawing.Color.GhostWhite
        Me.txtairesponse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtairesponse.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtairesponse.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtairesponse.Location = New System.Drawing.Point(9, 10)
        Me.txtairesponse.Name = "txtairesponse"
        Me.txtairesponse.ReadOnly = True
        Me.txtairesponse.ShortcutsEnabled = False
        Me.txtairesponse.Size = New System.Drawing.Size(1128, 679)
        Me.txtairesponse.TabIndex = 0
        Me.txtairesponse.Text = ""
        '
        'txtPrompt
        '
        Me.txtPrompt.BackColor = System.Drawing.Color.Transparent
        Me.txtPrompt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPrompt.BorderRadius = 13
        Me.txtPrompt.BorderThickness = 2
        Me.txtPrompt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrompt.DefaultText = ""
        Me.txtPrompt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrompt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrompt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrompt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrompt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrompt.Font = New System.Drawing.Font("Yu Gothic UI", 15.0!)
        Me.txtPrompt.ForeColor = System.Drawing.Color.Black
        Me.txtPrompt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrompt.Location = New System.Drawing.Point(480, 777)
        Me.txtPrompt.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPrompt.Multiline = True
        Me.txtPrompt.Name = "txtPrompt"
        Me.txtPrompt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrompt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPrompt.PlaceholderText = "What do you want to cook today?"
        Me.txtPrompt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPrompt.SelectedText = ""
        Me.txtPrompt.Size = New System.Drawing.Size(618, 46)
        Me.txtPrompt.TabIndex = 0
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(291, 165)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(3, 2)
        Me.Guna2HtmlLabel4.TabIndex = 8
        Me.Guna2HtmlLabel4.Text = Nothing
        '
        'tmrLabel
        '
        Me.tmrLabel.Interval = 1000
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnSend1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1424, 861)
        Me.Controls.Add(Me.pnlHome)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VescorAI"
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        Me.pnlSideMenu.ResumeLayout(False)
        Me.pnlCalorieTrack.ResumeLayout(False)
        Me.pnlBookmarks.ResumeLayout(False)
        Me.pnlIngredients.ResumeLayout(False)
        Me.pnlLogout.ResumeLayout(False)
        Me.pnlSubHeader.ResumeLayout(False)
        Me.pnlSubHeader.PerformLayout()
        Me.pnlAiResponse.ResumeLayout(False)
        CType(Me.Generating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnIngredients As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tmrIncrease As Timer
    Friend WithEvents tmrReduce As Timer
    Friend WithEvents pnlHome As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnBookmarked As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnCalorieTrack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlSideMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSaveRecipe As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSend1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlAiResponse As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Generating As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtairesponse As RichTextBox
    Friend WithEvents txtPrompt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSideMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlSubHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlLogout As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlBookmarks As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlIngredients As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlCalorieTrack As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblBrand As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents lblSaved As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents tmrLabel As Timer
End Class
