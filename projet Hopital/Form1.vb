Public Class frm_main
    Private Sub AjouterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem.Click
        frm_ajoutPatient.Show()
    End Sub

    Private Sub AfficherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherToolStripMenuItem.Click
        frm_afficherPatient.Show()
    End Sub

    Private Sub AfficherToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AfficherToolStripMenuItem1.Click
        frm_afficherRDV.Show()
    End Sub

    Private Sub RendreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RendreToolStripMenuItem.Click
        frm_ajoutRDV.Show()
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
