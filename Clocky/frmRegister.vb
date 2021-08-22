Imports System.Data.SqlClient

Public Class frmRegister
    Dim con As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Clocky;Data Source=.")
    Dim cmd As SqlCommand = New SqlCommand()
    Dim adpt As SqlDataAdapter = New SqlDataAdapter()
    Dim ds As DataSet = New DataSet()

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If (txtRUserName.Text = "" And txtEmail.Text = "" And txtPassword.Text = "" And txtCpassword.Text = "") Then
            MessageBox.Show("Please Fill All Filelds!")
        ElseIf (txtPassword.Text <> txtCpassword.Text) Then
            MessageBox.Show("Please Enter Same Password!")
        Else
            con.Open()
            Dim query As String = "select * from UserTB where Name = '" + txtRUserName.Text + "'"
            cmd = New SqlCommand(query, con)
            adpt = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            adpt.Fill(dt)
            con.Close()
            If (dt.Rows.Count > 0) Then
                MessageBox.Show("This name is currently taken!")
            Else
                Try
                    con.Open()
                    Dim query2 As String = "insert into UserTB (Name, Email, Birthday, Password) values ('" + txtRUserName.Text + "','" + txtEmail.Text + "','" + dtpBirthday.Text + "','" + txtPassword.Text + "')"
                    cmd = New SqlCommand(query2, con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    txtRUserName.Text = ""
                    txtEmail.Text = ""
                    txtPassword.Text = ""
                    txtCpassword.Text = ""
                    Dim frmLog As New frmLogin
                    frmLog.Show()
                    MessageBox.Show("Successfully Added")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If

    End Sub

    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged

    End Sub
End Class