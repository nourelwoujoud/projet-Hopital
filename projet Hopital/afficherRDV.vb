Public Class frm_afficherRDV
    Private Sub frm_afficherRDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affichageRDV(dgv_rdv)

    End Sub

    Private Sub btn_rechercher_Click(sender As Object, e As EventArgs) Handles btn_rechercher.Click
        dgv_rdv.Rows.Clear()
        rechercherRDV(txt_rechercher.Text, dgv_rdv)
    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        dgv_rdv.Rows.Clear()
        supprimerRDV(txt_rechercher.Text)
    End Sub

    Private Sub txt_rechercher_TextChanged(sender As Object, e As EventArgs) Handles txt_rechercher.TextChanged

    End Sub
End Class