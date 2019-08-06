Public Class Fr_siswa
    Public dt() As Object
    Dim db As New C_database, md As Mode, filter As Boolean, separator = " - "

    Private Sub Fr_siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Text &= "- " & IIf(dt(3) = 1, "Ketua Jurusan", "Wali Kelas") & " " & dt(1)
        cl()
        fill()
        isiv()
        modeedit(False)
    End Sub

    Private Sub s_tbh_Click(sender As Object, e As EventArgs) Handles s_tbh.Click
        md = Mode.Baru
        modeedit(True)
        cl()
    End Sub
    Private Enum Mode
        Baru
        Ubah
    End Enum

    Private Sub s_ubh_Click(sender As Object, e As EventArgs) Handles s_ubh.Click
        md = Mode.Ubah
        modeedit(True)
    End Sub

    Private Sub kp(sender As Object, e As KeyPressEventArgs) Handles s_filter2.KeyPress
        If e.KeyChar = Chr(13) Then
            filter = True
            fill()
        End If
    End Sub

    Private Sub s_hps_Click(sender As Object, e As EventArgs) Handles s_hps.Click
        db.QueryIUD("delete from siswa  where nis='" + s_nis.Text + "'")
        cl()
        fill()
    End Sub

    Private Sub s_sp_Click(sender As Object, e As EventArgs) Handles s_sp.Click
        Dim nis = s_nis.Text.Length > 0 AndAlso s_nm.Text.Length > 0 AndAlso s_alm.Text.Length > 0 AndAlso s_jk.Text.Length > 0 AndAlso s_kls.Text.Length > 0
        If Not nis Then MessageBox.Show("Silakan isi formulir dahulu.") : Return
        If kej.Enabled AndAlso kej.Text.Length < 1 Then MessageBox.Show("Silakan pilih kompetensi dahulu.") : Return
        Select Case md
            Case Mode.Baru
                If db.QueryTable("select * from siswa where nis='" + s_nis.Text + "'").Rows.Count = 0 Then

                    db.QueryIUD("insert into siswa (nis, nama, alamat, kelamin, kode_kompetensi, kelas, tahun_ajaran, peringkat) " +
                        "values ('" + s_nis.Text + "','" +
                        s_nm.Text + "','" +
                        s_alm.Text + "','" +
                        s_jk.Text + "','" +
                        IIf(kej.Enabled, kej.Text, dt(0)) + "','" +
                        s_kls.Text + "','" +
                        tahun_ajaran.Value.ToString + "','" +
                        peringkat.Value.ToString + "')")
                Else
                    MessageBox.Show("NIS """ & s_nis.Text & """ sudah ada, operasi dibatalkan.")
                End If
            Case Mode.Ubah
                db.QueryIUD("update siswa set nama='" + s_nm.Text +
                            "', alamat='" + s_alm.Text +
                            "', kelamin='" + s_jk.Text +
                            "', kode_kompetensi='" + IIf(kej.Enabled, kej.Text, dt(0)) +
                            "', kelas='" + s_kls.Text +
                            "', tahun_ajaran='" + tahun_ajaran.Value.ToString +
                            "', peringkat='" + peringkat.Value.ToString +
                            "' where nis='" + s_nis.Text + "'")
        End Select
        modeedit(False)
        cl()
        fill()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles s_reset.Click
        modeedit(False)
        filter = False
        fill()
    End Sub
    Private Sub cl()
        s_nis.Clear()
        s_nm.Clear()
        s_alm.Clear()
        s_jk.ResetText()
        If kej.Enabled Then kej.ResetText()
        'skej.ResetText()
        s_kls.Clear()
        tahun_ajaran.Value = Now.Year
        peringkat.Value = 0
    End Sub

    Private Sub dgvc(sender As Object, e As DataGridViewCellEventArgs) Handles dgV.CellClick, dgV.CellEnter
        s_nis.Text = dgV.CurrentRow.Cells(0).Value
        s_nm.Text = dgV.CurrentRow.Cells(1).Value
        s_alm.Text = dgV.CurrentRow.Cells(2).Value
        s_jk.Text = dgV.CurrentRow.Cells(3).Value
        kej.Text = dgV.CurrentRow.Cells(4).Value
        s_kls.Text = dgV.CurrentRow.Cells(5).Value
        tahun_ajaran.Value = IIf(IsDBNull(dgV.CurrentRow.Cells(6).Value), Now.Year, dgV.CurrentRow.Cells(6).Value)
        peringkat.Value = IIf(IsDBNull(dgV.CurrentRow.Cells(7).Value), 0, dgV.CurrentRow.Cells(7).Value)
    End Sub

    Private Sub modeedit(boo As Boolean)
        s_nis.Enabled = boo
        s_nm.Enabled = boo
        s_alm.Enabled = boo
        s_jk.Enabled = boo
        kej.Enabled = kej.Items.Count > 0 AndAlso boo
        tahun_ajaran.Enabled = boo
        peringkat.Enabled = boo
        s_kls.Enabled = boo
        S_filter.Enabled = Not boo
        s_filter2.Enabled = Not boo
        s_tbh.Enabled = Not boo
        s_ubh.Enabled = Not boo And s_nis.Text.Length > 0
        s_hps.Enabled = Not boo And s_nis.Text.Length > 0
        s_sp.Enabled = boo
        s_reset.Enabled = boo

        dgV.Enabled = Not boo

    End Sub

    Private Sub s_jk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kej.Leave
        kej.Text = kej.Text.Replace(separator, "-").Split("-")(0)
    End Sub

    'Private Sub skej_Leave(sender As Object, e As EventArgs)
    '    skej.Text = skej.Text.Replace(separator, "-").Split("-")(0)
    'End Sub

    'Private Sub kej_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kej.SelectedIndexChanged

    '    skej.Items.Clear()
    '    For Each s As DataRow In db.QueryTable("select id_sub_kompetensi, nama from sub_kompetensi where id_kompetensi ='" + kej.Text.Replace(separator, "-").Split("-")(0) + "'").Rows
    '        skej.Items.Add(s(0) & separator & s(1))
    '    Next
    '    skej.Enabled = skej.Items.Count > 0
    'End Sub

    Private Sub fill()
        If filter Then
            dgV.DataSource = db.QueryDS(siswa(dt(0), S_filter.Text, s_filter2.Text))
        Else
            'dgV.DataSource = db.QueryDS("select distinct s.* from (siswa as s inner join sub_kompetensi as sk on sk.id_sub_kompetensi=s.kode_kompetensi) " +
            '                            " inner join kompetensi as k on k.id_kompetensi=s.kode_kompetensi where k.kode_jurusan='" & dt(0) & "'")
            dgV.DataSource = db.QueryDS(siswa(dt(0)))
        End If
        isiv()
    End Sub
    Public Function siswa(jurusan As String, filterKolom As String, isiFilter As String) As String
        Dim ass = ""
        If filterKolom IsNot Nothing AndAlso filterKolom.Length > 0 Then
            ass &= " instr(" + filterKolom + ",'" + isiFilter + "')<>0 and "

        ElseIf isiFilter IsNot Nothing Then
            ass &= "instr (nis&nama&alamat&kode_kompetensi&kelas,'" + isiFilter + "')<>0 and "
        End If
        Return "select  s.* from siswa as s where " + ass +
                                      " (s.kode_kompetensi='" & jurusan & "' " +
                                      "or s.kode_kompetensi=(select id_kompetensi from kompetensi as k where k.id_kompetensi=s.kode_kompetensi and k.kode_jurusan='" & jurusan & "'))"

    End Function
    Public Function siswa(jurusan As String) As String
        Return siswa(jurusan, Nothing, Nothing)
    End Function
    Private Function idkompetensi(namakom, namasubkom) As String
        Dim kom = "true"
        Dim subk = "true"
        Dim sss = ""
        If namakom IsNot Nothing Then
            kom = "  k.nama='" + namakom + "' "
        ElseIf namasubkom IsNot Nothing Then
            subk = " sk.nama='" + namasubkom + "' "
        End If
        sss = "where " & kom & " and " & namasubkom
        Return db.QueryStr("select distinct j.kode_jurusan, k.id_kompetensi, sk.id_sub_kompetensi from (jurusan as j inner join kompetensi as k on j.kode_jurusan=k.kode_jurusan) inner join sub_kompetensi as sk on sk.id_kompetensi=k.id_kompetensi where j.kode_jurusan='" + dt(0) +
                           "' " + sss)
    End Function

    Private Sub isiv()
        kej.Items.Clear()
        S_filter.Items.Clear()

        For Each s As DataRow In db.QueryTable("select id_kompetensi, nama from kompetensi as k where kode_jurusan='" + dt(0) + "' and (select count(*) from sub_kompetensi as s where s.id_kompetensi=k.id_kompetensi)>0").Rows
            kej.Items.Add(s(0) & separator & s(1))

        Next
        If kej.Items.Count = 0 Then kej.Text = dt(0)
        For i = 0 To dgV.Columns.Count - 1
            S_filter.Items.Add(dgV.Columns.Item(i).HeaderText)
        Next

    End Sub


End Class