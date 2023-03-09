Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms

Namespace TreeViewAdvSearchDemo

    Partial Public Class TreeViewSearchForm
        Inherits MetroForm
#Region "Variables"

        'Initialize the TreeViewAdvFindReplaceDialog
        Private dialog As TreeViewAdvFindReplaceDialog = Nothing
        'Initialize the TreeViewAdv
        Private TreeView As TreeViewAdv
#End Region

#Region "Consructor"

        'To pass the TreeviewAdv argument to the form.
        Public Sub New(ByVal tree As TreeViewAdv)
            InitializeComponent()
            TreeView = tree
            Me.TreeView.InactiveSelectedNodeBackground = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218)))))))
            'To assign the TreeViewAdv to TreeViewSearchForm            
            dialog = New TreeViewAdvFindReplaceDialog(Me.TreeView)

            'To add the TreeViewSearchRange in ComboBox
            Dim searchRange As Array = System.Enum.GetValues(GetType(TreeViewSearchRange))
            For i As Integer = 0 To searchRange.Length - 1
                Me.SearchRangeCombo.Items.Add(searchRange.GetValue(i))
            Next i

            'To add the TreeViewSearchOption in ComboBox
            Dim SearchOptions As Array = System.Enum.GetValues(GetType(TreeViewSearchOption))
            For i As Integer = 0 To SearchOptions.Length - 1
                Me.SearchOptionCombo.Items.Add(SearchOptions.GetValue(i))
            Next i

            'To add the TreeViewSearchNavigation in ComboBox
            Dim NodeSearchType As Array = System.Enum.GetValues(GetType(TreeViewSearchNavigation))
            For i As Integer = 0 To NodeSearchType.Length - 1
                Me.comboBox3.Items.Add(NodeSearchType.GetValue(i))
            Next i
            AddHandler comboBox3.SelectedIndexChanged, AddressOf comboBox3_SelectedIndexChanged
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.SearchOptionCombo.SelectedIndex = 0
            Me.SearchRangeCombo.SelectedIndex = 0
            Me.comboBox3.SelectedIndex = 1
            Me.findTextBox.Select()
        End Sub
#End Region

#Region "Implementation"

        'To get the TreeViewSearchNavigation
        Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            dialog.TreeViewSearchNavigation = CType(Me.SearchRangeCombo.Items(Me.comboBox3.Items.IndexOf(Me.comboBox3.SelectedItem)), TreeViewSearchNavigation)
        End Sub

        'To get the TreeViewSearchRange
        Private Sub SearchRangeCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles SearchRangeCombo.SelectedIndexChanged
            dialog.TreeViewSearchRange = CType(Me.SearchRangeCombo.Items(Me.SearchRangeCombo.Items.IndexOf(Me.SearchRangeCombo.SelectedItem)), TreeViewSearchRange)
        End Sub

        'To get the TreeViewSearchOption
        Private Sub SearchOptionCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles SearchOptionCombo.SelectedIndexChanged
            dialog.TreeViewSearchOption = CType(Me.SearchOptionCombo.Items(Me.SearchOptionCombo.Items.IndexOf(Me.SearchOptionCombo.SelectedItem)), TreeViewSearchOption)
        End Sub

        Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button5.Click
            Me.Close()
        End Sub

        'To Find TreeNodeAdv
        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            dialog.Find(Me.findTextBox.Text)
        End Sub

        'To Find All the TreeNodeAdv
        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
            dialog.FindAll(Me.findTextBox.Text)
        End Sub

        'To Replace the TreeNodeAdv
        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
            Me.TreeView.SelectedNodes.Clear()
            If dialog.Find(Me.findTextBox.Text) Then
                dialog.Replace(Me.replaceTextbox.Text)
            End If
        End Sub

        'To Replace All the TreeNodeAdv
        Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
            Me.TreeView.SelectedNodes.Clear()
            If dialog.FindAll(Me.findTextBox.Text) Then
                dialog.ReplaceAll(Me.replaceTextbox.Text)
            End If
        End Sub
#End Region
    End Class
End Namespace