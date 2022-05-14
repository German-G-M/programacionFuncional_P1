Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim array(3), a As Integer
        Dim b As Boolean
        array(0) = Convert.ToInt32(TextBox1.Text)
        array(1) = Convert.ToInt32(TextBox2.Text)
        array(2) = Convert.ToInt32(TextBox3.Text)
        'If array(0) > array(1) Then GoTo intercambiar1 Else If array(0) > array(2) Then GoTo intercambiar2 Else If array(1) > array(2) Then GoTo intercambiar3 Else GoTo salir
        'intercambiar1:
        If array(0) < array(1) Then GoTo intercambiar2
        a = array(0)
        array(0) = array(1)
        array(1) = a

intercambiar2:
        If array(0) < array(2) Then GoTo intercambiar3
        a = array(0)
        array(0) = array(2)
        array(2) = a
intercambiar3:
        If array(1) < array(2) Then GoTo salir
        a = array(1)
        array(1) = array(2)
        array(2) = a
salir:
        TextBox1.Text = array(0).ToString
        TextBox2.Text = array(1).ToString
        TextBox3.Text = array(2).ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class
