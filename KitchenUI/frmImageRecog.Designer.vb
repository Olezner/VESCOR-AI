<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImageRecog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImageRecog))
        Me.pnlUpload = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblOr = New ReaLTaiizor.Controls.BigLabel()
        Me.lblDragnDrop = New ReaLTaiizor.Controls.BigLabel()
        Me.btnUpload = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlPreview = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.pbShowImage = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PanelDetails = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.txtAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnDecrease = New Guna.UI2.WinForms.Guna2Button()
        Me.btnIncrease = New Guna.UI2.WinForms.Guna2Button()
        Me.lblUnit = New ReaLTaiizor.Controls.BigLabel()
        Me.ddUnit = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblClassification = New ReaLTaiizor.Controls.BigLabel()
        Me.lblAmount = New ReaLTaiizor.Controls.BigLabel()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnImageRecBack = New Guna.UI2.WinForms.Guna2Button()
        Me.lblPreview = New ReaLTaiizor.Controls.BigLabel()
        Me.txtItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlUpload.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPreview.SuspendLayout()
        CType(Me.pbShowImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlUpload
        '
        Me.pnlUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUpload.BackColor = System.Drawing.Color.Transparent
        Me.pnlUpload.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.pnlUpload.BorderRadius = 13
        Me.pnlUpload.BorderThickness = 2
        Me.pnlUpload.Controls.Add(Me.Guna2PictureBox1)
        Me.pnlUpload.Controls.Add(Me.lblOr)
        Me.pnlUpload.Controls.Add(Me.lblDragnDrop)
        Me.pnlUpload.Controls.Add(Me.btnUpload)
        Me.pnlUpload.CustomBorderColor = System.Drawing.Color.Empty
        Me.pnlUpload.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.pnlUpload.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.pnlUpload.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pnlUpload.ForeColor = System.Drawing.Color.Transparent
        Me.pnlUpload.Location = New System.Drawing.Point(938, 70)
        Me.pnlUpload.Name = "pnlUpload"
        Me.pnlUpload.Size = New System.Drawing.Size(444, 436)
        Me.pnlUpload.TabIndex = 60
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(97, 15)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(252, 262)
        Me.Guna2PictureBox1.TabIndex = 73
        Me.Guna2PictureBox1.TabStop = False
        '
        'lblOr
        '
        Me.lblOr.BackColor = System.Drawing.Color.Transparent
        Me.lblOr.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOr.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblOr.Location = New System.Drawing.Point(202, 314)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(43, 43)
        Me.lblOr.TabIndex = 72
        Me.lblOr.Text = "or"
        '
        'lblDragnDrop
        '
        Me.lblDragnDrop.BackColor = System.Drawing.Color.Transparent
        Me.lblDragnDrop.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDragnDrop.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblDragnDrop.Location = New System.Drawing.Point(57, 269)
        Me.lblDragnDrop.Name = "lblDragnDrop"
        Me.lblDragnDrop.Size = New System.Drawing.Size(332, 51)
        Me.lblDragnDrop.TabIndex = 71
        Me.lblDragnDrop.Text = "Drag and Drop a file"
        '
        'btnUpload
        '
        Me.btnUpload.BorderRadius = 13
        Me.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpload.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnUpload.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(125, 361)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(196, 51)
        Me.btnUpload.TabIndex = 0
        Me.btnUpload.Text = "UPLOAD"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(133, 459)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(59, 27)
        Me.Guna2HtmlLabel3.TabIndex = 48
        Me.Guna2HtmlLabel3.Text = "Unit(s)"
        '
        'pnlPreview
        '
        Me.pnlPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPreview.BackColor = System.Drawing.Color.Transparent
        Me.pnlPreview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.pnlPreview.BorderRadius = 13
        Me.pnlPreview.Controls.Add(Me.pbShowImage)
        Me.pnlPreview.CustomBorderColor = System.Drawing.Color.Empty
        Me.pnlPreview.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.pnlPreview.FillColor = System.Drawing.Color.Transparent
        Me.pnlPreview.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pnlPreview.ForeColor = System.Drawing.Color.Transparent
        Me.pnlPreview.Location = New System.Drawing.Point(44, 70)
        Me.pnlPreview.Name = "pnlPreview"
        Me.pnlPreview.Size = New System.Drawing.Size(826, 750)
        Me.pnlPreview.TabIndex = 62
        Me.pnlPreview.UseTransparentBackground = True
        '
        'pbShowImage
        '
        Me.pbShowImage.BackColor = System.Drawing.Color.Transparent
        Me.pbShowImage.BorderRadius = 13
        Me.pbShowImage.Cursor = System.Windows.Forms.Cursors.No
        Me.pbShowImage.ErrorImage = Nothing
        Me.pbShowImage.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.pbShowImage.ImageRotate = 0!
        Me.pbShowImage.InitialImage = Nothing
        Me.pbShowImage.Location = New System.Drawing.Point(3, 3)
        Me.pbShowImage.Name = "pbShowImage"
        Me.pbShowImage.Size = New System.Drawing.Size(820, 744)
        Me.pbShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbShowImage.TabIndex = 62
        Me.pbShowImage.TabStop = False
        Me.pbShowImage.UseTransparentBackground = True
        '
        'PanelDetails
        '
        Me.PanelDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetails.BackColor = System.Drawing.Color.Transparent
        Me.PanelDetails.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.PanelDetails.BorderRadius = 13
        Me.PanelDetails.BorderThickness = 2
        Me.PanelDetails.Controls.Add(Me.txtItemName)
        Me.PanelDetails.Controls.Add(Me.lblError)
        Me.PanelDetails.Controls.Add(Me.txtAmount)
        Me.PanelDetails.Controls.Add(Me.btnDecrease)
        Me.PanelDetails.Controls.Add(Me.btnIncrease)
        Me.PanelDetails.Controls.Add(Me.lblUnit)
        Me.PanelDetails.Controls.Add(Me.ddUnit)
        Me.PanelDetails.Controls.Add(Me.lblClassification)
        Me.PanelDetails.Controls.Add(Me.lblAmount)
        Me.PanelDetails.CustomBorderColor = System.Drawing.Color.Empty
        Me.PanelDetails.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.PanelDetails.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.PanelDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PanelDetails.ForeColor = System.Drawing.Color.Transparent
        Me.PanelDetails.Location = New System.Drawing.Point(938, 554)
        Me.PanelDetails.Name = "PanelDetails"
        Me.PanelDetails.Size = New System.Drawing.Size(444, 211)
        Me.PanelDetails.TabIndex = 63
        Me.PanelDetails.UseTransparentBackground = True
        '
        'lblError
        '
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(250, 97)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(187, 18)
        Me.lblError.TabIndex = 73
        Me.lblError.Text = " "
        '
        'txtAmount
        '
        Me.txtAmount.BorderColor = System.Drawing.Color.Black
        Me.txtAmount.BorderRadius = 9
        Me.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmount.DefaultText = ""
        Me.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmount.Location = New System.Drawing.Point(106, 142)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmount.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAmount.PlaceholderText = ""
        Me.txtAmount.SelectedText = ""
        Me.txtAmount.Size = New System.Drawing.Size(142, 35)
        Me.txtAmount.TabIndex = 3
        '
        'btnDecrease
        '
        Me.btnDecrease.BorderRadius = 13
        Me.btnDecrease.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDecrease.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDecrease.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDecrease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDecrease.FillColor = System.Drawing.Color.Transparent
        Me.btnDecrease.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrease.ForeColor = System.Drawing.Color.White
        Me.btnDecrease.Image = CType(resources.GetObject("btnDecrease.Image"), System.Drawing.Image)
        Me.btnDecrease.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnDecrease.Location = New System.Drawing.Point(254, 155)
        Me.btnDecrease.Name = "btnDecrease"
        Me.btnDecrease.Size = New System.Drawing.Size(34, 29)
        Me.btnDecrease.TabIndex = 69
        Me.btnDecrease.TabStop = False
        '
        'btnIncrease
        '
        Me.btnIncrease.BorderRadius = 13
        Me.btnIncrease.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnIncrease.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnIncrease.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnIncrease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnIncrease.FillColor = System.Drawing.Color.Transparent
        Me.btnIncrease.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncrease.ForeColor = System.Drawing.Color.White
        Me.btnIncrease.Image = CType(resources.GetObject("btnIncrease.Image"), System.Drawing.Image)
        Me.btnIncrease.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnIncrease.Location = New System.Drawing.Point(253, 130)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(34, 29)
        Me.btnIncrease.TabIndex = 62
        Me.btnIncrease.TabStop = False
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.Transparent
        Me.lblUnit.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblUnit.Location = New System.Drawing.Point(18, 86)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(59, 41)
        Me.lblUnit.TabIndex = 71
        Me.lblUnit.Text = "Unit:"
        '
        'ddUnit
        '
        Me.ddUnit.AllowDrop = True
        Me.ddUnit.BackColor = System.Drawing.Color.Transparent
        Me.ddUnit.BorderColor = System.Drawing.Color.Transparent
        Me.ddUnit.BorderRadius = 9
        Me.ddUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ddUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddUnit.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ddUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ddUnit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ddUnit.ForeColor = System.Drawing.Color.Black
        Me.ddUnit.ItemHeight = 30
        Me.ddUnit.Items.AddRange(New Object() {"Pieces", "Kilograms", "Grams", "Milligrams", "Liters", "Milliliters"})
        Me.ddUnit.Location = New System.Drawing.Point(82, 85)
        Me.ddUnit.Name = "ddUnit"
        Me.ddUnit.Size = New System.Drawing.Size(166, 36)
        Me.ddUnit.TabIndex = 2
        '
        'lblClassification
        '
        Me.lblClassification.BackColor = System.Drawing.Color.Transparent
        Me.lblClassification.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassification.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblClassification.Location = New System.Drawing.Point(16, 29)
        Me.lblClassification.Name = "lblClassification"
        Me.lblClassification.Size = New System.Drawing.Size(143, 41)
        Me.lblClassification.TabIndex = 65
        Me.lblClassification.Text = "Classification:"
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblAmount.Location = New System.Drawing.Point(16, 144)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(143, 41)
        Me.lblAmount.TabIndex = 67
        Me.lblAmount.Text = "Amount:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BorderRadius = 13
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(1169, 786)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 34)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseTransparentBackground = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 13
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(1283, 786)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 34)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseTransparentBackground = True
        '
        'btnImageRecBack
        '
        Me.btnImageRecBack.BackColor = System.Drawing.Color.Transparent
        Me.btnImageRecBack.BorderRadius = 13
        Me.btnImageRecBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImageRecBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnImageRecBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnImageRecBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnImageRecBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnImageRecBack.FillColor = System.Drawing.Color.Transparent
        Me.btnImageRecBack.FocusedColor = System.Drawing.Color.LightSalmon
        Me.btnImageRecBack.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImageRecBack.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnImageRecBack.Image = CType(resources.GetObject("btnImageRecBack.Image"), System.Drawing.Image)
        Me.btnImageRecBack.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnImageRecBack.Location = New System.Drawing.Point(11, 16)
        Me.btnImageRecBack.Name = "btnImageRecBack"
        Me.btnImageRecBack.Size = New System.Drawing.Size(55, 41)
        Me.btnImageRecBack.TabIndex = 63
        Me.btnImageRecBack.UseTransparentBackground = True
        '
        'lblPreview
        '
        Me.lblPreview.BackColor = System.Drawing.Color.Transparent
        Me.lblPreview.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreview.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblPreview.Location = New System.Drawing.Point(365, 16)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(130, 41)
        Me.lblPreview.TabIndex = 65
        Me.lblPreview.Text = "Preview"
        '
        'txtItemName
        '
        Me.txtItemName.BorderRadius = 9
        Me.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemName.DefaultText = ""
        Me.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemName.Location = New System.Drawing.Point(149, 26)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemName.PlaceholderText = ""
        Me.txtItemName.SelectedText = ""
        Me.txtItemName.Size = New System.Drawing.Size(200, 36)
        Me.txtItemName.TabIndex = 66
        '
        'frmImageRecog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1424, 861)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnImageRecBack)
        Me.Controls.Add(Me.PanelDetails)
        Me.Controls.Add(Me.pnlPreview)
        Me.Controls.Add(Me.pnlUpload)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(100, 0)
        Me.Name = "frmImageRecog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.pnlUpload.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPreview.ResumeLayout(False)
        CType(Me.pbShowImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetails.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlUpload As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnUpload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlPreview As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents PanelDetails As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblAmount As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents lblClassification As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents pbShowImage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnImageRecBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDecrease As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnIncrease As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblOr As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents lblDragnDrop As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents ddUnit As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblUnit As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents txtAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPreview As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents lblError As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtItemName As Guna.UI2.WinForms.Guna2TextBox
End Class
