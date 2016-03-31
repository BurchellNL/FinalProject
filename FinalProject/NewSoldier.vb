Public Class NewSoldier
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load combobox with ranks.
        cboRank.Items.Clear()
        cboRank.Items.Add("PVT")
        cboRank.Items.Add("PV2")
        cboRank.Items.Add("PFC")
        cboRank.Items.Add("SPC")
        cboRank.Items.Add("CPL")
        cboRank.Items.Add("CDT")
        cboRank.Items.Add("SGT")
        cboRank.Items.Add("SSG")
        cboRank.Items.Add("SFC")
        cboRank.Items.Add("MSG/1SG")
        cboRank.Items.Add("SGM/CSM/SMA")
        cboRank.Items.Add("W01")
        cboRank.Items.Add("CW2")
        cboRank.Items.Add("CW3")
        cboRank.Items.Add("CW4")
        cboRank.Items.Add("CW5")
        cboRank.Items.Add("2LT")
        cboRank.Items.Add("1LT")
        cboRank.Items.Add("CPT")
        cboRank.Items.Add("MAJ")
        cboRank.Items.Add("LTC")
        cboRank.Items.Add("COL")
        cboRank.Items.Add("GEN")

        ' Clear textboxes, clear CBO, reset radio buttons.
        cboRank.SelectedIndex = -1
        txtName.Text = ""
        txtSsn.Text = ""
        txtAge.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ssnId As Integer
        Dim LastName As String = txtName.Text
        Dim age As Integer

        ' Clear status label
        lblStatus.Text = ""

        ' Check if a rank has been selected.
        If cboRank.SelectedIndex = -1 Then
            lblStatus.Text = "Please select the servicemember's rank."
            cboRank.Focus()
            Return
        End If

        ' Check is a name has been entered.
        If txtName.Text = "" Then
            lblStatus.Text = "Please enter the servicemember's last name."
            txtName.Focus()
            Return
        End If

        ' Check if SSN has been correctly entered.
        If Not Integer.TryParse(txtSsn.Text, ssnId) Then
            lblStatus.Text = "Please enter the servicemember's last four (SSN)."
            txtSsn.Text = ""
            txtSsn.Focus()
            Return
        End If

        ' Check if age has been entered.
        If Not Integer.TryParse(txtAge.Text, age) Then
            lblStatus.Text = "Please enter the servicemember's age."
            txtAge.Text = ""
            txtAge.Focus()
            Return
        End If
    End Sub
End Class