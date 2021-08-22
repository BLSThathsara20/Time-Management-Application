Imports System.Data.SqlClient
Public Class frmLogin

    Dim con As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Clocky;Data Source=.")
    Dim cmd As SqlCommand = New SqlCommand()
    Dim adpt As SqlDataAdapter = New SqlDataAdapter()
    Dim ds As DataSet = New DataSet()
    Public Shared LoginUName As String



    ' timeleft 24 hours 00 minutes 00 seconds

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtLUserName.Text = "" And txtLPassword.Text = "") Then
            MessageBox.Show("Please Fill All Filelds!")
        Else
            Try
                con.Open()
                Dim query As String = "select * from UserTB where Name = '" + txtLUserName.Text + "' and Password = '" + txtLPassword.Text + "'"
                cmd = New SqlCommand(query, con)
                adpt = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                adpt.Fill(dt)
                con.Close()
                If (dt.Rows.Count > 0) Then
                    MessageBox.Show("login Successfully!")
                    Dim frmlD As New frmDashboard
                    Dim frmH As New frmHome
                    'Pass the user name in home
                    frmlD.UserName = txtLUserName.Text
                    frmH.UserName2 = txtLUserName.Text
                    Me.Hide()
                    frmlD.Show()
                Else
                    MessageBox.Show("Please Check Your Details!")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        Dim frmReg As New frmRegister
        frmReg.Show()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtLUserName_TextChanged(sender As Object, e As EventArgs) Handles txtLUserName.TextChanged

    End Sub
End Class