<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ajoutRDV
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
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.dtpDH = New System.Windows.Forms.DateTimePicker()
        Me.btn_ajoutRDV = New System.Windows.Forms.Button()
        Me.btn_annulerRDV = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(39, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(27, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date/Heure"
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(179, 91)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(247, 22)
        Me.txt_code.TabIndex = 3
        Me.txt_code.UseSystemPasswordChar = True
        '
        'dtpDH
        '
        Me.dtpDH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDH.Location = New System.Drawing.Point(194, 200)
        Me.dtpDH.Name = "dtpDH"
        Me.dtpDH.Size = New System.Drawing.Size(232, 24)
        Me.dtpDH.TabIndex = 4
        '
        'btn_ajoutRDV
        '
        Me.btn_ajoutRDV.BackColor = System.Drawing.SystemColors.Menu
        Me.btn_ajoutRDV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajoutRDV.ForeColor = System.Drawing.Color.Green
        Me.btn_ajoutRDV.Location = New System.Drawing.Point(76, 350)
        Me.btn_ajoutRDV.Name = "btn_ajoutRDV"
        Me.btn_ajoutRDV.Size = New System.Drawing.Size(112, 47)
        Me.btn_ajoutRDV.TabIndex = 6
        Me.btn_ajoutRDV.Text = "Ajouter"
        Me.btn_ajoutRDV.UseVisualStyleBackColor = False
        '
        'btn_annulerRDV
        '
        Me.btn_annulerRDV.BackColor = System.Drawing.SystemColors.Menu
        Me.btn_annulerRDV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annulerRDV.ForeColor = System.Drawing.Color.Green
        Me.btn_annulerRDV.Location = New System.Drawing.Point(268, 350)
        Me.btn_annulerRDV.Name = "btn_annulerRDV"
        Me.btn_annulerRDV.Size = New System.Drawing.Size(117, 47)
        Me.btn_annulerRDV.TabIndex = 7
        Me.btn_annulerRDV.Text = "Annuler"
        Me.btn_annulerRDV.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.projet_Hopital.My.Resources.Resources.Capture_d_écran_2023_12_06_2053051
        Me.PictureBox1.Location = New System.Drawing.Point(549, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(449, 429)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frm_ajoutRDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(1037, 562)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_annulerRDV)
        Me.Controls.Add(Me.btn_ajoutRDV)
        Me.Controls.Add(Me.dtpDH)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_ajoutRDV"
        Me.Text = "ajoutRDV"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents dtpDH As DateTimePicker
    Friend WithEvents btn_ajoutRDV As Button
    Friend WithEvents btn_annulerRDV As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
