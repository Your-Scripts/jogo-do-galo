Public Class Form1
    Dim vez As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If vez = 1 Then
            Button1.Text = "X"
            vez = 2
        Else
            Button1.Text = "O"
            vez = 1
        End If
        Button1.Enabled = False
        verificar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If vez = 1 Then
            Button2.Text = "X"
            vez = 2
        Else
            Button2.Text = "O"
            vez = 1
        End If
        Button2.Enabled = False
        verificar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If vez = 1 Then
            Button3.Text = "X"
            vez = 2
        Else
            Button3.Text = "O"
            vez = 1
        End If
        Button3.Enabled = False
        verificar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If vez = 1 Then
            Button4.Text = "X"
            vez = 2
        Else
            Button4.Text = "O"
            vez = 1
        End If
        Button4.Enabled = False
        verificar()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If vez = 1 Then
            Button5.Text = "X"
            vez = 2
        Else
            Button5.Text = "O"
            vez = 1
        End If
        Button5.Enabled = False
        verificar()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If vez = 1 Then
            Button6.Text = "X"
            vez = 2
        Else
            Button6.Text = "O"
            vez = 1
        End If
        Button6.Enabled = False
        verificar()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If vez = 1 Then
            Button7.Text = "X"
            vez = 2
        Else
            Button7.Text = "O"
            vez = 1
        End If
        Button7.Enabled = False
        verificar()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If vez = 1 Then
            Button8.Text = "X"
            vez = 2
        Else
            Button8.Text = "O"
            vez = 1
        End If
        Button8.Enabled = False
        verificar()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If vez = 1 Then
            Button9.Text = "X"
            vez = 2
        Else
            Button9.Text = "O"
            vez = 1
        End If
        Button9.Enabled = False
        verificar()
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Application.Restart()
    End Sub

    Sub verificar()
        If ((Button1.Text = "X") And (Button2.Text = "X") And (Button3.Text = "X")) Then
            MsgBox("Parabens vc ganhou!!!")
        ElseIf ((Button4.Text = "X") And (Button5.Text = "X") And (Button6.Text = "X")) Then
            MsgBox("Parabens vc ganhou!!!")
        ElseIf ((Button7.Text = "X") And (Button8.Text = "X") And (Button9.Text = "X")) Then
            MsgBox("Parabens vc ganhou!!!")
        ElseIf ((Button1.Text = "X") And (Button4.Text = "X") And (Button7.Text = "X")) Then
            MsgBox("Parabens vc ganhou!!!")
        ElseIf ((Button2.Text = "X") And (Button5.Text = "X") And (Button8.Text = "X")) Then
            MsgBox("Parabens vc ganhou!!!")
        ElseIf ((Button3.Text = "X") And (Button6.Text = "X") And (Button9.Text = "X")) Then
            MsgBox("Parabens vc ganhou!!!")
        ElseIf ((Button1.Text = "X") And (Button5.Text = "X") And (Button9.Text = "X")) Then
            MsgBox("Parabens vc ganhou!!!")
        ElseIf ((Button3.Text = "X") And (Button5.Text = "X") And (Button7.Text = "X")) Then
            MsgBox("Parabens vc ganhou!!!")
        End If

        If ((Button1.Text <> "") And (Button2.Text <> "") And (Button3.Text <> "") And (Button4.Text <> "") And (Button5.Text <> "") And (Button6.Text <> "") And (Button7.Text <> "") And (Button8.Text <> "") And (Button9.Text <> "")) Then
            MsgBox("Deu empate")
            Exit Sub
        End If
    End Sub
End Class