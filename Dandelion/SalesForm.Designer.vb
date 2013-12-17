<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesForm))
        Me.CartGrpBox = New System.Windows.Forms.GroupBox()
        Me.priceListBox = New System.Windows.Forms.ListBox()
        Me.nameLstBox = New System.Windows.Forms.ListBox()
        Me.quanLstBox = New System.Windows.Forms.ListBox()
        Me.BtnCntrlGrpBox = New System.Windows.Forms.GroupBox()
        Me.CatagoryTabCntrl = New System.Windows.Forms.TabControl()
        Me.ColdFoodTabPage = New System.Windows.Forms.TabPage()
        Me.CookedTabPage = New System.Windows.Forms.TabPage()
        Me.BeverageTabPage = New System.Windows.Forms.TabPage()
        Me.AlcoholTabPage = New System.Windows.Forms.TabPage()
        Me.CigarettesTabPage = New System.Windows.Forms.TabPage()
        Me.GasLotteryTabPage = New System.Windows.Forms.TabPage()
        Me.NonFoodTabPage = New System.Windows.Forms.TabPage()
        Me.SalesMnuStrp = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchTxtBox = New System.Windows.Forms.TextBox()
        Me.CartGrpBox.SuspendLayout()
        Me.CatagoryTabCntrl.SuspendLayout()
        Me.SalesMnuStrp.SuspendLayout()
        Me.SuspendLayout()
        '
        'CartGrpBox
        '
        Me.CartGrpBox.Controls.Add(Me.priceListBox)
        Me.CartGrpBox.Controls.Add(Me.nameLstBox)
        Me.CartGrpBox.Controls.Add(Me.quanLstBox)
        Me.CartGrpBox.Controls.Add(Me.BtnCntrlGrpBox)
        Me.CartGrpBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.CartGrpBox.Location = New System.Drawing.Point(1150, 24)
        Me.CartGrpBox.Name = "CartGrpBox"
        Me.CartGrpBox.Size = New System.Drawing.Size(266, 832)
        Me.CartGrpBox.TabIndex = 0
        Me.CartGrpBox.TabStop = False
        Me.CartGrpBox.Text = "Cart"
        '
        'priceListBox
        '
        Me.priceListBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.priceListBox.FormattingEnabled = True
        Me.priceListBox.Location = New System.Drawing.Point(209, 16)
        Me.priceListBox.Name = "priceListBox"
        Me.priceListBox.Size = New System.Drawing.Size(58, 515)
        Me.priceListBox.TabIndex = 6
        '
        'nameLstBox
        '
        Me.nameLstBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.nameLstBox.FormattingEnabled = True
        Me.nameLstBox.Location = New System.Drawing.Point(37, 16)
        Me.nameLstBox.Name = "nameLstBox"
        Me.nameLstBox.Size = New System.Drawing.Size(172, 515)
        Me.nameLstBox.TabIndex = 5
        '
        'quanLstBox
        '
        Me.quanLstBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.quanLstBox.FormattingEnabled = True
        Me.quanLstBox.Location = New System.Drawing.Point(3, 16)
        Me.quanLstBox.Name = "quanLstBox"
        Me.quanLstBox.Size = New System.Drawing.Size(34, 515)
        Me.quanLstBox.TabIndex = 4
        '
        'BtnCntrlGrpBox
        '
        Me.BtnCntrlGrpBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnCntrlGrpBox.Location = New System.Drawing.Point(3, 531)
        Me.BtnCntrlGrpBox.Name = "BtnCntrlGrpBox"
        Me.BtnCntrlGrpBox.Size = New System.Drawing.Size(260, 298)
        Me.BtnCntrlGrpBox.TabIndex = 3
        Me.BtnCntrlGrpBox.TabStop = False
        '
        'CatagoryTabCntrl
        '
        Me.CatagoryTabCntrl.Controls.Add(Me.ColdFoodTabPage)
        Me.CatagoryTabCntrl.Controls.Add(Me.CookedTabPage)
        Me.CatagoryTabCntrl.Controls.Add(Me.BeverageTabPage)
        Me.CatagoryTabCntrl.Controls.Add(Me.AlcoholTabPage)
        Me.CatagoryTabCntrl.Controls.Add(Me.CigarettesTabPage)
        Me.CatagoryTabCntrl.Controls.Add(Me.GasLotteryTabPage)
        Me.CatagoryTabCntrl.Controls.Add(Me.NonFoodTabPage)
        Me.CatagoryTabCntrl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CatagoryTabCntrl.Location = New System.Drawing.Point(0, 24)
        Me.CatagoryTabCntrl.Name = "CatagoryTabCntrl"
        Me.CatagoryTabCntrl.SelectedIndex = 0
        Me.CatagoryTabCntrl.Size = New System.Drawing.Size(1150, 832)
        Me.CatagoryTabCntrl.TabIndex = 1
        Me.CatagoryTabCntrl.TabStop = False
        '
        'ColdFoodTabPage
        '
        Me.ColdFoodTabPage.BackColor = System.Drawing.Color.Transparent
        Me.ColdFoodTabPage.BackgroundImage = Global.Dandelion.My.Resources.Resources.Dandelion_logo_background
        Me.ColdFoodTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ColdFoodTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ColdFoodTabPage.Name = "ColdFoodTabPage"
        Me.ColdFoodTabPage.Size = New System.Drawing.Size(1142, 806)
        Me.ColdFoodTabPage.TabIndex = 3
        Me.ColdFoodTabPage.Text = "Cold Food"
        '
        'CookedTabPage
        '
        Me.CookedTabPage.BackgroundImage = Global.Dandelion.My.Resources.Resources.Dandelion_logo_background
        Me.CookedTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CookedTabPage.Location = New System.Drawing.Point(4, 22)
        Me.CookedTabPage.Name = "CookedTabPage"
        Me.CookedTabPage.Size = New System.Drawing.Size(1142, 806)
        Me.CookedTabPage.TabIndex = 4
        Me.CookedTabPage.Text = "Cooked Food"
        Me.CookedTabPage.UseVisualStyleBackColor = True
        '
        'BeverageTabPage
        '
        Me.BeverageTabPage.BackgroundImage = Global.Dandelion.My.Resources.Resources.Dandelion_logo_background
        Me.BeverageTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BeverageTabPage.Location = New System.Drawing.Point(4, 22)
        Me.BeverageTabPage.Name = "BeverageTabPage"
        Me.BeverageTabPage.Size = New System.Drawing.Size(1142, 806)
        Me.BeverageTabPage.TabIndex = 6
        Me.BeverageTabPage.Text = "Beverage"
        Me.BeverageTabPage.UseVisualStyleBackColor = True
        '
        'AlcoholTabPage
        '
        Me.AlcoholTabPage.BackgroundImage = Global.Dandelion.My.Resources.Resources.Dandelion_logo_background
        Me.AlcoholTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AlcoholTabPage.Location = New System.Drawing.Point(4, 22)
        Me.AlcoholTabPage.Name = "AlcoholTabPage"
        Me.AlcoholTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.AlcoholTabPage.Size = New System.Drawing.Size(1142, 806)
        Me.AlcoholTabPage.TabIndex = 1
        Me.AlcoholTabPage.Text = "Alcohol"
        Me.AlcoholTabPage.UseVisualStyleBackColor = True
        '
        'CigarettesTabPage
        '
        Me.CigarettesTabPage.BackgroundImage = Global.Dandelion.My.Resources.Resources.Dandelion_logo_background
        Me.CigarettesTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CigarettesTabPage.Location = New System.Drawing.Point(4, 22)
        Me.CigarettesTabPage.Name = "CigarettesTabPage"
        Me.CigarettesTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.CigarettesTabPage.Size = New System.Drawing.Size(1142, 806)
        Me.CigarettesTabPage.TabIndex = 0
        Me.CigarettesTabPage.Text = "Cigarettes"
        Me.CigarettesTabPage.UseVisualStyleBackColor = True
        '
        'GasLotteryTabPage
        '
        Me.GasLotteryTabPage.BackgroundImage = Global.Dandelion.My.Resources.Resources.Dandelion_logo_background
        Me.GasLotteryTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GasLotteryTabPage.Location = New System.Drawing.Point(4, 22)
        Me.GasLotteryTabPage.Name = "GasLotteryTabPage"
        Me.GasLotteryTabPage.Size = New System.Drawing.Size(1142, 806)
        Me.GasLotteryTabPage.TabIndex = 5
        Me.GasLotteryTabPage.Text = "Other"
        Me.GasLotteryTabPage.UseVisualStyleBackColor = True
        '
        'NonFoodTabPage
        '
        Me.NonFoodTabPage.BackgroundImage = Global.Dandelion.My.Resources.Resources.Dandelion_logo_background
        Me.NonFoodTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NonFoodTabPage.Location = New System.Drawing.Point(4, 22)
        Me.NonFoodTabPage.Name = "NonFoodTabPage"
        Me.NonFoodTabPage.Size = New System.Drawing.Size(1142, 806)
        Me.NonFoodTabPage.TabIndex = 2
        Me.NonFoodTabPage.Text = "Non-food Products"
        Me.NonFoodTabPage.UseVisualStyleBackColor = True
        '
        'SalesMnuStrp
        '
        Me.SalesMnuStrp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.SalesMnuStrp.Location = New System.Drawing.Point(0, 0)
        Me.SalesMnuStrp.Name = "SalesMnuStrp"
        Me.SalesMnuStrp.Size = New System.Drawing.Size(1416, 24)
        Me.SalesMnuStrp.TabIndex = 2
        Me.SalesMnuStrp.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'SearchTxtBox
        '
        Me.SearchTxtBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.SearchTxtBox.Location = New System.Drawing.Point(995, 24)
        Me.SearchTxtBox.Name = "SearchTxtBox"
        Me.SearchTxtBox.Size = New System.Drawing.Size(155, 20)
        Me.SearchTxtBox.TabIndex = 2
        '
        'SalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1416, 856)
        Me.Controls.Add(Me.SearchTxtBox)
        Me.Controls.Add(Me.CatagoryTabCntrl)
        Me.Controls.Add(Me.CartGrpBox)
        Me.Controls.Add(Me.SalesMnuStrp)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.SalesMnuStrp
        Me.Name = "SalesForm"
        Me.Text = "SalesForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CartGrpBox.ResumeLayout(False)
        Me.CatagoryTabCntrl.ResumeLayout(False)
        Me.SalesMnuStrp.ResumeLayout(False)
        Me.SalesMnuStrp.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents CartGrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents CatagoryTabCntrl As System.Windows.Forms.TabControl
    Friend WithEvents ColdFoodTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CookedTabPage As System.Windows.Forms.TabPage
    Friend WithEvents BeverageTabPage As System.Windows.Forms.TabPage
    Friend WithEvents AlcoholTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CigarettesTabPage As System.Windows.Forms.TabPage
    Friend WithEvents GasLotteryTabPage As System.Windows.Forms.TabPage
    Friend WithEvents NonFoodTabPage As System.Windows.Forms.TabPage
    Friend WithEvents SalesMnuStrp As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnCntrlGrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents SearchTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents priceListBox As System.Windows.Forms.ListBox
    Friend WithEvents nameLstBox As System.Windows.Forms.ListBox
    Friend WithEvents quanLstBox As System.Windows.Forms.ListBox
    'Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
