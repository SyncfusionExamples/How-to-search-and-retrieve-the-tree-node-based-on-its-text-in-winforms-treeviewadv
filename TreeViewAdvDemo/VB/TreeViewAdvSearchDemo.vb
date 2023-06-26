Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms

Namespace TreeViewAdvSearchDemo
    Partial Public Class TreeViewAdvSearchDemo
        Inherits MetroForm
        'Initialize the TreeViewSearchForm
        Private form As TreeViewSearchForm

#Region "Constructor"

        Public Sub New()
            InitializeComponent()
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
            Me.WindowState = FormWindowState.Normal
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Padding = New Padding(10)
            Me.MinimumSize = Me.Size
            Me.treeViewAdv1.SelectionMode = Tools.TreeSelectionMode.MultiSelectAll
            'To assign the TreeViewAdv to TreeViewSearchForm
            form = New TreeViewSearchForm(Me.treeViewAdv1)
            AddHandler treeViewAdv1.PreviewKeyDown, AddressOf treeViewAdv1_PreviewKeyDown
            Me.treeViewAdv1.HideSelection = False
            Me.richTextBox1.AppendText(Constants.vbLf)
            AddHandler treeViewAdv1.OnNodeAfterFound, AddressOf treeViewAdv1_OnNodeAfterFound
            AddHandler treeViewAdv1.OnNodeBeforeFind, AddressOf treeViewAdv1_OnNodeBeforeFind
            AddHandler treeViewAdv1.OnNodeReplacing, AddressOf treeViewAdv1_OnNodeReplacing
            AddHandler treeViewAdv1.OnNodeReplaced, AddressOf treeViewAdv1_OnNodeReplaced
        End Sub

#End Region

        Private Sub treeViewAdv1_OnNodeAfterFound(ByVal sender As Object, ByVal e As Tools.TreeNodeAdvAfterFindArgs)
            Me.richTextBox1.AppendText(Constants.vbLf & " AfterNodeMatchFound Event Triggered")
        End Sub

        Private Sub treeViewAdv1_OnNodeReplaced(ByVal sender As Object, ByVal e As Tools.TreeNodeAdvOnReplacedArgs)
            Me.richTextBox1.AppendText(Constants.vbLf & " OnNodeTextReplaced Event Triggered")
        End Sub

        Private Sub treeViewAdv1_OnNodeReplacing(ByVal sender As Object, ByVal e As Tools.TreeNodeAdvOnReplacingArgs)
            Me.richTextBox1.AppendText(Constants.vbLf & " OnNodeTextReplacing Event Triggered")
        End Sub

        Private Sub treeViewAdv1_OnNodeBeforeFind(ByVal sender As Object, ByVal e As Tools.TreeNodeAdvBeforeFindArgs)
            Me.richTextBox1.AppendText(Constants.vbLf & " BeforeNodeMatchFound Event Triggered")
        End Sub

        'To show the search dialog
        Private Sub treeViewAdv1_PreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs)
            If e.Modifiers = Keys.Control AndAlso e.KeyValue = Keys.F Then
                form = New TreeViewSearchForm(Me.treeViewAdv1)
                form.ShowDialog()
            End If
        End Sub
    End Class
End Namespace