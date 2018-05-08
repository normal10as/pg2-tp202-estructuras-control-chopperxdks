Module _2_9
    Sub mian()
        Dim opcion As Integer
        Dim medida As Integer
        Console.WriteLine("Ingrese un tipo de medida (1- Metros 2- Yardas 3- Pie 4- Pulgadas): ")
        opcion = Console.ReadLine
        Console.WriteLine("Ingrese la medida: ")
        medida = Console.ReadLine
        Select Case opcion
            Case 1
                Dim cm, yarda, pie, pulgada As Single
                cm = medida * 100
                pulgada = cm / 2.54
                pie = pulgada / 12
                yarda = pie / 3
                Console.WriteLine("Son: " & cm & "Centimetros.")
                Console.WriteLine("Son: " & pulgada & "Pulgadas")
                Console.WriteLine("Son: " & pie & "Pie")
                Console.WriteLine("Son: " & yarda & "Yarda")
            Case 2
                Dim cm, metro, pie, pulgada As Single
                pie = medida * 3
                pulgada = pie / 12
                cm = pulgada * 2.54
                metro = cm / 100
                Console.WriteLine("Son: " & pie & " pies.")
                Console.WriteLine("Son: " & pulgada & " pulgadas.")
                Console.WriteLine("Son: " & cm & " centimetros.")
                Console.WriteLine("Son: " & metro & " metros.")
            Case 3
                Dim cm, metro, yarda, pulgada As Single
                yarda = medida / 3
                pulgada = medida * 12
                cm = pulgada / 2.54
                metro = cm * 100
                Console.WriteLine("Son: " & yarda & " yardas.")
                Console.WriteLine("Son: " & pulgada & " pulgadas.")
                Console.WriteLine("Son: " & cm & " centimetros.")
                Console.WriteLine("Son: " & metro & " metros.")
            Case 4
                Dim cm, metro, yarda, pie As Single
                pie = medida / 12
                yarda = pie / 3
                cm = medida * 2.54
                metro = cm * 100
                Console.WriteLine("Son: " & pie & " pies.")
                Console.WriteLine("Son: " & yarda & " yardas.")
                Console.WriteLine("Son: " & cm & " centimetros.")
                Console.WriteLine("Son: " & metro & " metros.")

        End Select
        Console.ReadKey()

    End Sub
End Module
