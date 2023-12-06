Module module_RDV
    Public Structure rdv
        Dim code As Integer
        Dim datee As DateTime

    End Structure
    Public rdvs(100) As rdv
    Public nb As Integer
    Public Function ajout_RDV(r As rdv) As Boolean
        If nb >= rdvs.Length Then
            Return False
        End If
        For i As Integer = 0 To nb - 1
            If rdvs(i).code = r.code Then
                Return False

            End If
        Next
        rdvs(nb) = r
        nb += 1
        Return True
    End Function
    Public Sub affichageRDV(dgv As DataGridView)

        For i As Integer = 0 To nb - 1
            If rdvs(i).datee.Date = DateTime.Now.Date Then
                dgv.Rows.Add(rdvs(i).code, rdvs(i).datee)
            End If
        Next

    End Sub
    Public Sub rechercherRDV(codeP As Integer, dgv As DataGridView)
        For i As Integer = 0 To nb - 1
            If (rdvs(i).code = codeP) Then
                dgv.Rows.Add(rdvs(i).code, rdvs(i).datee)
            End If
        Next
    End Sub
    Public Sub supprimerRDV(codePatient As Integer)
        For i As Integer = 0 To nb - 1
            If rdvs(i).code = codePatient Then
                For j As Integer = i To nb - 2
                    rdvs(j) = rdvs(j + 1)
                Next
                nb -= 1
                Exit For
            End If
        Next
    End Sub
End Module
