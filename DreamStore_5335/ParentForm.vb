Imports DreamStore_5335.DAL
Public Class ParentForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        My.Forms.ParentForm.Close() 'closing of parent form
    End Sub

    Private Sub NewConsignmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewConsignmentToolStripMenuItem.Click
        Dim ConsAddForm As ConsignmentEditForm = New ConsignmentEditForm 'creating ConsignmentEditForm class object consAddForm 
        ConsAddForm.CreateNewConsignment()  'for creating new consignment
    End Sub

    Private Sub AllConsignmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllConsignmentsToolStripMenuItem.Click
        My.Forms.ConsignmentListForm.Show() 'showing consignmentList form
    End Sub

    Private Sub AllSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllSalesToolStripMenuItem.Click
        My.Forms.SaleListForm.Show() 'showing saleList form
    End Sub

    Private Sub FindConsignmentByIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindConsignmentByIDToolStripMenuItem.Click
        Dim form As FastSearch = New FastSearch
        form.Show() 'showing FastSearch form
    End Sub

    Private Sub NewSaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSaleToolStripMenuItem.Click
        Dim form As SaleAddForm = New SaleAddForm
        form.Show() 'showing SaleAdd form
    End Sub
End Class
