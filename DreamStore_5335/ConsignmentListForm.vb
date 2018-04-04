' importing of namespases of of Database access layer
Imports DreamStore_5335.DAL
Public Class ConsignmentListForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ConsAddForm As ConsignmentEditForm = New ConsignmentEditForm
        ConsAddForm.CreateNewConsignment()
    End Sub

    Private Sub ConsignmentListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        Me.MdiParent = My.Forms.ParentForm 'setting parent form

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData() 'refreshing data
    End Sub

    Public Sub RefreshData()
        dgv.DataMember = ""
        dgv.DataSource = Nothing ' set data source of dgv to null
        Dim consignments As ConsignmentList = New ConsignmentList
        dgv.DataSource = consignments.GetAllConsignments ' set all consignments to dgv
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        'get sorting attribute
        If cbxSort.SelectedIndex < 0 Then
            MsgBox("Please select an option")
        Else
            Dim selectedAttribute As ConsignmentAttribute
            Select Case cbxSort.SelectedIndex
                Case 0
                    selectedAttribute = ConsignmentAttribute.Id
                Case 1
                    selectedAttribute = ConsignmentAttribute.Vendor
                Case 2
                    selectedAttribute = ConsignmentAttribute.ExpDate
                Case 3
                    selectedAttribute = ConsignmentAttribute.Price
                Case 4
                    selectedAttribute = ConsignmentAttribute.Amount
                Case 5
                    selectedAttribute = ConsignmentAttribute.Remaining
            End Select

            dgv.DataMember = ""
            dgv.DataSource = Nothing
            'setting sorted list 
            Dim consignments As ConsignmentList = New ConsignmentList
            dgv.DataSource = consignments.Sort(selectedAttribute)

        End If
    End Sub

    Public Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'get find attribute
        If cbxSearch.SelectedIndex < 0 Then
            MsgBox("Please select an option")
        ElseIf String.IsNullOrWhiteSpace(tbxSearch.Text) Then
            MsgBox("Please enter the value to search for")
        Else
            Dim selectedAttribute As ConsignmentAttribute
            Select Case cbxSearch.SelectedIndex
                Case 0
                    selectedAttribute = ConsignmentAttribute.Id
                Case 1
                    selectedAttribute = ConsignmentAttribute.Vendor
                Case 2
                    selectedAttribute = ConsignmentAttribute.ExpDate
                Case 3
                    selectedAttribute = ConsignmentAttribute.Price
            End Select


            'setting search result
            Dim consignments As ConsignmentList = New ConsignmentList
            Dim searchResult As Consignment = consignments.Search(tbxSearch.Text, selectedAttribute)

            If searchResult Is Nothing Then
                MsgBox("No such consignment found")
            Else
                dgv.DataMember = ""
                dgv.DataSource = Nothing
                Dim result As List(Of Consignment) = New List(Of Consignment)
                result.Add(searchResult)
                dgv.DataSource = result
            End If
        End If
    End Sub

    'changing of selected consignment
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Please select a consignment")
        Else
            'converting selected row in dgv to consignment class
            Dim c As Consignment = CType(dgv.SelectedRows.Item(0).DataBoundItem, Consignment)
            Dim ConsAddForm As ConsignmentEditForm = New ConsignmentEditForm
            ConsAddForm.UpdateConsignment(c) 'update selected consignment
        End If

    End Sub

    'deletion of selected consignment
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Please select a consignment")
        Else
            Dim c As Consignment = CType(dgv.SelectedRows.Item(0).DataBoundItem, Consignment)
            Dim manager As ConsignmentManager = New ConsignmentManager
            manager.Delete(c.Id)
            RefreshData()
        End If
    End Sub

End Class