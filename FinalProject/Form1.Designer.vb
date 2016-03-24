<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.cboRank = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSSN = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grpGender.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(59, 134)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 23
        Me.lblAge.Text = "Age:"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(163, 131)
        Me.txtAge.MaxLength = 3
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(61, 20)
        Me.txtAge.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Name:"
        '
        'grpGender
        '
        Me.grpGender.Controls.Add(Me.radFemale)
        Me.grpGender.Controls.Add(Me.radMale)
        Me.grpGender.Location = New System.Drawing.Point(62, 157)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(167, 68)
        Me.grpGender.TabIndex = 21
        Me.grpGender.TabStop = False
        Me.grpGender.Text = "Gender:"
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(63, 43)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(59, 17)
        Me.radFemale.TabIndex = 1
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Checked = True
        Me.radMale.Location = New System.Drawing.Point(63, 20)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(48, 17)
        Me.radMale.TabIndex = 0
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'cboRank
        '
        Me.cboRank.FormattingEnabled = True
        Me.cboRank.Location = New System.Drawing.Point(103, 21)
        Me.cboRank.Name = "cboRank"
        Me.cboRank.Size = New System.Drawing.Size(121, 21)
        Me.cboRank.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Rank:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(103, 59)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 20)
        Me.txtName.TabIndex = 18
        '
        'txtSSN
        '
        Me.txtSSN.Location = New System.Drawing.Point(163, 95)
        Me.txtSSN.MaxLength = 4
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(61, 20)
        Me.txtSSN.TabIndex = 24
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(149, 231)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 312)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1048, 22)
        Me.StatusStrip1.TabIndex = 27
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Location = New System.Drawing.Point(59, 98)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(85, 13)
        Me.lblSSN.TabIndex = 28
        Me.lblSSN.Text = "SSN (Last Four):"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(248, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(642, 288)
        Me.DataGridView1.TabIndex = 29
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 334)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblSSN)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSSN)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpGender)
        Me.Controls.Add(Me.cboRank)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpGender.ResumeLayout(False)
        Me.grpGender.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAge As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents cboRank As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSSN As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents lblSSN As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
