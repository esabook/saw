Public Class Fr_olahJurusan
    Dim db As New C_database, modebaru = False, jabatan As String = "", kju As String = ""

    Private Sub ub_Click(sender As Object, e As EventArgs) Handles ub.Click
        modeedit(True)
        modebaru = False
    End Sub

    Private Sub tb_Click(sender As Object, e As EventArgs) Handles tb.Click
        modeedit(True)
        ressss()
        modebaru = True
    End Sub

    Private Sub hp_Click(sender As Object, e As EventArgs) Handles hp.Click
        If db.QueryTable("select * from kompetensi where kode_jurusan='" & kj.Text & "'").Rows.Count = 0 Then
            db.QueryIUD("delete * from jurusan where kode_jurusan='" & kj.Text & "' and jabatan='" & j.SelectedIndex + 1 & "'")
            ressss()

        Else
            MessageBox.Show("Jurusan ini masih digunakan silakan hapus data kompetensi dahulu, operasi penghapusan dibatalkan.")
        End If
    End Sub

    Private Sub sp_Click(sender As Object, e As EventArgs) Handles sp.Click
        If modebaru AndAlso db.QueryTable("select * from jurusan where kode_jurusan='" + kj.Text + "' and jabatan='" & j.SelectedIndex + 1 & "'").Rows.Count = 0 Then
            db.QueryIUD("Insert into jurusan (kode_jurusan, nama, kode_masuk, jabatan, nama_pejabat) values ('" +
                        kj.Text + "','" + nj.Text + "','" + km.Text + "','" & j.SelectedIndex + 1 & "','" & np.Text & "')")
            modeedit(False)
            ressss()
        ElseIf Not modebaru Then
            db.QueryIUD("update jurusan set nama='" + nj.Text + "', kode_masuk='" + km.Text + "', jabatan='" & j.SelectedIndex + 1 & "', nama_pejabat='" & np.Text & "' where kode_jurusan='" & kju & "' and jabatan='" & jabatan & "'")
            modeedit(False)
            ressss()
        Else
            MessageBox.Show("Operasi dibatalkan, terdeteksi kombinasi kode_masuk dan kode_jurusan yang sudah ada pada satu jabatan.")
        End If


    End Sub

    Private Sub bt_Click(sender As Object, e As EventArgs) Handles bt.Click
        modeedit(False)
    End Sub

    Private Sub Fr_olahJurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ressss()
        modeedit(False)
    End Sub

    Private Sub ressss()
        kj.Clear()
        nj.Clear()
        km.Clear()
        nj.Clear()
        j.ResetText()
        np.Clear()
        dg.DataSource = db.QueryDS("select kode_jurusan, nama, kode_masuk, jabatan, nama_pejabat from jurusan where len(nama)>0 order by nama")

    End Sub

    Private Sub modeedit(boo As Boolean)
        kj.Enabled = boo
        nj.Enabled = boo
        km.Enabled = boo
        nj.Enabled = boo
        j.Enabled = boo
        np.Enabled = boo
        ub.Enabled = Not boo
        tb.Enabled = Not boo
        hp.Enabled = Not boo

        sp.Enabled = boo
        bt.Enabled = boo
    End Sub

    Private Sub dg_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellEnter
        kj.Text = IIf(IsDBNull(dg.CurrentRow.Cells(0).Value), "", dg.CurrentRow.Cells(0).Value)
        kju = kj.Text
        nj.Text = IIf(IsDBNull(dg.CurrentRow.Cells(1).Value), "", dg.CurrentRow.Cells(1).Value)
        km.Text = IIf(IsDBNull(dg.CurrentRow.Cells(2).Value), "", dg.CurrentRow.Cells(2).Value)
        np.Text = IIf(IsDBNull(dg.CurrentRow.Cells(4).Value), "", dg.CurrentRow.Cells(4).Value)
        j.SelectedIndex = IIf(IsDBNull(dg.CurrentRow.Cells(3).Value), "", dg.CurrentRow.Cells(3).Value - 1)
        jabatan = j.SelectedIndex + 1

    End Sub

End Class