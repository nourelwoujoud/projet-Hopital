Public Class frm_ajoutPatient
    Private Sub btn_ajouterP_Click(sender As Object, e As EventArgs) Handles btn_ajouterP.Click
        Dim p As Patient
        p.code = txt_codeP.Text
        p.nom = txt_nom.Text
        p.prenom = txt_prénom.Text
        If ajout_patient(p) = True Then
            MessageBox.Show("l'ajout est valide")
        Else
            MessageBox.Show("l'ajout est invalide")
        End If
        txt_codeP.Clear()
        txt_nom.Clear()
        txt_prénom.Clear()
    End Sub

    Private Sub txt_codeP_TextChanged(sender As Object, e As EventArgs) Handles txt_codeP.TextChanged

    End Sub

    Private Sub btn_annulerP_Click(sender As Object, e As EventArgs) Handles btn_annulerP.Click
        txt_codeP.Clear()
        txt_nom.Clear()
        txt_prénom.Clear()

    End Sub
End Class