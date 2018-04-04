Imports DreamStore_5335.DAL
Public Class SaleListForm
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim form As SaleAddForm = New SaleAddForm
        form.Show()
    End Sub

    Private Sub SaleListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        Me.MdiParent = My.Forms.ParentForm
    End Sub

    Public Sub RefreshData()
        dgv.DataMember = ""
        dgv.DataSource = Nothing
        Dim saleList As SaleList = New SaleList
        dgv.DataSource = saleList.GetAllSales
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Please select a consignment")
        Else
            Dim s As Sale = CType(dgv.SelectedRows.Item(0).DataBoundItem, Sale)
            Dim manager As SaleManager = New SaleManager
            manager.Delete(s.Id)
            RefreshData()
        End If
    End Sub
End Class