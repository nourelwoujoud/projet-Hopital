Public Class frm_ajoutRDV
    Private Sub frm_ajoutRDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDH.Format = DateTimePickerFormat.Custom
        dtpDH.CustomFormat = "MM/dd/yyyy hh:mm:ss"
    End Sub

    Private Sub btn_ajoutRDV_Click(sender As Object, e As EventArgs) Handles btn_ajoutRDV.Click
        Dim r As rdv
        If txt_code.Text = "" Then
            MessageBox.Show("veuillez entrez le code svp!")
        Else
            r.code = txt_code.Text
            r.datee = dtpDH.Value


            If ajout_RDV(r) = True Then
                MessageBox.Show("l'ajout est valide")
            Else
                MessageBox.Show("l'ajout est invalide")
            End If
            txt_code.Clear()

        End If

    End Sub

    Private Sub dtpdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDH.ValueChanged

    End Sub

    Private Sub btn_supprimerRDV_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_annulerRDV_Click(sender As Object, e As EventArgs) Handles btn_annulerRDV.Click
        txt_code.Clear()
        dtpDH.Value = DateTime.Now

    End Sub
End Class