Public Class frm_authentification
    Private Sub init()
        txt_nom.Clear()
        txt_pw.Clear()
    End Sub
    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim login As String
        Dim pw As String
        login = txt_nom.Text
        pw = txt_pw.Text
        If (login = "admin") And (pw = "1234") Then
            Me.Hide()
            frm_main.Show()

        Else
            init()
        End If
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        init()
    End Sub
End Class