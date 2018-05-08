Module _2_4
    Sub main()
        Dim cantidad As Byte
        Dim precio_unitario As Byte
        Dim descuento As Single
        Dim subtotal As Byte
        Console.WriteLine("Ingrese cantidad: ")
        cantidad = Console.ReadLine
        Console.WriteLine("Ingrese presio: ")
        precio_unitario = Console.ReadLine
        If cantidad >= 10 And cantidad <= 50 Then
            descuento = 0.05
            'subtotal = cantidad * precio_unitario / 100
        ElseIf cantidad > 50 And cantidad <= 250 Then
            descuento = 0.1
            'subtotal = precio_unitario * descuento / 100
        ElseIf cantidad > 250 Then
            descuento = 0.2
            'subtotal = precio_unitario * descuento / 100

        End If
        subtotal = cantidad * precio_unitario
        'Console.WriteLine("Cantidad: " & cantidad & " " & "Precio: " & precio_unitario & " " & "descuento" & subtotal)
        Console.WriteLine("El descuento del {0}", descuento * 100)
        Console.WriteLine("Subtotal: " & subtotal)
        Console.WriteLine("Monto del descuento: {0}", subtotal * descuento)
        Console.WriteLine("Total de pago {0}", subtotal - (subtotal * descuento))
        Console.ReadKey()

    End Sub
End Module
