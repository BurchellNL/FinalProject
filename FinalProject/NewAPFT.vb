Public Class New_APFT
    Private Sub New_APFT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cboSoldier.DataSource = 
        ' Fake it.
        cboSoldier.Items.Clear()
        cboSoldier.Items.Add("1LT Peterson")
        cboSoldier.Items.Add("CDT Name")
        cboSoldier.Items.Add("CDT Allen")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim PU As Integer
        Dim SU As Integer
        Dim MINS As Integer
        Dim SEC As Integer

        ' Clear status label
        lblStatus.Text = ""

        ' Check if a rank has been selected.
        If cboSoldier.SelectedIndex = -1 Then
            lblStatus.Text = "Please a servicemember."
            cboSoldier.Focus()
            Return
        End If


        ' Check if PU has been correctly entered.
        If Not Integer.TryParse(txtPu.Text, PU) Then
            lblStatus.Text = "Please enter the number of correctly performed Push Ups."
            txtPu.Text = ""
            txtPu.Focus()
            Return
        End If

        ' Check if SU has been correctly entered.
        If Not Integer.TryParse(txtSu.Text, SU) Then
            lblStatus.Text = "Please enter the number of correctly performed Sit Ups."
            txtSu.Text = ""
            txtSu.Focus()
            Return
        End If

        ' Check if MINS has been correctly entered.
        If Not Integer.TryParse(txtMins.Text, MINS) Then
            lblStatus.Text = "Please enter the 2 Mile minute time."
            txtMins.Text = ""
            txtMins.Focus()
            Return
        End If

        ' Check if SEC has been correctly entered.
        If Not Integer.TryParse(txtSec.Text, SEC) Then
            lblStatus.Text = "Please enter the 2 Mile second time."
            txtSec.Text = ""
            txtSec.Focus()
            Return
        End If


    End Sub
End Class