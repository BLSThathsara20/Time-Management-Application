Imports System.Data.SqlClient
Public Class frmSearch

    Dim con As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Clocky;Data Source=.")
    Dim cmd As SqlCommand = New SqlCommand()
    Dim adpt As SqlDataAdapter = New SqlDataAdapter()
    Dim ds As DataSet = New DataSet()
    Public Shared LoginUName As String

    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch1.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please select the Project Name")
        Else
            Try
                If con.State <> ConnectionState.Open Then
                    con.Open()
                End If
                Dim cmd As New SqlCommand("SELECT * FROM TimeSheet where ProjectName = '" + txtName.Text + "' ", con)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                dgtWorkspaces.DataSource = dt
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub dp_ValueChanged(sender As Object, e As EventArgs) Handles dpDate.ValueChanged
        dpDate.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub btnDateSearch_Click(sender As Object, e As EventArgs) Handles btnDateSearch.Click
        If dpDate.Text = "" Then
            MessageBox.Show("Please select the Date")
        Else
            Try
                If con.State <> ConnectionState.Open Then
                    con.Open()
                End If
                Dim cmd As New SqlCommand("SELECT * FROM TimeSheet where CreateDate = '" + dpDate.Text + "' ", con)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                dgtWorkspaces.DataSource = dt
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class