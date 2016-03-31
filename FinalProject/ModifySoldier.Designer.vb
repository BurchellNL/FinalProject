<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifySoldier
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
        Me.btnModify = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtSsn = New System.Windows.Forms.TextBox()
        Me.lblSsn = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.cboRank = New System.Windows.Forms.ComboBox()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(106, 143)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 23
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 199)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(305, 22)
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(163, 106)
        Me.txtAge.MaxLength = 3
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(63, 20)
        Me.txtAge.TabIndex = 19
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(117, 109)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 18
        Me.lblAge.Text = "Age:"
        '
        'txtSsn
        '
        Me.txtSsn.Location = New System.Drawing.Point(163, 76)
        Me.txtSsn.MaxLength = 4
        Me.txtSsn.Name = "txtSsn"
        Me.txtSsn.ReadOnly = True
        Me.txtSsn.Size = New System.Drawing.Size(63, 20)
        Me.txtSsn.TabIndex = 17
        '
        'lblSsn
        '
        Me.lblSsn.AutoSize = True
        Me.lblSsn.Location = New System.Drawing.Point(61, 79)
        Me.lblSsn.Name = "lblSsn"
        Me.lblSsn.Size = New System.Drawing.Size(85, 13)
        Me.lblSsn.TabIndex = 16
        Me.lblSsn.Text = "SSN (Last Four):"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(62, 26)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "Name:"
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Location = New System.Drawing.Point(64, 52)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(36, 13)
        Me.lblRank.TabIndex = 13
        Me.lblRank.Text = "Rank:"
        '
        'cboRank
        '
        Me.cboRank.FormattingEnabled = True
        Me.cboRank.Location = New System.Drawing.Point(106, 49)
        Me.cboRank.Name = "cboRank"
        Me.cboRank.Size = New System.Drawing.Size(121, 21)
        Me.cboRank.TabIndex = 12
        '
        'cboName
        '
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(106, 23)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(121, 21)
        Me.cboName.TabIndex = 24
        '
        'ModifySoldier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 221)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtSsn)
        Me.Controls.Add(Me.lblSsn)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblRank)
        Me.Controls.Add(Me.cboRank)
        Me.Name = "ModifySoldier"
        Me.Text = "Modify Soldier"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnModify As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtSsn As TextBox
    Friend WithEvents lblSsn As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblRank As Label
    Friend WithEvents cboRank As ComboBox
    Friend WithEvents cboName As ComboBox
End Class
