<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APFTList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(APFTList))
        Me.dgvAPFT = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblSoldier = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn300 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFailed = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvAPFT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAPFT
        '
        Me.dgvAPFT.AllowUserToAddRows = False
        Me.dgvAPFT.AllowUserToDeleteRows = False
        Me.dgvAPFT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAPFT.Location = New System.Drawing.Point(1, 50)
        Me.dgvAPFT.Name = "dgvAPFT"
        Me.dgvAPFT.ReadOnly = True
        Me.dgvAPFT.Size = New System.Drawing.Size(717, 398)
        Me.dgvAPFT.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAll, Me.ToolStripSeparator1, Me.lblSoldier, Me.txtSearch, Me.ToolStripSeparator2, Me.btn300, Me.ToolStripSeparator3, Me.btnFailed})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(720, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAll
        '
        Me.btnAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAll.Image = CType(resources.GetObject("btnAll.Image"), System.Drawing.Image)
        Me.btnAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(25, 22)
        Me.btnAll.Text = "All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lblSoldier
        '
        Me.lblSoldier.Name = "lblSoldier"
        Me.lblSoldier.Size = New System.Drawing.Size(46, 22)
        Me.lblSoldier.Text = "Soldier:"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btn300
        '
        Me.btn300.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn300.Image = CType(resources.GetObject("btn300.Image"), System.Drawing.Image)
        Me.btn300.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn300.Name = "btn300"
        Me.btn300.Size = New System.Drawing.Size(68, 22)
        Me.btn300.Text = "Scored 300"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnFailed
        '
        Me.btnFailed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnFailed.Image = CType(resources.GetObject("btnFailed.Image"), System.Drawing.Image)
        Me.btnFailed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFailed.Name = "btnFailed"
        Me.btnFailed.Size = New System.Drawing.Size(42, 22)
        Me.btnFailed.Text = "Failed"
        '
        'APFTList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 460)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvAPFT)
        Me.Name = "APFTList"
        Me.Text = "APFT Database"
        CType(Me.dgvAPFT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAPFT As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAll As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblSoldier As ToolStripLabel
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btn300 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnFailed As ToolStripButton
End Class
