Module _2_8
    Enum meses As Byte
        enero = 1
        febrero = 2
        marzo = 3
        abril = 4
        mayo = 5
        junio = 6
        julio = 7
        agosto = 8
        septiembre = 9
        octubre = 10
        noviembre = 11
        diciembre = 12
    End Enum
    Sub main()
        Console.WriteLine("ingrese el mes: ")
        Dim mes As meses = Console.ReadLine
        If mes = 1 Or mes = 3 Or mes = 5 Or mes = 7 Or mes = 8 Or mes = 10 Or mes = 12 Then
            Console.WriteLine(" tiene 31 dias")
        ElseIf mes = 4 Or mes = 6 Or mes = 11 Then
            Console.WriteLine("tiene 30 dias")
        ElseIf mes = 2 Then
            Console.WriteLine("febrero, ingrese el año para ver si es bisiesto: ")
            Dim año As UShort = Console.ReadLine
            If año Mod 400 = 0 Then
                Console.WriteLine("es bisiesto, mes de 28 dias")
            End If

        End If
        Console.ReadKey()
    End Sub
End Module
