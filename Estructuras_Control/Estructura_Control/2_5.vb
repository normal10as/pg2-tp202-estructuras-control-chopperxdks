Module _2_5
    Enum meses
        Enero = 1
        Febrero = 2
        Marzo = 3
        Abril = 4
        Mayo = 5
        Junio = 6
        Julio = 7
        Agosto = 8
        Septiembre = 9
        Octubre = 10
        Noviembre = 11
        Diciembre = 12
    End Enum
    Sub main()
        Console.WriteLine("Ingrece un valor para saber el mes(1-12): ")
        Dim a As UShort = Console.ReadLine
        Select Case a
            Case meses.Enero
                Console.WriteLine("Enero")
            Case meses.Febrero
                Console.WriteLine("Febrero")
            Case meses.Marzo
                Console.WriteLine("Marzo")
            Case meses.Abril
                Console.WriteLine("Abril")
            Case meses.Mayo
                Console.WriteLine("Mayo")
            Case meses.Junio
                Console.WriteLine("Junio")
            Case meses.Julio
                Console.WriteLine("Julio")
            Case meses.Agosto
                Console.WriteLine("Agosto")
            Case meses.Septiembre
                Console.WriteLine("Septiembre")
            Case meses.Octubre
                Console.WriteLine("Octunre")
            Case meses.Noviembre
                Console.WriteLine("Noviembre")
            Case meses.Diciembre
                Console.WriteLine("Diciembre")
            Case Else
                Console.WriteLine("Valor incorrecto")
        End Select
        Console.ReadKey()
    End Sub
End Module
