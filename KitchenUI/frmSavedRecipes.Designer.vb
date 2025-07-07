<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSavedRecipes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSavedRecipes))
        Me.lblVescor = New ReaLTaiizor.Controls.BigLabel()
        Me.PnlDishTitle = New Guna.UI2.WinForms.Guna2Panel()
        Me.PnlDishIngredients = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtRecipe = New System.Windows.Forms.RichTextBox()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSaveRecipe = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteRecipe = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditRecipe = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PnlDishIngredients.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVescor
        '
        Me.lblVescor.AutoSize = True
        Me.lblVescor.BackColor = System.Drawing.Color.Transparent
        Me.lblVescor.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVescor.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblVescor.Location = New System.Drawing.Point(65, 21)
        Me.lblVescor.Name = "lblVescor"
        Me.lblVescor.Size = New System.Drawing.Size(235, 45)
        Me.lblVescor.TabIndex = 48
        Me.lblVescor.Text = "Saved Recipes"
        '
        'PnlDishTitle
        '
        Me.PnlDishTitle.AutoScroll = True
        Me.PnlDishTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.PnlDishTitle.BorderColor = System.Drawing.Color.Transparent
        Me.PnlDishTitle.BorderThickness = 2
        Me.PnlDishTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlDishTitle.Location = New System.Drawing.Point(57, 87)
        Me.PnlDishTitle.Name = "PnlDishTitle"
        Me.PnlDishTitle.Size = New System.Drawing.Size(275, 754)
        Me.PnlDishTitle.TabIndex = 49
        '
        'PnlDishIngredients
        '
        Me.PnlDishIngredients.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.PnlDishIngredients.BorderColor = System.Drawing.Color.Transparent
        Me.PnlDishIngredients.BorderThickness = 2
        Me.PnlDishIngredients.Controls.Add(Me.txtRecipe)
        Me.PnlDishIngredients.ForeColor = System.Drawing.Color.Transparent
        Me.PnlDishIngredients.Location = New System.Drawing.Point(338, 87)
        Me.PnlDishIngredients.Name = "PnlDishIngredients"
        Me.PnlDishIngredients.Size = New System.Drawing.Size(1022, 754)
        Me.PnlDishIngredients.TabIndex = 50
        '
        'txtRecipe
        '
        Me.txtRecipe.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.txtRecipe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRecipe.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecipe.Location = New System.Drawing.Point(0, 0)
        Me.txtRecipe.Name = "txtRecipe"
        Me.txtRecipe.ReadOnly = True
        Me.txtRecipe.ShortcutsEnabled = False
        Me.txtRecipe.Size = New System.Drawing.Size(1022, 754)
        Me.txtRecipe.TabIndex = 1
        Me.txtRecipe.Text = ""
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
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnBack.Location = New System.Drawing.Point(12, 21)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(47, 45)
        Me.btnBack.TabIndex = 64
        Me.btnBack.UseTransparentBackground = True
        '
        'btnSaveRecipe
        '
        Me.btnSaveRecipe.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveRecipe.BorderRadius = 13
        Me.btnSaveRecipe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveRecipe.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSaveRecipe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSaveRecipe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSaveRecipe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSaveRecipe.FillColor = System.Drawing.Color.Teal
        Me.btnSaveRecipe.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveRecipe.ForeColor = System.Drawing.Color.White
        Me.btnSaveRecipe.Image = CType(resources.GetObject("btnSaveRecipe.Image"), System.Drawing.Image)
        Me.btnSaveRecipe.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnSaveRecipe.Location = New System.Drawing.Point(577, 21)
        Me.btnSaveRecipe.Name = "btnSaveRecipe"
        Me.btnSaveRecipe.Size = New System.Drawing.Size(60, 54)
        Me.btnSaveRecipe.TabIndex = 65
        Me.btnSaveRecipe.UseTransparentBackground = True
        '
        'btnDeleteRecipe
        '
        Me.btnDeleteRecipe.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteRecipe.BorderRadius = 13
        Me.btnDeleteRecipe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteRecipe.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteRecipe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteRecipe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteRecipe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeleteRecipe.FillColor = System.Drawing.Color.Teal
        Me.btnDeleteRecipe.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRecipe.ForeColor = System.Drawing.Color.White
        Me.btnDeleteRecipe.Image = CType(resources.GetObject("btnDeleteRecipe.Image"), System.Drawing.Image)
        Me.btnDeleteRecipe.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btnDeleteRecipe.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDeleteRecipe.Location = New System.Drawing.Point(709, 21)
        Me.btnDeleteRecipe.Name = "btnDeleteRecipe"
        Me.btnDeleteRecipe.Size = New System.Drawing.Size(60, 54)
        Me.btnDeleteRecipe.TabIndex = 66
        Me.btnDeleteRecipe.UseTransparentBackground = True
        '
        'btnEditRecipe
        '
        Me.btnEditRecipe.BackColor = System.Drawing.Color.Transparent
        Me.btnEditRecipe.BorderRadius = 13
        Me.btnEditRecipe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditRecipe.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditRecipe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditRecipe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditRecipe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditRecipe.FillColor = System.Drawing.Color.Teal
        Me.btnEditRecipe.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRecipe.ForeColor = System.Drawing.Color.White
        Me.btnEditRecipe.Image = CType(resources.GetObject("btnEditRecipe.Image"), System.Drawing.Image)
        Me.btnEditRecipe.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnEditRecipe.Location = New System.Drawing.Point(643, 21)
        Me.btnEditRecipe.Name = "btnEditRecipe"
        Me.btnEditRecipe.Size = New System.Drawing.Size(60, 54)
        Me.btnEditRecipe.TabIndex = 67
        Me.btnEditRecipe.UseTransparentBackground = True
        '
        'txtSearch
        '
        Me.txtSearch.BorderRadius = 13
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(338, 21)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtSearch.PlaceholderText = "Search Recipe"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(233, 54)
        Me.txtSearch.TabIndex = 68
        '
        'frmSavedRecipes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1424, 861)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnDeleteRecipe)
        Me.Controls.Add(Me.btnEditRecipe)
        Me.Controls.Add(Me.btnSaveRecipe)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PnlDishIngredients)
        Me.Controls.Add(Me.PnlDishTitle)
        Me.Controls.Add(Me.lblVescor)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSavedRecipes"
        Me.Text = "frmSavedRecipes"
        Me.PnlDishIngredients.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVescor As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents PnlDishTitle As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlDishIngredients As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSaveRecipe As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeleteRecipe As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditRecipe As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtRecipe As RichTextBox
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
End Class
