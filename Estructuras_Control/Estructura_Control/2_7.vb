Module _2_7
    Sub main()
        Console.WriteLine("Ingrese los grados: ")
        Dim grados As Integer = Console.ReadLine
        Select Case grados
            Case Is < 90
                Console.WriteLine("Es Agudo")
            Case 90
                Console.WriteLine("Es Recto")
            Case Is < 180
                Console.WriteLine("Es Obtuso")
            Case 180
                Console.WriteLine("Es Llano")
            Case Is < 360
                Console.WriteLine("Es Conbavo")
            Case Else
                Console.WriteLine("Valor incorrecto")

        End Select
        Console.ReadKey()

    End Sub
End Module
