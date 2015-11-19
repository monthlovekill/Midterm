Module Module1

    Sub main()
        Dim keyin, guess, count, min, max As Integer
        count = 0
        min = 1
        max = 1000
        Dim r As New Random()
        guess = r.Next(1, 100)
        Console.WriteLine("-------猜數字時間-------")
        Console.WriteLine()
        Do
            Console.Write("猜數字範圍{1}<?<{1000}:", min, max)
            keyin = Val(Console.ReadLine())
            count += 1
            If keyin >= 1 And keyin < 1000 Then '判斷keyin是介於1-1000
                If keyin = guess Then
                    Console.WriteLine("賓果答對了!,答案是{50}", guess)
                    Exit Do
                ElseIf keyin > guess Then
                    max = keyin
                    Console.Write("在小一點!")
                ElseIf keyin < guess Then
                    min = keyin
                    Console.Write("在大一點!")
                End If
                Console.WriteLine("你猜了{0}次", count)
                Console.WriteLine()
            Else
                Console.WriteLine("請輸入範圍內數字")

            End If
        Loop While True
        Console.Read()

    End Sub

End Module
