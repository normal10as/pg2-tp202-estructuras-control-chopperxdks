Module _2_1
    Sub main()
        Console.WriteLine("Ingrese dos valores para comparar: ")
        Dim a As Byte = Console.ReadLine
        Dim b As Byte = Console.ReadLine
        If a > b Then
            Console.WriteLine("El mayor valor es: " & a)
        ElseIf a = b Then
            Console.WriteLine("Los dos valores son iguales: " & a & b)
        Else
            Console.WriteLine("EL mayor valor es: " & b)

        End If
        Console.ReadKey()

    End Sub
End Module
