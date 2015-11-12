Module Module1

    Sub main()
        Dim i, j As Integer
        For i = 1 To 9
            For j = 1 To 9
                Dim ans As Integer = i * j
                Console.Write(i & "*" & j & "=" & ans & vbTab)
            Next j
            Console.WriteLine()
        Next i
    End Sub


End Module
