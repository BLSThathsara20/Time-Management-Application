Imports System.Data.SqlClient
Public Class frmWorkspaces

    Dim con As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Clocky;Data Source=.")
    Dim cmd As SqlCommand = New SqlCommand()
    Dim adpt As SqlDataAdapter = New SqlDataAdapter()
    Dim ds As DataSet = New DataSet()
    Public Shared LoginUName As String

    Sub ShowGrid1()
        Try
            con.Open()
            Dim cmd As New SqlCommand("SELECT * FROM WorkspacesTB", con)
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())
            dgtWorkspaces.DataSource = dt
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmWorkspaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowGrid1()
    End Sub
End Class