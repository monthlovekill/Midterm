Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        Dim BytCom As Byte
        BytCom = Int(Rnd() * 3)   '隨便抽三個變數1~3，1代表電腦出剪刀，依此類推 
        Select Case BytCom
            Case 1
                MsgBox("你出剪刀，電腦出剪刀，peer", vbOKOnly)
            Case 2
                MsgBox("你出剪刀，電腦出石頭，lose", vbOKOnly)
            Case 3
                MsgBox("你出剪刀，電腦出布，win", vbOKOnly)
        End Select

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Randomize()
        Dim BytCom As Byte
        BytCom = Int(Rnd() * 3)
        Select Case BytCom
            Case 1
                MsgBox("你出石頭，電腦出剪刀，win", vbOKOnly)
            Case 2
                MsgBox("你出石頭，電腦出石頭，peer", vbOKOnly)
            Case 3
                MsgBox("你出石頭，電腦出布，lose", vbOKOnly)
        End Select

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Randomize()
        Dim BytCom As Byte
        BytCom = Int(Rnd() * 3)
        Select Case BytCom
            Case 1
                MsgBox("你出布，電腦出剪刀，lose", vbOKOnly)
            Case 2
                MsgBox("你出布，電腦出石頭，win", vbOKOnly)
            Case 3
                MsgBox("你出布，電腦出布，peer", vbOKOnly)
        End Select

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
