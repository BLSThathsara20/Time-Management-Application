Imports System.Data.SqlClient
Public Class frmNewProject

    Dim con As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Clocky;Data Source=.")
    Dim cmd As SqlCommand = New SqlCommand()
    Dim createrDate As Date = Date.Now.Date

    Private Sub btnPCancel_Click(sender As Object, e As EventArgs) Handles btnPCancel.Click
        Me.Hide()
    End Sub

    Private Sub btnNProjectSCreate_Click(sender As Object, e As EventArgs) Handles btnNProjectSCreate.Click
        Dim currentUser As String = "1"
        Dim STime As String = "1"
        Dim ETime As String = "1"
        Dim TDifferent As String = "1"
        Dim wid As String = "2"
        If (txtPName.Text = "") Then
            MessageBox.Show("Please Fill the Project Name!")
        Else
            Try
                con.Open()
                Dim query As String = "insert into ProjectTB (WSID, ProjectName, CreateDate, StartTime, EndTime, TimeDifferent) values ('" + wid + "', '" + txtPName.Text + "', '" + createrDate + "', '" + STime + "', '" + ETime + "', '" + TDifferent + "')"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Successfully Added")
                Me.Hide()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class