'================================================================================
'Author:		Maxime Caron
'Create date:   29 Juin 2022
'Description:	Page pour le code de la classe Etudiant
'================================================================================

Imports System.IO

Public Class Etudiant
    Const nomFichier As String = "Eleves.Dta"

    Private Property _Da As String
    Private Property _Nom As String
    Private Property _Prenom As String
    Private Property _Sexe As Char
    Private Property _Ville As String
    Private Property _NbCoursReussi As Integer
    Private Property _Moyenne As Single
    Private Property _Statut As Char
    Public Shared Property _Nb_Etu As Integer = 0
    Public Property _Index As Integer = 0
    Private _ListEtudiant As ArrayList
    Private Shared _NbConnexion As Integer = 0

    ''' <summary>
    ''' Cette procedure permet calculer nombre etudiant et les lister dans l'arrayList a partir du fichier texte
    ''' </summary>
    Public Sub New()
        Try
            Dim fs As New FileStream(nomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None)
            Dim sr As New StreamReader(fs)

            Const longeurEtu As Integer = 73
            _Nb_Etu = (fs.Length / longeurEtu) - 1

            _ListEtudiant = New ArrayList()
            If _Nb_Etu > 0 Then
                Dim ligne As String
                For i = 0 To _Nb_Etu
                    ligne = sr.ReadLine()
                    _ListEtudiant.Add(ligne)
                Next
            End If

            sr.Close()
            fs.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(Err.Number)
        End Try
    End Sub

    ''' <summary>
    ''' Cette proprieter permet de seulement lire nombre d'etudiant
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property Nb_Etu As Integer
        Get
            Return _Nb_Etu
        End Get
    End Property

    ''' <summary>
    ''' Cette proprieter permet de seulement lire le DA de l'etudiant
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Da As String
        Get
            Return _Da
        End Get
    End Property

    ''' <summary>
    ''' Cette proprieter permet de seulement lire le Nom de l'etudiant
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Nom As String
        Get
            Return _Nom
        End Get
    End Property

    ''' <summary>
    ''' Cette proprieter permet de seulement lire le Prenom de l'etudiant
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Prenom As String
        Get
            Return _Prenom
        End Get
    End Property

    ''' <summary>
    ''' Cette proprieter permet de seulement lire le Prenom de l'etudiant
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Sexe As Char
        Get
            Return _Sexe
        End Get
    End Property

    ''' <summary>
    ''' Cette proprieter permet de seulement lire le Ville de l'etudiant
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Ville As String
        Get
            Return _Ville
        End Get
    End Property

    ''' <summary>
    ''' Cette proprieter permet de seulement lire le Nombre de Cours Reussi de l'etudiant
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property NbCoursReussi As Integer
        Get
            Return _NbCoursReussi
        End Get
    End Property

    ''' <summary>
    ''' Cette proprieter permet de seulement lire le Moyenne de l'etudiant
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Moyenne As Single
        Get
            Return _Moyenne
        End Get
    End Property

    ''' <summary>
    ''' Cette proprieter permet de seulement lire le Statut de l'etudiant
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Statut As Char
        Get
            Return _Statut
        End Get
    End Property

    ''' <summary>
    ''' Cette proprieter permet de seulement lire et d'ecrice l'Index pour selectionner un etudiant
    ''' </summary>
    ''' <returns></returns>
    Public Property Index As Integer
        Get
            Return _Index
        End Get
        Set(value As Integer)
            _Index = value
            Dim tabLigne() As String = Split(_ListEtudiant(_Index).ToString(), ";")
            _Da = tabLigne(0)
            _Nom = tabLigne(1)
            _Prenom = tabLigne(2)
            _Ville = tabLigne(3)
            _Sexe = tabLigne(4)
            _NbCoursReussi = tabLigne(5)
            _Moyenne = tabLigne(6)
            _Statut = tabLigne(7)
        End Set
    End Property

    ''' <summary>
    ''' Cette proprieter permet de seulement lire la list des etudiants
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property ListEtudiant As ArrayList
        Get
            Return _ListEtudiant
        End Get
    End Property

    ''' <summary>
    ''' Cette proprieter permet ???????
    ''' </summary>
    ''' <returns></returns>
    Public Property NbConnexion As Integer
        Get
            Return _NbConnexion
        End Get
        Set(value As Integer)
            _NbConnexion = value
        End Set
    End Property

    ''' <summary>
    ''' Cette procedure permet de d'ajouter un etudiant a la List des etudiants
    ''' </summary>
    ''' <param name="nom"></param>
    ''' <param name="prenom"></param>
    ''' <param name="sexe"></param>
    ''' <param name="ville"></param>
    ''' <param name="nbcr"></param>
    ''' <param name="moyenne"></param>
    ''' <param name="statut"></param>
    Public Sub AjouterEtudiant(nom As String, prenom As String, sexe As Char, ville As String, nbcr As Integer, moyenne As Single, statut As Char)
        _Da += 1
        _Nom = nom
        _Prenom = prenom
        _Sexe = sexe
        _Ville = ville
        _NbCoursReussi = nbcr
        _Moyenne = moyenne
        _Statut = statut

        _Nb_Etu += 1
        _ListEtudiant.Add($"{_Da.PadRight(7)};{_Nom.PadRight(15)};{_Prenom.PadRight(15)};{_Ville.PadRight(20)};{_Sexe};{_NbCoursReussi.ToString("00")};{_Moyenne.ToString("000.00")};{_Statut}")

        If _Nb_Etu Mod 5 = 0 Then
            RaiseEvent BesoinProf("Besoin de Professeur")
        End If
    End Sub

    ''' <summary>
    ''' Cette procedure permet de modifier un etudiant a la List des etudiants
    ''' </summary>
    ''' <param name="da"></param>
    ''' <param name="nom"></param>
    ''' <param name="prenom"></param>
    ''' <param name="sexe"></param>
    ''' <param name="ville"></param>
    ''' <param name="nbcr"></param>
    ''' <param name="moyenne"></param>
    ''' <param name="statut"></param>
    Public Sub ModifierEtudiant(da As Integer, nom As String, prenom As String, sexe As Char, ville As String, nbcr As Integer, moyenne As Single, statut As Char)
        Dim Index As Integer

        _Nom = nom
        _Prenom = prenom
        _Sexe = sexe
        _Ville = ville
        _NbCoursReussi = nbcr
        _Moyenne = moyenne
        _Statut = statut

        For i = 0 To _Nb_Etu
            _Da = Microsoft.VisualBasic.Left(_ListEtudiant(i), 7) 'Bug avec Left oubliger de mettre Microsoft.VisualBasic devant
            If da = _Da Then
                Index = i
            End If
        Next

        _Da = da
        _ListEtudiant(Index) = $"{_Da.PadRight(7)};{_Nom.PadRight(15)};{_Prenom.PadRight(15)};{_Ville.PadRight(20)};{_Sexe};{_NbCoursReussi.ToString("00")};{_Moyenne.ToString("000.00")};{_Statut}"

        If _NbCoursReussi >= 20 Then
            RaiseEvent DiplomeObtenue($"{_Prenom} {_Nom} a obtenue son diplome")
        End If

        If _NbCoursReussi < 20 And statut = "X" Then
            RaiseEvent EchecEtudiant($"{_Prenom} {_Nom} a echoue")
        End If
    End Sub

    ''' <summary>
    ''' Cette procedure permet de supprimer un etudiant a la List des etudiants
    ''' </summary>
    ''' <param name="da"></param>
    Public Sub SupprimerEtudiant(da As Integer)
        Dim index As Integer

        For i = 0 To _Nb_Etu
            _Da = Microsoft.VisualBasic.Left(_ListEtudiant(i), 7).ToString() 'Bug avec Left oubliger de mettre Microsoft.VisualBasic devant
            If da = _Da Then
                index = i
            End If
        Next

        _ListEtudiant.RemoveAt(index)

        _Nb_Etu -= 1

        If _Nb_Etu Mod 5 = 0 Then
            RaiseEvent BesoinProf("Besoin de Professeur")
        End If
    End Sub

    ''' <summary>
    ''' Cette procedure permet de lister les etudiants avec son DA,son Prenom et son Nom
    ''' </summary>
    Public Sub ListerEtudiant()
        Dim texte As String
        For i = 0 To Nb_Etu
            _Da = Microsoft.VisualBasic.Left(_ListEtudiant(i), 7)
            _Nom = Mid(_ListEtudiant(i), 9, 15)
            _Prenom = Mid(_ListEtudiant(i), 25, 15)
            texte = $"{texte} {_Da} {_Prenom}  {_Nom}" & vbCrLf
        Next
        MsgBox(texte)
    End Sub

    ''' <summary>
    ''' Cette procedure permet de calculer la moyenne de tous etudiants
    ''' </summary>
    Public Sub CalculerMoyenne()
        Dim calMoy As Single
        For i = 0 To Nb_Etu
            _Moyenne = Mid(_ListEtudiant(i), 67, 6)
            calMoy += _Moyenne
        Next
        calMoy = calMoy / (Nb_Etu + 1)
        MsgBox($"La moyenne de tous les etudiants: {calMoy}%", MsgBoxStyle.Information, "Moyenne")
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    ''' <summary>
    ''' Cette evenement sert a indiquer le manque de professeur
    ''' </summary>
    ''' <param name="message"></param>
    Public Event BesoinProf(message As String)

    ''' <summary>
    ''' Cette pogner est pour afficher le message du manque de professeur
    ''' </summary>
    ''' <param name="message"></param>
    Private Sub Handle_Besoin_Prof(message As String) Handles Me.BesoinProf
        MsgBox(message)
    End Sub

    ''' <summary>
    ''' Cette evenement sert a indiquer le diplome obtenue
    ''' </summary>
    ''' <param name="message"></param>
    Public Event DiplomeObtenue(message As String)

    ''' <summary>
    ''' Cette pogner est pour afficher le message du diplome obtenue
    ''' </summary>
    ''' <param name="message"></param>
    Private Sub Handle_Diplome_Obtenue(message As String) Handles Me.DiplomeObtenue
        MsgBox(message)
    End Sub

    ''' <summary>
    ''' Cette evenement sert a indiquer un echec
    ''' </summary>
    ''' <param name="message"></param>
    Public Event EchecEtudiant(message As String)

    ''' <summary>
    ''' Cette pogner est pour afficher le message d'un echec
    ''' </summary>
    ''' <param name="message"></param>
    Private Sub Handle_Echec_Etudianf(message As String) Handles Me.EchecEtudiant
        MsgBox(message)
    End Sub
End Class
