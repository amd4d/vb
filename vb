Public Class Form
Dim count As Integer = 0
Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click Timer1.Enabled = True
End Sub
Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.click Timer1.Enabled = False
End Sub
Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
count = count + 1
Label1.Text = count.ToString
End Sub
End Clace
100
