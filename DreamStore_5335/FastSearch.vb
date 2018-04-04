'implementing new form for fast search by consignment id
Public Class FastSearch
    'setting up form (remove minimize and maximize buttons)
    Private Sub FastSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MinimizeBox = False
        MaximizeBox = False
        Me.MdiParent = My.Forms.ParentForm 'setting parent form for form
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        goAndFind(sender, e) 'calling search function when btnFind pressed
    End Sub
    'implementing shearch procedure
    Private Sub goAndFind(sender As Object, e As EventArgs)
        'Selecting ID in cbxSearch
        My.Forms.ConsignmentListForm.cbxSearch.SelectedIndex = 0 'index of id in cbxSearch
        'Entering ID
        My.Forms.ConsignmentListForm.tbxSearch.Text = tbxFindID.Text 'coping info from tbxFindId in form FastSearch to 
        'tbxSerch in form ConsignmentListForm
        'close form fastSearch and open form consignmentListForm
        Me.Close()
        'Pressing "Search" on consignmentListForm
        My.Forms.ConsignmentListForm.Show()
        My.Forms.ConsignmentListForm.btnSearch_Click(sender, e) 'program pressing on btnSearch in consignmentListForm
    End Sub

    Private Sub tbxFindID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxFindID.KeyPress
        If e.KeyChar = vbCr Then 'if pressed key is "enter" than calling search function
            goAndFind(sender, e)
        End If
    End Sub
End Class