Module Module1

    Public Sub Main(ByVal Args() As String)
        On Error GoTo erreur
        Dim chaine, ligne, fichier, contenu, resultat As String
        chaine = Args(0)
        fichier = Args(1)
        resultat = "KO"
        contenu = ""

        FileOpen(1, fichier, OpenMode.Input)


        While Not EOF(1)
            contenu = contenu & LineInput(1)
        End While

        FileClose(1)

        If contenu.Contains(chaine) = True Then
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
