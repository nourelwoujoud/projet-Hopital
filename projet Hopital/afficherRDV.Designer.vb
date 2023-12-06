<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficherRDV
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
        Me.dgv_rdv = New System.Windows.Forms.DataGridView()
        Me.btn_rechercher = New System.Windows.Forms.Button()
        Me.txt_rechercher = New System.Windows.Forms.TextBox()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_rdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_rdv
        '
        Me.dgv_rdv.BackgroundColor = System.Drawing.Color.Moccasin
        Me.dgv_rdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_rdv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code, Me.Column1})
        Me.dgv_rdv.Location = New System.Drawing.Point(44, 32)
        Me.dgv_rdv.Name = "dgv_rdv"
        Me.dgv_rdv.RowHeadersWidth = 51
        Me.dgv_rdv.RowTemplate.Height = 24
        Me.dgv_rdv.Size = New System.Drawing.Size(408, 175)
        Me.dgv_rdv.TabIndex = 0
        '
        'btn_rechercher
        '
        Me.btn_rechercher.BackColor = System.Drawing.Color.LightPink
        Me.btn_rechercher.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rechercher.ForeColor = System.Drawing.Color.Green
        Me.btn_rechercher.Location = New System.Drawing.Point(44, 260)
        Me.btn_rechercher.Name = "btn_rechercher"
        Me.btn_rechercher.Size = New System.Drawing.Size(141, 45)
        Me.btn_rechercher.TabIndex = 1
        Me.btn_rechercher.Text = "Rechercher"
        Me.btn_rechercher.UseVisualStyleBackColor = False
        '
        'txt_rechercher
        '
        Me.txt_rechercher.Location = New System.Drawing.Point(135, 356)
        Me.txt_rechercher.Name = "txt_rechercher"
        Me.txt_rechercher.Size = New System.Drawing.Size(177, 22)
        Me.txt_rechercher.TabIndex = 2
        '
        'btn_supprimer
        '
        Me.btn_supprimer.BackColor = System.Drawing.Color.LightPink
        Me.btn_supprimer.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.ForeColor = System.Drawing.Color.Green
        Me.btn_supprimer.Location = New System.Drawing.Point(299, 259)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(140, 46)
        Me.btn_supprimer.TabIndex = 3
        Me.btn_supprimer.Text = "Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = False
        '
        'code
        '
        Me.code.HeaderText = "code"
        Me.code.MinimumWidth = 6
        Me.code.Name = "code"
        Me.code.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "date/heure"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.projet_Hopital.My.Resources.Resources.Capture_d_écran_2023_12_06_2144561
        Me.PictureBox1.Location = New System.Drawing.Point(554, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(482, 469)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frm_afficherRDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(1039, 465)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_supprimer)
        Me.Controls.Add(Me.txt_rechercher)
        Me.Controls.Add(Me.btn_rechercher)
        Me.Controls.Add(Me.dgv_rdv)
        Me.Name = "frm_afficherRDV"
        Me.Text = "afficherRDV"
        CType(Me.dgv_rdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_rdv As DataGridView
    Friend WithEvents btn_rechercher As Button
    Friend WithEvents txt_rechercher As TextBox
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
