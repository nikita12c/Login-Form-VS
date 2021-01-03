Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;userid=nikitamysql;port=3306;password=nikitamysql.123;database=sad_loginform"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pwd.Text = ""
        ftxtbox.Text = ""
        ltxtbox.Text = ""
        etxtbox.Text = ""
        combo.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (pwd.Text = "" Or
           ftxtbox.Text = "" Or
           ltxtbox.Text = "" Or
           etxtbox.Text = "") Then
            MsgBox("Plz enter all data", MsgBoxStyle.Critical)
        Else
            sql = "select * from users where firstname='" & ftxtbox.Text & "' and lastname='" & ltxtbox.Text & "' and subject='" & etxtbox.Text & "' and pwd='" & pwd.Text & "'"
            connect()

            If dr.Read = True Then
                MsgBox("You have Login successfully", MsgBoxStyle.Information, "Updated Successully")
                Me.Hide()
            Else
                MsgBox("Wrong Info", MsgBoxStyle.Information, "Login Fail")
            End If
            conn.Close()

        End If
    End Sub

End Class
