Module _2_10
    Sub main()
        'Dim valor1, valor2, multiplo As Integer
        'Console.WriteLine("Ingrese valor1(menor): ")
        'valor1 = Console.ReadLine
        'Console.WriteLine("Ingrese valor2(mayor): ")
        'valor2 = Console.ReadLine
        'Do While (valor1 < valor2)
        '    If valor1 Mod 5 = 0 Then
        '        multiplo = multiplo + 1
        '    End If
        '    valor1 = valor1 + 1

        'Loop
        'Console.WriteLine("Multiplo de 5: " & multiplo)
        'Console.ReadKey()

        'Dim valor1, valor2, multiplo As Integer
        'Console.WriteLine("Ingrese valor1(menor): ")
        'valor1 = Console.ReadLine
        'Console.WriteLine("Ingrese valor2(mayor): ")
        'valor2 = Console.ReadLine
        'Do Until (valor1 > valor2)
        '    If valor1 Mod 5 = 0 Then
        '        multiplo = multiplo + 1
        '    End If
        '    valor1 = valor1 + 1

        'Loop
        'Console.WriteLine("Multiplo de 5: " & multiplo)
        'Console.ReadKey()

        'Dim valor1, valor2, multiplo As Integer
        'Console.WriteLine("Ingrese valor1(menor): ")
        'valor1 = Console.ReadLine
        'Console.WriteLine("Ingrese valor2(mayor): ")
        'valor2 = Console.ReadLine
        'Do
        '    If valor1 Mod 5 = 0 Then
        '        multiplo = multiplo + 1
        '    End If
        '    valor1 = valor1 + 1

        'Loop While (valor1 <= valor2)
        'Console.WriteLine("Multiplo de 5: " & multiplo)
        'Console.ReadKey()

        Dim valor1, valor2, multiplo As Integer
        Console.WriteLine("Ingrese valor1(menor): ")
        valor1 = Console.ReadLine
        Console.WriteLine("Ingrese valor2(mayor): ")
        valor2 = Console.ReadLine
        Do
            If valor1 Mod 5 = 0 Then
                multiplo = multiplo + 1
            End If
            valor1 = valor1 + 1

        Loop Until valor1 > valor2
        Console.WriteLine("Multiplo de 5: " & multiplo)
        Console.ReadKey()

    End Sub
End Module
