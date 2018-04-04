<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewConsignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllConsignmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindConsignmentByIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ConsignmentToolStripMenuItem, Me.SalesToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(362, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ConsignmentToolStripMenuItem
        '
        Me.ConsignmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewConsignmentToolStripMenuItem, Me.AllConsignmentsToolStripMenuItem, Me.FindConsignmentByIDToolStripMenuItem})
        Me.ConsignmentToolStripMenuItem.Name = "ConsignmentToolStripMenuItem"
        Me.ConsignmentToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ConsignmentToolStripMenuItem.Text = "Consignments"
        '
        'NewConsignmentToolStripMenuItem
        '
        Me.NewConsignmentToolStripMenuItem.Name = "NewConsignmentToolStripMenuItem"
        Me.NewConsignmentToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.NewConsignmentToolStripMenuItem.Text = "New consignment"
        '
        'AllConsignmentsToolStripMenuItem
        '
        Me.AllConsignmentsToolStripMenuItem.Name = "AllConsignmentsToolStripMenuItem"
        Me.AllConsignmentsToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AllConsignmentsToolStripMenuItem.Text = "All consignments"
        '
        'FindConsignmentByIDToolStripMenuItem
        '
        Me.FindConsignmentByIDToolStripMenuItem.Name = "FindConsignmentByIDToolStripMenuItem"
        Me.FindConsignmentByIDToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.FindConsignmentByIDToolStripMenuItem.Text = "Find consignment by ID"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSaleToolStripMenuItem, Me.AllSalesToolStripMenuItem})
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'NewSaleToolStripMenuItem
        '
        Me.NewSaleToolStripMenuItem.Name = "NewSaleToolStripMenuItem"
        Me.NewSaleToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.NewSaleToolStripMenuItem.Text = "New Sale"
        '
        'AllSalesToolStripMenuItem
        '
        Me.AllSalesToolStripMenuItem.Name = "AllSalesToolStripMenuItem"
        Me.AllSalesToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AllSalesToolStripMenuItem.Text = "All Sales"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ParentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 285)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ParentForm"
        Me.Text = "Dream Store"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsignmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewConsignmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllConsignmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewSaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllSalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindConsignmentByIDToolStripMenuItem As ToolStripMenuItem
End Class
