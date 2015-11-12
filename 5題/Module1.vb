Module Module1

    Sub Main()
        Dim i, j, k, m, n
        For i = 1 To 9
            For j = 1 To 9
                m = (i * j).ToString
                n = StrDup(4 - Len(m), " ")
                k &= i & "*" & j & "=" & m & n
            Next
            Console.WriteLine(k) : k = ""
        Next
        Console.ReadKey()
    End Sub
End Module

