<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDateSearch = New System.Windows.Forms.Button()
        Me.dpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSearch1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgtWorkspaces = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgtWorkspaces, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnDateSearch)
        Me.Panel1.Controls.Add(Me.dpDate)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.btnSearch1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(995, 111)
        Me.Panel1.TabIndex = 0
        '
        'btnDateSearch
        '
        Me.btnDateSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnDateSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDateSearch.FlatAppearance.BorderSize = 0
        Me.btnDateSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnDateSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDateSearch.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.btnDateSearch.ForeColor = System.Drawing.Color.White
        Me.btnDateSearch.Image = Global.Clocky.My.Resources.Resources.login
        Me.btnDateSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDateSearch.Location = New System.Drawing.Point(406, 64)
        Me.btnDateSearch.Name = "btnDateSearch"
        Me.btnDateSearch.Size = New System.Drawing.Size(160, 37)
        Me.btnDateSearch.TabIndex = 23
        Me.btnDateSearch.Text = "Search"
        Me.btnDateSearch.UseVisualStyleBackColor = False
        '
        'dpDate
        '
        Me.dpDate.CustomFormat = " "
        Me.dpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpDate.Location = New System.Drawing.Point(159, 69)
        Me.dpDate.Name = "dpDate"
        Me.dpDate.Size = New System.Drawing.Size(224, 26)
        Me.dpDate.TabIndex = 22
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(159, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(224, 26)
        Me.txtName.TabIndex = 21
        '
        'btnSearch1
        '
        Me.btnSearch1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnSearch1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch1.FlatAppearance.BorderSize = 0
        Me.btnSearch1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnSearch1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnSearch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch1.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.btnSearch1.ForeColor = System.Drawing.Color.White
        Me.btnSearch1.Image = Global.Clocky.My.Resources.Resources.login
        Me.btnSearch1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch1.Location = New System.Drawing.Point(406, 13)
        Me.btnSearch1.Name = "btnSearch1"
        Me.btnSearch1.Size = New System.Drawing.Size(160, 37)
        Me.btnSearch1.TabIndex = 20
        Me.btnSearch1.Text = "Search"
        Me.btnSearch1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgtWorkspaces)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(995, 339)
        Me.Panel2.TabIndex = 0
        '
        'dgtWorkspaces
        '
        Me.dgtWorkspaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtWorkspaces.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgtWorkspaces.Location = New System.Drawing.Point(0, 0)
        Me.dgtWorkspaces.Name = "dgtWorkspaces"
        Me.dgtWorkspaces.Size = New System.Drawing.Size(995, 339)
        Me.dgtWorkspaces.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(28, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 20)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Project Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(28, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Create Date"
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(995, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSearch"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgtWorkspaces, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgtWorkspaces As DataGridView
    Friend WithEvents btnSearch1 As Button
    Friend WithEvents dpDate As DateTimePicker
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnDateSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
End Class
