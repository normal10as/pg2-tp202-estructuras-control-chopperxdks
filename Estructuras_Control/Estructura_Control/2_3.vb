Module _2_3
    Sub main()
        Console.WriteLine("ingrese 5 valores: ")
        Dim a, b, c, d, e As Byte
        a = Console.ReadLine
        b = Console.ReadLine
        c = Console.ReadLine
        d = Console.ReadLine
        e = Console.ReadLine
        If a > b And a > c And a > d And a > e Then
            Console.WriteLine("El primer valor es el mayor: " & a)
        ElseIf b > c And b > d And c > e Then
            Console.WriteLine("El segundo valor es el mayor: " & b)
        ElseIf c > d And c > e Then
            Console.WriteLine("El tercer valor es el mayor: " & c)
        ElseIf d > e Then
            Console.WriteLine("el cuarto valor es el mayor: " & d)
        Else
            Console.WriteLine("El quinto valor es el mayor: " & e)

        End If
        Console.ReadKey()
    End Sub
End Module
