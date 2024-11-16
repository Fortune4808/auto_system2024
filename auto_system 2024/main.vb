Imports MySql.Data.MySqlClient
Imports System.IO
Public Class main
    Dim connection = functions.connection
    Dim query As String
    Dim reader As MySqlDataReader

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        functions.getUserIds()
        functions.userCount()
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Dim closeValidation = MessageBox.Show("Are you sure you want to Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeValidation = vbYes Then
            Me.Close()
            index.Close()
        End If
    End Sub

    Private Sub selectPictureBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectPictureBtn.Click
        'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
        If fd.ShowDialog = DialogResult.OK Then
            passport.Image = Image.FromFile(fd.FileName)
        End If
        fd = Nothing
    End Sub

    Private Sub clearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearBtn.Click
        clearFunction()
    End Sub

    Private Sub submitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitBtn.Click
        If fullName.Text = "" Or email.Text = "" Or mobileNo.Text = "" Then
            MessageBox.Show("ERROR! All Fields are Required", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf passport.Image Is Nothing Then
            MessageBox.Show("ERROR! Select a Passport to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf functions.emailValidate(email.Text) = False Then
            MessageBox.Show("Invalid Email Address", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If profile_id.Text = "SELECT USER" Then
                If functions.emailCheck(email.Text) Then
                    MessageBox.Show("Email Address is already Exist, Kindly Enter a new Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    newRegistration()
                End If
            Else
                If functions.updateemailCheck(email.Text) Then
                    MessageBox.Show("Email Address is already Exist, Kindly Enter a new Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    functions.updateData()
                End If
            End If
        End If
    End Sub

    Private Sub fetchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetchBtn.Click
        If profile_id.Text = "SELECT USER" Then
            MessageBox.Show("SELECT USER TO CONTINUE!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                connection.Open()
                query = "SELECT * FROM users_tab WHERE userid=@userId;"
                Dim Command = New MySqlCommand(query, connection)
                Command.Parameters.AddWithValue("@userId", profile_id.SelectedValue)
                reader = Command.ExecuteReader
                reader.Read()

                Dim arrimage() As Byte

                fullName.Text = reader("fullname")
                email.Text = reader("email")
                mobileNo.Text = reader("mobileno")
                arrimage = reader("passport")

                Dim mstream As New MemoryStream
                mstream = New MemoryStream(arrimage)
                passport.Image = Image.FromStream(mstream)
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub delBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delBtn.Click
        If profile_id.Text = "SELECT USER" Then
            MessageBox.Show("SELECT USER TO CONTINUE!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim delValidation = MessageBox.Show("Are you sure you want to Delete", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If delValidation = vbYes Then
                Try
                    connection.Open()
                    query = "DELETE FROM users_tab WHERE userid=@userId"
                    Dim Command = New MySqlCommand(query, connection)
                    Command.Parameters.AddWithValue("@userId", profile_id.SelectedValue)
                    reader = Command.ExecuteReader
                    connection.Close()
                    MessageBox.Show("Profile successfully deleted!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearFunction()
                    functions.getUserIds()
                    functions.userCount()
                    functions.usersRecord()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub fullName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fullName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field allows only Letters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub mobileNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mobileNo.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso
       Not Char.IsWhiteSpace(e.KeyChar) AndAlso
       Not Char.IsControl(e.KeyChar) AndAlso
       e.KeyChar <> "+"c AndAlso
       e.KeyChar <> "-"c AndAlso
       e.KeyChar <> "("c AndAlso
       e.KeyChar <> ")"c Then
            e.Handled = True
            MessageBox.Show("This field allows only numbers and valid mobile number symbols (+, -, (, ))!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub recordBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recordBtn.Click
        Me.Hide()
        recordview.Show()
        Me.ShowInTaskbar = False
    End Sub
End Class