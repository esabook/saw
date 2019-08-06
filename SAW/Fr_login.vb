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
        dgV.DataSource = db.QueryDS("select kode_jurusan, nama, kode_masuk, jabatan from jurusan where len(nama)>0 order by nama")
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

    Private Sub dgV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgV.CellClick

        Try
            TextBox2.Text = dgV.CurrentRow.Cells(2).Value
            ComboBox1.Text = dgV.CurrentRow.Cells(1).Value
            query.Text = dgV.CurrentRow.Cells(0).Value + "; " + dgV.CurrentRow.Cells(1).Value + "; " + dgV.CurrentRow.Cells(2).Value + "; " + dgV.CurrentRow.Cells(3).Value
        Catch
        End Try
    End Sub
    Private Sub tes()
        If ComboBox1.Text = "root" AndAlso TextBox2.Text = "root" Then Size = New Size(784, 377) : MaximumSize = New Size(784, 377) : Return Else Size = New Size(345, 377) : MaximumSize = New Size(345, 377)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Try
                db.QueryIUD(query.Text)
                fill()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Try
            Dim na() = query.Text.Replace("; ", ";").Split("; ")
            If db.QueryTable("select * from jurusan where kode_jurusan='" + na(0) + "'").Rows.Count = 0 Then
                db.QueryIUD("Insert into jurusan (kode_jurusan, nama, kode_masuk, jabatan) values ('" + na(0) + "','" + na(1) + "','" + na(2) + "','" + na(3) + "')")
            ElseIf db.QueryTable("select * from jurusan where kode_jurusan='" + na(0) + "' and jabatan='" + na(3) + "'").Rows.Count = 0 Then
                db.QueryIUD("update jurusan set nama='" + na(1) + "', kode_masuk='" + na(2) + "', jabatan='" + na(3) + "' where kode_jurusan='" + na(0) + "'")
            Else
                MessageBox.Show("Penambahan dibatalkan, terdeteksi kombinasi kode_masuk dan kode_jurusan yang sudah ada pada satu jabatan.")
            End If
            fill()
        Catch
        End Try
    End Sub

End Class
