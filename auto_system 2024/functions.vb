Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.IO
Module functions
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Function connection()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=autosystem2024")
        Return conn
    End Function

    Function countId(ByVal counter_id As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("UPDATE counters_tab SET counter_value=counter_value+1 WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        connection.Close()

        connection.Open()
        command = New MySqlCommand("SELECT counter_value FROM counters_tab WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        reader.Read()
        Dim counter_value = reader("counter_value")
        connection.Close()
        Return counter_value
    End Function

    Public Sub clearFunction()
        main.fullName.Text = ""
        main.email.Text = ""
        main.mobileNo.Text = ""
        main.profile_id.Text = "SELECT USER"
        main.passport.Image = Nothing
    End Sub

    Public Sub getUserIds()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM users_tab;", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("userid") = ""
        defaultRow("fullname") = "SELECT USER"
        defaultRow("email") = ""
        defaultRow("mobileno") = ""
        defaultRow("createdTime") = Date.Now
        defaultRow("updatedTime") = Date.Now
        DT.Rows.InsertAt(defaultRow, 0)

        main.profile_id.DataSource = DT
        main.profile_id.DisplayMember = "fullname"
        main.profile_id.ValueMember = "userid"
    End Sub

    Function passportSave()
        Dim arrimage() As Byte
        Dim msstream As New System.IO.MemoryStream()
        main.passport.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()

        Return arrimage
    End Function

    Public Sub newRegistration()
        Dim connection = functions.connection
        Try
            Dim userId = "USER" & Now.ToString("yyyyMMddss") & functions.countId("USER")

            connection.Open()
            query = "INSERT INTO `users_tab`(`userid`, `fullname`, `email`, `mobileno`, `passport`, `createdTime`) VALUES (@userId,@fullName,@email,@mobileNo,@passport,NOW());"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@userId", userId)
            Command.Parameters.AddWithValue("@fullName", main.fullName.Text.ToUpper)
            Command.Parameters.AddWithValue("@email", main.email.Text)
            Command.Parameters.AddWithValue("@mobileNo", main.mobileNo.Text)
            Command.Parameters.AddWithValue("@passport", functions.passportSave)
            reader = Command.ExecuteReader
            connection.Close()
            MessageBox.Show("User Registration successful!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clearFunction()
            functions.getUserIds()
            functions.userCount()
            functions.usersRecord()
        Catch ex As Exception
            MsgBox("User Registration failed: " & ex.Message)
        End Try
    End Sub

    Public Sub updateData()
        Dim connection = functions.connection
        Try
            connection.Open()
            query = "UPDATE users_tab SET fullname=@fullname, email=@email, mobileno=mobileno, passport=@passport WHERE userid=@userid"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@userid", main.profile_id.SelectedValue)
            Command.Parameters.AddWithValue("@fullName", main.fullName.Text.ToUpper)
            Command.Parameters.AddWithValue("@email", main.email.Text)
            Command.Parameters.AddWithValue("@mobileno", main.mobileNo.Text)
            Command.Parameters.AddWithValue("@passport", functions.passportSave)
            reader = Command.ExecuteReader
            connection.Close()
            MessageBox.Show("User successfully updated!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
            functions.usersRecord()
        Catch ex As Exception
            MsgBox("User update failed: " & ex.Message)
        End Try
    End Sub

    Function emailValidate(ByVal email_address As String) As Boolean
        Dim email As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        If email.IsMatch(email_address) Then
            Return True
        End If
        Return False
    End Function

    Function emailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM users_tab WHERE email=@email", connection)
        command.Parameters.AddWithValue("@email", email)
        reader = command.ExecuteReader
        Dim validateEmail = reader.Read()
        connection.Close()
        Return validateEmail
    End Function

    Function updateemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM users_tab WHERE email=@email AND userid!=@userid", connection)
        command.Parameters.AddWithValue("@email", email)
        command.Parameters.AddWithValue("@userid", main.profile_id.SelectedValue)
        reader = command.ExecuteReader
        Dim validateEmail = reader.Read()
        connection.Close()
        Return validateEmail
    End Function

    Public Sub userCount()
        Dim connection = functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT COUNT(*) FROM users_tab", connection)
        main.userCount.Text = command.ExecuteScalar
        recordview.userCount.Text = command.ExecuteScalar
        connection.close()
    End Sub

    Public Sub usersRecord()
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = functions.connection

            Dim adapter As New MySqlDataAdapter("SELECT * FROM users_tab;", connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            recordview.userRecord.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("userid").ToString())
                listItem.SubItems.Add(row("fullname").ToString())
                listItem.SubItems.Add(row("email").ToString())
                listItem.SubItems.Add(row("mobileno").ToString())
                listItem.SubItems.Add(row("passport").ToString())
                listItem.SubItems.Add(row("updatedTime").ToString())
                listItem.SubItems.Add(row("createdTime").ToString())

                recordview.userRecord.Items.Add(listItem)
                sn += 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module