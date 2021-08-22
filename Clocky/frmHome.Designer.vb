<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.lblTimeDifferent = New System.Windows.Forms.Label()
        Me.btnTimeStop = New System.Windows.Forms.Button()
        Me.btnTimeStart = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbProjectNames = New System.Windows.Forms.ComboBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.lblCurrentUsre = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtUpdatetable = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTID = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(25, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Home"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel13)
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1196, 159)
        Me.Panel1.TabIndex = 11
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Panel14)
        Me.Panel13.Controls.Add(Me.Label9)
        Me.Panel13.Controls.Add(Me.cmbProjectNames)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(0, 63)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1196, 96)
        Me.Panel13.TabIndex = 1
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.lblTimeDifferent)
        Me.Panel14.Controls.Add(Me.btnTimeStop)
        Me.Panel14.Controls.Add(Me.btnTimeStart)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel14.Location = New System.Drawing.Point(812, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(384, 96)
        Me.Panel14.TabIndex = 17
        '
        'lblTimeDifferent
        '
        Me.lblTimeDifferent.AutoSize = True
        Me.lblTimeDifferent.Font = New System.Drawing.Font("Roboto Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeDifferent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.lblTimeDifferent.Location = New System.Drawing.Point(53, 32)
        Me.lblTimeDifferent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeDifferent.Name = "lblTimeDifferent"
        Me.lblTimeDifferent.Size = New System.Drawing.Size(104, 25)
        Me.lblTimeDifferent.TabIndex = 9
        Me.lblTimeDifferent.Text = "00:00:00"
        '
        'btnTimeStop
        '
        Me.btnTimeStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnTimeStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimeStop.FlatAppearance.BorderSize = 0
        Me.btnTimeStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnTimeStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnTimeStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeStop.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeStop.ForeColor = System.Drawing.Color.White
        Me.btnTimeStop.Image = Global.Clocky.My.Resources.Resources.login
        Me.btnTimeStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimeStop.Location = New System.Drawing.Point(217, 17)
        Me.btnTimeStop.Name = "btnTimeStop"
        Me.btnTimeStop.Size = New System.Drawing.Size(141, 58)
        Me.btnTimeStop.TabIndex = 18
        Me.btnTimeStop.Text = "STOP"
        Me.btnTimeStop.UseVisualStyleBackColor = False
        '
        'btnTimeStart
        '
        Me.btnTimeStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnTimeStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimeStart.FlatAppearance.BorderSize = 0
        Me.btnTimeStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnTimeStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnTimeStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeStart.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.btnTimeStart.ForeColor = System.Drawing.Color.White
        Me.btnTimeStart.Image = Global.Clocky.My.Resources.Resources.login
        Me.btnTimeStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimeStart.Location = New System.Drawing.Point(217, 17)
        Me.btnTimeStart.Name = "btnTimeStart"
        Me.btnTimeStart.Size = New System.Drawing.Size(141, 58)
        Me.btnTimeStart.TabIndex = 16
        Me.btnTimeStart.Text = "START"
        Me.btnTimeStart.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(30, 17)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "What are you working on?"
        '
        'cmbProjectNames
        '
        Me.cmbProjectNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProjectNames.FormattingEnabled = True
        Me.cmbProjectNames.Location = New System.Drawing.Point(33, 43)
        Me.cmbProjectNames.Name = "cmbProjectNames"
        Me.cmbProjectNames.Size = New System.Drawing.Size(283, 32)
        Me.cmbProjectNames.TabIndex = 0
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.PictureBox1)
        Me.Panel12.Controls.Add(Me.lblHint)
        Me.Panel12.Controls.Add(Me.Label6)
        Me.Panel12.Controls.Add(Me.lblCurrentUsre)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1196, 63)
        Me.Panel12.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1128, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.lblHint.Location = New System.Drawing.Point(145, 23)
        Me.lblHint.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(0, 20)
        Me.lblHint.TabIndex = 9
        '
        'lblCurrentUsre
        '
        Me.lblCurrentUsre.AutoSize = True
        Me.lblCurrentUsre.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentUsre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.lblCurrentUsre.Location = New System.Drawing.Point(1055, 23)
        Me.lblCurrentUsre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentUsre.Name = "lblCurrentUsre"
        Me.lblCurrentUsre.Size = New System.Drawing.Size(66, 20)
        Me.lblCurrentUsre.TabIndex = 9
        Me.lblCurrentUsre.Text = "savindu"
        Me.lblCurrentUsre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 159)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1196, 544)
        Me.Panel2.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(888, 544)
        Me.Panel4.TabIndex = 12
        '
        'Panel10
        '
        Me.Panel10.AutoScroll = True
        Me.Panel10.Controls.Add(Me.DataGridView2)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 95)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(888, 449)
        Me.Panel10.TabIndex = 12
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeight = 30
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(888, 449)
        Me.DataGridView2.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Panel5.Controls.Add(Me.txtUpdatetable)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.lblTID)
        Me.Panel5.Controls.Add(Me.btnUpdate)
        Me.Panel5.Controls.Add(Me.btnDelete)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(888, 95)
        Me.Panel5.TabIndex = 11
        '
        'txtUpdatetable
        '
        Me.txtUpdatetable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUpdatetable.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdatetable.Location = New System.Drawing.Point(194, 10)
        Me.txtUpdatetable.Name = "txtUpdatetable"
        Me.txtUpdatetable.Size = New System.Drawing.Size(336, 27)
        Me.txtUpdatetable.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(25, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Project Name"
        '
        'lblTID
        '
        Me.lblTID.AutoSize = True
        Me.lblTID.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.lblTID.Location = New System.Drawing.Point(145, 11)
        Me.lblTID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTID.Name = "lblTID"
        Me.lblTID.Size = New System.Drawing.Size(32, 23)
        Me.lblTID.TabIndex = 9
        Me.lblTID.Text = "00"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = Global.Clocky.My.Resources.Resources.login
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(194, 49)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(160, 31)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.Clocky.My.Resources.Resources.login
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(360, 49)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 31)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(888, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(308, 544)
        Me.Panel3.TabIndex = 11
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(308, 544)
        Me.Panel6.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.AutoScroll = True
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(29, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(279, 544)
        Me.Panel8.TabIndex = 1
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.DataGridView1)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 52)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(279, 492)
        Me.Panel11.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(279, 492)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(279, 52)
        Me.Panel9.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(7, 14)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Recently tracked activities"
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(29, 544)
        Me.Panel7.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1196, 703)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmHome"
        Me.Panel1.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents btnTimeStart As Button
    Friend WithEvents lblTimeDifferent As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnTimeStop As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbProjectNames As ComboBox
    Friend WithEvents lblCurrentUsre As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUpdatetable As TextBox
    Friend WithEvents lblTID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHint As Label
End Class
