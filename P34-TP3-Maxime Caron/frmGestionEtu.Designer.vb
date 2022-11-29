<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.grpEleve = New System.Windows.Forms.GroupBox()
        Me.grpstatut = New System.Windows.Forms.GroupBox()
        Me.optAbandon = New System.Windows.Forms.RadioButton()
        Me.optInactif = New System.Windows.Forms.RadioButton()
        Me.optActif = New System.Windows.Forms.RadioButton()
        Me.grpSexe = New System.Windows.Forms.GroupBox()
        Me.optMasculin = New System.Windows.Forms.RadioButton()
        Me.optFeminin = New System.Windows.Forms.RadioButton()
        Me.numMoyenne = New System.Windows.Forms.NumericUpDown()
        Me.numNbCoursReussi = New System.Windows.Forms.NumericUpDown()
        Me.lblMoyenne = New System.Windows.Forms.Label()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.mskDa = New System.Windows.Forms.MaskedTextBox()
        Me.lblNbCoursRussi = New System.Windows.Forms.Label()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.ldlDa = New System.Windows.Forms.Label()
        Me.lstEleve = New System.Windows.Forms.ListView()
        Me.colDa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrenom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVille = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSexe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNbCoursReussi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMoyenne = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStatut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnListerEtudiant = New System.Windows.Forms.Button()
        Me.btnCalMoyenne = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.grpEleve.SuspendLayout()
        Me.grpstatut.SuspendLayout()
        Me.grpSexe.SuspendLayout()
        CType(Me.numMoyenne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNbCoursReussi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEleve
        '
        Me.grpEleve.Controls.Add(Me.grpstatut)
        Me.grpEleve.Controls.Add(Me.grpSexe)
        Me.grpEleve.Controls.Add(Me.numMoyenne)
        Me.grpEleve.Controls.Add(Me.numNbCoursReussi)
        Me.grpEleve.Controls.Add(Me.lblMoyenne)
        Me.grpEleve.Controls.Add(Me.txtVille)
        Me.grpEleve.Controls.Add(Me.txtPrenom)
        Me.grpEleve.Controls.Add(Me.txtNom)
        Me.grpEleve.Controls.Add(Me.mskDa)
        Me.grpEleve.Controls.Add(Me.lblNbCoursRussi)
        Me.grpEleve.Controls.Add(Me.lblVille)
        Me.grpEleve.Controls.Add(Me.lblPrenom)
        Me.grpEleve.Controls.Add(Me.lblNom)
        Me.grpEleve.Controls.Add(Me.ldlDa)
        Me.grpEleve.Enabled = False
        Me.grpEleve.Location = New System.Drawing.Point(61, 25)
        Me.grpEleve.Name = "grpEleve"
        Me.grpEleve.Size = New System.Drawing.Size(507, 266)
        Me.grpEleve.TabIndex = 0
        Me.grpEleve.TabStop = False
        Me.grpEleve.Text = "Eleve"
        '
        'grpstatut
        '
        Me.grpstatut.Controls.Add(Me.optAbandon)
        Me.grpstatut.Controls.Add(Me.optInactif)
        Me.grpstatut.Controls.Add(Me.optActif)
        Me.grpstatut.Location = New System.Drawing.Point(333, 132)
        Me.grpstatut.Name = "grpstatut"
        Me.grpstatut.Size = New System.Drawing.Size(137, 119)
        Me.grpstatut.TabIndex = 13
        Me.grpstatut.TabStop = False
        Me.grpstatut.Text = "Statut"
        '
        'optAbandon
        '
        Me.optAbandon.AutoSize = True
        Me.optAbandon.Location = New System.Drawing.Point(18, 86)
        Me.optAbandon.Name = "optAbandon"
        Me.optAbandon.Size = New System.Drawing.Size(92, 24)
        Me.optAbandon.TabIndex = 2
        Me.optAbandon.Text = "Abandon"
        Me.optAbandon.UseVisualStyleBackColor = True
        '
        'optInactif
        '
        Me.optInactif.AutoSize = True
        Me.optInactif.Location = New System.Drawing.Point(18, 56)
        Me.optInactif.Name = "optInactif"
        Me.optInactif.Size = New System.Drawing.Size(69, 24)
        Me.optInactif.TabIndex = 1
        Me.optInactif.Text = "inactif"
        Me.optInactif.UseVisualStyleBackColor = True
        '
        'optActif
        '
        Me.optActif.AutoSize = True
        Me.optActif.Checked = True
        Me.optActif.Location = New System.Drawing.Point(18, 26)
        Me.optActif.Name = "optActif"
        Me.optActif.Size = New System.Drawing.Size(59, 24)
        Me.optActif.TabIndex = 0
        Me.optActif.TabStop = True
        Me.optActif.Text = "Actif"
        Me.optActif.UseVisualStyleBackColor = True
        '
        'grpSexe
        '
        Me.grpSexe.Controls.Add(Me.optMasculin)
        Me.grpSexe.Controls.Add(Me.optFeminin)
        Me.grpSexe.Location = New System.Drawing.Point(297, 25)
        Me.grpSexe.Name = "grpSexe"
        Me.grpSexe.Size = New System.Drawing.Size(137, 93)
        Me.grpSexe.TabIndex = 12
        Me.grpSexe.TabStop = False
        Me.grpSexe.Text = "Sexe"
        '
        'optMasculin
        '
        Me.optMasculin.AutoSize = True
        Me.optMasculin.Location = New System.Drawing.Point(18, 56)
        Me.optMasculin.Name = "optMasculin"
        Me.optMasculin.Size = New System.Drawing.Size(89, 24)
        Me.optMasculin.TabIndex = 1
        Me.optMasculin.Text = "Masculin"
        Me.optMasculin.UseVisualStyleBackColor = True
        '
        'optFeminin
        '
        Me.optFeminin.AutoSize = True
        Me.optFeminin.Checked = True
        Me.optFeminin.Location = New System.Drawing.Point(18, 26)
        Me.optFeminin.Name = "optFeminin"
        Me.optFeminin.Size = New System.Drawing.Size(83, 24)
        Me.optFeminin.TabIndex = 0
        Me.optFeminin.TabStop = True
        Me.optFeminin.Text = "Feminin"
        Me.optFeminin.UseVisualStyleBackColor = True
        '
        'numMoyenne
        '
        Me.numMoyenne.DecimalPlaces = 2
        Me.numMoyenne.Location = New System.Drawing.Point(129, 213)
        Me.numMoyenne.Name = "numMoyenne"
        Me.numMoyenne.Size = New System.Drawing.Size(69, 26)
        Me.numMoyenne.TabIndex = 11
        Me.numMoyenne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numNbCoursReussi
        '
        Me.numNbCoursReussi.Location = New System.Drawing.Point(230, 177)
        Me.numNbCoursReussi.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.numNbCoursReussi.Name = "numNbCoursReussi"
        Me.numNbCoursReussi.Size = New System.Drawing.Size(69, 26)
        Me.numNbCoursReussi.TabIndex = 10
        Me.numNbCoursReussi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMoyenne
        '
        Me.lblMoyenne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMoyenne.Location = New System.Drawing.Point(31, 213)
        Me.lblMoyenne.Name = "lblMoyenne"
        Me.lblMoyenne.Size = New System.Drawing.Size(81, 26)
        Me.lblMoyenne.TabIndex = 9
        Me.lblMoyenne.Text = "Moyenne:"
        Me.lblMoyenne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(118, 138)
        Me.txtVille.MaxLength = 20
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(179, 26)
        Me.txtVille.TabIndex = 8
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(118, 103)
        Me.txtPrenom.MaxLength = 15
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(149, 26)
        Me.txtPrenom.TabIndex = 7
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(118, 67)
        Me.txtNom.MaxLength = 15
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(149, 26)
        Me.txtNom.TabIndex = 6
        '
        'mskDa
        '
        Me.mskDa.Enabled = False
        Me.mskDa.Location = New System.Drawing.Point(118, 33)
        Me.mskDa.Mask = "0000000"
        Me.mskDa.Name = "mskDa"
        Me.mskDa.Size = New System.Drawing.Size(100, 26)
        Me.mskDa.TabIndex = 5
        '
        'lblNbCoursRussi
        '
        Me.lblNbCoursRussi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNbCoursRussi.Location = New System.Drawing.Point(31, 177)
        Me.lblNbCoursRussi.Name = "lblNbCoursRussi"
        Me.lblNbCoursRussi.Size = New System.Drawing.Size(193, 26)
        Me.lblNbCoursRussi.TabIndex = 4
        Me.lblNbCoursRussi.Text = "Nombre de cours reussi:"
        Me.lblNbCoursRussi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVille
        '
        Me.lblVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVille.Location = New System.Drawing.Point(31, 138)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(81, 26)
        Me.lblVille.TabIndex = 3
        Me.lblVille.Text = "Ville:"
        Me.lblVille.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrenom
        '
        Me.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrenom.Location = New System.Drawing.Point(31, 103)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(81, 26)
        Me.lblPrenom.TabIndex = 2
        Me.lblPrenom.Text = "Prenom:"
        Me.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNom
        '
        Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNom.Location = New System.Drawing.Point(31, 67)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(67, 26)
        Me.lblNom.TabIndex = 1
        Me.lblNom.Text = "Nom:"
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ldlDa
        '
        Me.ldlDa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ldlDa.Location = New System.Drawing.Point(31, 33)
        Me.ldlDa.Name = "ldlDa"
        Me.ldlDa.Size = New System.Drawing.Size(67, 26)
        Me.ldlDa.TabIndex = 0
        Me.ldlDa.Text = "DA:"
        Me.ldlDa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstEleve
        '
        Me.lstEleve.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDa, Me.colNom, Me.colPrenom, Me.colVille, Me.colSexe, Me.colNbCoursReussi, Me.colMoyenne, Me.colStatut})
        Me.lstEleve.FullRowSelect = True
        Me.lstEleve.GridLines = True
        Me.lstEleve.HideSelection = False
        Me.lstEleve.Location = New System.Drawing.Point(23, 308)
        Me.lstEleve.MultiSelect = False
        Me.lstEleve.Name = "lstEleve"
        Me.lstEleve.Size = New System.Drawing.Size(772, 311)
        Me.lstEleve.TabIndex = 1
        Me.lstEleve.UseCompatibleStateImageBehavior = False
        Me.lstEleve.View = System.Windows.Forms.View.Details
        '
        'colDa
        '
        Me.colDa.Text = "Da"
        Me.colDa.Width = 80
        '
        'colNom
        '
        Me.colNom.Text = "Nom"
        Me.colNom.Width = 150
        '
        'colPrenom
        '
        Me.colPrenom.Text = "Prenom"
        Me.colPrenom.Width = 150
        '
        'colVille
        '
        Me.colVille.Text = "Ville"
        Me.colVille.Width = 150
        '
        'colSexe
        '
        Me.colSexe.Text = "Sexe"
        '
        'colNbCoursReussi
        '
        Me.colNbCoursReussi.Text = "Cours Reussi"
        '
        'colMoyenne
        '
        Me.colMoyenne.Text = "Moyenne"
        '
        'colStatut
        '
        Me.colStatut.Text = "Statut"
        '
        'btnAjouter
        '
        Me.btnAjouter.Enabled = False
        Me.btnAjouter.Location = New System.Drawing.Point(583, 42)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(150, 42)
        Me.btnAjouter.TabIndex = 2
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Enabled = False
        Me.btnModifier.Location = New System.Drawing.Point(583, 90)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(150, 42)
        Me.btnModifier.TabIndex = 3
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnSupprimer
        '
        Me.btnSupprimer.Enabled = False
        Me.btnSupprimer.Location = New System.Drawing.Point(583, 138)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(150, 42)
        Me.btnSupprimer.TabIndex = 4
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'btnListerEtudiant
        '
        Me.btnListerEtudiant.Enabled = False
        Me.btnListerEtudiant.Location = New System.Drawing.Point(739, 67)
        Me.btnListerEtudiant.Name = "btnListerEtudiant"
        Me.btnListerEtudiant.Size = New System.Drawing.Size(100, 87)
        Me.btnListerEtudiant.TabIndex = 5
        Me.btnListerEtudiant.Text = "Lister etudiant"
        Me.btnListerEtudiant.UseVisualStyleBackColor = True
        '
        'btnCalMoyenne
        '
        Me.btnCalMoyenne.Enabled = False
        Me.btnCalMoyenne.Location = New System.Drawing.Point(739, 163)
        Me.btnCalMoyenne.Name = "btnCalMoyenne"
        Me.btnCalMoyenne.Size = New System.Drawing.Size(100, 91)
        Me.btnCalMoyenne.TabIndex = 6
        Me.btnCalMoyenne.Text = "Calculer moyenne"
        Me.btnCalMoyenne.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Enabled = False
        Me.btnOk.Location = New System.Drawing.Point(583, 185)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(150, 42)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Enabled = False
        Me.btnAnnuler.Location = New System.Drawing.Point(583, 234)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(150, 42)
        Me.btnAnnuler.TabIndex = 8
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(861, 631)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCalMoyenne)
        Me.Controls.Add(Me.btnListerEtudiant)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.lstEleve)
        Me.Controls.Add(Me.grpEleve)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmPrincipal"
        Me.Text = "Gestion d'eleves"
        Me.grpEleve.ResumeLayout(False)
        Me.grpEleve.PerformLayout()
        Me.grpstatut.ResumeLayout(False)
        Me.grpstatut.PerformLayout()
        Me.grpSexe.ResumeLayout(False)
        Me.grpSexe.PerformLayout()
        CType(Me.numMoyenne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNbCoursReussi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpEleve As GroupBox
    Friend WithEvents lblVille As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents ldlDa As Label
    Friend WithEvents lblMoyenne As Label
    Friend WithEvents txtVille As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents mskDa As MaskedTextBox
    Friend WithEvents lblNbCoursRussi As Label
    Friend WithEvents numMoyenne As NumericUpDown
    Friend WithEvents numNbCoursReussi As NumericUpDown
    Friend WithEvents grpstatut As GroupBox
    Friend WithEvents optAbandon As RadioButton
    Friend WithEvents optInactif As RadioButton
    Friend WithEvents optActif As RadioButton
    Friend WithEvents grpSexe As GroupBox
    Friend WithEvents optMasculin As RadioButton
    Friend WithEvents optFeminin As RadioButton
    Friend WithEvents lstEleve As ListView
    Friend WithEvents colDa As ColumnHeader
    Friend WithEvents colNom As ColumnHeader
    Friend WithEvents colPrenom As ColumnHeader
    Friend WithEvents colVille As ColumnHeader
    Friend WithEvents colSexe As ColumnHeader
    Friend WithEvents colNbCoursReussi As ColumnHeader
    Friend WithEvents colMoyenne As ColumnHeader
    Friend WithEvents colStatut As ColumnHeader
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents btnListerEtudiant As Button
    Friend WithEvents btnCalMoyenne As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnAnnuler As Button
End Class
