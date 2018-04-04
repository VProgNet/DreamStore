Imports DreamStore_5335.DAL
Public Class SaleAddForm
    Dim _scm As SaleCompositionManager = New SaleCompositionManager() 'creating obeject of SaleCompositionManager
    Dim _formState As Boolean 'for detecting if form is loaded. For correct event handling from widgets

    Private Sub SaleAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = My.Forms.ParentForm
        _formState = True
        RefreshData()
        ' Derective of preprocessor
        ' There is no need btnSaveSale in release version only in debug, 
        ' too difficult to delete.
#If DEBUG Then
        btnSaveSale.Visible = True
#Else
        btnSaveSale.Visible = False
#End If
    End Sub

    Private Sub SaleAddForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        _formState = False
    End Sub

    Private Sub nudExpDays_ValueChanged(sender As Object, e As EventArgs) Handles nudExpDays.ValueChanged
        RefreshData()
    End Sub


    Private Sub RefreshData()
        Try
            If _formState Then
                'when form is loaded
                Dim amount As Integer
                If tbxAmount.Text = "" Then
                    amount = 0 'for correct call of SetSaleParams procedure
                    _scm.SetSaleParams(amount, dtpSaleDate.Value, nudExpDays.Value, True) '
                Else
                    amount = tbxAmount.Text
                    _scm.SetSaleParams(amount, dtpSaleDate.Value, nudExpDays.Value, False)
                End If

                dgv.DataMember = ""
                dgv.DataSource = Nothing
                dgv.DataSource = _scm.SaleCompositionList

                tbxOrderTotal.Text = _scm.Total
            End If
        Catch ex As Exception
            Me.tbxAmount.Text = ""
            tbxOrderTotal.Text = ""
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dtpSaleDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpSaleDate.ValueChanged
        RefreshData()
    End Sub

    Private Sub tbxAmount_TextChanged(sender As Object, e As EventArgs) Handles tbxAmount.TextChanged
        RefreshData()
    End Sub

    Private Sub btnSaveSale_Click(sender As Object, e As EventArgs) Handles btnSaveSale.Click
        Try
            _scm.MakeSale(tbxClient.Text, dtpSaleDate.Value, Convert.ToInt32(tbxAmount.Text), False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSaveAndUpdate_Click(sender As Object, e As EventArgs) Handles btnSaveAndUpdate.Click
        Try
            _scm.MakeSale(tbxClient.Text, dtpSaleDate.Value, Convert.ToInt32(tbxAmount.Text), True)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            RefreshData()
            My.Forms.ConsignmentListForm.RefreshData()
        End Try
    End Sub

    Private Sub tbxClient_TextChanged(sender As Object, e As EventArgs) Handles tbxClient.TextChanged

    End Sub
End Class