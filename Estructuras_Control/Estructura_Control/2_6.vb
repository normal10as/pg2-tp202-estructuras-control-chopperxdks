Module _2_6
    Sub main()
        Dim cantidad As Byte
        Dim precio_unitario As Byte
        Dim descuento As Single
        Dim subtotal As Byte
        Dim eleccion As Integer
        Console.WriteLine("Ingrece el descuento (1- 5% de descuento 2- 10% 3- 20%): ")
        eleccion = Console.ReadLine
        Select Case eleccion
            Case 1
                Console.WriteLine("Ingrese cantidad: ")
                cantidad = Console.ReadLine
                Console.WriteLine("Ingrese presio: ")
                precio_unitario = Console.ReadLine
                subtotal = cantidad * precio_unitario
                descuento = subtotal / 0.05
                Console.WriteLine("El descuento del {0}", descuento * 100)
                Console.WriteLine("Subtotal: " & subtotal)
                Console.WriteLine("Monto del descuento: {0}", subtotal * descuento)
                Console.WriteLine("Total de pago {0}", subtotal - (subtotal * descuento))
            Case 2
                Console.WriteLine("Ingrese cantidad: ")
                cantidad = Console.ReadLine
                Console.WriteLine("Ingrese presio: ")
                precio_unitario = Console.ReadLine
                subtotal = cantidad * precio_unitario
                descuento = subtotal / 0.01
                Console.WriteLine("El descuento del {0}", descuento * 100)
                Console.WriteLine("Subtotal: " & subtotal)
                Console.WriteLine("Monto del descuento: {0}", subtotal * descuento)
                Console.WriteLine("Total de pago {0}", subtotal - (subtotal * descuento))
            Case 3
                Console.WriteLine("Ingrese cantidad: ")
                cantidad = Console.ReadLine
                Console.WriteLine("Ingrese presio: ")
                precio_unitario = Console.ReadLine
                subtotal = cantidad * precio_unitario
                descuento = subtotal / 0.02
                Console.WriteLine("El descuento del {0}", descuento * 100)
                Console.WriteLine("Subtotal: " & subtotal)
                Console.WriteLine("Monto del descuento: {0}", subtotal * descuento)
                Console.WriteLine("Total de pago {0}", subtotal - (subtotal * descuento))
        End Select
        Console.ReadKey()
    End Sub
End Module
