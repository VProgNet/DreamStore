' importing of namespases of of Database access layer
Imports DreamStore_5335.DAL

Public Class ConsignmentEditForm

    Private _consignment As Consignment
    Public Property Consignment() As Consignment
        Get
            Return _consignment
        End Get
        Set(ByVal value As Consignment)
            _consignment = value
        End Set
    End Property

    'need for control form widgets
    Private _mode As FormMode
    Public Property Mode() As FormMode
        Get
            Return _mode
        End Get
        Set(ByVal value As FormMode)
            _mode = value
        End Set
    End Property

    Public Sub CreateNewConsignment()
        Mode = FormMode.CreateNew
        Me.Consignment = New Consignment
        InitializeControls()
        'if new consignment, calc Remaining from amount
        Me.lblRemaining.Visible = False
        Me.tbxRemaining.Visible = False
        'setting parent form
        Me.MdiParent = My.Forms.ParentForm
        Me.Show()
    End Sub

    'update of existing consignment
    Public Sub UpdateConsignment(ByVal consignment As Consignment)
        Mode = FormMode.Update
        Me.Consignment = consignment
        InitializeControls()
        ShowConsignmentInControls()
        Me.MdiParent = My.Forms.ParentForm
        Me.Show()
    End Sub

    Private Sub InitializeControls()

    End Sub

    'setting widgets data for update existing consignment
    Private Sub ShowConsignmentInControls()
        tbxVendor.Text = _consignment.Vendor
        dtpExpDate.Value = _consignment.ExpDate
        tbxAmount.Text = _consignment.Amount
        tbxRemaining.Text = _consignment.Remaining
        tbxPrice.Text = _consignment.Price
    End Sub

    'for addinf info from user input
    Private Sub GrabUserInput()
        _consignment.Vendor = tbxVendor.Text
        _consignment.ExpDate = dtpExpDate.Value
        _consignment.Amount = tbxAmount.Text
        If Mode = FormMode.CreateNew Then
            tbxRemaining.Text = tbxAmount.Text
        End If

        _consignment.Remaining = tbxRemaining.Text
        _consignment.Price = tbxPrice.Text
    End Sub

#Region "form buttons"
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close() 'close form
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'save info to db
            GrabUserInput()
            Dim manager As ConsignmentManager = New ConsignmentManager
            If _mode = FormMode.CreateNew Then
                manager.Create(_consignment)
            Else
                manager.Update(_consignment)
            End If
            Me.Close()
            My.Forms.ConsignmentListForm.RefreshData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ConsignmentEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region
End Class
