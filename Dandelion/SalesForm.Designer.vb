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
        Me.CartLstBox = New System.Windows.Forms.ListBox()
        Me.PriceLstBox = New System.Windows.Forms.ListBox()
        Me.CartCtrlBox = New System.Windows.Forms.GroupBox()
        Me.CnclBtn = New System.Windows.Forms.Button()
        Me.ClrBtn = New System.Windows.Forms.Button()
        Me.RemBtn = New System.Windows.Forms.Button()
        Me.DecBtn = New System.Windows.Forms.Button()
        Me.IncrBtn = New System.Windows.Forms.Button()
        Me.ChkoutCtrlBox = New System.Windows.Forms.GroupBox()
        Me.CheckOutBtn = New System.Windows.Forms.Button()
        Me.TBlankLbl = New System.Windows.Forms.Label()
        Me.STBlankLbl = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.SubTotalLbl = New System.Windows.Forms.Label()
        Me.SearchTxtBox = New System.Windows.Forms.TextBox()
        Me.CatBox = New System.Windows.Forms.GroupBox()
        Me.BoxMngrCtrl = New System.Windows.Forms.GroupBox()
        Me.BtnAlerts = New System.Windows.Forms.Button()
        Me.BtnEditInv = New System.Windows.Forms.Button()
        Me.BoxOuterBtnGrp = New System.Windows.Forms.GroupBox()
        Me.BtnSupply = New System.Windows.Forms.Button()
        Me.CigBtn = New System.Windows.Forms.Button()
        Me.AlcoholBtn = New System.Windows.Forms.Button()
        Me.BeverageBtn = New System.Windows.Forms.Button()
        Me.HotBtn = New System.Windows.Forms.Button()
        Me.ColdBtn = New System.Windows.Forms.Button()
        Me.BtnSnack = New System.Windows.Forms.Button()
        Me.BtnCandy = New System.Windows.Forms.Button()
        Me.BtnOther = New System.Windows.Forms.Button()
        Me.CartGrpBox.SuspendLayout()
        Me.CartCtrlBox.SuspendLayout()
        Me.ChkoutCtrlBox.SuspendLayout()
        Me.CatBox.SuspendLayout()
        Me.BoxMngrCtrl.SuspendLayout()
        Me.SuspendLayout()
        '
        'CartGrpBox
        '
        Me.CartGrpBox.Controls.Add(Me.CartLstBox)
        Me.CartGrpBox.Controls.Add(Me.PriceLstBox)
        Me.CartGrpBox.Controls.Add(Me.CartCtrlBox)
        Me.CartGrpBox.Controls.Add(Me.ChkoutCtrlBox)
        Me.CartGrpBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.CartGrpBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CartGrpBox.Location = New System.Drawing.Point(845, 0)
        Me.CartGrpBox.Name = "CartGrpBox"
        Me.CartGrpBox.Size = New System.Drawing.Size(442, 865)
        Me.CartGrpBox.TabIndex = 0
        Me.CartGrpBox.TabStop = False
        '
        'CartLstBox
        '
        Me.CartLstBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CartLstBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CartLstBox.FormattingEnabled = True
        Me.CartLstBox.ItemHeight = 24
        Me.CartLstBox.Location = New System.Drawing.Point(115, 25)
        Me.CartLstBox.MultiColumn = True
        Me.CartLstBox.Name = "CartLstBox"
        Me.CartLstBox.Size = New System.Drawing.Size(235, 692)
        Me.CartLstBox.TabIndex = 5
        '
        'PriceLstBox
        '
        Me.PriceLstBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.PriceLstBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLstBox.FormattingEnabled = True
        Me.PriceLstBox.ItemHeight = 24
        Me.PriceLstBox.Location = New System.Drawing.Point(350, 25)
        Me.PriceLstBox.Name = "PriceLstBox"
        Me.PriceLstBox.Size = New System.Drawing.Size(89, 692)
        Me.PriceLstBox.TabIndex = 7
        '
        'CartCtrlBox
        '
        Me.CartCtrlBox.Controls.Add(Me.CnclBtn)
        Me.CartCtrlBox.Controls.Add(Me.ClrBtn)
        Me.CartCtrlBox.Controls.Add(Me.RemBtn)
        Me.CartCtrlBox.Controls.Add(Me.DecBtn)
        Me.CartCtrlBox.Controls.Add(Me.IncrBtn)
        Me.CartCtrlBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.CartCtrlBox.Enabled = False
        Me.CartCtrlBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CartCtrlBox.Location = New System.Drawing.Point(3, 25)
        Me.CartCtrlBox.Name = "CartCtrlBox"
        Me.CartCtrlBox.Size = New System.Drawing.Size(112, 692)
        Me.CartCtrlBox.TabIndex = 6
        Me.CartCtrlBox.TabStop = False
        '
        'CnclBtn
        '
        Me.CnclBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.CnclBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CnclBtn.Location = New System.Drawing.Point(3, 341)
        Me.CnclBtn.Name = "CnclBtn"
        Me.CnclBtn.Size = New System.Drawing.Size(106, 79)
        Me.CnclBtn.TabIndex = 4
        Me.CnclBtn.Text = "Exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cart Edit"
        Me.CnclBtn.UseVisualStyleBackColor = True
        Me.CnclBtn.Visible = False
        '
        'ClrBtn
        '
        Me.ClrBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ClrBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClrBtn.Location = New System.Drawing.Point(3, 262)
        Me.ClrBtn.Name = "ClrBtn"
        Me.ClrBtn.Size = New System.Drawing.Size(106, 79)
        Me.ClrBtn.TabIndex = 3
        Me.ClrBtn.Text = "Clear Cart"
        Me.ClrBtn.UseVisualStyleBackColor = True
        '
        'RemBtn
        '
        Me.RemBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.RemBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemBtn.Location = New System.Drawing.Point(3, 183)
        Me.RemBtn.Name = "RemBtn"
        Me.RemBtn.Size = New System.Drawing.Size(106, 79)
        Me.RemBtn.TabIndex = 2
        Me.RemBtn.Text = "Remove"
        Me.RemBtn.UseVisualStyleBackColor = True
        '
        'DecBtn
        '
        Me.DecBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.DecBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecBtn.Location = New System.Drawing.Point(3, 104)
        Me.DecBtn.Name = "DecBtn"
        Me.DecBtn.Size = New System.Drawing.Size(106, 79)
        Me.DecBtn.TabIndex = 1
        Me.DecBtn.Text = "Decrease"
        Me.DecBtn.UseVisualStyleBackColor = True
        '
        'IncrBtn
        '
        Me.IncrBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.IncrBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncrBtn.Location = New System.Drawing.Point(3, 25)
        Me.IncrBtn.Name = "IncrBtn"
        Me.IncrBtn.Size = New System.Drawing.Size(106, 79)
        Me.IncrBtn.TabIndex = 0
        Me.IncrBtn.Text = "Increase"
        Me.IncrBtn.UseVisualStyleBackColor = True
        '
        'ChkoutCtrlBox
        '
        Me.ChkoutCtrlBox.Controls.Add(Me.CheckOutBtn)
        Me.ChkoutCtrlBox.Controls.Add(Me.TBlankLbl)
        Me.ChkoutCtrlBox.Controls.Add(Me.STBlankLbl)
        Me.ChkoutCtrlBox.Controls.Add(Me.TotalLabel)
        Me.ChkoutCtrlBox.Controls.Add(Me.SubTotalLbl)
        Me.ChkoutCtrlBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ChkoutCtrlBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkoutCtrlBox.Location = New System.Drawing.Point(3, 717)
        Me.ChkoutCtrlBox.Name = "ChkoutCtrlBox"
        Me.ChkoutCtrlBox.Size = New System.Drawing.Size(436, 145)
        Me.ChkoutCtrlBox.TabIndex = 3
        Me.ChkoutCtrlBox.TabStop = False
        '
        'CheckOutBtn
        '
        Me.CheckOutBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CheckOutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOutBtn.Location = New System.Drawing.Point(3, 63)
        Me.CheckOutBtn.Name = "CheckOutBtn"
        Me.CheckOutBtn.Size = New System.Drawing.Size(430, 79)
        Me.CheckOutBtn.TabIndex = 4
        Me.CheckOutBtn.Text = "Proceed to Checkout"
        Me.CheckOutBtn.UseVisualStyleBackColor = True
        '
        'TBlankLbl
        '
        Me.TBlankLbl.AutoSize = True
        Me.TBlankLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBlankLbl.Location = New System.Drawing.Point(326, 16)
        Me.TBlankLbl.Name = "TBlankLbl"
        Me.TBlankLbl.Size = New System.Drawing.Size(66, 24)
        Me.TBlankLbl.TabIndex = 3
        Me.TBlankLbl.Text = "Label4"
        '
        'STBlankLbl
        '
        Me.STBlankLbl.AutoSize = True
        Me.STBlankLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STBlankLbl.Location = New System.Drawing.Point(102, 16)
        Me.STBlankLbl.Name = "STBlankLbl"
        Me.STBlankLbl.Size = New System.Drawing.Size(66, 24)
        Me.STBlankLbl.TabIndex = 2
        Me.STBlankLbl.Text = "Label3"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(232, 16)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(56, 24)
        Me.TotalLabel.TabIndex = 1
        Me.TotalLabel.Text = "Total:"
        '
        'SubTotalLbl
        '
        Me.SubTotalLbl.AutoSize = True
        Me.SubTotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalLbl.Location = New System.Drawing.Point(6, 16)
        Me.SubTotalLbl.Name = "SubTotalLbl"
        Me.SubTotalLbl.Size = New System.Drawing.Size(82, 24)
        Me.SubTotalLbl.TabIndex = 0
        Me.SubTotalLbl.Text = "Subtotal:"
        '
        'SearchTxtBox
        '
        Me.SearchTxtBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTxtBox.Location = New System.Drawing.Point(3, 25)
        Me.SearchTxtBox.Name = "SearchTxtBox"
        Me.SearchTxtBox.Size = New System.Drawing.Size(106, 29)
        Me.SearchTxtBox.TabIndex = 1
        '
        'CatBox
        '
        Me.CatBox.Controls.Add(Me.BtnOther)
        Me.CatBox.Controls.Add(Me.BtnSupply)
        Me.CatBox.Controls.Add(Me.CigBtn)
        Me.CatBox.Controls.Add(Me.AlcoholBtn)
        Me.CatBox.Controls.Add(Me.BeverageBtn)
        Me.CatBox.Controls.Add(Me.HotBtn)
        Me.CatBox.Controls.Add(Me.ColdBtn)
        Me.CatBox.Controls.Add(Me.BtnSnack)
        Me.CatBox.Controls.Add(Me.BtnCandy)
        Me.CatBox.Controls.Add(Me.SearchTxtBox)
        Me.CatBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.CatBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CatBox.Location = New System.Drawing.Point(0, 107)
        Me.CatBox.Name = "CatBox"
        Me.CatBox.Size = New System.Drawing.Size(112, 758)
        Me.CatBox.TabIndex = 3
        Me.CatBox.TabStop = False
        '
        'BoxMngrCtrl
        '
        Me.BoxMngrCtrl.Controls.Add(Me.BtnAlerts)
        Me.BoxMngrCtrl.Controls.Add(Me.BtnEditInv)
        Me.BoxMngrCtrl.Dock = System.Windows.Forms.DockStyle.Top
        Me.BoxMngrCtrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxMngrCtrl.Location = New System.Drawing.Point(0, 0)
        Me.BoxMngrCtrl.Name = "BoxMngrCtrl"
        Me.BoxMngrCtrl.Size = New System.Drawing.Size(845, 107)
        Me.BoxMngrCtrl.TabIndex = 8
        Me.BoxMngrCtrl.TabStop = False
        '
        'BtnAlerts
        '
        Me.BtnAlerts.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnAlerts.Location = New System.Drawing.Point(109, 25)
        Me.BtnAlerts.Name = "BtnAlerts"
        Me.BtnAlerts.Size = New System.Drawing.Size(106, 79)
        Me.BtnAlerts.TabIndex = 1
        Me.BtnAlerts.Text = "Alerts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( )"
        Me.BtnAlerts.UseVisualStyleBackColor = True
        '
        'BtnEditInv
        '
        Me.BtnEditInv.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnEditInv.Location = New System.Drawing.Point(3, 25)
        Me.BtnEditInv.Name = "BtnEditInv"
        Me.BtnEditInv.Size = New System.Drawing.Size(106, 79)
        Me.BtnEditInv.TabIndex = 0
        Me.BtnEditInv.Text = "Edit Inventory"
        Me.BtnEditInv.UseVisualStyleBackColor = True
        '
        'BoxOuterBtnGrp
        '
        Me.BoxOuterBtnGrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxOuterBtnGrp.Location = New System.Drawing.Point(112, 107)
        Me.BoxOuterBtnGrp.Name = "BoxOuterBtnGrp"
        Me.BoxOuterBtnGrp.Size = New System.Drawing.Size(733, 758)
        Me.BoxOuterBtnGrp.TabIndex = 9
        Me.BoxOuterBtnGrp.TabStop = False
        '
        'BtnSupply
        '
        Me.BtnSupply.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSupply.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSupply.Location = New System.Drawing.Point(3, 607)
        Me.BtnSupply.Name = "BtnSupply"
        Me.BtnSupply.Size = New System.Drawing.Size(106, 79)
        Me.BtnSupply.TabIndex = 16
        Me.BtnSupply.Text = "Supplies"
        Me.BtnSupply.UseVisualStyleBackColor = True
        '
        'CigBtn
        '
        Me.CigBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.CigBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CigBtn.Location = New System.Drawing.Point(3, 528)
        Me.CigBtn.Name = "CigBtn"
        Me.CigBtn.Size = New System.Drawing.Size(106, 79)
        Me.CigBtn.TabIndex = 15
        Me.CigBtn.Text = "Cigarettes"
        Me.CigBtn.UseVisualStyleBackColor = True
        '
        'AlcoholBtn
        '
        Me.AlcoholBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AlcoholBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlcoholBtn.Location = New System.Drawing.Point(3, 449)
        Me.AlcoholBtn.Name = "AlcoholBtn"
        Me.AlcoholBtn.Size = New System.Drawing.Size(106, 79)
        Me.AlcoholBtn.TabIndex = 14
        Me.AlcoholBtn.Text = "Alcohol"
        Me.AlcoholBtn.UseVisualStyleBackColor = True
        '
        'BeverageBtn
        '
        Me.BeverageBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.BeverageBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeverageBtn.Location = New System.Drawing.Point(3, 370)
        Me.BeverageBtn.Name = "BeverageBtn"
        Me.BeverageBtn.Size = New System.Drawing.Size(106, 79)
        Me.BeverageBtn.TabIndex = 13
        Me.BeverageBtn.Text = "Beverage"
        Me.BeverageBtn.UseVisualStyleBackColor = True
        '
        'HotBtn
        '
        Me.HotBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.HotBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotBtn.Location = New System.Drawing.Point(3, 291)
        Me.HotBtn.Name = "HotBtn"
        Me.HotBtn.Size = New System.Drawing.Size(106, 79)
        Me.HotBtn.TabIndex = 12
        Me.HotBtn.Text = "Hot Food"
        Me.HotBtn.UseVisualStyleBackColor = True
        '
        'ColdBtn
        '
        Me.ColdBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ColdBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColdBtn.Location = New System.Drawing.Point(3, 212)
        Me.ColdBtn.Name = "ColdBtn"
        Me.ColdBtn.Size = New System.Drawing.Size(106, 79)
        Me.ColdBtn.TabIndex = 11
        Me.ColdBtn.Text = "Cold Food"
        Me.ColdBtn.UseVisualStyleBackColor = True
        '
        'BtnSnack
        '
        Me.BtnSnack.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSnack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSnack.Location = New System.Drawing.Point(3, 133)
        Me.BtnSnack.Name = "BtnSnack"
        Me.BtnSnack.Size = New System.Drawing.Size(106, 79)
        Me.BtnSnack.TabIndex = 18
        Me.BtnSnack.Text = "Snacks"
        Me.BtnSnack.UseVisualStyleBackColor = True
        '
        'BtnCandy
        '
        Me.BtnCandy.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCandy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCandy.Location = New System.Drawing.Point(3, 54)
        Me.BtnCandy.Name = "BtnCandy"
        Me.BtnCandy.Size = New System.Drawing.Size(106, 79)
        Me.BtnCandy.TabIndex = 17
        Me.BtnCandy.Text = "Candy"
        Me.BtnCandy.UseVisualStyleBackColor = True
        '
        'BtnOther
        '
        Me.BtnOther.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOther.Location = New System.Drawing.Point(3, 686)
        Me.BtnOther.Name = "BtnOther"
        Me.BtnOther.Size = New System.Drawing.Size(106, 79)
        Me.BtnOther.TabIndex = 19
        Me.BtnOther.Text = "Other"
        Me.BtnOther.UseVisualStyleBackColor = True
        '
        'SalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 865)
        Me.Controls.Add(Me.BoxOuterBtnGrp)
        Me.Controls.Add(Me.CatBox)
        Me.Controls.Add(Me.BoxMngrCtrl)
        Me.Controls.Add(Me.CartGrpBox)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SalesForm"
        Me.Text = "SalesForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CartGrpBox.ResumeLayout(False)
        Me.CartCtrlBox.ResumeLayout(False)
        Me.ChkoutCtrlBox.ResumeLayout(False)
        Me.ChkoutCtrlBox.PerformLayout()
        Me.CatBox.ResumeLayout(False)
        Me.CatBox.PerformLayout()
        Me.BoxMngrCtrl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CartGrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents ChkoutCtrlBox As System.Windows.Forms.GroupBox
    Friend WithEvents SearchTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents CartLstBox As System.Windows.Forms.ListBox
    Friend WithEvents CatBox As System.Windows.Forms.GroupBox
    Friend WithEvents PriceLstBox As System.Windows.Forms.ListBox
    Friend WithEvents TBlankLbl As System.Windows.Forms.Label
    Friend WithEvents STBlankLbl As System.Windows.Forms.Label
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents SubTotalLbl As System.Windows.Forms.Label
    Friend WithEvents CnclBtn As System.Windows.Forms.Button
    Friend WithEvents ClrBtn As System.Windows.Forms.Button
    Friend WithEvents RemBtn As System.Windows.Forms.Button
    Friend WithEvents DecBtn As System.Windows.Forms.Button
    Friend WithEvents IncrBtn As System.Windows.Forms.Button
    Private WithEvents CartCtrlBox As System.Windows.Forms.GroupBox
    Friend WithEvents CheckOutBtn As System.Windows.Forms.Button
    Friend WithEvents BoxMngrCtrl As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAlerts As System.Windows.Forms.Button
    Friend WithEvents BtnEditInv As System.Windows.Forms.Button
    Friend WithEvents BoxOuterBtnGrp As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSupply As System.Windows.Forms.Button
    Friend WithEvents CigBtn As System.Windows.Forms.Button
    Friend WithEvents AlcoholBtn As System.Windows.Forms.Button
    Friend WithEvents BeverageBtn As System.Windows.Forms.Button
    Friend WithEvents HotBtn As System.Windows.Forms.Button
    Friend WithEvents ColdBtn As System.Windows.Forms.Button
    Friend WithEvents BtnSnack As System.Windows.Forms.Button
    Friend WithEvents BtnCandy As System.Windows.Forms.Button
    Friend WithEvents BtnOther As System.Windows.Forms.Button
    'Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
