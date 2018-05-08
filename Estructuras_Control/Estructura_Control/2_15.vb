Module _2_15
    Sub main()
        Dim anual, interes, saldo, m, capital, total_impuestos As Integer
        anual = 36%
        m = anual / 12
        Console.Write("Ingrese capital inicial:$ ")
        capital = Console.ReadLine
        interes = (m * capital) / 100
        For mes As Integer = 1 To 24
            saldo = interes + capital
            Console.WriteLine("Mes: " & mes & "Capital:$ " & capital & "Interes: " & interes & " % " & "Saldo: $" & saldo)
            capital = saldo
            total_impuestos = total_impuestos + interes
        Next
        Console.WriteLine("Total de intres ganado: $" & total_impuestos)
        Console.ReadKey()
    End Sub
End Module
