Imports MySql.Data.MySqlClient
Public Class index

    Private Sub index_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        main.Show()
        Dim connection As New MySqlConnection("server=localhost;userid=root;password=;database=autosystem2024")

        Try
            connection.Open()
            If connection.State = ConnectionState.Open Then
                MsgBox("Connection successful.")
            End If
        Catch ex As MySqlException
            MsgBox("Connection failed: " & ex.Message)
            Me.Close()
        Finally
            connection.Close()
        End Try
    End Sub

   
End Class
