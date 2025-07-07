<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalorieTracker
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalorieTracker))
        Me.lblCalCounter = New System.Windows.Forms.Label()
        Me.dtpStartingdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblCaloriePercentage = New System.Windows.Forms.Label()
        Me.dtpEndingdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtCalorieGoal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgvCaloriecount = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmbFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.pbxcaloriered = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pbxcalorieyellow = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pbxcaloriegreen = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pbxcaloriewhite = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtcaloriecount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblFoodName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtFoodname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDailyCalorieGoal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.cpbCalorie = New Guna.UI2.WinForms.Guna2RadialGauge()
        Me.btnBackCT = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        CType(Me.dgvCaloriecount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.pbxcaloriered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxcalorieyellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxcaloriegreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxcaloriewhite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCalCounter
        '
        Me.lblCalCounter.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCalCounter.ForeColor = System.Drawing.Color.Black
        Me.lblCalCounter.Location = New System.Drawing.Point(476, 98)
        Me.lblCalCounter.Name = "lblCalCounter"
        Me.lblCalCounter.Size = New System.Drawing.Size(124, 46)
        Me.lblCalCounter.TabIndex = 3
        Me.lblCalCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpStartingdate
        '
        Me.dtpStartingdate.Checked = True
        Me.dtpStartingdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.dtpStartingdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpStartingdate.ForeColor = System.Drawing.Color.GhostWhite
        Me.dtpStartingdate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpStartingdate.Location = New System.Drawing.Point(669, 248)
        Me.dtpStartingdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartingdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartingdate.Name = "dtpStartingdate"
        Me.dtpStartingdate.Size = New System.Drawing.Size(210, 36)
        Me.dtpStartingdate.TabIndex = 68
        Me.dtpStartingdate.Value = New Date(2025, 3, 2, 3, 5, 28, 0)
        '
        'lblCaloriePercentage
        '
        Me.lblCaloriePercentage.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCaloriePercentage.ForeColor = System.Drawing.Color.Black
        Me.lblCaloriePercentage.Location = New System.Drawing.Point(140, 105)
        Me.lblCaloriePercentage.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCaloriePercentage.Name = "lblCaloriePercentage"
        Me.lblCaloriePercentage.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.lblCaloriePercentage.Size = New System.Drawing.Size(165, 64)
        Me.lblCaloriePercentage.TabIndex = 71
        Me.lblCaloriePercentage.Text = "0.00%"
        Me.lblCaloriePercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpEndingdate
        '
        Me.dtpEndingdate.Checked = True
        Me.dtpEndingdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.dtpEndingdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpEndingdate.ForeColor = System.Drawing.Color.GhostWhite
        Me.dtpEndingdate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpEndingdate.Location = New System.Drawing.Point(925, 248)
        Me.dtpEndingdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEndingdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEndingdate.Name = "dtpEndingdate"
        Me.dtpEndingdate.Size = New System.Drawing.Size(210, 36)
        Me.dtpEndingdate.TabIndex = 69
        Me.dtpEndingdate.Value = New Date(2025, 2, 27, 0, 0, 0, 0)
        '
        'txtCalorieGoal
        '
        Me.txtCalorieGoal.BorderColor = System.Drawing.Color.Black
        Me.txtCalorieGoal.BorderRadius = 13
        Me.txtCalorieGoal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCalorieGoal.DefaultText = ""
        Me.txtCalorieGoal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCalorieGoal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCalorieGoal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCalorieGoal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCalorieGoal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCalorieGoal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCalorieGoal.ForeColor = System.Drawing.Color.Black
        Me.txtCalorieGoal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCalorieGoal.Location = New System.Drawing.Point(896, 33)
        Me.txtCalorieGoal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCalorieGoal.Name = "txtCalorieGoal"
        Me.txtCalorieGoal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCalorieGoal.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtCalorieGoal.PlaceholderText = ""
        Me.txtCalorieGoal.SelectedText = ""
        Me.txtCalorieGoal.Size = New System.Drawing.Size(210, 37)
        Me.txtCalorieGoal.TabIndex = 64
        '
        'dgvCaloriecount
        '
        Me.dgvCaloriecount.AllowUserToAddRows = False
        Me.dgvCaloriecount.AllowUserToDeleteRows = False
        Me.dgvCaloriecount.AllowUserToResizeColumns = False
        Me.dgvCaloriecount.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.dgvCaloriecount.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCaloriecount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCaloriecount.ColumnHeadersHeight = 50
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCaloriecount.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCaloriecount.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCaloriecount.Location = New System.Drawing.Point(12, 290)
        Me.dgvCaloriecount.Name = "dgvCaloriecount"
        Me.dgvCaloriecount.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCaloriecount.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCaloriecount.RowHeadersVisible = False
        Me.dgvCaloriecount.RowHeadersWidth = 62
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(172, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(172, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvCaloriecount.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCaloriecount.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvCaloriecount.RowTemplate.Height = 40
        Me.dgvCaloriecount.ShowCellErrors = False
        Me.dgvCaloriecount.ShowCellToolTips = False
        Me.dgvCaloriecount.ShowEditingIcon = False
        Me.dgvCaloriecount.ShowRowErrors = False
        Me.dgvCaloriecount.Size = New System.Drawing.Size(1288, 420)
        Me.dgvCaloriecount.TabIndex = 66
        Me.dgvCaloriecount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.dgvCaloriecount.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCaloriecount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCaloriecount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCaloriecount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCaloriecount.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvCaloriecount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCaloriecount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCaloriecount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCaloriecount.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCaloriecount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCaloriecount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCaloriecount.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvCaloriecount.ThemeStyle.ReadOnly = True
        Me.dgvCaloriecount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.DarkCyan
        Me.dgvCaloriecount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCaloriecount.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCaloriecount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvCaloriecount.ThemeStyle.RowsStyle.Height = 40
        Me.dgvCaloriecount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCaloriecount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cmbFilter
        '
        Me.cmbFilter.BackColor = System.Drawing.Color.Transparent
        Me.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbFilter.ItemHeight = 30
        Me.cmbFilter.Items.AddRange(New Object() {"Today", "Current Week", "Current Month"})
        Me.cmbFilter.Location = New System.Drawing.Point(1147, 248)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(140, 36)
        Me.cmbFilter.TabIndex = 67
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblTo)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblFrom)
        Me.Guna2ShadowPanel1.Controls.Add(Me.pbxcaloriered)
        Me.Guna2ShadowPanel1.Controls.Add(Me.pbxcalorieyellow)
        Me.Guna2ShadowPanel1.Controls.Add(Me.pbxcaloriegreen)
        Me.Guna2ShadowPanel1.Controls.Add(Me.pbxcaloriewhite)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblCalCounter)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtcaloriecount)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblFoodName)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtFoodname)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblDailyCalorieGoal)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnSave)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblCaloriePercentage)
        Me.Guna2ShadowPanel1.Controls.Add(Me.cpbCalorie)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtCalorieGoal)
        Me.Guna2ShadowPanel1.Controls.Add(Me.cmbFilter)
        Me.Guna2ShadowPanel1.Controls.Add(Me.dgvCaloriecount)
        Me.Guna2ShadowPanel1.Controls.Add(Me.dtpEndingdate)
        Me.Guna2ShadowPanel1.Controls.Add(Me.dtpStartingdate)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(55, 63)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 13
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(1316, 727)
        Me.Guna2ShadowPanel1.TabIndex = 69
        '
        'lblTo
        '
        Me.lblTo.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.ForeColor = System.Drawing.Color.Black
        Me.lblTo.Location = New System.Drawing.Point(883, 248)
        Me.lblTo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.lblTo.Size = New System.Drawing.Size(43, 36)
        Me.lblTo.TabIndex = 84
        Me.lblTo.Text = "To"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFrom
        '
        Me.lblFrom.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.ForeColor = System.Drawing.Color.Black
        Me.lblFrom.Location = New System.Drawing.Point(609, 248)
        Me.lblFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.lblFrom.Size = New System.Drawing.Size(56, 36)
        Me.lblFrom.TabIndex = 83
        Me.lblFrom.Text = "From"
        Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxcaloriered
        '
        Me.pbxcaloriered.Image = CType(resources.GetObject("pbxcaloriered.Image"), System.Drawing.Image)
        Me.pbxcaloriered.ImageRotate = 0!
        Me.pbxcaloriered.InitialImage = Nothing
        Me.pbxcaloriered.Location = New System.Drawing.Point(434, 91)
        Me.pbxcaloriered.Name = "pbxcaloriered"
        Me.pbxcaloriered.Size = New System.Drawing.Size(50, 50)
        Me.pbxcaloriered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxcaloriered.TabIndex = 82
        Me.pbxcaloriered.TabStop = False
        '
        'pbxcalorieyellow
        '
        Me.pbxcalorieyellow.Image = CType(resources.GetObject("pbxcalorieyellow.Image"), System.Drawing.Image)
        Me.pbxcalorieyellow.ImageRotate = 0!
        Me.pbxcalorieyellow.InitialImage = Nothing
        Me.pbxcalorieyellow.Location = New System.Drawing.Point(434, 91)
        Me.pbxcalorieyellow.Name = "pbxcalorieyellow"
        Me.pbxcalorieyellow.Size = New System.Drawing.Size(50, 50)
        Me.pbxcalorieyellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxcalorieyellow.TabIndex = 81
        Me.pbxcalorieyellow.TabStop = False
        '
        'pbxcaloriegreen
        '
        Me.pbxcaloriegreen.Image = CType(resources.GetObject("pbxcaloriegreen.Image"), System.Drawing.Image)
        Me.pbxcaloriegreen.ImageRotate = 0!
        Me.pbxcaloriegreen.InitialImage = Nothing
        Me.pbxcaloriegreen.Location = New System.Drawing.Point(434, 91)
        Me.pbxcaloriegreen.Name = "pbxcaloriegreen"
        Me.pbxcaloriegreen.Size = New System.Drawing.Size(50, 50)
        Me.pbxcaloriegreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxcaloriegreen.TabIndex = 80
        Me.pbxcaloriegreen.TabStop = False
        '
        'pbxcaloriewhite
        '
        Me.pbxcaloriewhite.Image = CType(resources.GetObject("pbxcaloriewhite.Image"), System.Drawing.Image)
        Me.pbxcaloriewhite.ImageRotate = 0!
        Me.pbxcaloriewhite.InitialImage = Nothing
        Me.pbxcaloriewhite.Location = New System.Drawing.Point(434, 91)
        Me.pbxcaloriewhite.Name = "pbxcaloriewhite"
        Me.pbxcaloriewhite.Size = New System.Drawing.Size(50, 50)
        Me.pbxcaloriewhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxcaloriewhite.TabIndex = 79
        Me.pbxcaloriewhite.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(760, 147)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(102, 23)
        Me.Guna2HtmlLabel1.TabIndex = 78
        Me.Guna2HtmlLabel1.Text = "Calorie Count"
        '
        'txtcaloriecount
        '
        Me.txtcaloriecount.BorderColor = System.Drawing.Color.Black
        Me.txtcaloriecount.BorderRadius = 13
        Me.txtcaloriecount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcaloriecount.DefaultText = ""
        Me.txtcaloriecount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcaloriecount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcaloriecount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcaloriecount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcaloriecount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcaloriecount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcaloriecount.ForeColor = System.Drawing.Color.Black
        Me.txtcaloriecount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcaloriecount.Location = New System.Drawing.Point(896, 140)
        Me.txtcaloriecount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcaloriecount.Name = "txtcaloriecount"
        Me.txtcaloriecount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcaloriecount.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtcaloriecount.PlaceholderText = ""
        Me.txtcaloriecount.SelectedText = ""
        Me.txtcaloriecount.Size = New System.Drawing.Size(210, 37)
        Me.txtcaloriecount.TabIndex = 77
        '
        'lblFoodName
        '
        Me.lblFoodName.BackColor = System.Drawing.Color.Transparent
        Me.lblFoodName.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFoodName.Location = New System.Drawing.Point(760, 91)
        Me.lblFoodName.Name = "lblFoodName"
        Me.lblFoodName.Size = New System.Drawing.Size(88, 23)
        Me.lblFoodName.TabIndex = 76
        Me.lblFoodName.Text = "Food Name"
        '
        'txtFoodname
        '
        Me.txtFoodname.BorderColor = System.Drawing.Color.Black
        Me.txtFoodname.BorderRadius = 13
        Me.txtFoodname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFoodname.DefaultText = ""
        Me.txtFoodname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFoodname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFoodname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFoodname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFoodname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFoodname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFoodname.ForeColor = System.Drawing.Color.Black
        Me.txtFoodname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFoodname.Location = New System.Drawing.Point(896, 85)
        Me.txtFoodname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFoodname.Name = "txtFoodname"
        Me.txtFoodname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFoodname.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtFoodname.PlaceholderText = ""
        Me.txtFoodname.SelectedText = ""
        Me.txtFoodname.Size = New System.Drawing.Size(210, 37)
        Me.txtFoodname.TabIndex = 75
        '
        'lblDailyCalorieGoal
        '
        Me.lblDailyCalorieGoal.BackColor = System.Drawing.Color.Transparent
        Me.lblDailyCalorieGoal.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDailyCalorieGoal.Location = New System.Drawing.Point(760, 39)
        Me.lblDailyCalorieGoal.Name = "lblDailyCalorieGoal"
        Me.lblDailyCalorieGoal.Size = New System.Drawing.Size(130, 23)
        Me.lblDailyCalorieGoal.TabIndex = 74
        Me.lblDailyCalorieGoal.Text = "Daily Calorie Goal"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 13
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.Teal
        Me.btnSave.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnSave.Location = New System.Drawing.Point(1046, 185)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 54)
        Me.btnSave.TabIndex = 72
        Me.btnSave.UseTransparentBackground = True
        '
        'cpbCalorie
        '
        Me.cpbCalorie.ArrowColor = System.Drawing.Color.Transparent
        Me.cpbCalorie.Font = New System.Drawing.Font("Verdana", 8.2!)
        Me.cpbCalorie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.cpbCalorie.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cpbCalorie.Location = New System.Drawing.Point(86, 6)
        Me.cpbCalorie.MinimumSize = New System.Drawing.Size(30, 30)
        Me.cpbCalorie.Name = "cpbCalorie"
        Me.cpbCalorie.ProgressColor = System.Drawing.Color.Transparent
        Me.cpbCalorie.ProgressColor2 = System.Drawing.Color.Transparent
        Me.cpbCalorie.ProgressThickness = 30
        Me.cpbCalorie.ShowPercentage = False
        Me.cpbCalorie.Size = New System.Drawing.Size(275, 275)
        Me.cpbCalorie.TabIndex = 71
        '
        'btnBackCT
        '
        Me.btnBackCT.BackColor = System.Drawing.Color.Transparent
        Me.btnBackCT.BorderRadius = 13
        Me.btnBackCT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackCT.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBackCT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBackCT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBackCT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBackCT.FillColor = System.Drawing.Color.Transparent
        Me.btnBackCT.FocusedColor = System.Drawing.Color.LightSalmon
        Me.btnBackCT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnBackCT.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnBackCT.Image = CType(resources.GetObject("btnBackCT.Image"), System.Drawing.Image)
        Me.btnBackCT.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnBackCT.Location = New System.Drawing.Point(12, 15)
        Me.btnBackCT.Name = "btnBackCT"
        Me.btnBackCT.PressedColor = System.Drawing.Color.Transparent
        Me.btnBackCT.Size = New System.Drawing.Size(48, 42)
        Me.btnBackCT.TabIndex = 70
        Me.btnBackCT.UseTransparentBackground = True
        '
        'frmCalorieTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1411, 715)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBackCT)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCalorieTracker"
        Me.Text = "frmCalorieTracker"
        CType(Me.dgvCaloriecount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.pbxcaloriered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxcalorieyellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxcaloriegreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxcaloriewhite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCalCounter As Label
    Friend WithEvents dtpStartingdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpEndingdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtCalorieGoal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvCaloriecount As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmbFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents lblCaloriePercentage As Label
    Friend WithEvents cpbCalorie As Guna.UI2.WinForms.Guna2RadialGauge
    Friend WithEvents btnBackCT As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblDailyCalorieGoal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblFoodName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtFoodname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtcaloriecount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pbxcaloriewhite As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pbxcaloriered As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pbxcalorieyellow As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pbxcaloriegreen As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
End Class
