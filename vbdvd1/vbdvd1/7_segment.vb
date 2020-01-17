Public Class Form1
    Public counter As Integer = -1

    Private Sub clear_color()

        Button1.BackColor = Color.LightGray
        Button2.BackColor = Color.LightGray
        Button3.BackColor = Color.LightGray
        Button4.BackColor = Color.LightGray
        Button5.BackColor = Color.LightGray
        Button6.BackColor = Color.LightGray
        Button7.BackColor = Color.LightGray
        

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        


        Timer1.Start()



    End Sub

    

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        counter += 1

        If counter > 9 Then
            counter = 0
        End If

        If counter = 0 Then
            clear_color()
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Return
        End If

        If counter = 1 Then
            clear_color()
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Return
        End If

        If counter = 2 Then
            clear_color()
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Return
        End If

        If counter = 3 Then
            clear_color()
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Return
        End If

        If counter = 4 Then
            clear_color()
            Button1.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Return
        End If

        If counter = 5 Then
            clear_color()
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Return
        End If

        If counter = 6 Then
            clear_color()
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Return
        End If

        If counter = 7 Then
            clear_color()
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Return
        End If

        If counter = 8 Then
            clear_color()
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Return
        End If

        If counter = 9 Then
            clear_color()
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Return
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Timer1.Stop()

    End Sub
End Class
