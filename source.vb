Module Module1

    Public Sub Main(ByVal Args() As String)
        On Error GoTo erreur
        Dim chaine, ligne, fichier, resultat, errMess As String
        Dim i, n As Integer

        chaine = Args(0)
        fichier = Args(1)

        resultat = "KO;" + chaine + ";" + fichier
        i = 0
        n = 0

        FileOpen(1, fichier, OpenMode.Input)
        'Console.WriteLine("Recherche de la chaîne : '" + chaine + "'...")

        While Not EOF(1)
            ligne = LineInput(1)
            i = i + 1
            If ligne.Contains(chaine) = True Then
                resultat = "OK;" + chaine + ";" + fichier + ";" + Str(i).Replace(" ", "")
                Exit While
            Else
            End If
        End While

        FileClose(1)

        Console.WriteLine(resultat)

        GoTo fin

erreur:
        errMess = "ERR;" + fichier + ";" + Err.Description
        Console.WriteLine(errMess)
fin:
        End
    End Sub

End Module
