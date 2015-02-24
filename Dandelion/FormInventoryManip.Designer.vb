<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventoryManip
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
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BoxSectionOne = New System.Windows.Forms.GroupBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnRestock = New System.Windows.Forms.Button()
        Me.BtnBegin = New System.Windows.Forms.Button()
        Me.BoxSelectItems = New System.Windows.Forms.GroupBox()
        Me.ListEditQue = New System.Windows.Forms.ListBox()
        Me.CartCtrlBox = New System.Windows.Forms.GroupBox()
        Me.CnclBtn = New System.Windows.Forms.Button()
        Me.ClrBtn = New System.Windows.Forms.Button()
        Me.RemBtn = New System.Windows.Forms.Button()
        Me.BoxCartEdit = New System.Windows.Forms.GroupBox()
        Me.BtnCnclCart = New System.Windows.Forms.Button()
        Me.LblBarcode = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.LblMaxStock = New System.Windows.Forms.Label()
        Me.LblMiniStock = New System.Windows.Forms.Label()
        Me.LblNowStock = New System.Windows.Forms.Label()
        Me.TxtBarcodeFill = New System.Windows.Forms.TextBox()
        Me.TxtNameFill = New System.Windows.Forms.TextBox()
        Me.TxtMiniStockFill = New System.Windows.Forms.TextBox()
        Me.TxtNowStockFill = New System.Windows.Forms.TextBox()
        Me.CmboCatFill = New System.Windows.Forms.ComboBox()
        Me.BoxSectionThree = New System.Windows.Forms.GroupBox()
        Me.BoxInputFields = New System.Windows.Forms.GroupBox()
        Me.TxtAgeReqFill = New System.Windows.Forms.TextBox()
        Me.TxtMaxStockFill = New System.Windows.Forms.TextBox()
        Me.TxtPriceFill = New System.Windows.Forms.TextBox()
        Me.TxtStockFill = New System.Windows.Forms.TextBox()
        Me.LblAgeReq = New System.Windows.Forms.Label()
        Me.RdBtnSet = New System.Windows.Forms.RadioButton()
        Me.LblIncreaseStock = New System.Windows.Forms.Label()
        Me.BoxFinish = New System.Windows.Forms.GroupBox()
        Me.BtnFinished = New System.Windows.Forms.Button()
        Me.BtnExitFieldEdit = New System.Windows.Forms.Button()
        Me.RdBtnIncrease = New System.Windows.Forms.RadioButton()
        Me.CatBox = New System.Windows.Forms.GroupBox()
        Me.BtnOther = New System.Windows.Forms.Button()
        Me.BtnSupply = New System.Windows.Forms.Button()
        Me.CigBtn = New System.Windows.Forms.Button()
        Me.AlcoholBtn = New System.Windows.Forms.Button()
        Me.BeverageBtn = New System.Windows.Forms.Button()
        Me.HotBtn = New System.Windows.Forms.Button()
        Me.ColdBtn = New System.Windows.Forms.Button()
        Me.BtnSnack = New System.Windows.Forms.Button()
        Me.BtnCandy = New System.Windows.Forms.Button()
        Me.SearchTxtBox = New System.Windows.Forms.TextBox()
        Me.BoxOuterBtnGrp = New System.Windows.Forms.GroupBox()
        Me.BoxSectionTwo = New System.Windows.Forms.GroupBox()
        Me.BoxSectionOne.SuspendLayout()
        Me.BoxSelectItems.SuspendLayout()
        Me.CartCtrlBox.SuspendLayout()
        Me.BoxCartEdit.SuspendLayout()
        Me.BoxSectionThree.SuspendLayout()
        Me.BoxInputFields.SuspendLayout()
        Me.BoxFinish.SuspendLayout()
        Me.CatBox.SuspendLayout()
        Me.BoxSectionTwo.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(3, 104)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(106, 79)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "Add" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Items"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BoxSectionOne
        '
        Me.BoxSectionOne.Controls.Add(Me.BtnCancel)
        Me.BoxSectionOne.Controls.Add(Me.BtnRemove)
        Me.BoxSectionOne.Controls.Add(Me.BtnEdit)
        Me.BoxSectionOne.Controls.Add(Me.BtnAdd)
        Me.BoxSectionOne.Controls.Add(Me.BtnRestock)
        Me.BoxSectionOne.Dock = System.Windows.Forms.DockStyle.Left
        Me.BoxSectionOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxSectionOne.Location = New System.Drawing.Point(0, 0)
        Me.BoxSectionOne.Name = "BoxSectionOne"
        Me.BoxSectionOne.Size = New System.Drawing.Size(112, 844)
        Me.BoxSectionOne.TabIndex = 4
        Me.BoxSectionOne.TabStop = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(3, 341)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(106, 79)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.Location = New System.Drawing.Point(3, 262)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(106, 79)
        Me.BtnRemove.TabIndex = 2
        Me.BtnRemove.Text = "Remove" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Items"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(3, 183)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(106, 79)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.Text = "Edit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Items"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnRestock
        '
        Me.BtnRestock.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRestock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestock.Location = New System.Drawing.Point(3, 25)
        Me.BtnRestock.Name = "BtnRestock"
        Me.BtnRestock.Size = New System.Drawing.Size(106, 79)
        Me.BtnRestock.TabIndex = 3
        Me.BtnRestock.Text = "Restock Items"
        Me.BtnRestock.UseVisualStyleBackColor = True
        '
        'BtnBegin
        '
        Me.BtnBegin.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnBegin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBegin.Location = New System.Drawing.Point(3, 25)
        Me.BtnBegin.Name = "BtnBegin"
        Me.BtnBegin.Size = New System.Drawing.Size(156, 72)
        Me.BtnBegin.TabIndex = 1
        Me.BtnBegin.Text = "Continue"
        Me.BtnBegin.UseVisualStyleBackColor = True
        '
        'BoxSelectItems
        '
        Me.BoxSelectItems.Controls.Add(Me.ListEditQue)
        Me.BoxSelectItems.Controls.Add(Me.CartCtrlBox)
        Me.BoxSelectItems.Controls.Add(Me.BoxCartEdit)
        Me.BoxSelectItems.Dock = System.Windows.Forms.DockStyle.Right
        Me.BoxSelectItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxSelectItems.Location = New System.Drawing.Point(676, 16)
        Me.BoxSelectItems.Name = "BoxSelectItems"
        Me.BoxSelectItems.Size = New System.Drawing.Size(323, 825)
        Me.BoxSelectItems.TabIndex = 2
        Me.BoxSelectItems.TabStop = False
        Me.BoxSelectItems.Text = "Select Items:"
        '
        'ListEditQue
        '
        Me.ListEditQue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListEditQue.FormattingEnabled = True
        Me.ListEditQue.ItemHeight = 24
        Me.ListEditQue.Location = New System.Drawing.Point(115, 25)
        Me.ListEditQue.Name = "ListEditQue"
        Me.ListEditQue.Size = New System.Drawing.Size(205, 697)
        Me.ListEditQue.TabIndex = 23
        '
        'CartCtrlBox
        '
        Me.CartCtrlBox.Controls.Add(Me.CnclBtn)
        Me.CartCtrlBox.Controls.Add(Me.ClrBtn)
        Me.CartCtrlBox.Controls.Add(Me.RemBtn)
        Me.CartCtrlBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.CartCtrlBox.Enabled = False
        Me.CartCtrlBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CartCtrlBox.Location = New System.Drawing.Point(3, 25)
        Me.CartCtrlBox.Name = "CartCtrlBox"
        Me.CartCtrlBox.Size = New System.Drawing.Size(112, 697)
        Me.CartCtrlBox.TabIndex = 16
        Me.CartCtrlBox.TabStop = False
        '
        'CnclBtn
        '
        Me.CnclBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.CnclBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CnclBtn.Location = New System.Drawing.Point(3, 183)
        Me.CnclBtn.Name = "CnclBtn"
        Me.CnclBtn.Size = New System.Drawing.Size(106, 79)
        Me.CnclBtn.TabIndex = 4
        Me.CnclBtn.Text = "Exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cart Edit"
        Me.CnclBtn.UseVisualStyleBackColor = True
        '
        'ClrBtn
        '
        Me.ClrBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ClrBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClrBtn.Location = New System.Drawing.Point(3, 104)
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
        Me.RemBtn.Location = New System.Drawing.Point(3, 25)
        Me.RemBtn.Name = "RemBtn"
        Me.RemBtn.Size = New System.Drawing.Size(106, 79)
        Me.RemBtn.TabIndex = 2
        Me.RemBtn.Text = "Remove"
        Me.RemBtn.UseVisualStyleBackColor = True
        '
        'BoxCartEdit
        '
        Me.BoxCartEdit.Controls.Add(Me.BtnCnclCart)
        Me.BoxCartEdit.Controls.Add(Me.BtnBegin)
        Me.BoxCartEdit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BoxCartEdit.Location = New System.Drawing.Point(3, 722)
        Me.BoxCartEdit.Name = "BoxCartEdit"
        Me.BoxCartEdit.Size = New System.Drawing.Size(317, 100)
        Me.BoxCartEdit.TabIndex = 22
        Me.BoxCartEdit.TabStop = False
        '
        'BtnCnclCart
        '
        Me.BtnCnclCart.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCnclCart.Location = New System.Drawing.Point(158, 25)
        Me.BtnCnclCart.Name = "BtnCnclCart"
        Me.BtnCnclCart.Size = New System.Drawing.Size(156, 72)
        Me.BtnCnclCart.TabIndex = 21
        Me.BtnCnclCart.Text = "Cancel"
        Me.BtnCnclCart.UseVisualStyleBackColor = True
        '
        'LblBarcode
        '
        Me.LblBarcode.AutoSize = True
        Me.LblBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarcode.Location = New System.Drawing.Point(6, 56)
        Me.LblBarcode.Name = "LblBarcode"
        Me.LblBarcode.Size = New System.Drawing.Size(86, 24)
        Me.LblBarcode.TabIndex = 0
        Me.LblBarcode.Text = "Barcode:"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(6, 91)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(66, 24)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Name:"
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice.Location = New System.Drawing.Point(6, 197)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(58, 24)
        Me.LblPrice.TabIndex = 2
        Me.LblPrice.Text = "Price:"
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategory.Location = New System.Drawing.Point(6, 126)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(90, 24)
        Me.LblCategory.TabIndex = 3
        Me.LblCategory.Text = "Category:"
        '
        'LblMaxStock
        '
        Me.LblMaxStock.AutoSize = True
        Me.LblMaxStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaxStock.Location = New System.Drawing.Point(6, 286)
        Me.LblMaxStock.Name = "LblMaxStock"
        Me.LblMaxStock.Size = New System.Drawing.Size(102, 24)
        Me.LblMaxStock.TabIndex = 5
        Me.LblMaxStock.Text = "Max Stock:"
        '
        'LblMiniStock
        '
        Me.LblMiniStock.AutoSize = True
        Me.LblMiniStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMiniStock.Location = New System.Drawing.Point(6, 251)
        Me.LblMiniStock.Name = "LblMiniStock"
        Me.LblMiniStock.Size = New System.Drawing.Size(144, 24)
        Me.LblMiniStock.TabIndex = 6
        Me.LblMiniStock.Text = "Minimum Stock:"
        '
        'LblNowStock
        '
        Me.LblNowStock.AutoSize = True
        Me.LblNowStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNowStock.Location = New System.Drawing.Point(5, 321)
        Me.LblNowStock.Name = "LblNowStock"
        Me.LblNowStock.Size = New System.Drawing.Size(128, 24)
        Me.LblNowStock.TabIndex = 7
        Me.LblNowStock.Text = "Current Stock:"
        '
        'TxtBarcodeFill
        '
        Me.TxtBarcodeFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarcodeFill.Location = New System.Drawing.Point(7, 28)
        Me.TxtBarcodeFill.Name = "TxtBarcodeFill"
        Me.TxtBarcodeFill.Size = New System.Drawing.Size(147, 29)
        Me.TxtBarcodeFill.TabIndex = 9
        '
        'TxtNameFill
        '
        Me.TxtNameFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNameFill.Location = New System.Drawing.Point(8, 63)
        Me.TxtNameFill.Name = "TxtNameFill"
        Me.TxtNameFill.Size = New System.Drawing.Size(147, 29)
        Me.TxtNameFill.TabIndex = 11
        '
        'TxtMiniStockFill
        '
        Me.TxtMiniStockFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMiniStockFill.Location = New System.Drawing.Point(6, 223)
        Me.TxtMiniStockFill.Name = "TxtMiniStockFill"
        Me.TxtMiniStockFill.Size = New System.Drawing.Size(147, 29)
        Me.TxtMiniStockFill.TabIndex = 13
        '
        'TxtNowStockFill
        '
        Me.TxtNowStockFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNowStockFill.Location = New System.Drawing.Point(5, 293)
        Me.TxtNowStockFill.Name = "TxtNowStockFill"
        Me.TxtNowStockFill.Size = New System.Drawing.Size(148, 29)
        Me.TxtNowStockFill.TabIndex = 14
        '
        'CmboCatFill
        '
        Me.CmboCatFill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboCatFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmboCatFill.FormattingEnabled = True
        Me.CmboCatFill.Items.AddRange(New Object() {"------", "Candy", "Snack", "ColdFood", "HotFood", "Beverage", "Alcohol", "Cigarettes", "Supplies", "Other"})
        Me.CmboCatFill.Location = New System.Drawing.Point(8, 98)
        Me.CmboCatFill.Name = "CmboCatFill"
        Me.CmboCatFill.Size = New System.Drawing.Size(147, 32)
        Me.CmboCatFill.TabIndex = 16
        '
        'BoxSectionThree
        '
        Me.BoxSectionThree.Controls.Add(Me.BoxInputFields)
        Me.BoxSectionThree.Controls.Add(Me.LblAgeReq)
        Me.BoxSectionThree.Controls.Add(Me.RdBtnSet)
        Me.BoxSectionThree.Controls.Add(Me.LblIncreaseStock)
        Me.BoxSectionThree.Controls.Add(Me.BoxFinish)
        Me.BoxSectionThree.Controls.Add(Me.LblMaxStock)
        Me.BoxSectionThree.Controls.Add(Me.LblMiniStock)
        Me.BoxSectionThree.Controls.Add(Me.LblCategory)
        Me.BoxSectionThree.Controls.Add(Me.RdBtnIncrease)
        Me.BoxSectionThree.Controls.Add(Me.LblNowStock)
        Me.BoxSectionThree.Controls.Add(Me.LblPrice)
        Me.BoxSectionThree.Controls.Add(Me.LblName)
        Me.BoxSectionThree.Controls.Add(Me.LblBarcode)
        Me.BoxSectionThree.Dock = System.Windows.Forms.DockStyle.Right
        Me.BoxSectionThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxSectionThree.Location = New System.Drawing.Point(1114, 0)
        Me.BoxSectionThree.Name = "BoxSectionThree"
        Me.BoxSectionThree.Size = New System.Drawing.Size(323, 844)
        Me.BoxSectionThree.TabIndex = 17
        Me.BoxSectionThree.TabStop = False
        '
        'BoxInputFields
        '
        Me.BoxInputFields.Controls.Add(Me.TxtBarcodeFill)
        Me.BoxInputFields.Controls.Add(Me.TxtNameFill)
        Me.BoxInputFields.Controls.Add(Me.TxtAgeReqFill)
        Me.BoxInputFields.Controls.Add(Me.TxtMiniStockFill)
        Me.BoxInputFields.Controls.Add(Me.TxtNowStockFill)
        Me.BoxInputFields.Controls.Add(Me.CmboCatFill)
        Me.BoxInputFields.Controls.Add(Me.TxtMaxStockFill)
        Me.BoxInputFields.Controls.Add(Me.TxtPriceFill)
        Me.BoxInputFields.Controls.Add(Me.TxtStockFill)
        Me.BoxInputFields.Location = New System.Drawing.Point(160, 25)
        Me.BoxInputFields.Name = "BoxInputFields"
        Me.BoxInputFields.Size = New System.Drawing.Size(160, 372)
        Me.BoxInputFields.TabIndex = 36
        Me.BoxInputFields.TabStop = False
        '
        'TxtAgeReqFill
        '
        Me.TxtAgeReqFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAgeReqFill.Location = New System.Drawing.Point(7, 134)
        Me.TxtAgeReqFill.Name = "TxtAgeReqFill"
        Me.TxtAgeReqFill.Size = New System.Drawing.Size(147, 29)
        Me.TxtAgeReqFill.TabIndex = 35
        '
        'TxtMaxStockFill
        '
        Me.TxtMaxStockFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMaxStockFill.Location = New System.Drawing.Point(6, 258)
        Me.TxtMaxStockFill.Name = "TxtMaxStockFill"
        Me.TxtMaxStockFill.Size = New System.Drawing.Size(147, 29)
        Me.TxtMaxStockFill.TabIndex = 17
        '
        'TxtPriceFill
        '
        Me.TxtPriceFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPriceFill.Location = New System.Drawing.Point(6, 169)
        Me.TxtPriceFill.Name = "TxtPriceFill"
        Me.TxtPriceFill.Size = New System.Drawing.Size(147, 29)
        Me.TxtPriceFill.TabIndex = 18
        '
        'TxtStockFill
        '
        Me.TxtStockFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStockFill.Location = New System.Drawing.Point(7, 330)
        Me.TxtStockFill.Name = "TxtStockFill"
        Me.TxtStockFill.Size = New System.Drawing.Size(148, 29)
        Me.TxtStockFill.TabIndex = 24
        '
        'LblAgeReq
        '
        Me.LblAgeReq.AutoSize = True
        Me.LblAgeReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgeReq.Location = New System.Drawing.Point(6, 162)
        Me.LblAgeReq.Name = "LblAgeReq"
        Me.LblAgeReq.Size = New System.Drawing.Size(99, 24)
        Me.LblAgeReq.TabIndex = 34
        Me.LblAgeReq.Text = "Age Reqs:"
        '
        'RdBtnSet
        '
        Me.RdBtnSet.AutoSize = True
        Me.RdBtnSet.Location = New System.Drawing.Point(32, 411)
        Me.RdBtnSet.Name = "RdBtnSet"
        Me.RdBtnSet.Size = New System.Drawing.Size(106, 28)
        Me.RdBtnSet.TabIndex = 25
        Me.RdBtnSet.TabStop = True
        Me.RdBtnSet.Text = "Set Stock"
        Me.RdBtnSet.UseVisualStyleBackColor = True
        '
        'LblIncreaseStock
        '
        Me.LblIncreaseStock.AutoSize = True
        Me.LblIncreaseStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIncreaseStock.Location = New System.Drawing.Point(7, 358)
        Me.LblIncreaseStock.Name = "LblIncreaseStock"
        Me.LblIncreaseStock.Size = New System.Drawing.Size(121, 24)
        Me.LblIncreaseStock.TabIndex = 23
        Me.LblIncreaseStock.Text = "Add to Stock:"
        '
        'BoxFinish
        '
        Me.BoxFinish.Controls.Add(Me.BtnFinished)
        Me.BoxFinish.Controls.Add(Me.BtnExitFieldEdit)
        Me.BoxFinish.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BoxFinish.Location = New System.Drawing.Point(3, 741)
        Me.BoxFinish.Name = "BoxFinish"
        Me.BoxFinish.Size = New System.Drawing.Size(317, 100)
        Me.BoxFinish.TabIndex = 21
        Me.BoxFinish.TabStop = False
        '
        'BtnFinished
        '
        Me.BtnFinished.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnFinished.Location = New System.Drawing.Point(3, 25)
        Me.BtnFinished.Name = "BtnFinished"
        Me.BtnFinished.Size = New System.Drawing.Size(156, 72)
        Me.BtnFinished.TabIndex = 19
        Me.BtnFinished.Text = "Complete"
        Me.BtnFinished.UseVisualStyleBackColor = True
        '
        'BtnExitFieldEdit
        '
        Me.BtnExitFieldEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnExitFieldEdit.Location = New System.Drawing.Point(158, 25)
        Me.BtnExitFieldEdit.Name = "BtnExitFieldEdit"
        Me.BtnExitFieldEdit.Size = New System.Drawing.Size(156, 72)
        Me.BtnExitFieldEdit.TabIndex = 20
        Me.BtnExitFieldEdit.Text = "Cancel"
        Me.BtnExitFieldEdit.UseVisualStyleBackColor = True
        '
        'RdBtnIncrease
        '
        Me.RdBtnIncrease.AutoSize = True
        Me.RdBtnIncrease.Location = New System.Drawing.Point(160, 411)
        Me.RdBtnIncrease.Name = "RdBtnIncrease"
        Me.RdBtnIncrease.Size = New System.Drawing.Size(134, 28)
        Me.RdBtnIncrease.TabIndex = 26
        Me.RdBtnIncrease.TabStop = True
        Me.RdBtnIncrease.Text = "Add to Stock"
        Me.RdBtnIncrease.UseVisualStyleBackColor = True
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
        Me.CatBox.Location = New System.Drawing.Point(3, 16)
        Me.CatBox.Name = "CatBox"
        Me.CatBox.Size = New System.Drawing.Size(112, 825)
        Me.CatBox.TabIndex = 4
        Me.CatBox.TabStop = False
        '
        'BtnOther
        '
        Me.BtnOther.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOther.Location = New System.Drawing.Point(3, 686)
        Me.BtnOther.Name = "BtnOther"
        Me.BtnOther.Size = New System.Drawing.Size(106, 79)
        Me.BtnOther.TabIndex = 20
        Me.BtnOther.Text = "Other"
        Me.BtnOther.UseVisualStyleBackColor = True
        '
        'BtnSupply
        '
        Me.BtnSupply.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSupply.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSupply.Location = New System.Drawing.Point(3, 607)
        Me.BtnSupply.Name = "BtnSupply"
        Me.BtnSupply.Size = New System.Drawing.Size(106, 79)
        Me.BtnSupply.TabIndex = 8
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
        Me.CigBtn.TabIndex = 7
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
        Me.AlcoholBtn.TabIndex = 6
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
        Me.BeverageBtn.TabIndex = 5
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
        Me.HotBtn.TabIndex = 3
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
        Me.ColdBtn.TabIndex = 2
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
        Me.BtnSnack.TabIndex = 10
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
        Me.BtnCandy.TabIndex = 9
        Me.BtnCandy.Text = "Candy"
        Me.BtnCandy.UseVisualStyleBackColor = True
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
        'BoxOuterBtnGrp
        '
        Me.BoxOuterBtnGrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxOuterBtnGrp.Location = New System.Drawing.Point(115, 16)
        Me.BoxOuterBtnGrp.Name = "BoxOuterBtnGrp"
        Me.BoxOuterBtnGrp.Size = New System.Drawing.Size(561, 825)
        Me.BoxOuterBtnGrp.TabIndex = 0
        Me.BoxOuterBtnGrp.TabStop = False
        '
        'BoxSectionTwo
        '
        Me.BoxSectionTwo.Controls.Add(Me.BoxOuterBtnGrp)
        Me.BoxSectionTwo.Controls.Add(Me.BoxSelectItems)
        Me.BoxSectionTwo.Controls.Add(Me.CatBox)
        Me.BoxSectionTwo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxSectionTwo.Location = New System.Drawing.Point(112, 0)
        Me.BoxSectionTwo.Name = "BoxSectionTwo"
        Me.BoxSectionTwo.Size = New System.Drawing.Size(1002, 844)
        Me.BoxSectionTwo.TabIndex = 0
        Me.BoxSectionTwo.TabStop = False
        '
        'FormInventoryManip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1437, 844)
        Me.Controls.Add(Me.BoxSectionTwo)
        Me.Controls.Add(Me.BoxSectionOne)
        Me.Controls.Add(Me.BoxSectionThree)
        Me.Name = "FormInventoryManip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormInventoryManip"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BoxSectionOne.ResumeLayout(False)
        Me.BoxSelectItems.ResumeLayout(False)
        Me.CartCtrlBox.ResumeLayout(False)
        Me.BoxCartEdit.ResumeLayout(False)
        Me.BoxSectionThree.ResumeLayout(False)
        Me.BoxSectionThree.PerformLayout()
        Me.BoxInputFields.ResumeLayout(False)
        Me.BoxInputFields.PerformLayout()
        Me.BoxFinish.ResumeLayout(False)
        Me.CatBox.ResumeLayout(False)
        Me.CatBox.PerformLayout()
        Me.BoxSectionTwo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BoxSectionOne As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBegin As System.Windows.Forms.Button
    Friend WithEvents BoxSelectItems As System.Windows.Forms.GroupBox
    Friend WithEvents LblBarcode As System.Windows.Forms.Label
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents LblPrice As System.Windows.Forms.Label
    Friend WithEvents LblCategory As System.Windows.Forms.Label
    Friend WithEvents LblMaxStock As System.Windows.Forms.Label
    Friend WithEvents LblMiniStock As System.Windows.Forms.Label
    Friend WithEvents LblNowStock As System.Windows.Forms.Label
    Friend WithEvents TxtBarcodeFill As System.Windows.Forms.TextBox
    Friend WithEvents TxtNameFill As System.Windows.Forms.TextBox
    Friend WithEvents TxtMiniStockFill As System.Windows.Forms.TextBox
    Friend WithEvents TxtNowStockFill As System.Windows.Forms.TextBox
    Friend WithEvents CmboCatFill As System.Windows.Forms.ComboBox
    Friend WithEvents BoxSectionThree As System.Windows.Forms.GroupBox
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnRestock As System.Windows.Forms.Button
    Friend WithEvents CatBox As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCandy As System.Windows.Forms.Button
    Friend WithEvents BtnSupply As System.Windows.Forms.Button
    Friend WithEvents CigBtn As System.Windows.Forms.Button
    Friend WithEvents AlcoholBtn As System.Windows.Forms.Button
    Friend WithEvents BeverageBtn As System.Windows.Forms.Button
    Friend WithEvents HotBtn As System.Windows.Forms.Button
    Friend WithEvents ColdBtn As System.Windows.Forms.Button
    Friend WithEvents SearchTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents TxtPriceFill As System.Windows.Forms.TextBox
    Friend WithEvents TxtMaxStockFill As System.Windows.Forms.TextBox
    Friend WithEvents BoxOuterBtnGrp As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Private WithEvents CartCtrlBox As System.Windows.Forms.GroupBox
    Friend WithEvents CnclBtn As System.Windows.Forms.Button
    Friend WithEvents ClrBtn As System.Windows.Forms.Button
    Friend WithEvents RemBtn As System.Windows.Forms.Button
    Friend WithEvents BoxFinish As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFinished As System.Windows.Forms.Button
    Friend WithEvents BtnExitFieldEdit As System.Windows.Forms.Button
    Friend WithEvents BoxCartEdit As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCnclCart As System.Windows.Forms.Button
    Friend WithEvents LblIncreaseStock As System.Windows.Forms.Label
    Friend WithEvents TxtStockFill As System.Windows.Forms.TextBox
    Friend WithEvents RdBtnIncrease As System.Windows.Forms.RadioButton
    Friend WithEvents RdBtnSet As System.Windows.Forms.RadioButton
    Friend WithEvents BoxSectionTwo As System.Windows.Forms.GroupBox
    Friend WithEvents ListEditQue As System.Windows.Forms.ListBox
    Friend WithEvents LblAgeReq As System.Windows.Forms.Label
    Friend WithEvents TxtAgeReqFill As System.Windows.Forms.TextBox
    Friend WithEvents BoxInputFields As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSnack As System.Windows.Forms.Button
    Friend WithEvents BtnOther As System.Windows.Forms.Button
End Class
