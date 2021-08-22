Imports System.Data.SqlClient
Public Class frmNewWorkSpace

    Dim con As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Clocky;Data Source=.")
    Dim cmd As SqlCommand = New SqlCommand()
    Dim regDate As Date = Date.Now.Date

    Private Sub btnWCancel_Click(sender As Object, e As EventArgs) Handles btnWCancel.Click
        Me.Close()
    End Sub

    Private Sub btnNWorkSCreate_Click(sender As Object, e As EventArgs) Handles btnNWorkSCreate.Click
        Dim currentUser As String = "1"
        If (txtWName.Text = "") Then
            MessageBox.Show("Please Fill the Workspace!")
        Else
            Try
                con.Open()
                Dim query As String = "insert into WorkspacesTB (UID, WName, CreateDate) values ('" + currentUser + "', '" + txtWName.Text + "', '" + regDate + "')"
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