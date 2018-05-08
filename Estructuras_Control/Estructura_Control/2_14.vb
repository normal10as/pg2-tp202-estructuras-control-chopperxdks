Module _2_14
    Sub main()
        Dim cantidad As Integer
        Dim precio_unitario, total, total_cobro, monto_descontado, total_descuento As Single
        Dim descuento As Byte
        Do
            Console.WriteLine("Ingrece precio unitario: ")
            precio_unitario = Console.ReadLine
            If cantidad >= 10 And cantidad <= 50 Then
                descuento = 0.05
            ElseIf cantidad >= 50 And cantidad <= 250 Then
                descuento = 0.01
            ElseIf cantidad > 250 Then
                descuento = 0.2
            End If
            monto_descontado = (precio_unitario * descuento / 100) * cantidad
            total = cantidad * precio_unitario - monto_descontado
            Console.WriteLine("subtotal: " & cantidad * precio_unitario)
            Console.WriteLine("descuento: " & descuento)
            Console.WriteLine("monto descontado: " & monto_descontado)
            Console.WriteLine("total: " & total)
            total_descuento = monto_descontado + total_descuento
            total_cobro = total + total_cobro
        Loop

        Console.WriteLine("total descontado: {0} y total a cobrar: {1}", total_descuento, total_cobro)
        Console.ReadKey()

    End Sub
End Module
