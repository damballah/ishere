Module Module1

    Public Sub Main(ByVal Args() As String)
        On Error GoTo erreur
        Dim chaine, ligne, fichier, contenu, resultat As String
        Dim SR As New IO.StreamReader(Args(1))

        chaine = Args(0)
        'fichier = Args(1)
        resultat = "KO"


        Do Until SR.Peek = -1
            ligne = ligne & SR.ReadLine()
        Loop

        SR.Close()

        If ligne.Contains(chaine) = True Then
            resultat = "OK"
        Else
        End If

        Console.WriteLine(resultat)

        GoTo fin



erreur:
        Console.WriteLine("Une erreur s'est produite, vérifiez que le fichier existe bien !")
fin:
        End
    End Sub

End Module
