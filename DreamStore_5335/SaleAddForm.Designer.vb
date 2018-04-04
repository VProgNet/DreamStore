<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleAddForm
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
        Me.components = New System.ComponentModel.Container()
        Me.tbxAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveSale = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudExpDays = New System.Windows.Forms.NumericUpDown()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.LineTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxClient = New System.Windows.Forms.TextBox()
        Me.dtpSaleDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxOrderTotal = New System.Windows.Forms.TextBox()
        Me.btnSaveAndUpdate = New System.Windows.Forms.Button()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemainingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToTakeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExplanationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemainingAfterSaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleCompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.nudExpDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleCompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbxAmount
        '
        Me.tbxAmount.Location = New System.Drawing.Point(105, 74)
        Me.tbxAmount.Name = "tbxAmount"
        Me.tbxAmount.Size = New System.Drawing.Size(100, 20)
        Me.tbxAmount.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Amount in tons"
        '
        'btnSaveSale
        '
        Me.btnSaveSale.Location = New System.Drawing.Point(344, 72)
        Me.btnSaveSale.Name = "btnSaveSale"
        Me.btnSaveSale.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveSale.TabIndex = 3
        Me.btnSaveSale.Text = "Save sale"
        Me.btnSaveSale.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Expiry time in days"
        '
        'nudExpDays
        '
        Me.nudExpDays.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nudExpDays.Location = New System.Drawing.Point(118, 331)
        Me.nudExpDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudExpDays.Name = "nudExpDays"
        Me.nudExpDays.Size = New System.Drawing.Size(37, 20)
        Me.nudExpDays.TabIndex = 6
        Me.nudExpDays.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ExpDateDataGridViewTextBoxColumn, Me.RemainingDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.ToTakeDataGridViewTextBoxColumn, Me.ExplanationDataGridViewTextBoxColumn, Me.RemainingAfterSaleDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.LineTotal, Me.VendorDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.SaleCompositionBindingSource
        Me.dgv.Location = New System.Drawing.Point(22, 101)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(877, 219)
        Me.dgv.TabIndex = 7
        '
        'LineTotal
        '
        Me.LineTotal.DataPropertyName = "LineTotal"
        Me.LineTotal.HeaderText = "Line Total"
        Me.LineTotal.Name = "LineTotal"
        Me.LineTotal.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Client Name"
        '
        'tbxClient
        '
        Me.tbxClient.Location = New System.Drawing.Point(105, 16)
        Me.tbxClient.Name = "tbxClient"
        Me.tbxClient.Size = New System.Drawing.Size(100, 20)
        Me.tbxClient.TabIndex = 9
        '
        'dtpSaleDate
        '
        Me.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSaleDate.Location = New System.Drawing.Point(105, 48)
        Me.dtpSaleDate.Name = "dtpSaleDate"
        Me.dtpSaleDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpSaleDate.TabIndex = 10
        Me.dtpSaleDate.Value = New Date(2018, 1, 15, 19, 27, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Date of sale"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(701, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Order Total"
        '
        'tbxOrderTotal
        '
        Me.tbxOrderTotal.Location = New System.Drawing.Point(767, 335)
        Me.tbxOrderTotal.Name = "tbxOrderTotal"
        Me.tbxOrderTotal.ReadOnly = True
        Me.tbxOrderTotal.Size = New System.Drawing.Size(100, 20)
        Me.tbxOrderTotal.TabIndex = 13
        '
        'btnSaveAndUpdate
        '
        Me.btnSaveAndUpdate.Location = New System.Drawing.Point(211, 72)
        Me.btnSaveAndUpdate.Name = "btnSaveAndUpdate"
        Me.btnSaveAndUpdate.Size = New System.Drawing.Size(127, 23)
        Me.btnSaveAndUpdate.TabIndex = 14
        Me.btnSaveAndUpdate.Text = "Save sale and Update remaining"
        Me.btnSaveAndUpdate.UseVisualStyleBackColor = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Consignment No"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExpDateDataGridViewTextBoxColumn
        '
        Me.ExpDateDataGridViewTextBoxColumn.DataPropertyName = "ExpDate"
        Me.ExpDateDataGridViewTextBoxColumn.HeaderText = "Expiry date"
        Me.ExpDateDataGridViewTextBoxColumn.Name = "ExpDateDataGridViewTextBoxColumn"
        Me.ExpDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemainingDataGridViewTextBoxColumn
        '
        Me.RemainingDataGridViewTextBoxColumn.DataPropertyName = "Remaining"
        Me.RemainingDataGridViewTextBoxColumn.HeaderText = "Remaining"
        Me.RemainingDataGridViewTextBoxColumn.Name = "RemainingDataGridViewTextBoxColumn"
        Me.RemainingDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ToTakeDataGridViewTextBoxColumn
        '
        Me.ToTakeDataGridViewTextBoxColumn.DataPropertyName = "ToTake"
        Me.ToTakeDataGridViewTextBoxColumn.HeaderText = "To take"
        Me.ToTakeDataGridViewTextBoxColumn.Name = "ToTakeDataGridViewTextBoxColumn"
        Me.ToTakeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExplanationDataGridViewTextBoxColumn
        '
        Me.ExplanationDataGridViewTextBoxColumn.DataPropertyName = "Explanation"
        Me.ExplanationDataGridViewTextBoxColumn.HeaderText = "Explanation"
        Me.ExplanationDataGridViewTextBoxColumn.Name = "ExplanationDataGridViewTextBoxColumn"
        Me.ExplanationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemainingAfterSaleDataGridViewTextBoxColumn
        '
        Me.RemainingAfterSaleDataGridViewTextBoxColumn.DataPropertyName = "RemainingAfterSale"
        Me.RemainingAfterSaleDataGridViewTextBoxColumn.HeaderText = "Remaining after sale"
        Me.RemainingAfterSaleDataGridViewTextBoxColumn.Name = "RemainingAfterSaleDataGridViewTextBoxColumn"
        Me.RemainingAfterSaleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.AmountDataGridViewTextBoxColumn.Visible = False
        '
        'VendorDataGridViewTextBoxColumn
        '
        Me.VendorDataGridViewTextBoxColumn.DataPropertyName = "Vendor"
        Me.VendorDataGridViewTextBoxColumn.HeaderText = "Vendor"
        Me.VendorDataGridViewTextBoxColumn.Name = "VendorDataGridViewTextBoxColumn"
        Me.VendorDataGridViewTextBoxColumn.ReadOnly = True
        Me.VendorDataGridViewTextBoxColumn.Visible = False
        '
        'SaleCompositionBindingSource
        '
        Me.SaleCompositionBindingSource.DataSource = GetType(DreamStore_5335.DAL.SaleComposition)
        '
        'SaleAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 393)
        Me.Controls.Add(Me.btnSaveAndUpdate)
        Me.Controls.Add(Me.tbxOrderTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpSaleDate)
        Me.Controls.Add(Me.tbxClient)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.nudExpDays)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSaveSale)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxAmount)
        Me.Name = "SaleAddForm"
        Me.Text = "SaleAddForm"
        CType(Me.nudExpDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleCompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveSale As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents nudExpDays As NumericUpDown
    Friend WithEvents dgv As DataGridView
    Friend WithEvents SaleCompositionBindingSource As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxClient As TextBox
    Friend WithEvents dtpSaleDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemainingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToTakeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExplanationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemainingAfterSaleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LineTotal As DataGridViewTextBoxColumn
    Friend WithEvents VendorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxOrderTotal As TextBox
    Friend WithEvents btnSaveAndUpdate As Button
End Class
