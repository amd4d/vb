visual basic count ..... 

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










hsisususus


Public Class Form1
0 references
Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click If TextBox3. Text> -1 And TextBox3.Text < 50 Then
MessageBox.Show("fail")
ElseIf TextBox3. Text> 49 And TextBox3.Text < 59 Then
MessageBox.Show("pass")
ElseIf TextBox3. Text> 59 And TextBox3. Text < 69 Then
MessageBox.Show("medium")
ElseIf TextBox3. Text > 69 And TextBox3.Text < 79 Then
MessageBox.Show("good")
ElseIf TextBox3.Text> 79 And TextBox3. Text < 89 Then
MessageBox.Show("very good")
ElseIf TextBox3.Text > 89 And TextBox3. Text < 101 Then MessageBox.Show("excellent")
Else
MessageBox.Show("out of the range")
End If
End Sub





shhshehehehe

butn 1 login 

Form1
Public Class Form
Declarations)
Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
If TextBox1.Text = "admin" And TextBox2.Text = "12345" Then
Else
Form2.Show() Me.Hide()
MessageBox.Show("The Username or Password is incorrect")
End If
End Sub
Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
Me.Close()
End Sub
End Class