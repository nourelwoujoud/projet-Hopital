<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_afficherPatient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgv_patient = New System.Windows.Forms.DataGridView()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prénom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_rechercherP = New System.Windows.Forms.Button()
        Me.btn_supprimerP = New System.Windows.Forms.Button()
        Me.txt_rechercherP = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_patient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_patient
        '
        Me.dgv_patient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_patient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code, Me.nom, Me.prénom})
        Me.dgv_patient.Location = New System.Drawing.Point(12, 41)
        Me.dgv_patient.Name = "dgv_patient"
        Me.dgv_patient.RowHeadersWidth = 51
        Me.dgv_patient.RowTemplate.Height = 24
        Me.dgv_patient.Size = New System.Drawing.Size(492, 166)
        Me.dgv_patient.TabIndex = 0
        '
        'code
        '
        Me.code.HeaderText = "code"
        Me.code.MinimumWidth = 6
        Me.code.Name = "code"
        Me.code.Width = 125
        '
        'nom
        '
        Me.nom.HeaderText = "nom"
        Me.nom.MinimumWidth = 6
        Me.nom.Name = "nom"
        Me.nom.Width = 125
        '
        'prénom
        '
        Me.prénom.HeaderText = "prénom"
        Me.prénom.MinimumWidth = 6
        Me.prénom.Name = "prénom"
        Me.prénom.Width = 125
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_annuler.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_annuler.Location = New System.Drawing.Point(33, 447)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(131, 47)
        Me.btn_annuler.TabIndex = 1
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'btn_rechercherP
        '
        Me.btn_rechercherP.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_rechercherP.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rechercherP.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_rechercherP.Location = New System.Drawing.Point(28, 240)
        Me.btn_rechercherP.Name = "btn_rechercherP"
        Me.btn_rechercherP.Size = New System.Drawing.Size(136, 47)
        Me.btn_rechercherP.TabIndex = 2
        Me.btn_rechercherP.Text = "Rechercher"
        Me.btn_rechercherP.UseVisualStyleBackColor = False
        '
        'btn_supprimerP
        '
        Me.btn_supprimerP.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_supprimerP.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimerP.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_supprimerP.Location = New System.Drawing.Point(295, 240)
        Me.btn_supprimerP.Name = "btn_supprimerP"
        Me.btn_supprimerP.Size = New System.Drawing.Size(126, 47)
        Me.btn_supprimerP.TabIndex = 3
        Me.btn_supprimerP.Text = "Supprimer"
        Me.btn_supprimerP.UseVisualStyleBackColor = False
        '
        'txt_rechercherP
        '
        Me.txt_rechercherP.Location = New System.Drawing.Point(157, 333)
        Me.txt_rechercherP.Name = "txt_rechercherP"
        Me.txt_rechercherP.Size = New System.Drawing.Size(142, 22)
        Me.txt_rechercherP.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.projet_Hopital.My.Resources.Resources.Capture_d_écran_2023_12_06_223146
        Me.PictureBox1.Location = New System.Drawing.Point(521, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(487, 431)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frm_afficherPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1034, 530)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_rechercherP)
        Me.Controls.Add(Me.btn_supprimerP)
        Me.Controls.Add(Me.btn_rechercherP)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.dgv_patient)
        Me.Name = "frm_afficherPatient"
        Me.Text = "afficherPatient"
        CType(Me.dgv_patient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_patient As DataGridView
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents nom As DataGridViewTextBoxColumn
    Friend WithEvents prénom As DataGridViewTextBoxColumn
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_rechercherP As Button
    Friend WithEvents btn_supprimerP As Button
    Friend WithEvents txt_rechercherP As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
