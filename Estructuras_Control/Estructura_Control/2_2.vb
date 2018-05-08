Module _2_2
    Sub main()
        Console.WriteLine("ingrese 3 valores: ")
        Dim a As Byte = Console.ReadLine
        Dim b As Byte = Console.ReadLine
        Dim c As Byte = Console.ReadLine
        If a < b And a < c Then
            Console.WriteLine("el primer valir es el menor:" & a)
        ElseIf b < c Then
            Console.WriteLine("el seg valor es el menor: " & b)
        Else
            Console.WriteLine("el tercer valor es el menor" & c)

        End If
        Console.ReadKey()

    End Sub
End Module
