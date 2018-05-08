Module _2_13
    Sub main()
        Dim contador, n_primo As UShort
        For a = 1 To 999
            For x = 1 To 999
                If a Mod x = 0 Then
                    contador += 1
                End If
            Next
            If contador = 2 Then
                n_primo += 1
            End If
            contador = 0
        Next
        Console.WriteLine("num primos: " & n_primo)
        Console.ReadKey()
    End Sub
End Module
