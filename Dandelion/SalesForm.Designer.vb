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
        Me.ChkoutCtrlBox = New System.Windows.Forms.GroupBox()
        Me.TBlankLbl = New System.Windows.Forms.Label()
        Me.STBlankLbl = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.SubTotalLbl = New System.Windows.Forms.Label()
        Me.SearchTxtBox = New System.Windows.Forms.TextBox()
        Me.CatBox = New System.Windows.Forms.GroupBox()
        Me.DsctBtn = New System.Windows.Forms.Button()
        Me.Other = New System.Windows.Forms.Button()
        Me.NonConsumBtn = New System.Windows.Forms.Button()
        Me.CigBtn = New System.Windows.Forms.Button()
        Me.AlcoholBtn = New System.Windows.Forms.Button()
        Me.BeverageBtn = New System.Windows.Forms.Button()
        Me.CookedBtn = New System.Windows.Forms.Button()
        Me.ColdBtn = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.CtrlBox = New System.Windows.Forms.GroupBox()
        Me.ItemPnl = New System.Windows.Forms.Panel()
        Me.CartGrpBox.SuspendLayout()
        Me.ChkoutCtrlBox.SuspendLayout()
        Me.CatBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CartGrpBox
        '
        Me.CartGrpBox.Controls.Add(Me.CartLstBox)
        Me.CartGrpBox.Controls.Add(Me.PriceLstBox)
        Me.CartGrpBox.Controls.Add(Me.CartCtrlBox)
        Me.CartGrpBox.Controls.Add(Me.ChkoutCtrlBox)
        Me.CartGrpBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.CartGrpBox.Location = New System.Drawing.Point(669, 0)
        Me.CartGrpBox.Name = "CartGrpBox"
        Me.CartGrpBox.Size = New System.Drawing.Size(442, 865)
        Me.CartGrpBox.TabIndex = 0
        Me.CartGrpBox.TabStop = False
        '
        'CartLstBox
        '
        Me.CartLstBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CartLstBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CartLstBox.FormattingEnabled = True
        Me.CartLstBox.ItemHeight = 25
        Me.CartLstBox.Location = New System.Drawing.Point(113, 16)
        Me.CartLstBox.MultiColumn = True
        Me.CartLstBox.Name = "CartLstBox"
        Me.CartLstBox.Size = New System.Drawing.Size(237, 510)
        Me.CartLstBox.TabIndex = 5
        '
        'PriceLstBox
        '
        Me.PriceLstBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.PriceLstBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLstBox.FormattingEnabled = True
        Me.PriceLstBox.ItemHeight = 25
        Me.PriceLstBox.Location = New System.Drawing.Point(350, 16)
        Me.PriceLstBox.Name = "PriceLstBox"
        Me.PriceLstBox.Size = New System.Drawing.Size(89, 510)
        Me.PriceLstBox.TabIndex = 7
        '
        'CartCtrlBox
        '
        Me.CartCtrlBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.CartCtrlBox.Location = New System.Drawing.Point(3, 16)
        Me.CartCtrlBox.Name = "CartCtrlBox"
        Me.CartCtrlBox.Size = New System.Drawing.Size(110, 510)
        Me.CartCtrlBox.TabIndex = 6
        Me.CartCtrlBox.TabStop = False
        '
        'ChkoutCtrlBox
        '
        Me.ChkoutCtrlBox.Controls.Add(Me.TBlankLbl)
        Me.ChkoutCtrlBox.Controls.Add(Me.STBlankLbl)
        Me.ChkoutCtrlBox.Controls.Add(Me.TotalLabel)
        Me.ChkoutCtrlBox.Controls.Add(Me.SubTotalLbl)
        Me.ChkoutCtrlBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ChkoutCtrlBox.Location = New System.Drawing.Point(3, 526)
        Me.ChkoutCtrlBox.Name = "ChkoutCtrlBox"
        Me.ChkoutCtrlBox.Size = New System.Drawing.Size(436, 336)
        Me.ChkoutCtrlBox.TabIndex = 3
        Me.ChkoutCtrlBox.TabStop = False
        '
        'TBlankLbl
        '
        Me.TBlankLbl.AutoSize = True
        Me.TBlankLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBlankLbl.Location = New System.Drawing.Point(103, 70)
        Me.TBlankLbl.Name = "TBlankLbl"
        Me.TBlankLbl.Size = New System.Drawing.Size(71, 25)
        Me.TBlankLbl.TabIndex = 3
        Me.TBlankLbl.Text = "Label4"
        '
        'STBlankLbl
        '
        Me.STBlankLbl.AutoSize = True
        Me.STBlankLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STBlankLbl.Location = New System.Drawing.Point(103, 20)
        Me.STBlankLbl.Name = "STBlankLbl"
        Me.STBlankLbl.Size = New System.Drawing.Size(71, 25)
        Me.STBlankLbl.TabIndex = 2
        Me.STBlankLbl.Text = "Label3"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(9, 70)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(62, 25)
        Me.TotalLabel.TabIndex = 1
        Me.TotalLabel.Text = "Total:"
        '
        'SubTotalLbl
        '
        Me.SubTotalLbl.AutoSize = True
        Me.SubTotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalLbl.Location = New System.Drawing.Point(7, 20)
        Me.SubTotalLbl.Name = "SubTotalLbl"
        Me.SubTotalLbl.Size = New System.Drawing.Size(90, 25)
        Me.SubTotalLbl.TabIndex = 0
        Me.SubTotalLbl.Text = "Subtotal:"
        '
        'SearchTxtBox
        '
        Me.SearchTxtBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchTxtBox.Location = New System.Drawing.Point(3, 16)
        Me.SearchTxtBox.Name = "SearchTxtBox"
        Me.SearchTxtBox.Size = New System.Drawing.Size(104, 20)
        Me.SearchTxtBox.TabIndex = 1
        '
        'CatBox
        '
        Me.CatBox.Controls.Add(Me.DsctBtn)
        Me.CatBox.Controls.Add(Me.Other)
        Me.CatBox.Controls.Add(Me.NonConsumBtn)
        Me.CatBox.Controls.Add(Me.CigBtn)
        Me.CatBox.Controls.Add(Me.AlcoholBtn)
        Me.CatBox.Controls.Add(Me.BeverageBtn)
        Me.CatBox.Controls.Add(Me.CookedBtn)
        Me.CatBox.Controls.Add(Me.ColdBtn)
        Me.CatBox.Controls.Add(Me.SearchTxtBox)
        Me.CatBox.Controls.Add(Me.ShapeContainer1)
        Me.CatBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.CatBox.Location = New System.Drawing.Point(0, 0)
        Me.CatBox.Name = "CatBox"
        Me.CatBox.Size = New System.Drawing.Size(110, 765)
        Me.CatBox.TabIndex = 3
        Me.CatBox.TabStop = False
        '
        'DsctBtn
        '
        Me.DsctBtn.Location = New System.Drawing.Point(3, 596)
        Me.DsctBtn.Name = "DsctBtn"
        Me.DsctBtn.Size = New System.Drawing.Size(104, 79)
        Me.DsctBtn.TabIndex = 11
        Me.DsctBtn.Text = "Discount Button"
        Me.DsctBtn.UseVisualStyleBackColor = True
        '
        'Other
        '
        Me.Other.Dock = System.Windows.Forms.DockStyle.Top
        Me.Other.Location = New System.Drawing.Point(3, 510)
        Me.Other.Name = "Other"
        Me.Other.Size = New System.Drawing.Size(104, 79)
        Me.Other.TabIndex = 9
        Me.Other.Text = "Other"
        Me.Other.UseVisualStyleBackColor = True
        '
        'NonConsumBtn
        '
        Me.NonConsumBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.NonConsumBtn.Location = New System.Drawing.Point(3, 431)
        Me.NonConsumBtn.Name = "NonConsumBtn"
        Me.NonConsumBtn.Size = New System.Drawing.Size(104, 79)
        Me.NonConsumBtn.TabIndex = 8
        Me.NonConsumBtn.Text = "Non-Consumable Products"
        Me.NonConsumBtn.UseVisualStyleBackColor = True
        '
        'CigBtn
        '
        Me.CigBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.CigBtn.Location = New System.Drawing.Point(3, 352)
        Me.CigBtn.Name = "CigBtn"
        Me.CigBtn.Size = New System.Drawing.Size(104, 79)
        Me.CigBtn.TabIndex = 7
        Me.CigBtn.Text = "Cigarettes"
        Me.CigBtn.UseVisualStyleBackColor = True
        '
        'AlcoholBtn
        '
        Me.AlcoholBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AlcoholBtn.Location = New System.Drawing.Point(3, 273)
        Me.AlcoholBtn.Name = "AlcoholBtn"
        Me.AlcoholBtn.Size = New System.Drawing.Size(104, 79)
        Me.AlcoholBtn.TabIndex = 6
        Me.AlcoholBtn.Text = "Alcohol"
        Me.AlcoholBtn.UseVisualStyleBackColor = True
        '
        'BeverageBtn
        '
        Me.BeverageBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.BeverageBtn.Location = New System.Drawing.Point(3, 194)
        Me.BeverageBtn.Name = "BeverageBtn"
        Me.BeverageBtn.Size = New System.Drawing.Size(104, 79)
        Me.BeverageBtn.TabIndex = 5
        Me.BeverageBtn.Text = "Beverage"
        Me.BeverageBtn.UseVisualStyleBackColor = True
        '
        'CookedBtn
        '
        Me.CookedBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.CookedBtn.Location = New System.Drawing.Point(3, 115)
        Me.CookedBtn.Name = "CookedBtn"
        Me.CookedBtn.Size = New System.Drawing.Size(104, 79)
        Me.CookedBtn.TabIndex = 3
        Me.CookedBtn.Text = "Cooked Food"
        Me.CookedBtn.UseVisualStyleBackColor = True
        '
        'ColdBtn
        '
        Me.ColdBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ColdBtn.Location = New System.Drawing.Point(3, 36)
        Me.ColdBtn.Name = "ColdBtn"
        Me.ColdBtn.Size = New System.Drawing.Size(104, 79)
        Me.ColdBtn.TabIndex = 2
        Me.ColdBtn.Text = "Cold Food"
        Me.ColdBtn.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(104, 746)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 104
        Me.LineShape1.Y1 = 580
        Me.LineShape1.Y2 = 580
        '
        'CtrlBox
        '
        Me.CtrlBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CtrlBox.Location = New System.Drawing.Point(0, 765)
        Me.CtrlBox.Name = "CtrlBox"
        Me.CtrlBox.Size = New System.Drawing.Size(669, 100)
        Me.CtrlBox.TabIndex = 0
        Me.CtrlBox.TabStop = False
        '
        'ItemPnl
        '
        Me.ItemPnl.AutoScroll = True
        Me.ItemPnl.Location = New System.Drawing.Point(132, 13)
        Me.ItemPnl.Name = "ItemPnl"
        Me.ItemPnl.Size = New System.Drawing.Size(516, 518)
        Me.ItemPnl.TabIndex = 4
        '
        'SalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 865)
        Me.Controls.Add(Me.ItemPnl)
        Me.Controls.Add(Me.CatBox)
        Me.Controls.Add(Me.CtrlBox)
        Me.Controls.Add(Me.CartGrpBox)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SalesForm"
        Me.Text = "SalesForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CartGrpBox.ResumeLayout(False)
        Me.ChkoutCtrlBox.ResumeLayout(False)
        Me.ChkoutCtrlBox.PerformLayout()
        Me.CatBox.ResumeLayout(False)
        Me.CatBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CartGrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents ChkoutCtrlBox As System.Windows.Forms.GroupBox
    Friend WithEvents SearchTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents CartLstBox As System.Windows.Forms.ListBox
    Friend WithEvents CatBox As System.Windows.Forms.GroupBox
    Friend WithEvents Other As System.Windows.Forms.Button
    Friend WithEvents NonConsumBtn As System.Windows.Forms.Button
    Friend WithEvents CigBtn As System.Windows.Forms.Button
    Friend WithEvents AlcoholBtn As System.Windows.Forms.Button
    Friend WithEvents BeverageBtn As System.Windows.Forms.Button
    Friend WithEvents CookedBtn As System.Windows.Forms.Button
    Friend WithEvents ColdBtn As System.Windows.Forms.Button
    Friend WithEvents CtrlBox As System.Windows.Forms.GroupBox
    Friend WithEvents CartCtrlBox As System.Windows.Forms.GroupBox
    Friend WithEvents ItemPnl As System.Windows.Forms.Panel
    Friend WithEvents PriceLstBox As System.Windows.Forms.ListBox
    Friend WithEvents TBlankLbl As System.Windows.Forms.Label
    Friend WithEvents STBlankLbl As System.Windows.Forms.Label
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents SubTotalLbl As System.Windows.Forms.Label
    Friend WithEvents DsctBtn As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
