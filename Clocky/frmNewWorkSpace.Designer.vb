<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewWorkSpace
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnWCancel = New System.Windows.Forms.Button()
        Me.btnNWorkSCreate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(39, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 37)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Workspaces"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(991, 258)
        Me.Panel1.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.btnWCancel)
        Me.Panel3.Controls.Add(Me.btnNWorkSCreate)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtWName)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 70)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(991, 188)
        Me.Panel3.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(0, 100)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(991, 12)
        Me.Panel5.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(0, 7)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(991, 12)
        Me.Panel4.TabIndex = 19
        '
        'btnWCancel
        '
        Me.btnWCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnWCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWCancel.FlatAppearance.BorderSize = 0
        Me.btnWCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnWCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnWCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWCancel.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.btnWCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnWCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWCancel.Location = New System.Drawing.Point(585, 123)
        Me.btnWCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnWCancel.Name = "btnWCancel"
        Me.btnWCancel.Size = New System.Drawing.Size(181, 50)
        Me.btnWCancel.TabIndex = 18
        Me.btnWCancel.Text = "Cancel"
        Me.btnWCancel.UseVisualStyleBackColor = False
        '
        'btnNWorkSCreate
        '
        Me.btnNWorkSCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnNWorkSCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNWorkSCreate.FlatAppearance.BorderSize = 0
        Me.btnNWorkSCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnNWorkSCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnNWorkSCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNWorkSCreate.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.btnNWorkSCreate.ForeColor = System.Drawing.Color.White
        Me.btnNWorkSCreate.Image = Global.Clocky.My.Resources.Resources.login
        Me.btnNWorkSCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNWorkSCreate.Location = New System.Drawing.Point(775, 123)
        Me.btnNWorkSCreate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNWorkSCreate.Name = "btnNWorkSCreate"
        Me.btnNWorkSCreate.Size = New System.Drawing.Size(181, 50)
        Me.btnNWorkSCreate.TabIndex = 18
        Me.btnNWorkSCreate.Text = "Create"
        Me.btnNWorkSCreate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Workspace name"
        '
        'txtWName
        '
        Me.txtWName.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.txtWName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWName.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWName.ForeColor = System.Drawing.Color.White
        Me.txtWName.Location = New System.Drawing.Point(341, 43)
        Me.txtWName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWName.Name = "txtWName"
        Me.txtWName.Size = New System.Drawing.Size(614, 36)
        Me.txtWName.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(991, 70)
        Me.Panel2.TabIndex = 11
        '
        'frmNewWorkSpace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(991, 258)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmNewWorkSpace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNewWorkSpace"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtWName As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnWCancel As Button
    Friend WithEvents btnNWorkSCreate As Button
End Class
