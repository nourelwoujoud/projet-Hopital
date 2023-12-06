Public Class frm_afficherPatient
    Private Sub frm_afficherPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affichagePatient(dgv_patient)

    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        txt_rechercherP.Clear()
    End Sub

    Private Sub btn_rechercherP_Click(sender As Object, e As EventArgs) Handles btn_rechercherP.Click
        dgv_patient.Rows.Clear()
        rechercherPatient(txt_rechercherP.Text, dgv_patient)
    End Sub

    Private Sub btn_supprimerP_Click(sender As Object, e As EventArgs) Handles btn_supprimerP.Click
        dgv_patient.Rows.Clear()
        supprimerPatient(txt_rechercherP.Text)
    End Sub
End Class