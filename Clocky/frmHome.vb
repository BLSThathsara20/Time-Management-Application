Imports System.Data.SqlClient
Public Class frmHome
    Dim ss, tt, vv As Integer
    Dim counter As Int32
    Public Property UserName2 As String = "savindu"
    Public Property CurrentUserName As String
    Public Property TimeStartTime1 As String
    Public Property TimeEndTime1 As String
    Public Property TimeStartTime As String

    '.......................................
    Dim currentUser As String = "1"
    Dim STime As String = "1"
    Dim ETime As String = "1"
    Dim TDifferent As String = "1"
    Dim wid As String = "2"
    '.......................................

    Dim con As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Clocky;Data Source=.")
    Dim cmd As SqlCommand = New SqlCommand()
    Dim adpt As SqlDataAdapter = New SqlDataAdapter()
    Dim ds As DataSet = New DataSet()
    Public Shared LoginUName As String

    Sub FillCombo2()
        Try
            con.Open()
            cmd = New SqlCommand("SELECT ProjectName FROM ProjectTB WHERE UID = '" + currentUser + "' ", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                cmbProjectNames.Items.Add(dr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnTimeStart_Click(sender As Object, e As EventArgs) Handles btnTimeStart.Click
        btnTimeStart.Visible = False
        btnTimeStop.Visible = True
        Timer1.Enabled = True
        TimeStartTime1 = DateTime.Now.ToString()
        TimeStartTime1 = Format(Now, "hh:mm:ss tt")
        TimeStartTime = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        If cmbProjectNames.Text = "" Then
            MessageBox.Show("Select Your Project!")
        End If
        '/////////////////// input start time ///////////////////
        'Try
        '    con.Open()
        '    Dim cmd As New SqlCommand("UPDATE ProjectTB SET StartTime = '" + TimeStartTime1 + "' ", con)
        '    cmd.ExecuteNonQuery()
        '    con.Close()
        '    ShowGrid1()
        '    MessageBox.Show("Updated")
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo2()
        ShowGrid1()
        ShowGrid2()
        btnTimeStop.Visible = False
    End Sub

    Sub ShowGrid1()
        Try
            con.Open()
            Dim cmd As New SqlCommand("SELECT * FROM TimeSheet ORDER BY TSID DESC", con)
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())
            DataGridView2.DataSource = dt
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub ShowGrid2()
        Try
            con.Open()
            Dim cmd As New SqlCommand("SELECT * FROM TimeSheet WHERE TSID not in (SELECT TOP (SELECT COUNT(1)-5 FROM TimeSheet) TSID FROM TimeSheet)", con)
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())
            DataGridView1.DataSource = dt
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbProjectNames_TextChanged(sender As Object, e As EventArgs) Handles cmbProjectNames.TextChanged
        ShowGrid1()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand("UPDATE TimeSheet SET ProjectName = '" + txtUpdatetable.Text + "' WHERE TSID = @TID ", con)
            cmd.Parameters.AddWithValue("@TID", DataGridView2.CurrentRow.Cells(0).Value)
            cmd.ExecuteNonQuery()
            con.Close()
            ShowGrid1()
            txtUpdatetable.Text = ""
            lblTID.Text = ""
            MessageBox.Show("Updated")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        lblTID.Text = DataGridView2.CurrentRow.Cells(0).Value
        txtUpdatetable.Text = DataGridView2.CurrentRow.Cells(1).Value
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try
            con.Open()
            Dim cmd As New SqlCommand("delete from TimeSheet where TSID = @TID", con)
            cmd.Parameters.AddWithValue("@TID", DataGridView2.CurrentRow.Cells(0).Value)
            MessageBox.Show("Delete Successfully")
            cmd.ExecuteNonQuery()
            con.Close()
            ShowGrid1()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_MouseHover(sender As Object, e As EventArgs) Handles btnUpdate.MouseHover
        lblHint.Text = "Please Double click Data row"
    End Sub

    Private Sub btnUpdate_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate.MouseLeave
        lblHint.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimeDifferent.Text = Format(ss, "00:") & Format(tt, "00:") & Format(vv, "00")
        vv = vv + 1
        If vv > 59 Then
            vv = 0
            tt = tt + 1
        End If
        If True = 2 Then
            vv = 0
            tt = 0
            lblTimeDifferent.Text = "00:00:00"
            Timer1.Enabled = False
            MessageBox.Show("Time Ended")
        End If
    End Sub

    Private Sub btnTimeStop_Click(sender As Object, e As EventArgs) Handles btnTimeStop.Click
        btnTimeStart.Visible = True
        btnTimeStop.Visible = False
        Timer1.Enabled = False
        lblTimeDifferent.Text = "00:00:00"
        TimeEndTime1 = DateTime.Now.ToString()
        TimeEndTime1 = Format(Now, "hh:mm:ss tt")

        Dim d1 As DateTime = TimeStartTime
        'Dim d1 As DateTime = DateTime.Parse("1-Apr-2014 10:10:00 AM")
        Dim d2 As DateTime = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        Dim difference As TimeSpan = d2 - d1
        'round down total hours to integer'
        Dim hours = Math.Floor(difference.TotalHours)
        Dim minutes = Math.Abs(difference.Minutes)
        Dim seconds = difference.Seconds
        Dim timeleft As String = Format(hours, "00") + " h " + Format(minutes, "00") + " m " + Format(seconds, "00") + " s "
        If Int(seconds) < 0 Then
            timeleft = "00 h 00 m 00 s (Time Out)"
        End If

        Try
            con.Open()
            Dim query2 As String = "insert into TimeSheet (ProjectName, CreateDate, StartTime, EndTime, TimeDifferent) values ('" + cmbProjectNames.Text + "', '" + d2 + "', '" + TimeStartTime1 + "', '" + TimeEndTime1 + "', '" + timeleft + "')"
            cmd = New SqlCommand(query2, con)
            cmd.ExecuteNonQuery()
            con.Close()
            ShowGrid1()
            ShowGrid2()
            MessageBox.Show("Successfully Added")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class