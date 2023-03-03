Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms
Namespace TreeViewAdvSearchDemo
    Partial Public Class TreeViewSearchForm
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TreeViewSearchForm))
            Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
            Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
            Me.replaceTextbox = New System.Windows.Forms.TextBox()
            Me.findTextBox = New System.Windows.Forms.TextBox()
            Me.comboBox3 = New System.Windows.Forms.ComboBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.button5 = New Syncfusion.Windows.Forms.ButtonAdv()
            Me.SearchRangeCombo = New System.Windows.Forms.ComboBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.button4 = New Syncfusion.Windows.Forms.ButtonAdv()
            Me.button3 = New Syncfusion.Windows.Forms.ButtonAdv()
            Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv()
            Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
            Me.SearchOptionCombo = New System.Windows.Forms.ComboBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlAdv1.SuspendLayout()
            Me.tabPageAdv1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' tabControlAdv1
            ' 
            Me.tabControlAdv1.BeforeTouchSize = New System.Drawing.Size(662, 271)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
            Me.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabControlAdv1.Location = New System.Drawing.Point(10, 10)
            Me.tabControlAdv1.Name = "tabControlAdv1"
            Me.tabControlAdv1.Size = New System.Drawing.Size(662, 271)
            Me.tabControlAdv1.TabIndex = 0
            Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.White
            Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererMetro)
            ' 
            ' tabPageAdv1
            ' 
            Me.tabPageAdv1.Controls.Add(Me.replaceTextbox)
            Me.tabPageAdv1.Controls.Add(Me.findTextBox)
            Me.tabPageAdv1.Controls.Add(Me.comboBox3)
            Me.tabPageAdv1.Controls.Add(Me.label5)
            Me.tabPageAdv1.Controls.Add(Me.button5)
            Me.tabPageAdv1.Controls.Add(Me.SearchRangeCombo)
            Me.tabPageAdv1.Controls.Add(Me.label4)
            Me.tabPageAdv1.Controls.Add(Me.button4)
            Me.tabPageAdv1.Controls.Add(Me.button3)
            Me.tabPageAdv1.Controls.Add(Me.button2)
            Me.tabPageAdv1.Controls.Add(Me.button1)
            Me.tabPageAdv1.Controls.Add(Me.SearchOptionCombo)
            Me.tabPageAdv1.Controls.Add(Me.label3)
            Me.tabPageAdv1.Controls.Add(Me.label2)
            Me.tabPageAdv1.Controls.Add(Me.label1)
            Me.tabPageAdv1.Image = Nothing
            Me.tabPageAdv1.ImageSize = New System.Drawing.Size(16, 16)
            Me.tabPageAdv1.Location = New System.Drawing.Point(1, 22)
            Me.tabPageAdv1.Name = "tabPageAdv1"
            Me.tabPageAdv1.ShowCloseButton = True
            Me.tabPageAdv1.Size = New System.Drawing.Size(659, 247)
            Me.tabPageAdv1.TabIndex = 1
            Me.tabPageAdv1.Text = "Search Option"
            Me.tabPageAdv1.ThemesEnabled = False
            ' 
            ' replaceTextbox
            ' 
            Me.replaceTextbox.Location = New System.Drawing.Point(136, 50)
            Me.replaceTextbox.Name = "replaceTextbox"
            Me.replaceTextbox.Size = New System.Drawing.Size(363, 20)
            Me.replaceTextbox.TabIndex = 17
            ' 
            ' findTextBox
            ' 
            Me.findTextBox.Location = New System.Drawing.Point(136, 15)
            Me.findTextBox.Name = "findTextBox"
            Me.findTextBox.Size = New System.Drawing.Size(363, 20)
            Me.findTextBox.TabIndex = 16
            ' 
            ' comboBox3
            ' 
            Me.comboBox3.FormattingEnabled = True
            Me.comboBox3.Location = New System.Drawing.Point(136, 159)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(363, 21)
            Me.comboBox3.TabIndex = 15
            ' 
            ' label5
            ' 
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(23, 162)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(95, 13)
            Me.label5.TabIndex = 14
            Me.label5.Text = "Search Navigation"
            ' 
            ' button5
            ' 
            Me.button5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
            Me.button5.BeforeTouchSize = New System.Drawing.Size(75, 23)
            Me.button5.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.button5.ForeColor = System.Drawing.Color.White
            Me.button5.IsBackStageButton = False
            Me.button5.Location = New System.Drawing.Point(521, 216)
            Me.button5.Name = "button5"
            Me.button5.Size = New System.Drawing.Size(75, 23)
            Me.button5.TabIndex = 13
            Me.button5.Text = "&Done"
            Me.button5.UseVisualStyle = True
            Me.button5.UseVisualStyleBackColor = True
            ' 
            ' SearchRangeCombo
            ' 
            Me.SearchRangeCombo.FormattingEnabled = True
            Me.SearchRangeCombo.Location = New System.Drawing.Point(136, 119)
            Me.SearchRangeCombo.Name = "SearchRangeCombo"
            Me.SearchRangeCombo.Size = New System.Drawing.Size(363, 21)
            Me.SearchRangeCombo.TabIndex = 12
            ' 
            ' label4
            ' 
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(23, 122)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(76, 13)
            Me.label4.TabIndex = 11
            Me.label4.Text = "Search Range"
            ' 
            ' button4
            ' 
            Me.button4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
            Me.button4.BeforeTouchSize = New System.Drawing.Size(75, 23)
            Me.button4.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.button4.ForeColor = System.Drawing.Color.White
            Me.button4.IsBackStageButton = False
            Me.button4.Location = New System.Drawing.Point(424, 216)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(75, 23)
            Me.button4.TabIndex = 10
            Me.button4.Text = "&Replace All"
            Me.button4.UseVisualStyle = True
            Me.button4.UseVisualStyleBackColor = True
            ' 
            ' button3
            ' 
            Me.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
            Me.button3.BeforeTouchSize = New System.Drawing.Size(75, 23)
            Me.button3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.button3.ForeColor = System.Drawing.Color.White
            Me.button3.IsBackStageButton = False
            Me.button3.Location = New System.Drawing.Point(332, 216)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(75, 23)
            Me.button3.TabIndex = 9
            Me.button3.Text = "&Replace"
            Me.button3.UseVisualStyle = True
            Me.button3.UseVisualStyleBackColor = True
            ' 
            ' button2
            ' 
            Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
            Me.button2.BeforeTouchSize = New System.Drawing.Size(75, 23)
            Me.button2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.button2.ForeColor = System.Drawing.Color.White
            Me.button2.IsBackStageButton = False
            Me.button2.Location = New System.Drawing.Point(235, 216)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(75, 23)
            Me.button2.TabIndex = 8
            Me.button2.Text = "&Find All"
            Me.button2.UseVisualStyle = True
            Me.button2.UseVisualStyleBackColor = True
            ' 
            ' button1
            ' 
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
            Me.button1.BeforeTouchSize = New System.Drawing.Size(75, 23)
            Me.button1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.IsBackStageButton = False
            Me.button1.Location = New System.Drawing.Point(136, 216)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 7
            Me.button1.Text = "&Find Next"
            Me.button1.UseVisualStyle = True
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' SearchOptionCombo
            ' 
            Me.SearchOptionCombo.FormattingEnabled = True
            Me.SearchOptionCombo.Location = New System.Drawing.Point(136, 84)
            Me.SearchOptionCombo.Name = "SearchOptionCombo"
            Me.SearchOptionCombo.Size = New System.Drawing.Size(363, 21)
            Me.SearchOptionCombo.TabIndex = 6
            ' 
            ' label3
            ' 
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(23, 87)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(75, 13)
            Me.label3.TabIndex = 5
            Me.label3.Text = "Search Option"
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(25, 54)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(72, 13)
            Me.label2.TabIndex = 1
            Me.label2.Text = "Replace With"
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(28, 20)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(56, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Find What"
            ' 
            ' TreeViewSearchForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
            Me.BorderThickness = 2
            Me.CaptionBarColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
            Me.CaptionButtonColor = System.Drawing.Color.White
            Me.CaptionButtonHoverColor = System.Drawing.Color.Red
            Me.CaptionForeColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(682, 291)
            Me.Controls.Add(Me.tabControlAdv1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
            Me.MaximumSize = New System.Drawing.Size(694, 323)
            Me.MinimumSize = New System.Drawing.Size(694, 323)
            Me.Name = "TreeViewSearchForm"
            Me.Padding = New System.Windows.Forms.Padding(10)
            Me.ShowMaximizeBox = False
            Me.ShowMinimizeBox = False
            Me.Text = "TreeViewAdv Search Window"
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlAdv1.ResumeLayout(False)
            Me.tabPageAdv1.ResumeLayout(False)
            Me.tabPageAdv1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private tabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
        Private tabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
        Private WithEvents SearchRangeCombo As System.Windows.Forms.ComboBox
        Private label4 As System.Windows.Forms.Label
        Private WithEvents button4 As ButtonAdv
        Private WithEvents button3 As ButtonAdv
        Private WithEvents button2 As ButtonAdv
        Private WithEvents button1 As ButtonAdv
        Private WithEvents SearchOptionCombo As System.Windows.Forms.ComboBox
        Private label3 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label1 As System.Windows.Forms.Label
        Private WithEvents button5 As ButtonAdv
        Private comboBox3 As System.Windows.Forms.ComboBox
        Private label5 As System.Windows.Forms.Label
        Private replaceTextbox As System.Windows.Forms.TextBox
        Private findTextBox As System.Windows.Forms.TextBox
    End Class
End Namespace