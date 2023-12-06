<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ajoutPatient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_codeP = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_prénom = New System.Windows.Forms.TextBox()
        Me.btn_ajouterP = New System.Windows.Forms.Button()
        Me.btn_annulerP = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(35, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(35, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(31, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prénom"
        '
        'txt_codeP
        '
        Me.txt_codeP.Location = New System.Drawing.Point(186, 76)
        Me.txt_codeP.Name = "txt_codeP"
        Me.txt_codeP.Size = New System.Drawing.Size(162, 22)
        Me.txt_codeP.TabIndex = 3
        Me.txt_codeP.UseSystemPasswordChar = True
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(184, 142)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(164, 22)
        Me.txt_nom.TabIndex = 4
        '
        'txt_prénom
        '
        Me.txt_prénom.Location = New System.Drawing.Point(189, 217)
        Me.txt_prénom.Name = "txt_prénom"
        Me.txt_prénom.Size = New System.Drawing.Size(159, 22)
        Me.txt_prénom.TabIndex = 5
        '
        'btn_ajouterP
        '
        Me.btn_ajouterP.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_ajouterP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouterP.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_ajouterP.Location = New System.Drawing.Point(50, 344)
        Me.btn_ajouterP.Name = "btn_ajouterP"
        Me.btn_ajouterP.Size = New System.Drawing.Size(106, 42)
        Me.btn_ajouterP.TabIndex = 6
        Me.btn_ajouterP.Text = "Ajouter"
        Me.btn_ajouterP.UseVisualStyleBackColor = False
        '
        'btn_annulerP
        '
        Me.btn_annulerP.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_annulerP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annulerP.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_annulerP.Location = New System.Drawing.Point(226, 344)
        Me.btn_annulerP.Name = "btn_annulerP"
        Me.btn_annulerP.Size = New System.Drawing.Size(111, 42)
        Me.btn_annulerP.TabIndex = 7
        Me.btn_annulerP.Text = "Annuler"
        Me.btn_annulerP.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.projet_Hopital.My.Resources.Resources.ajoutP1
        Me.PictureBox1.Location = New System.Drawing.Point(465, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(491, 448)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frm_ajoutPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(987, 505)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_annulerP)
        Me.Controls.Add(Me.btn_ajouterP)
        Me.Controls.Add(Me.txt_prénom)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.txt_codeP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_ajoutPatient"
        Me.Text = "ajoutPatient"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_codeP As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_prénom As TextBox
    Friend WithEvents btn_ajouterP As Button
    Friend WithEvents btn_annulerP As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
