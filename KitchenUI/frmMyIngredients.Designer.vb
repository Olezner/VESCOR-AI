<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMyIngredients
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMyIngredients))
        Me.dgMyIngredients = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbboxunits = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblItemName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btndeleteingredient = New Guna.UI2.WinForms.Guna2Button()
        Me.lblIngredients = New ReaLTaiizor.Controls.BigLabel()
        Me.lblUnit = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblQuantity = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnaddingredient = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdateIngredient = New Guna.UI2.WinForms.Guna2Button()
        Me.lblfillallfield = New System.Windows.Forms.Label()
        Me.txtsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblsearch = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pbIngredientsLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.gbinventory = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUploadImage = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgMyIngredients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIngredientsLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbinventory.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgMyIngredients
        '
        Me.dgMyIngredients.AllowUserToAddRows = False
        Me.dgMyIngredients.AllowUserToDeleteRows = False
        Me.dgMyIngredients.AllowUserToOrderColumns = True
        Me.dgMyIngredients.AllowUserToResizeColumns = False
        Me.dgMyIngredients.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgMyIngredients.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMyIngredients.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.dgMyIngredients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMyIngredients.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgMyIngredients.ColumnHeadersHeight = 50
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgMyIngredients.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgMyIngredients.GridColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dgMyIngredients.Location = New System.Drawing.Point(499, 0)
        Me.dgMyIngredients.Name = "dgMyIngredients"
        Me.dgMyIngredients.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMyIngredients.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgMyIngredients.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.dgMyIngredients.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgMyIngredients.RowTemplate.Height = 50
        Me.dgMyIngredients.ShowCellToolTips = False
        Me.dgMyIngredients.Size = New System.Drawing.Size(930, 861)
        Me.dgMyIngredients.TabIndex = 2
        Me.dgMyIngredients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgMyIngredients.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgMyIngredients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgMyIngredients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgMyIngredients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgMyIngredients.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.dgMyIngredients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dgMyIngredients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgMyIngredients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgMyIngredients.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMyIngredients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgMyIngredients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMyIngredients.ThemeStyle.HeaderStyle.Height = 50
        Me.dgMyIngredients.ThemeStyle.ReadOnly = True
        Me.dgMyIngredients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgMyIngredients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgMyIngredients.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMyIngredients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgMyIngredients.ThemeStyle.RowsStyle.Height = 50
        Me.dgMyIngredients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgMyIngredients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderRadius = 8
        Me.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuantity.DefaultText = ""
        Me.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.Location = New System.Drawing.Point(135, 415)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantity.PlaceholderText = "e.g. 800"
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.Size = New System.Drawing.Size(216, 36)
        Me.txtQuantity.TabIndex = 3
        '
        'cmbboxunits
        '
        Me.cmbboxunits.BackColor = System.Drawing.Color.Transparent
        Me.cmbboxunits.BorderRadius = 8
        Me.cmbboxunits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbboxunits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxunits.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbboxunits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbboxunits.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbboxunits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbboxunits.ItemHeight = 30
        Me.cmbboxunits.Items.AddRange(New Object() {"Pieces", "Kilograms", "Grams", "Milligrams", "Liters", "Milliliters"})
        Me.cmbboxunits.Location = New System.Drawing.Point(135, 489)
        Me.cmbboxunits.Name = "cmbboxunits"
        Me.cmbboxunits.Size = New System.Drawing.Size(216, 36)
        Me.cmbboxunits.TabIndex = 4
        '
        'txtItemName
        '
        Me.txtItemName.BorderRadius = 8
        Me.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemName.DefaultText = ""
        Me.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemName.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemName.Location = New System.Drawing.Point(135, 341)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemName.PlaceholderText = "e.g. Carrot"
        Me.txtItemName.SelectedText = ""
        Me.txtItemName.Size = New System.Drawing.Size(216, 36)
        Me.txtItemName.TabIndex = 2
        '
        'lblItemName
        '
        Me.lblItemName.BackColor = System.Drawing.Color.Transparent
        Me.lblItemName.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!)
        Me.lblItemName.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblItemName.Location = New System.Drawing.Point(135, 312)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(100, 27)
        Me.lblItemName.TabIndex = 7
        Me.lblItemName.Text = "Item Name"
        '
        'btndeleteingredient
        '
        Me.btndeleteingredient.BorderRadius = 13
        Me.btndeleteingredient.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btndeleteingredient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btndeleteingredient.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btndeleteingredient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btndeleteingredient.FillColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btndeleteingredient.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeleteingredient.ForeColor = System.Drawing.Color.White
        Me.btndeleteingredient.Location = New System.Drawing.Point(135, 709)
        Me.btndeleteingredient.Name = "btndeleteingredient"
        Me.btndeleteingredient.Size = New System.Drawing.Size(207, 45)
        Me.btndeleteingredient.TabIndex = 7
        Me.btndeleteingredient.Text = "Delete"
        '
        'lblIngredients
        '
        Me.lblIngredients.BackColor = System.Drawing.Color.Transparent
        Me.lblIngredients.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngredients.ForeColor = System.Drawing.Color.Honeydew
        Me.lblIngredients.Location = New System.Drawing.Point(104, 117)
        Me.lblIngredients.Name = "lblIngredients"
        Me.lblIngredients.Size = New System.Drawing.Size(282, 82)
        Me.lblIngredients.TabIndex = 47
        Me.lblIngredients.Text = "Ingredients"
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.Transparent
        Me.lblUnit.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!)
        Me.lblUnit.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblUnit.Location = New System.Drawing.Point(133, 459)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(59, 27)
        Me.lblUnit.TabIndex = 48
        Me.lblUnit.Text = "Unit(s)"
        '
        'lblQuantity
        '
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!)
        Me.lblQuantity.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblQuantity.Location = New System.Drawing.Point(135, 386)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(78, 27)
        Me.lblQuantity.TabIndex = 49
        Me.lblQuantity.Text = "Quantity"
        '
        'btnaddingredient
        '
        Me.btnaddingredient.BorderRadius = 13
        Me.btnaddingredient.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnaddingredient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnaddingredient.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnaddingredient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnaddingredient.FillColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnaddingredient.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddingredient.ForeColor = System.Drawing.Color.White
        Me.btnaddingredient.Location = New System.Drawing.Point(135, 571)
        Me.btnaddingredient.Name = "btnaddingredient"
        Me.btnaddingredient.Size = New System.Drawing.Size(207, 45)
        Me.btnaddingredient.TabIndex = 5
        Me.btnaddingredient.Text = "Add"
        '
        'btnUpdateIngredient
        '
        Me.btnUpdateIngredient.BorderRadius = 13
        Me.btnUpdateIngredient.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateIngredient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateIngredient.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateIngredient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateIngredient.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnUpdateIngredient.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateIngredient.ForeColor = System.Drawing.Color.White
        Me.btnUpdateIngredient.Location = New System.Drawing.Point(135, 640)
        Me.btnUpdateIngredient.Name = "btnUpdateIngredient"
        Me.btnUpdateIngredient.Size = New System.Drawing.Size(207, 45)
        Me.btnUpdateIngredient.TabIndex = 6
        Me.btnUpdateIngredient.Text = "Update"
        '
        'lblfillallfield
        '
        Me.lblfillallfield.BackColor = System.Drawing.Color.Transparent
        Me.lblfillallfield.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfillallfield.ForeColor = System.Drawing.Color.Red
        Me.lblfillallfield.Location = New System.Drawing.Point(144, 529)
        Me.lblfillallfield.Name = "lblfillallfield"
        Me.lblfillallfield.Size = New System.Drawing.Size(110, 17)
        Me.lblfillallfield.TabIndex = 52
        Me.lblfillallfield.Text = "Please fill all fields"
        Me.lblfillallfield.Visible = False
        '
        'txtsearch
        '
        Me.txtsearch.BorderRadius = 8
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.DefaultText = ""
        Me.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.Location = New System.Drawing.Point(135, 229)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.PlaceholderText = "e.g. Beef"
        Me.txtsearch.SelectedText = ""
        Me.txtsearch.Size = New System.Drawing.Size(216, 36)
        Me.txtsearch.TabIndex = 1
        '
        'lblsearch
        '
        Me.lblsearch.BackColor = System.Drawing.Color.Transparent
        Me.lblsearch.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!)
        Me.lblsearch.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblsearch.Location = New System.Drawing.Point(134, 200)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(60, 27)
        Me.lblsearch.TabIndex = 54
        Me.lblsearch.Text = "Search"
        '
        'pbIngredientsLogo
        '
        Me.pbIngredientsLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbIngredientsLogo.FillColor = System.Drawing.Color.Transparent
        Me.pbIngredientsLogo.Image = CType(resources.GetObject("pbIngredientsLogo.Image"), System.Drawing.Image)
        Me.pbIngredientsLogo.ImageRotate = 0!
        Me.pbIngredientsLogo.Location = New System.Drawing.Point(193, 10)
        Me.pbIngredientsLogo.Name = "pbIngredientsLogo"
        Me.pbIngredientsLogo.Size = New System.Drawing.Size(107, 104)
        Me.pbIngredientsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbIngredientsLogo.TabIndex = 57
        Me.pbIngredientsLogo.TabStop = False
        Me.pbIngredientsLogo.UseTransparentBackground = True
        '
        'gbinventory
        '
        Me.gbinventory.BackColor = System.Drawing.Color.Transparent
        Me.gbinventory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gbinventory.BorderRadius = 13
        Me.gbinventory.BorderThickness = 2
        Me.gbinventory.Controls.Add(Me.btnBack)
        Me.gbinventory.Controls.Add(Me.btnUploadImage)
        Me.gbinventory.Controls.Add(Me.pbIngredientsLogo)
        Me.gbinventory.Controls.Add(Me.lblIngredients)
        Me.gbinventory.Controls.Add(Me.lblsearch)
        Me.gbinventory.Controls.Add(Me.txtQuantity)
        Me.gbinventory.Controls.Add(Me.txtsearch)
        Me.gbinventory.Controls.Add(Me.cmbboxunits)
        Me.gbinventory.Controls.Add(Me.lblfillallfield)
        Me.gbinventory.Controls.Add(Me.txtItemName)
        Me.gbinventory.Controls.Add(Me.btnUpdateIngredient)
        Me.gbinventory.Controls.Add(Me.lblItemName)
        Me.gbinventory.Controls.Add(Me.btnaddingredient)
        Me.gbinventory.Controls.Add(Me.btndeleteingredient)
        Me.gbinventory.Controls.Add(Me.lblQuantity)
        Me.gbinventory.Controls.Add(Me.lblUnit)
        Me.gbinventory.CustomBorderColor = System.Drawing.Color.Empty
        Me.gbinventory.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.gbinventory.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.gbinventory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gbinventory.ForeColor = System.Drawing.Color.Transparent
        Me.gbinventory.Location = New System.Drawing.Point(12, 12)
        Me.gbinventory.Name = "gbinventory"
        Me.gbinventory.Size = New System.Drawing.Size(471, 837)
        Me.gbinventory.TabIndex = 58
        Me.gbinventory.UseTransparentBackground = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BorderRadius = 13
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBack.FillColor = System.Drawing.Color.Transparent
        Me.btnBack.FocusedColor = System.Drawing.Color.LightSalmon
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnBack.Location = New System.Drawing.Point(17, 25)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.PressedColor = System.Drawing.Color.Transparent
        Me.btnBack.Size = New System.Drawing.Size(48, 42)
        Me.btnBack.TabIndex = 59
        Me.btnBack.UseTransparentBackground = True
        '
        'btnUploadImage
        '
        Me.btnUploadImage.BorderRadius = 13
        Me.btnUploadImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUploadImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUploadImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUploadImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUploadImage.FillColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnUploadImage.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadImage.ForeColor = System.Drawing.Color.White
        Me.btnUploadImage.Image = CType(resources.GetObject("btnUploadImage.Image"), System.Drawing.Image)
        Me.btnUploadImage.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnUploadImage.Location = New System.Drawing.Point(348, 571)
        Me.btnUploadImage.Name = "btnUploadImage"
        Me.btnUploadImage.Size = New System.Drawing.Size(65, 45)
        Me.btnUploadImage.TabIndex = 59
        '
        'frmMyIngredients
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1424, 861)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgMyIngredients)
        Me.Controls.Add(Me.gbinventory)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMyIngredients"
        Me.Text = "frmMyIngredients"
        CType(Me.dgMyIngredients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIngredientsLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbinventory.ResumeLayout(False)
        Me.gbinventory.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgMyIngredients As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbboxunits As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblItemName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btndeleteingredient As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblIngredients As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents lblUnit As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblQuantity As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnaddingredient As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdateIngredient As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblfillallfield As Label
    Friend WithEvents txtsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblsearch As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pbIngredientsLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents gbinventory As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnUploadImage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
End Class
