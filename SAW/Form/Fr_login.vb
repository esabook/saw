Public Class Fr_login
    Dim db As New C_database
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As DataTable = db.QueryTable("Select kode_jurusan, nama, kode_masuk, jabatan from jurusan where kode_masuk='" + TextBox2.Text + "' and nama='" + ComboBox1.Text + "'")
        If str.Rows.Count > 0 Then
            Dim f As New Fr_beranda
            f.dataLogin(str.Rows(0).ItemArray)
            f.Show()
            Me.Close()
        ElseIf Not TextBox2.Text.Contains("root") Then
            MessageBox.Show("kode yang dimasukan salah")
        Else
            tes()
        End If


    End Sub
    Private Sub fill()
        Dim str As DataTable = db.QueryTable("Select nama from jurusan where len(nama)>0  group by nama")
        ComboBox1.Items.Clear()

        For Each s As DataRow In str.Rows
            ComboBox1.Items.Add(s(0))
        Next
    End Sub
    Private Sub Fr_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tes()
        fill()

    End Sub

    Private Sub tes()
        If ComboBox1.Text = "root" AndAlso TextBox2.Text = "root" Then
            Dim f As New Fr_beranda
            f.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


        Try
            'db.QueryIUD(query.Text)
            fill()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
