Imports System.Data.SqlClient
Public Class frmDashboard

    Dim con As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Clocky;Data Source=.")
    Dim cmd As SqlCommand = New SqlCommand()
    Dim adpt As SqlDataAdapter = New SqlDataAdapter()
    Dim ds As DataSet = New DataSet()
    Public Shared LoginUName As String
    Public Property UserName As String
    Public Property CurrentUserName As String

    Private Sub T1ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmLogin.Show()
    End Sub

    Sub GetUserId()
        Try
            con.Open()
            Dim cmd As New SqlCommand("select * from UserTB where Name LIKE '" + lblCurrentUsre.Text + "' ", con)
            Dim drr As SqlDataReader = cmd.ExecuteReader()
            If (drr.Read) Then
                CurrentUserName = drr("UID").ToString
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub FillCombo1()
        GetUserId()
        Try
            con.Open()
            cmd = New SqlCommand("SELECT WName FROM WorkspacesTB WHERE UID = '" + CurrentUserName + "' ", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                cmbWorkSpace.Items.Add(dr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.ForeColor = Color.White
        Dim frmlL As New frmHome
        frmlL.MdiParent = Me
        frmlL.Show()
        lblCurrentUsre.Text = UserName
        FillCombo1()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub GunaContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub ProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectToolStripMenuItem.Click

    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        Dim frmReg As New frmRegister
        frmReg.MdiParent = Me
        frmReg.Show()
    End Sub

    Private Sub btnMinimixe_Click(sender As Object, e As EventArgs) Handles btnMinimixe.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim message As String = "Do you want to exite application?"
        Dim caption As String = "Clocky - Manage your time"
        Dim icons As Integer = MessageBoxIcon.Question
        Dim buttons As Integer = MessageBoxButtons.YesNo

        Dim result As DialogResult

        result = MessageBox.Show(Me, message, caption, buttons, icons)

        If result = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim frmLog As New frmLogin
        frmLog.MdiParent = Me
        frmLog.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If Not ActiveMdiChild Is Nothing Then
            ActiveMdiChild.Close()
        End If
        Dim frmWorks As New frmWorkspaces
        frmWorks.MdiParent = Me
        frmWorks.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If Not ActiveMdiChild Is Nothing Then
            ActiveMdiChild.Close()
        End If
        Dim frmNWorks As New frmNewWorkSpace
        frmNWorks.MdiParent = Me
        frmNWorks.Show()
    End Sub

    Private Sub TimetrackerToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim f As New frmProjects()
        f.MdiParent = Me
        f.StartPosition = FormStartPosition.Manual
        f.Left = 3.5 : f.Top = 6 : f.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        If Not ActiveMdiChild Is Nothing Then
            ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        If Not ActiveMdiChild Is Nothing Then
            ActiveMdiChild.Close()
        End If
        Dim frmNProject As New frmNewProject
        frmNProject.MdiParent = Me
        frmNProject.Show()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        If Not ActiveMdiChild Is Nothing Then
            ActiveMdiChild.Close()
        End If
        Dim frmS As New frmSearch
        frmS.MdiParent = Me
        frmS.Show()
    End Sub
End Class