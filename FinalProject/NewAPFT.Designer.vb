<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_APFT
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
        Me.cboSoldier = New System.Windows.Forms.ComboBox()
        Me.lblSoldier = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPu = New System.Windows.Forms.Label()
        Me.txtPu = New System.Windows.Forms.TextBox()
        Me.txtSu = New System.Windows.Forms.TextBox()
        Me.lblSu = New System.Windows.Forms.Label()
        Me.lbl2Mile = New System.Windows.Forms.Label()
        Me.txtMins = New System.Windows.Forms.TextBox()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.txtSec = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboSoldier
        '
        Me.cboSoldier.FormattingEnabled = True
        Me.cboSoldier.Location = New System.Drawing.Point(97, 29)
        Me.cboSoldier.Name = "cboSoldier"
        Me.cboSoldier.Size = New System.Drawing.Size(121, 21)
        Me.cboSoldier.TabIndex = 0
        '
        'lblSoldier
        '
        Me.lblSoldier.AutoSize = True
        Me.lblSoldier.Location = New System.Drawing.Point(49, 32)
        Me.lblSoldier.Name = "lblSoldier"
        Me.lblSoldier.Size = New System.Drawing.Size(42, 13)
        Me.lblSoldier.TabIndex = 1
        Me.lblSoldier.Text = "Soldier:"
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(117, 68)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(101, 20)
        Me.dtpDate.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(33, 74)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(58, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Tested on:"
        '
        'lblPu
        '
        Me.lblPu.AutoSize = True
        Me.lblPu.Location = New System.Drawing.Point(45, 118)
        Me.lblPu.Name = "lblPu"
        Me.lblPu.Size = New System.Drawing.Size(108, 13)
        Me.lblPu.TabIndex = 4
        Me.lblPu.Text = "Number of Push Ups:"
        '
        'txtPu
        '
        Me.txtPu.Location = New System.Drawing.Point(159, 115)
        Me.txtPu.MaxLength = 3
        Me.txtPu.Name = "txtPu"
        Me.txtPu.Size = New System.Drawing.Size(59, 20)
        Me.txtPu.TabIndex = 5
        '
        'txtSu
        '
        Me.txtSu.Location = New System.Drawing.Point(159, 141)
        Me.txtSu.MaxLength = 3
        Me.txtSu.Name = "txtSu"
        Me.txtSu.Size = New System.Drawing.Size(59, 20)
        Me.txtSu.TabIndex = 8
        '
        'lblSu
        '
        Me.lblSu.AutoSize = True
        Me.lblSu.Location = New System.Drawing.Point(45, 144)
        Me.lblSu.Name = "lblSu"
        Me.lblSu.Size = New System.Drawing.Size(96, 13)
        Me.lblSu.TabIndex = 7
        Me.lblSu.Text = "Number of Sit Ups:"
        '
        'lbl2Mile
        '
        Me.lbl2Mile.AutoSize = True
        Me.lbl2Mile.Location = New System.Drawing.Point(45, 174)
        Me.lbl2Mile.Name = "lbl2Mile"
        Me.lbl2Mile.Size = New System.Drawing.Size(125, 13)
        Me.lbl2Mile.TabIndex = 9
        Me.lbl2Mile.Text = "2 Mile Run Completed in:"
        '
        'txtMins
        '
        Me.txtMins.Location = New System.Drawing.Point(176, 171)
        Me.txtMins.MaxLength = 2
        Me.txtMins.Name = "txtMins"
        Me.txtMins.Size = New System.Drawing.Size(41, 20)
        Me.txtMins.TabIndex = 10
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Location = New System.Drawing.Point(224, 174)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(44, 13)
        Me.lblMinutes.TabIndex = 11
        Me.lblMinutes.Text = "Minutes"
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Location = New System.Drawing.Point(224, 205)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(49, 13)
        Me.lblSeconds.TabIndex = 12
        Me.lblSeconds.Text = "Seconds"
        '
        'txtSec
        '
        Me.txtSec.Location = New System.Drawing.Point(177, 202)
        Me.txtSec.MaxLength = 2
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(41, 20)
        Me.txtSec.TabIndex = 13
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(142, 257)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 350)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(361, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'New_APFT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 372)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSec)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.txtMins)
        Me.Controls.Add(Me.lbl2Mile)
        Me.Controls.Add(Me.txtSu)
        Me.Controls.Add(Me.lblSu)
        Me.Controls.Add(Me.txtPu)
        Me.Controls.Add(Me.lblPu)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblSoldier)
        Me.Controls.Add(Me.cboSoldier)
        Me.Name = "New_APFT"
        Me.Text = "New APFT"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboSoldier As ComboBox
    Friend WithEvents lblSoldier As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents lblPu As Label
    Friend WithEvents txtPu As TextBox
    Friend WithEvents txtSu As TextBox
    Friend WithEvents lblSu As Label
    Friend WithEvents lbl2Mile As Label
    Friend WithEvents txtMins As TextBox
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents txtSec As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
