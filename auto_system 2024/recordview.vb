Imports MySql.Data.MySqlClient
Public Class recordview

    Private Sub recordview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        functions.userCount()
        functions.usersRecord()
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Dim closeValidation = MessageBox.Show("Are you sure you want to Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeValidation = vbYes Then
            Me.Close()
            index.Close()
        End If
    End Sub

    Private Sub homeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles homeBtn.Click
        main.Show()
        Me.Hide()
        main.ShowInTaskbar = True
    End Sub
End Class