Module Module1

    Public Sub Main(ByVal Args() As String)
        On Error GoTo erreur
        Dim chaine, ligne, fichier, resultat As String
        Dim i, n As Integer

        chaine = Args(0)
        fichier = Args(1)
        resultat = "Résultat de la recherche : KO"
        i = 0
        n = 0

        FileOpen(1, fichier, OpenMode.Input)
        Console.WriteLine("Recherche de la chaîne : '" + chaine + "'...")

        While Not EOF(1)
            ligne = LineInput(1)
            i = i + 1
            If ligne.Contains(chaine) = True Then
                resultat = "Résultat de la recherche : OK --> chaîne trouvée à la ligne " + Str(i)
                Exit While
            Else
            End If
        End While

        FileClose(1)

        Console.WriteLine(resultat)

        GoTo fin

erreur:
        Console.WriteLine("Une erreur s'est produite, vérifiez que le fichier existe bien !")
fin:
        End
    End Sub

End Module
