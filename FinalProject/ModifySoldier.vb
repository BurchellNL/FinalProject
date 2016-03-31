Public Class ModifySoldier


    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim age As Integer

        ' Clear status label
        lblStatus.Text = ""

        ' Check is a name has been entered.
        If cboName.SelectedIndex = -1 Then
            lblStatus.Text = "Please select the servicemember to modify."
            cboName.Focus()
        End If

        ' Check if a rank has been selected.
        If cboRank.SelectedIndex = -1 Then
            lblStatus.Text = "Please select the servicemember's rank."
            cboRank.Focus()
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

    Private Sub ModifySoldier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'Fake it.
        cboName.Items.Clear()
        cboName.Items.Add("2LT Peterson")
        cboName.Items.Add("CDT Name")
        cboName.Items.Add("CDT Allen")

        ' Clear textboxes, clear CBO, reset radio buttons.
        cboRank.SelectedIndex = -1
        cboName.SelectedIndex = -1
        txtSsn.Text = ""
        txtAge.Text = ""
        cboName.Focus()
    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        'Fake Soldier Selection.
        If cboName.SelectedIndex = 0 Then
            txtSsn.Text = "0001"
            cboRank.SelectedIndex = 16
            txtAge.Text = "26"
        ElseIf cboName.SelectedIndex = 1 Then
            txtSsn.Text = "0002"
            cboRank.SelectedIndex = 5
            txtAge.Text = "20"
        ElseIf cboName.SelectedIndex = 2 Then
            txtSsn.Text = "0003"
            cboRank.SelectedIndex = 5
            txtAge.Text = "23"
        End If
    End Sub
End Class