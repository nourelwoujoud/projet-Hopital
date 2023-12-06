Module module_patient
    Public Structure Patient
        Dim code As Integer
        Dim nom As String
        Dim prenom As String
    End Structure
    Public patients(100) As Patient
    Public nb As Integer
    Public Function ajout_patient(p As Patient) As Boolean
        If nb >= patients.Length Then
            Return False
        End If
        For i As Integer = 0 To nb - 1
                If patients(i).code = p.code Then
                    Return False

                End If
            Next
        patients(nb) = p
        nb += 1
        Return True
    End Function
    Public Sub affichagePatient(dgv As DataGridView)
        Dim p As Patient
        For Each p In patients

            dgv.Rows.Add(p.code, p.nom, p.prenom)
            dgv.Show()
        Next
    End Sub
    Public Sub rechercherPatient(codeP As Integer, dgv As DataGridView)
        For i As Integer = 0 To nb - 1
            If (patients(i).code = codeP) Then
                dgv.Rows.Add(patients(i).code, patients(i).nom, patients(i).prenom)
            End If
        Next
    End Sub
    Public Sub supprimerPatient(codeP As Integer)
        For i As Integer = 0 To nb - 1
            If patients(i).code = codeP Then
                For j As Integer = i To nb - 2
                    patients(j) = patients(j + 1)
                Next
                nb -= 1
                Exit For
            End If
        Next
    End Sub
End Module
