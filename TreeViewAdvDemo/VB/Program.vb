Imports System
Imports System.Windows.Forms

Namespace TreeViewAdvSearchDemo
    Friend NotInheritable Class Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        Private Sub New()
        End Sub
        <STAThread>
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New TreeViewAdvSearchDemo())
        End Sub
    End Class
End Namespace