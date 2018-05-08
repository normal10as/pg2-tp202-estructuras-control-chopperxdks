Module _2_12
    Sub main()
        Dim inicio As UShort
        Dim final As UShort = 1
        Dim secuencia As UShort = 0
        Dim a As Byte = 1
        Console.WriteLine("fibonacci")
        While a <= 20
            Console.WriteLine(a & " º " & secuencia)
            secuencia = inicio + final
            inicio = final
            final = secuencia

            Console.ReadKey()
            a += 1
        End While
        '
        Console.ReadKey()
    End Sub
End Module
