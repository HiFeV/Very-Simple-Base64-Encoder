Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(TextBox1.Text)
        TextBox3.Text = Convert.ToBase64String(byt)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim b As Byte() = Convert.FromBase64String(TextBox1.Text)
        TextBox2.Text = System.Text.Encoding.UTF8.GetString(b)
    End Sub
End Class
