Module _2_11
    Sub main()
        Dim a As Byte = 1
        Dim pares, impares, contador As Byte
        Do Until a = 0
            Console.WriteLine("ingrese valor o (0 FIN:)")
            a = Console.ReadLine
            If a Mod 2 = 0 And a <> 0 Then
                pares += 1
            ElseIf a Mod 2 <> 0 And a <> 0 Then
                impares += 1
            End If
            contador += 1
        Loop
        contador = contador - 1

        If contador = 0 Then
            Console.WriteLine("FIN")

        ElseIf pares = contador Then
            Console.WriteLine("pares: " & pares)

        ElseIf impares = contador Then
            Console.WriteLine("impares: " & impares)
        Else

            Console.WriteLine("Los valores ingresados son {0}, pares: {1} e impares: {2} ", contador, pares, impares)
        End If
        Console.ReadKey()
    End Sub
End Module
