<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgeVerificationForm
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
        Me.InputConfirmBtn = New System.Windows.Forms.Button()
        Me.QuickConfirmBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.YrTxtBox = New System.Windows.Forms.TextBox()
        Me.DayTextBox = New System.Windows.Forms.TextBox()
        Me.MnthTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputConfirmBtn
        '
        Me.InputConfirmBtn.Location = New System.Drawing.Point(110, 91)
        Me.InputConfirmBtn.Name = "InputConfirmBtn"
        Me.InputConfirmBtn.Size = New System.Drawing.Size(71, 50)
        Me.InputConfirmBtn.TabIndex = 4
        Me.InputConfirmBtn.Text = "Confirm"
        Me.InputConfirmBtn.UseVisualStyleBackColor = True
        '
        'QuickConfirmBtn
        '
        Me.QuickConfirmBtn.Location = New System.Drawing.Point(113, 53)
        Me.QuickConfirmBtn.Name = "QuickConfirmBtn"
        Me.QuickConfirmBtn.Size = New System.Drawing.Size(71, 50)
        Me.QuickConfirmBtn.TabIndex = 5
        Me.QuickConfirmBtn.Text = "Confirm"
        Me.QuickConfirmBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter Customers Birthday ( MM/DD/YYYY):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Quick Confirm:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Is the Customer:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MaskedTextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.YrTxtBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DayTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MnthTxtBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputConfirmBtn)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.QuickConfirmBtn)
        Me.SplitContainer1.Size = New System.Drawing.Size(286, 328)
        Me.SplitContainer1.SplitterDistance = 164
        Me.SplitContainer1.TabIndex = 9
        '
        'YrTxtBox
        '
        Me.YrTxtBox.Location = New System.Drawing.Point(175, 42)
        Me.YrTxtBox.Name = "YrTxtBox"
        Me.YrTxtBox.Size = New System.Drawing.Size(56, 20)
        Me.YrTxtBox.TabIndex = 9
        '
        'DayTextBox
        '
        Me.DayTextBox.Location = New System.Drawing.Point(113, 42)
        Me.DayTextBox.Name = "DayTextBox"
        Me.DayTextBox.Size = New System.Drawing.Size(56, 20)
        Me.DayTextBox.TabIndex = 8
        '
        'MnthTxtBox
        '
        Me.MnthTxtBox.Location = New System.Drawing.Point(51, 42)
        Me.MnthTxtBox.Name = "MnthTxtBox"
        Me.MnthTxtBox.Size = New System.Drawing.Size(56, 20)
        Me.MnthTxtBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(101, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(15, 107)
        Me.MaskedTextBox1.Mask = "00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(80, 20)
        Me.MaskedTextBox1.TabIndex = 10
        '
        'AgeVerificationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 328)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "AgeVerificationForm"
        Me.Text = "AgeVerificationForm"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InputConfirmBtn As System.Windows.Forms.Button
    Friend WithEvents QuickConfirmBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents YrTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents DayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MnthTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
End Class
