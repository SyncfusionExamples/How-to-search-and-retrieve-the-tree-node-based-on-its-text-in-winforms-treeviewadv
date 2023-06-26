Imports Microsoft.VisualBasic
Namespace TreeViewAdvSearchDemo
    Partial Public Class TreeViewAdvSearchDemo
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim treeNodeAdv1 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv2 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv3 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv4 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv5 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv6 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv7 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv8 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv9 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv10 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv11 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv12 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv13 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv14 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv15 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TreeViewAdvSearchDemo))
            Me.treeViewAdv1 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv()
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.panel1 = New System.Windows.Forms.Panel()
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' treeViewAdv1
            ' 
            Me.treeViewAdv1.BeforeTouchSize = New System.Drawing.Size(312, 455)
            Me.treeViewAdv1.CanSelectDisabledNode = False
            Me.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill
            ' 
            ' 
            ' 
            Me.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.HelpTextControl.Location = New System.Drawing.Point(0, 0)
            Me.treeViewAdv1.HelpTextControl.Name = "helpText"
            Me.treeViewAdv1.HelpTextControl.Size = New System.Drawing.Size(49, 15)
            Me.treeViewAdv1.HelpTextControl.TabIndex = 0
            Me.treeViewAdv1.HelpTextControl.Text = "help text"
            Me.treeViewAdv1.HotTracking = True
            Me.treeViewAdv1.Location = New System.Drawing.Point(0, 0)
            Me.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
            Me.treeViewAdv1.Name = "treeViewAdv1"
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv1.EnsureDefaultOptionedChild = True
            treeNodeAdv1.Expanded = True
            treeNodeAdv1.MultiLine = True
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv2.EnsureDefaultOptionedChild = True
            treeNodeAdv2.Expanded = True
            treeNodeAdv2.MultiLine = True
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv3.EnsureDefaultOptionedChild = True
            treeNodeAdv3.Expanded = True
            treeNodeAdv3.MultiLine = True
            treeNodeAdv3.Optioned = True
            treeNodeAdv3.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv3.ShowLine = True
            treeNodeAdv3.Text = "Mumbai"
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv4.EnsureDefaultOptionedChild = True
            treeNodeAdv4.MultiLine = True
            treeNodeAdv4.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv4.ShowLine = True
            treeNodeAdv4.Text = "Kolkata"
            treeNodeAdv2.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {treeNodeAdv3, treeNodeAdv4})
            treeNodeAdv2.Optioned = True
            treeNodeAdv2.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv2.ShowLine = True
            treeNodeAdv2.Text = "Chennai"
            treeNodeAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {treeNodeAdv2})
            treeNodeAdv1.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv1.ShowLine = True
            treeNodeAdv1.Text = "India"
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv5.EnsureDefaultOptionedChild = True
            treeNodeAdv5.Expanded = True
            treeNodeAdv5.MultiLine = True
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv6.EnsureDefaultOptionedChild = True
            treeNodeAdv6.MultiLine = True
            treeNodeAdv6.Optioned = True
            treeNodeAdv6.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv6.ShowLine = True
            treeNodeAdv6.Text = "California"
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv7.EnsureDefaultOptionedChild = True
            treeNodeAdv7.MultiLine = True
            treeNodeAdv7.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv7.ShowLine = True
            treeNodeAdv7.Text = "NewYork"
            treeNodeAdv5.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {treeNodeAdv6, treeNodeAdv7})
            treeNodeAdv5.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv5.ShowLine = True
            treeNodeAdv5.Text = "USA"
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv8.EnsureDefaultOptionedChild = True
            treeNodeAdv8.Expanded = True
            treeNodeAdv8.MultiLine = True
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv9.EnsureDefaultOptionedChild = True
            treeNodeAdv9.MultiLine = True
            treeNodeAdv9.Optioned = True
            treeNodeAdv9.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv9.ShowLine = True
            treeNodeAdv9.Text = "Beijing"
            treeNodeAdv8.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {treeNodeAdv9})
            treeNodeAdv8.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv8.ShowLine = True
            treeNodeAdv8.Text = "China"
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv10.EnsureDefaultOptionedChild = True
            treeNodeAdv10.Expanded = True
            treeNodeAdv10.MultiLine = True
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv11.EnsureDefaultOptionedChild = True
            treeNodeAdv11.MultiLine = True
            treeNodeAdv11.Optioned = True
            treeNodeAdv11.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv11.ShowLine = True
            treeNodeAdv11.Text = "Alashka"
            treeNodeAdv10.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {treeNodeAdv11})
            treeNodeAdv10.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv10.ShowLine = True
            treeNodeAdv10.Text = "Canada"
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv12.EnsureDefaultOptionedChild = True
            treeNodeAdv12.Expanded = True
            treeNodeAdv12.MultiLine = True
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv13.EnsureDefaultOptionedChild = True
            treeNodeAdv13.MultiLine = True
            treeNodeAdv13.Optioned = True
            treeNodeAdv13.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv13.ShowLine = True
            treeNodeAdv13.Text = "India"
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv14.EnsureDefaultOptionedChild = True
            treeNodeAdv14.MultiLine = True
            treeNodeAdv14.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv14.ShowLine = True
            treeNodeAdv14.Text = "China"
            treeNodeAdv12.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {treeNodeAdv13, treeNodeAdv14})
            treeNodeAdv12.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv12.ShowLine = True
            treeNodeAdv12.Text = "Asia"
            treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv15.EnsureDefaultOptionedChild = True
            treeNodeAdv15.MultiLine = True
            treeNodeAdv15.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv15.ShowLine = True
            treeNodeAdv15.Text = "Indonesia"
            Me.treeViewAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {treeNodeAdv1, treeNodeAdv5, treeNodeAdv8, treeNodeAdv10, treeNodeAdv12, treeNodeAdv15})
            Me.treeViewAdv1.ShowFocusRect = True
            Me.treeViewAdv1.Size = New System.Drawing.Size(312, 455)
            Me.treeViewAdv1.TabIndex = 0
            Me.treeViewAdv1.Text = "treeViewAdv1"
            ' 
            ' 
            ' 
            Me.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
            Me.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.ToolTipControl.Location = New System.Drawing.Point(0, 0)
            Me.treeViewAdv1.ToolTipControl.Name = "toolTip"
            Me.treeViewAdv1.ToolTipControl.Size = New System.Drawing.Size(41, 15)
            Me.treeViewAdv1.ToolTipControl.TabIndex = 1
            Me.treeViewAdv1.ToolTipControl.Text = "toolTip"
            ' 
            ' richTextBox1
            ' 
            Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Right
            Me.richTextBox1.Location = New System.Drawing.Point(312, 0)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(328, 455)
            Me.richTextBox1.TabIndex = 1
            Me.richTextBox1.Text = "Event Log Details"
            ' 
            ' label1
            ' 
            Me.label1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220))))))
            Me.label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label1.ForeColor = System.Drawing.Color.White
            Me.label1.Location = New System.Drawing.Point(0, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(640, 31)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Press Ctrl + F to Load Search window"
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.treeViewAdv1)
            Me.panel1.Controls.Add(Me.richTextBox1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 31)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(640, 455)
            Me.panel1.TabIndex = 3
            ' 
            ' TreeViewAdvSearchDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
            Me.BorderThickness = 2
            Me.ClientSize = New System.Drawing.Size(640, 486)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.label1)
            Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
            Me.Name = "TreeViewAdvSearchDemo"
            Me.Text = "TreeViewAdv Search"
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private treeViewAdv1 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
        Private richTextBox1 As System.Windows.Forms.RichTextBox
        Private label1 As System.Windows.Forms.Label
        Private panel1 As System.Windows.Forms.Panel
    End Class
End Namespace