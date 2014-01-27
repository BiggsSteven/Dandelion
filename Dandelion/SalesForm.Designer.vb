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
        Me.BtnCntrlGrpBox = New System.Windows.Forms.GroupBox()
        Me.SearchTxtBox = New System.Windows.Forms.TextBox()
        Me.CatBox = New System.Windows.Forms.GroupBox()
        Me.Other = New System.Windows.Forms.Button()
        Me.NonConsumBtn = New System.Windows.Forms.Button()
        Me.CigBtn = New System.Windows.Forms.Button()
        Me.AlcoholBtn = New System.Windows.Forms.Button()
        Me.BeverageBtn = New System.Windows.Forms.Button()
        Me.CookedBtn = New System.Windows.Forms.Button()
        Me.ColdBtn = New System.Windows.Forms.Button()
        Me.ItemsBox = New System.Windows.Forms.GroupBox()
        Me.CartGrpBox.SuspendLayout()
        Me.CatBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CartGrpBox
        '
        Me.CartGrpBox.Controls.Add(Me.CartLstBox)
        Me.CartGrpBox.Controls.Add(Me.BtnCntrlGrpBox)
        Me.CartGrpBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.CartGrpBox.Location = New System.Drawing.Point(1150, 0)
        Me.CartGrpBox.Name = "CartGrpBox"
        Me.CartGrpBox.Size = New System.Drawing.Size(266, 856)
        Me.CartGrpBox.TabIndex = 0
        Me.CartGrpBox.TabStop = False
        Me.CartGrpBox.Text = "Cart"
        '
        'CartLstBox
        '
        Me.CartLstBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CartLstBox.FormattingEnabled = True
        Me.CartLstBox.Location = New System.Drawing.Point(3, 16)
        Me.CartLstBox.Name = "CartLstBox"
        Me.CartLstBox.Size = New System.Drawing.Size(260, 539)
        Me.CartLstBox.TabIndex = 5
        '
        'BtnCntrlGrpBox
        '
        Me.BtnCntrlGrpBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnCntrlGrpBox.Location = New System.Drawing.Point(3, 555)
        Me.BtnCntrlGrpBox.Name = "BtnCntrlGrpBox"
        Me.BtnCntrlGrpBox.Size = New System.Drawing.Size(260, 298)
        Me.BtnCntrlGrpBox.TabIndex = 3
        Me.BtnCntrlGrpBox.TabStop = False
        '
        'SearchTxtBox
        '
        Me.SearchTxtBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchTxtBox.Location = New System.Drawing.Point(3, 16)
        Me.SearchTxtBox.Name = "SearchTxtBox"
        Me.SearchTxtBox.Size = New System.Drawing.Size(174, 20)
        Me.SearchTxtBox.TabIndex = 1
        '
        'CatBox
        '
        Me.CatBox.Controls.Add(Me.Other)
        Me.CatBox.Controls.Add(Me.NonConsumBtn)
        Me.CatBox.Controls.Add(Me.CigBtn)
        Me.CatBox.Controls.Add(Me.AlcoholBtn)
        Me.CatBox.Controls.Add(Me.BeverageBtn)
        Me.CatBox.Controls.Add(Me.CookedBtn)
        Me.CatBox.Controls.Add(Me.ColdBtn)
        Me.CatBox.Controls.Add(Me.SearchTxtBox)
        Me.CatBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.CatBox.Location = New System.Drawing.Point(970, 0)
        Me.CatBox.Name = "CatBox"
        Me.CatBox.Size = New System.Drawing.Size(180, 856)
        Me.CatBox.TabIndex = 3
        Me.CatBox.TabStop = False
        '
        'Other
        '
        Me.Other.Dock = System.Windows.Forms.DockStyle.Top
        Me.Other.Location = New System.Drawing.Point(3, 510)
        Me.Other.Name = "Other"
        Me.Other.Size = New System.Drawing.Size(174, 79)
        Me.Other.TabIndex = 9
        Me.Other.Text = "Other"
        Me.Other.UseVisualStyleBackColor = True
        '
        'NonConsumBtn
        '
        Me.NonConsumBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.NonConsumBtn.Location = New System.Drawing.Point(3, 431)
        Me.NonConsumBtn.Name = "NonConsumBtn"
        Me.NonConsumBtn.Size = New System.Drawing.Size(174, 79)
        Me.NonConsumBtn.TabIndex = 8
        Me.NonConsumBtn.Text = "Non-Consumable Products"
        Me.NonConsumBtn.UseVisualStyleBackColor = True
        '
        'CigBtn
        '
        Me.CigBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.CigBtn.Location = New System.Drawing.Point(3, 352)
        Me.CigBtn.Name = "CigBtn"
        Me.CigBtn.Size = New System.Drawing.Size(174, 79)
        Me.CigBtn.TabIndex = 7
        Me.CigBtn.Text = "Cigarettes"
        Me.CigBtn.UseVisualStyleBackColor = True
        '
        'AlcoholBtn
        '
        Me.AlcoholBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AlcoholBtn.Location = New System.Drawing.Point(3, 273)
        Me.AlcoholBtn.Name = "AlcoholBtn"
        Me.AlcoholBtn.Size = New System.Drawing.Size(174, 79)
        Me.AlcoholBtn.TabIndex = 6
        Me.AlcoholBtn.Text = "Alcohol"
        Me.AlcoholBtn.UseVisualStyleBackColor = True
        '
        'BeverageBtn
        '
        Me.BeverageBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.BeverageBtn.Location = New System.Drawing.Point(3, 194)
        Me.BeverageBtn.Name = "BeverageBtn"
        Me.BeverageBtn.Size = New System.Drawing.Size(174, 79)
        Me.BeverageBtn.TabIndex = 5
        Me.BeverageBtn.Text = "Beverage"
        Me.BeverageBtn.UseVisualStyleBackColor = True
        '
        'CookedBtn
        '
        Me.CookedBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.CookedBtn.Location = New System.Drawing.Point(3, 115)
        Me.CookedBtn.Name = "CookedBtn"
        Me.CookedBtn.Size = New System.Drawing.Size(174, 79)
        Me.CookedBtn.TabIndex = 3
        Me.CookedBtn.Text = "Cooked Food"
        Me.CookedBtn.UseVisualStyleBackColor = True
        '
        'ColdBtn
        '
        Me.ColdBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ColdBtn.Location = New System.Drawing.Point(3, 36)
        Me.ColdBtn.Name = "ColdBtn"
        Me.ColdBtn.Size = New System.Drawing.Size(174, 79)
        Me.ColdBtn.TabIndex = 2
        Me.ColdBtn.Text = "Cold Food"
        Me.ColdBtn.UseVisualStyleBackColor = True
        '
        'ItemsBox
        '
        Me.ItemsBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemsBox.Location = New System.Drawing.Point(0, 0)
        Me.ItemsBox.Name = "ItemsBox"
        Me.ItemsBox.Size = New System.Drawing.Size(970, 856)
        Me.ItemsBox.TabIndex = 4
        Me.ItemsBox.TabStop = False
        Me.ItemsBox.Text = "Items"
        '
        'SalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1416, 856)
        Me.Controls.Add(Me.ItemsBox)
        Me.Controls.Add(Me.CatBox)
        Me.Controls.Add(Me.CartGrpBox)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SalesForm"
        Me.Text = "SalesForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CartGrpBox.ResumeLayout(False)
        Me.CatBox.ResumeLayout(False)
        Me.CatBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CartGrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCntrlGrpBox As System.Windows.Forms.GroupBox
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
    Friend WithEvents ItemsBox As System.Windows.Forms.GroupBox
    'Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
