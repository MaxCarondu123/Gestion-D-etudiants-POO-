'================================================================================
'Author:		Maxime Caron
'Create date:   29 Juin 2022
'Description:	Page pour le code du formulaire pour la gestion d'etudiant
'================================================================================

Imports System.IO

Public Enum Action
    Ajout = 0
    Modif = 1
End Enum

Public Class frmPrincipal
    Dim action As Action
    Dim WithEvents etu As New Etudiant()

    ''' <summary>
    ''' Cette procedure permet de initisaliser le formmulaire au l'ouverture du programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If (Etudiant._Nb_Etu > 0) Then
                Remplir_ListView()

                lstEleve.Items(0).Selected = True
                If lstEleve.SelectedItems.Count > 0 Then
                    Debarrer(btnAjouter, btnModifier, btnSupprimer, btnListerEtudiant, btnCalMoyenne)
                    Remplir_FormEtudiant(lstEleve.SelectedIndices(0))
                End If
            Else
                Verifier_NbrEtu()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de remplir le ListView des etudiants
    ''' </summary>
    Public Sub Remplir_ListView()
        Try
            Dim list As ListViewItem
            Dim cpt As Integer = 0
            For i = 0 To Etudiant._Nb_Etu
                cpt += 1
                etu.Index = i

                list = New ListViewItem(etu.Da)
                list.SubItems.Add(etu.Nom)
                list.SubItems.Add(etu.Prenom)
                list.SubItems.Add(etu.Ville)
                list.SubItems.Add(etu.Sexe)
                list.SubItems.Add(etu.NbCoursReussi)
                list.SubItems.Add(etu.Moyenne)
                list.SubItems.Add(etu.Statut)
                lstEleve.Items.Add(list)

                If cpt Mod 2 = 0 Then
                    list.BackColor = Color.CadetBlue
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Permet de savoir quelle ligne est selectionner dans le ListView
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lstEleve_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEleve.SelectedIndexChanged
        Try
            If lstEleve.SelectedItems.Count > 0 Then
                Remplir_FormEtudiant(lstEleve.SelectedIndices(0))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de remplir le formualire d'un etudiant qui a ete selectionner
    ''' </summary>
    ''' <param name="no"></param>
    Private Sub Remplir_FormEtudiant(no As Integer)
        Try
            mskDa.Text = lstEleve.SelectedItems(0).SubItems(0).Text
            txtNom.Text = lstEleve.SelectedItems(0).SubItems(1).Text
            txtPrenom.Text = lstEleve.SelectedItems(0).SubItems(2).Text
            txtVille.Text = lstEleve.SelectedItems(0).SubItems(3).Text

            If lstEleve.SelectedItems(0).SubItems(4).Text = "F" Then
                optFeminin.Checked = True
            Else
                optMasculin.Checked = True
            End If

            numNbCoursReussi.Value = lstEleve.SelectedItems(0).SubItems(5).Text
            numMoyenne.Value = lstEleve.SelectedItems(0).SubItems(6).Text

            If lstEleve.SelectedItems(0).SubItems(7).Text = "A" Then
                optActif.Checked = True
            ElseIf lstEleve.SelectedItems(0).SubItems(7).Text = "I" Then
                optInactif.Checked = True
            Else
                optAbandon.Checked = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet d'ajouter un etudiant a partir de son bouton dans le formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Try
            action = Action.Ajout
            Barrer(btnAjouter, btnModifier, btnSupprimer, btnListerEtudiant, btnCalMoyenne, lstEleve)
            Debarrer(grpEleve, btnOk, mskDa)

            Vider_Formulaire()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de modifier un etudiant a partir de son bouton dans le formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Try
            action = Action.Modif
            Barrer(btnAjouter, btnModifier, btnSupprimer, btnListerEtudiant, btnCalMoyenne, lstEleve)
            Debarrer(grpEleve, btnOk)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de valider son ajout ou modification d'un etudiant a partir de son bouton dans le formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            Dim sexe As Char
            Dim statut As Char
            Choix_RadioButton(sexe, statut)

            If action = Action.Ajout Then
                etu.AjouterEtudiant(txtNom.Text, txtPrenom.Text, sexe, txtVille.Text, numNbCoursReussi.Value, numMoyenne.Value, statut)
            ElseIf action = Action.Modif Then
                etu.ModifierEtudiant(mskDa.Text, txtNom.Text, txtPrenom.Text, sexe, txtVille.Text, numNbCoursReussi.Value, numMoyenne.Value, statut)
            End If
            lstEleve.Items.Clear()
            Remplir_ListView()

            Barrer(grpEleve, btnOk, mskDa)
            Debarrer(btnAjouter, btnModifier, btnSupprimer, btnListerEtudiant, btnCalMoyenne, lstEleve)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de supprimer un etudiant a partir de son bouton dans le formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        Try
            Dim reponse As Integer = MsgBox("Voulez-vous vraiment supprimer l'etudiant ?", MsgBoxStyle.Question + vbYesNo, "Supprimer")
            If reponse = vbYes Then
                etu.SupprimerEtudiant(mskDa.Text)
            End If
            lstEleve.Items.Clear()
            Remplir_ListView()
            Verifier_NbrEtu()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de barrer les controle dans le formaulaire
    ''' </summary>
    ''' <param name="ctrl"></param>
    Private Sub Barrer(ParamArray ctrl() As Control)
        For Each c As Control In ctrl
            c.Enabled = False
        Next
    End Sub

    ''' <summary>
    ''' Cette procedure permet de debarrer les controle dans le formaulaire
    ''' </summary>
    ''' <param name="ctrl"></param>
    Private Sub Debarrer(ParamArray ctrl() As Control)
        For Each c As Control In ctrl
            c.Enabled = True
        Next
    End Sub

    ''' <summary>
    ''' Cette procedure permet initisaliser les choix sur les radio boutton 
    ''' </summary>
    ''' <param name="sexe"></param>
    ''' <param name="statut"></param>
    Private Sub Choix_RadioButton(sexe As Char, statut As Char)
        If optFeminin.Checked = True Then
            sexe = "F"
        Else
            sexe = "M"
        End If

        If optActif.Checked = True Then
            statut = "A"
        ElseIf optInactif.Checked = True Then
            statut = "I"
        Else
            statut = "X"
        End If
    End Sub

    ''' <summary>
    ''' Cette procedure permet de calculer la moyenne un etudiant a partir de son bouton dans le formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalMoyenne_Click(sender As Object, e As EventArgs) Handles btnCalMoyenne.Click
        Try
            etu.CalculerMoyenne()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de lister les etudiants a partir de son bouton dans le formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnListerEtudiant_Click(sender As Object, e As EventArgs) Handles btnListerEtudiant.Click
        Try
            etu.ListerEtudiant()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cette procedure permet de vider les champs dans le formualire d'un etudiant
    ''' </summary>
    Private Sub Vider_Formulaire()
        mskDa.Text = ""
        txtNom.Text = ""
        txtPrenom.Text = ""
        txtVille.Text = ""
        numNbCoursReussi.Value = 0
        numMoyenne.Value = 0.00
        optFeminin.Checked = True
        optActif.Checked = True
    End Sub

    Private Sub Verifier_NbrEtu()
        If Etudiant._Nb_Etu <= 0 Then
            Barrer(grpEleve, btnOk, mskDa, btnModifier, btnSupprimer, btnListerEtudiant, btnCalMoyenne, lstEleve)
            Debarrer(btnAjouter)
        End If
    End Sub
End Class
