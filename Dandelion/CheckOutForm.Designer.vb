<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckOutForm))
        Me.CashSaleBtn = New System.Windows.Forms.Button()
        Me.CreditSaleBtn = New System.Windows.Forms.Button()
        Me.CheckSaleBtn = New System.Windows.Forms.Button()
        Me.MskTendered = New System.Windows.Forms.MaskedTextBox()
        Me.TotalLbl = New System.Windows.Forms.Label()
        Me.TotalFillLbl = New System.Windows.Forms.Label()
        Me.ChangeLbl = New System.Windows.Forms.Label()
        Me.ChangeFillLbl = New System.Windows.Forms.Label()
        Me.Num7Btn = New System.Windows.Forms.Button()
        Me.Num0Btn = New System.Windows.Forms.Button()
        Me.BSBtn = New System.Windows.Forms.Button()
        Me.ClrBtn = New System.Windows.Forms.Button()
        Me.ECBtn = New System.Windows.Forms.Button()
        Me.CompleteBtn = New System.Windows.Forms.Button()
        Me.Num9Btn = New System.Windows.Forms.Button()
        Me.Num8Btn = New System.Windows.Forms.Button()
        Me.Num4Btn = New System.Windows.Forms.Button()
        Me.Num5Btn = New System.Windows.Forms.Button()
        Me.Num6Btn = New System.Windows.Forms.Button()
        Me.Num1Btn = New System.Windows.Forms.Button()
        Me.Num2Btn = New System.Windows.Forms.Button()
        Me.Num3Btn = New System.Windows.Forms.Button()
        Me.NumPadPnl = New System.Windows.Forms.Panel()
        Me.CnclBtn = New System.Windows.Forms.Button()
        Me.LblTendered = New System.Windows.Forms.Label()
        Me.NumPadPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'CashSaleBtn
        '
        Me.CashSaleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashSaleBtn.Location = New System.Drawing.Point(12, 12)
        Me.CashSaleBtn.Name = "CashSaleBtn"
        Me.CashSaleBtn.Size = New System.Drawing.Size(68, 40)
        Me.CashSaleBtn.TabIndex = 0
        Me.CashSaleBtn.Text = "Cash"
        Me.CashSaleBtn.UseVisualStyleBackColor = True
        '
        'CreditSaleBtn
        '
        Me.CreditSaleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditSaleBtn.Location = New System.Drawing.Point(86, 12)
        Me.CreditSaleBtn.Name = "CreditSaleBtn"
        Me.CreditSaleBtn.Size = New System.Drawing.Size(68, 40)
        Me.CreditSaleBtn.TabIndex = 1
        Me.CreditSaleBtn.Text = "Card"
        Me.CreditSaleBtn.UseVisualStyleBackColor = True
        '
        'CheckSaleBtn
        '
        Me.CheckSaleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckSaleBtn.Location = New System.Drawing.Point(160, 12)
        Me.CheckSaleBtn.Name = "CheckSaleBtn"
        Me.CheckSaleBtn.Size = New System.Drawing.Size(68, 40)
        Me.CheckSaleBtn.TabIndex = 2
        Me.CheckSaleBtn.Text = "Check"
        Me.CheckSaleBtn.UseVisualStyleBackColor = True
        '
        'MskTendered
        '
        Me.MskTendered.Enabled = False
        Me.MskTendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTendered.Location = New System.Drawing.Point(12, 113)
        Me.MskTendered.Name = "MskTendered"
        Me.MskTendered.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MskTendered.Size = New System.Drawing.Size(218, 26)
        Me.MskTendered.TabIndex = 3
        '
        'TotalLbl
        '
        Me.TotalLbl.AutoSize = True
        Me.TotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLbl.Location = New System.Drawing.Point(12, 67)
        Me.TotalLbl.Name = "TotalLbl"
        Me.TotalLbl.Size = New System.Drawing.Size(48, 20)
        Me.TotalLbl.TabIndex = 4
        Me.TotalLbl.Text = "Total:"
        '
        'TotalFillLbl
        '
        Me.TotalFillLbl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TotalFillLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalFillLbl.Location = New System.Drawing.Point(86, 67)
        Me.TotalFillLbl.Name = "TotalFillLbl"
        Me.TotalFillLbl.Size = New System.Drawing.Size(140, 20)
        Me.TotalFillLbl.TabIndex = 5
        Me.TotalFillLbl.Text = "$0.00"
        Me.TotalFillLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChangeLbl
        '
        Me.ChangeLbl.AutoSize = True
        Me.ChangeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeLbl.Location = New System.Drawing.Point(12, 140)
        Me.ChangeLbl.Name = "ChangeLbl"
        Me.ChangeLbl.Size = New System.Drawing.Size(69, 20)
        Me.ChangeLbl.TabIndex = 6
        Me.ChangeLbl.Text = "Change:"
        '
        'ChangeFillLbl
        '
        Me.ChangeFillLbl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ChangeFillLbl.Enabled = False
        Me.ChangeFillLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeFillLbl.Location = New System.Drawing.Point(86, 140)
        Me.ChangeFillLbl.Name = "ChangeFillLbl"
        Me.ChangeFillLbl.Size = New System.Drawing.Size(140, 20)
        Me.ChangeFillLbl.TabIndex = 7
        Me.ChangeFillLbl.Text = "$0.00"
        Me.ChangeFillLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Num7Btn
        '
        Me.Num7Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num7Btn.Location = New System.Drawing.Point(3, 3)
        Me.Num7Btn.Name = "Num7Btn"
        Me.Num7Btn.Size = New System.Drawing.Size(50, 50)
        Me.Num7Btn.TabIndex = 8
        Me.Num7Btn.Text = "7"
        Me.Num7Btn.UseVisualStyleBackColor = True
        '
        'Num0Btn
        '
        Me.Num0Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num0Btn.Location = New System.Drawing.Point(3, 171)
        Me.Num0Btn.Name = "Num0Btn"
        Me.Num0Btn.Size = New System.Drawing.Size(162, 50)
        Me.Num0Btn.TabIndex = 17
        Me.Num0Btn.Text = "0"
        Me.Num0Btn.UseVisualStyleBackColor = True
        '
        'BSBtn
        '
        Me.BSBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSBtn.Location = New System.Drawing.Point(171, 3)
        Me.BSBtn.Name = "BSBtn"
        Me.BSBtn.Size = New System.Drawing.Size(50, 50)
        Me.BSBtn.TabIndex = 18
        Me.BSBtn.Text = "<---"
        Me.BSBtn.UseVisualStyleBackColor = True
        '
        'ClrBtn
        '
        Me.ClrBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClrBtn.Location = New System.Drawing.Point(171, 59)
        Me.ClrBtn.Name = "ClrBtn"
        Me.ClrBtn.Size = New System.Drawing.Size(50, 50)
        Me.ClrBtn.TabIndex = 19
        Me.ClrBtn.Text = "Clr"
        Me.ClrBtn.UseVisualStyleBackColor = True
        '
        'ECBtn
        '
        Me.ECBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ECBtn.Location = New System.Drawing.Point(171, 115)
        Me.ECBtn.Name = "ECBtn"
        Me.ECBtn.Size = New System.Drawing.Size(50, 106)
        Me.ECBtn.TabIndex = 20
        Me.ECBtn.Text = "E. C."
        Me.ECBtn.UseVisualStyleBackColor = True
        '
        'CompleteBtn
        '
        Me.CompleteBtn.Enabled = False
        Me.CompleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompleteBtn.Location = New System.Drawing.Point(6, 406)
        Me.CompleteBtn.Name = "CompleteBtn"
        Me.CompleteBtn.Size = New System.Drawing.Size(110, 50)
        Me.CompleteBtn.TabIndex = 21
        Me.CompleteBtn.Text = "Complete"
        Me.CompleteBtn.UseVisualStyleBackColor = True
        '
        'Num9Btn
        '
        Me.Num9Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num9Btn.Location = New System.Drawing.Point(115, 3)
        Me.Num9Btn.Name = "Num9Btn"
        Me.Num9Btn.Size = New System.Drawing.Size(50, 50)
        Me.Num9Btn.TabIndex = 22
        Me.Num9Btn.Text = "9"
        Me.Num9Btn.UseVisualStyleBackColor = True
        '
        'Num8Btn
        '
        Me.Num8Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num8Btn.Location = New System.Drawing.Point(59, 3)
        Me.Num8Btn.Name = "Num8Btn"
        Me.Num8Btn.Size = New System.Drawing.Size(50, 50)
        Me.Num8Btn.TabIndex = 23
        Me.Num8Btn.Text = "8"
        Me.Num8Btn.UseVisualStyleBackColor = True
        '
        'Num4Btn
        '
        Me.Num4Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num4Btn.Location = New System.Drawing.Point(3, 59)
        Me.Num4Btn.Name = "Num4Btn"
        Me.Num4Btn.Size = New System.Drawing.Size(50, 50)
        Me.Num4Btn.TabIndex = 24
        Me.Num4Btn.Text = "4"
        Me.Num4Btn.UseVisualStyleBackColor = True
        '
        'Num5Btn
        '
        Me.Num5Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num5Btn.Location = New System.Drawing.Point(59, 59)
        Me.Num5Btn.Name = "Num5Btn"
        Me.Num5Btn.Size = New System.Drawing.Size(50, 50)
        Me.Num5Btn.TabIndex = 25
        Me.Num5Btn.Text = "5"
        Me.Num5Btn.UseVisualStyleBackColor = True
        '
        'Num6Btn
        '
        Me.Num6Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num6Btn.Location = New System.Drawing.Point(115, 59)
        Me.Num6Btn.Name = "Num6Btn"
        Me.Num6Btn.Size = New System.Drawing.Size(50, 50)
        Me.Num6Btn.TabIndex = 26
        Me.Num6Btn.Text = "6"
        Me.Num6Btn.UseVisualStyleBackColor = True
        '
        'Num1Btn
        '
        Me.Num1Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num1Btn.Location = New System.Drawing.Point(3, 115)
        Me.Num1Btn.Name = "Num1Btn"
        Me.Num1Btn.Size = New System.Drawing.Size(50, 50)
        Me.Num1Btn.TabIndex = 27
        Me.Num1Btn.Text = "1"
        Me.Num1Btn.UseVisualStyleBackColor = True
        '
        'Num2Btn
        '
        Me.Num2Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num2Btn.Location = New System.Drawing.Point(59, 115)
        Me.Num2Btn.Name = "Num2Btn"
        Me.Num2Btn.Size = New System.Drawing.Size(50, 50)
        Me.Num2Btn.TabIndex = 28
        Me.Num2Btn.Text = "2"
        Me.Num2Btn.UseVisualStyleBackColor = True
        '
        'Num3Btn
        '
        Me.Num3Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num3Btn.Location = New System.Drawing.Point(115, 115)
        Me.Num3Btn.Name = "Num3Btn"
        Me.Num3Btn.Size = New System.Drawing.Size(50, 50)
        Me.Num3Btn.TabIndex = 29
        Me.Num3Btn.Text = "3"
        Me.Num3Btn.UseVisualStyleBackColor = True
        '
        'NumPadPnl
        '
        Me.NumPadPnl.Controls.Add(Me.Num7Btn)
        Me.NumPadPnl.Controls.Add(Me.Num3Btn)
        Me.NumPadPnl.Controls.Add(Me.Num0Btn)
        Me.NumPadPnl.Controls.Add(Me.Num2Btn)
        Me.NumPadPnl.Controls.Add(Me.BSBtn)
        Me.NumPadPnl.Controls.Add(Me.Num1Btn)
        Me.NumPadPnl.Controls.Add(Me.ClrBtn)
        Me.NumPadPnl.Controls.Add(Me.Num6Btn)
        Me.NumPadPnl.Controls.Add(Me.ECBtn)
        Me.NumPadPnl.Controls.Add(Me.Num5Btn)
        Me.NumPadPnl.Controls.Add(Me.Num4Btn)
        Me.NumPadPnl.Controls.Add(Me.Num9Btn)
        Me.NumPadPnl.Controls.Add(Me.Num8Btn)
        Me.NumPadPnl.Enabled = False
        Me.NumPadPnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumPadPnl.Location = New System.Drawing.Point(6, 173)
        Me.NumPadPnl.Name = "NumPadPnl"
        Me.NumPadPnl.Size = New System.Drawing.Size(224, 227)
        Me.NumPadPnl.TabIndex = 30
        '
        'CnclBtn
        '
        Me.CnclBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CnclBtn.Location = New System.Drawing.Point(120, 406)
        Me.CnclBtn.Name = "CnclBtn"
        Me.CnclBtn.Size = New System.Drawing.Size(110, 50)
        Me.CnclBtn.TabIndex = 31
        Me.CnclBtn.Text = "Cancel"
        Me.CnclBtn.UseVisualStyleBackColor = True
        '
        'LblTendered
        '
        Me.LblTendered.AutoSize = True
        Me.LblTendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTendered.Location = New System.Drawing.Point(12, 90)
        Me.LblTendered.Name = "LblTendered"
        Me.LblTendered.Size = New System.Drawing.Size(81, 20)
        Me.LblTendered.TabIndex = 32
        Me.LblTendered.Text = "Tendered:"
        '
        'CheckOutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 485)
        Me.Controls.Add(Me.LblTendered)
        Me.Controls.Add(Me.CnclBtn)
        Me.Controls.Add(Me.NumPadPnl)
        Me.Controls.Add(Me.ChangeFillLbl)
        Me.Controls.Add(Me.ChangeLbl)
        Me.Controls.Add(Me.TotalFillLbl)
        Me.Controls.Add(Me.TotalLbl)
        Me.Controls.Add(Me.MskTendered)
        Me.Controls.Add(Me.CheckSaleBtn)
        Me.Controls.Add(Me.CreditSaleBtn)
        Me.Controls.Add(Me.CashSaleBtn)
        Me.Controls.Add(Me.CompleteBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CheckOutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Out Form"
        Me.TopMost = True
        Me.NumPadPnl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CashSaleBtn As System.Windows.Forms.Button
    Friend WithEvents CreditSaleBtn As System.Windows.Forms.Button
    Friend WithEvents CheckSaleBtn As System.Windows.Forms.Button
    Friend WithEvents MskTendered As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TotalLbl As System.Windows.Forms.Label
    Friend WithEvents TotalFillLbl As System.Windows.Forms.Label
    Friend WithEvents ChangeLbl As System.Windows.Forms.Label
    Friend WithEvents ChangeFillLbl As System.Windows.Forms.Label
    Friend WithEvents Num7Btn As System.Windows.Forms.Button
    Friend WithEvents Num0Btn As System.Windows.Forms.Button
    Friend WithEvents BSBtn As System.Windows.Forms.Button
    Friend WithEvents ClrBtn As System.Windows.Forms.Button
    Friend WithEvents ECBtn As System.Windows.Forms.Button
    Friend WithEvents CompleteBtn As System.Windows.Forms.Button
    Friend WithEvents Num9Btn As System.Windows.Forms.Button
    Friend WithEvents Num8Btn As System.Windows.Forms.Button
    Friend WithEvents Num4Btn As System.Windows.Forms.Button
    Friend WithEvents Num5Btn As System.Windows.Forms.Button
    Friend WithEvents Num6Btn As System.Windows.Forms.Button
    Friend WithEvents Num1Btn As System.Windows.Forms.Button
    Friend WithEvents Num2Btn As System.Windows.Forms.Button
    Friend WithEvents Num3Btn As System.Windows.Forms.Button
    Friend WithEvents NumPadPnl As System.Windows.Forms.Panel
    Friend WithEvents CnclBtn As System.Windows.Forms.Button
    Friend WithEvents LblTendered As System.Windows.Forms.Label
End Class
