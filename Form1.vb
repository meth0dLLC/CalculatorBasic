Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = Val(TextBox1.Text)
        c = " + "
        TextBox1.Text = CStr(x) + c
        b = "+"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        x = Val(TextBox1.Text)
        c = " - "
        TextBox1.Text = CStr(x) + c
        b = "-"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        x = Val(TextBox1.Text)
        c = " * "
        TextBox1.Text = CStr(x) + c
        b = "*"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        x = Val(TextBox1.Text)
        c = " / "
        TextBox1.Text = CStr(x) + c
        b = "/"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        x = Val(TextBox1.Text)
        c = "pow( "
        TextBox1.Text = "pow( " + CStr(x) + " ) "
        b = "^2"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button18.Enabled = True
        TextBox1.Clear()
        b = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        x = Val(TextBox1.Text)
        c = "sqrt( "
        TextBox1.Text = "sqrt( " + CStr(x) + " ) "
        b = "sqrt"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If (TextBox1.Text.Length = 0) Or (b = "") Then
            TextBox1.Text = "Введите значения / Выберите действие"
            Button18.Enabled = False
            TextBox1.DeselectAll()
        Else
            If b = "+" Then
                y = TextBox1.Text
                z = y.LastIndexOf(c)
                y = y.Remove(z, 2)
                y = y.Remove(y.LastIndexOf(CStr(x)), CStr(x).Length())
                TextBox1.Text = CStr(x) + " +" + y + " = " + CStr(x + y)
                Button18.Enabled = False
                TextBox1.DeselectAll()
            End If
            If b = "-" Then
                y = TextBox1.Text
                z = y.LastIndexOf(c)
                y = y.Remove(z, 2)
                y = y.Remove(y.LastIndexOf(CStr(x)), CStr(x).Length())
                TextBox1.Text = CStr(x) + " -" + y + " = " + CStr(x - y)
                Button18.Enabled = False
                TextBox1.DeselectAll()
            End If
            If b = "*" Then
                y = TextBox1.Text
                z = y.LastIndexOf(c)
                y = y.Remove(z, 2)
                y = y.Remove(y.LastIndexOf(CStr(x)), CStr(x).Length())
                TextBox1.Text = CStr(x) + " *" + y + " = " + CStr(x * y)
                Button18.Enabled = False
                TextBox1.DeselectAll()
            End If
            If b = "/" Then
                y = TextBox1.Text
                z = y.LastIndexOf(c)
                y = y.Remove(z, 2)
                y = y.Remove(y.LastIndexOf(CStr(x)), CStr(x).Length())
                If y = "0" Then
                    TextBox1.Text = "Error"
                    Button18.Enabled = False
                    TextBox1.DeselectAll()
                Else
                    TextBox1.Text = CStr(x) + " /" + y + " = " + CStr(x / y)
                    Button18.Enabled = False
                    TextBox1.DeselectAll()
                End If
            End If
            If b = "^2" Then
                TextBox1.Text = c + CStr(x) + " ) = " + CStr(Math.Pow(x, 2))
                Button18.Enabled = False
                TextBox1.DeselectAll()
            End If
            If b = "sqrt" Then
                TextBox1.Text = c + CStr(x) + " ) = " + CStr(Math.Sqrt(x))
                Button18.Enabled = False
                TextBox1.DeselectAll()
            End If
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If (TextBox1.Text.Length() > 0) Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length() - 1, 1)
        Else
            TextBox1.Text = ""
        End If
    End Sub
End Class
