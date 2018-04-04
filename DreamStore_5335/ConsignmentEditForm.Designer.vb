<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsignmentEditForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.tbxVendor = New System.Windows.Forms.TextBox()
        Me.tbxPrice = New System.Windows.Forms.TextBox()
        Me.tbxAmount = New System.Windows.Forms.TextBox()
        Me.tbxRemaining = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dtpExpDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vendor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Expiry Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Amount"
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.Location = New System.Drawing.Point(12, 69)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(57, 13)
        Me.lblRemaining.TabIndex = 4
        Me.lblRemaining.Text = "Remaining"
        '
        'tbxVendor
        '
        Me.tbxVendor.Location = New System.Drawing.Point(79, 7)
        Me.tbxVendor.Name = "tbxVendor"
        Me.tbxVendor.Size = New System.Drawing.Size(100, 20)
        Me.tbxVendor.TabIndex = 5
        '
        'tbxPrice
        '
        Me.tbxPrice.Location = New System.Drawing.Point(266, 7)
        Me.tbxPrice.Name = "tbxPrice"
        Me.tbxPrice.Size = New System.Drawing.Size(100, 20)
        Me.tbxPrice.TabIndex = 7
        '
        'tbxAmount
        '
        Me.tbxAmount.Location = New System.Drawing.Point(266, 37)
        Me.tbxAmount.Name = "tbxAmount"
        Me.tbxAmount.Size = New System.Drawing.Size(100, 20)
        Me.tbxAmount.TabIndex = 8
        '
        'tbxRemaining
        '
        Me.tbxRemaining.Location = New System.Drawing.Point(79, 66)
        Me.tbxRemaining.Name = "tbxRemaining"
        Me.tbxRemaining.Size = New System.Drawing.Size(100, 20)
        Me.tbxRemaining.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(220, 63)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(301, 63)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dtpExpDate
        '
        Me.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpDate.Location = New System.Drawing.Point(79, 40)
        Me.dtpExpDate.Name = "dtpExpDate"
        Me.dtpExpDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpExpDate.TabIndex = 13
        '
        'ConsignmentEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 124)
        Me.Controls.Add(Me.dtpExpDate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbxRemaining)
        Me.Controls.Add(Me.tbxAmount)
        Me.Controls.Add(Me.tbxPrice)
        Me.Controls.Add(Me.tbxVendor)
        Me.Controls.Add(Me.lblRemaining)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConsignmentEditForm"
        Me.Text = "Add new consignment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRemaining As Label
    Friend WithEvents tbxVendor As TextBox
    Friend WithEvents tbxPrice As TextBox
    Friend WithEvents tbxAmount As TextBox
    Friend WithEvents tbxRemaining As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dtpExpDate As DateTimePicker
End Class
