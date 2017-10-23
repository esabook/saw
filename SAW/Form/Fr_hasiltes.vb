﻿Public Class Fr_hasiltes
    Public dt() As Object
    Dim db As New C_database, sw As New Fr_siswa, md As Mode, filter As Boolean, s() As String, separator = " - ", modeISI = False, punyachildkompetensi = False

    Private Sub Fr_hasiltes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Text &= "- " & IIf(dt(3) = 1, "Ketua Jurusan", "Wali Kelas") & " " & dt(1)

        cl()
        modeedit(False)
        isisiswa()
        isiKompetensi()
    End Sub
    Private Sub isisiswa()
        tbs.DataSource = db.QueryDS(sw.siswa(dt(0), "tahun", thn.Value, " peringkat between " & IIf(up.Value > 0, 1, 0) & " and " & up.Value & " "))

    End Sub
    Private Sub cl()


        nil_kat.Text = ""
        thn.Value = Now.Year
        dgK.DataSource = Nothing
        For Each ss As DataGridViewRow In dgK.Rows
            ss.Cells(2).Value = Nothing
        Next

    End Sub

    Private Sub kp(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            filter = True
        End If
    End Sub

    Private Sub s_tbh_Click(sender As Object, e As EventArgs) Handles h_tbh.Click
        If db.QueryTable("select * from hasil_tes where nis='" + h_nis.Text + "' and tahun=" & thn.Value & "").Rows.Count > 0 Then
            MessageBox.Show("Data Hasil tes untuk siswa bersangkutan telah ada, mode ""Tambah"" dialihkan ke mode ""Ubah"".")
            h_ubh.PerformClick()
            Return
        End If
        md = Mode.Baru

        modeedit(True)
        cl()
    End Sub
    Private Enum Mode
        Baru
        Ubah
    End Enum

    Private Sub s_ubh_Click(sender As Object, e As EventArgs) Handles h_ubh.Click
        If h_nis.Text.Length > 0 Then
            md = Mode.Ubah

            isinilaikriteria
            modeedit(True)
        Else
            MessageBox.Show("Pilih yang akan diubah.")
        End If
    End Sub

    Private Sub isinilaikriteria()
        For Each ddd As DataGridViewRow In dgK.Rows
            ddd.Cells(2).Value = db.QueryStr("select nilai from hasil_tes where id_kriteria='" + ddd.Cells(0).Value + "' and nis='" + h_nis.Text + "' and tahun=" & thn.Value & "")
        Next
    End Sub

    Private Sub s_hps_Click(sender As Object, e As EventArgs) Handles h_hps.Click
        If h_nis.Text.Length > 0 Then
            db.QueryIUD("delete from hasil_tes where nis='" + h_nis.Text + "' and tahun=" & thn.Value & "")
            cl()
            tbs_CellClick(Nothing, Nothing)

        Else
            MessageBox.Show("Pilih yang akan dihapus.")
        End If

    End Sub

    Private Sub s_sp_Click(sender As Object, e As EventArgs) Handles h_sp.Click

        If db.QueryTable("select * from hasil_tes where nis='" + h_nis.Text + "' and tahun=" & thn.Value & "").Rows.Count > 0 Then
            If MessageBox.Show("Hasil tes siswa bersangkutan telah ada, Tekan ""Yes"" untuk menimpanya atau ""No"" untuk membatalkan.", "", MessageBoxButtons.YesNo) = DialogResult.No Then
                Return
            End If
        End If
        For Each d As DataGridViewRow In dgK.Rows
            If d.Cells(2).Value.ToString.Length < 1 Then MessageBox.Show("Terdapat Nilai yang belum diisi, silakan isi terlebih dahulu.") : Return
        Next
        For Each d As DataGridViewRow In dgK.Rows
            If db.QueryTable("select * from hasil_tes where nis='" + h_nis.Text + "' and id_kriteria='" + d.Cells(0).Value + "' and tahun=" & thn.Value & "").Rows.Count = 0 Then
                db.QueryIUD("insert into hasil_tes (id_hasil_tes, nis, id_kriteria, nilai, tahun) " +
                            "values ('" + db.IDBaruBerdasarTabel(db.tabel_HasilT) + "','" + h_nis.Text + "','" + d.Cells(0).Value + "','" + d.Cells(2).Value + "'," & thn.Value & ")")
            Else
                db.QueryIUD("update hasil_tes set nilai='" + d.Cells(2).Value + "' where nis='" + h_nis.Text + "' and id_kriteria='" + d.Cells(0).Value + "' and tahun=" & thn.Value & "")

            End If
            Next

            modeedit(False)
        cl()
        tbs_CellClick(Nothing, Nothing)

    End Sub



    Private Sub modeedit(boo As Boolean)
        dgK.Enabled = boo
        modeISI = boo
        nil_kat.Enabled = boo
        na.Enabled = boo
        tbs.Enabled = Not boo

        h_tbh.Enabled = Not boo
        h_ubh.Enabled = Not boo
        h_hps.Enabled = Not boo
        h_sp.Enabled = boo
        h_btl.Enabled = boo

    End Sub


    Private Sub isiKompetensi()
        kom.Items.Clear()
        kom.Items.Add("Semua :")

        For Each r As DataRow In db.QueryTable("select id_kompetensi &' - '& nama from kompetensi where kode_jurusan='" + dt(0) + "'").Rows

            kom.Items.Add(r(0))
            For Each subr As DataRow In db.QueryTable("select ' > '&id_sub_kompetensi &' - '& nama from sub_kompetensi where id_kompetensi='" + r(0).ToString.Replace(" - ", "-").Split("-")(0) + "'").Rows
                kom.Items.Add(subr(0))
                punyachildkompetensi = True
            Next

        Next

    End Sub
    Private Sub isiTabelKriteria(bcnf As String)
        Dim t As New DataTable("k"),
            d As DataRow,
            ds As New DataSet
        t.Columns.Add("id")
        t.Columns.Add("Kriteria")
        t.Columns.Add("Sub Kriteria")
        For Each dr As DataRow In db.QueryTable(kriteriaNilai(bcnf)).Rows
            d = t.NewRow
            d.Item(0) = dr.Item(0)
            d.Item(1) = dr.Item(1)
            d.Item(2) = db.QueryStr("select nilai from hasil_tes where nis='" + h_nis.Text + "' and id_kriteria='" + dr.Item(0) + "' and tahun=" & thn.Value & "")
            t.Rows.Add(d)
        Next

        ds.Tables.Add(t)

        dgK.DataSource = ds
        dgK.DataMember = ds.Tables(0).TableName
        dgK.Columns.Item(0).Visible = False
    End Sub

    Private Function kriteriaNilai(bcnf As String) As String
        If bcnf Is Nothing Then Return "SELECT id_kriteria as ID, k.nama as NAMA   from kriteria as k " +
                                                "where bcnf=(select id_sub_kompetensi from sub_kompetensi as sb inner join kompetensi as b on sb.id_kompetensi=b.id_kompetensi where b.kode_jurusan='" +
                                                dt(0) + "' and sb.id_sub_kompetensi=k.bcnf ) or bcnf=(select id_kompetensi from kompetensi where id_kompetensi=k.bcnf and kode_jurusan='" + dt(0) + "')"
        Return "select kr.id_kriteria as ID, kr.NAMA from kriteria as kr where kr.bcnf='" + bcnf +
            "' or '" + bcnf + "'=(select k.id_kompetensi from kompetensi as k inner join sub_kompetensi as s on s.id_kompetensi=k.id_kompetensi where s.id_sub_kompetensi=kr.bcnf and k.id_kompetensi=s.id_kompetensi)"
    End Function

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles thn.ValueChanged, up.ValueChanged
        Try
            isisiswa()
        Catch
        End Try
    End Sub

    Private Sub NumericUpDown1_ValueChanged_1(sender As Object, e As EventArgs) Handles na.ValueChanged, na.Leave
        Dim st() As String
        For Each ddd As DataRow In db.QueryTable("select nilai_rentang, nama from sub_kriteria where id_kriteria='" & dgK.CurrentRow.Cells(0).Value & "'").Rows
            st = IIf(IsDBNull(ddd.Item(0)), {"-1", "-1"}, ddd.Item(0).ToString.Split("-"))
            Select Case sender.Value
                Case CInt(st(0)) To CInt(st(1))
                    Debug.Print(sender.value & " === " & ddd.Item(1))
                    nil_kat.SelectedIndex = nil_kat.Items.IndexOf(ddd.Item(1))

            End Select
        Next
    End Sub

    Private Sub celclick(sender As Object, e As DataGridViewCellEventArgs) Handles dgK.CellClick
        nil_kat.Items.Clear()
        nil_kat.ResetText()

        For Each s As DataRow In db.QueryTable("select s.nama from sub_kriteria as s where id_kriteria='" + dgK.CurrentRow.Cells(0).Value + "'").Rows
            nil_kat.Items.Add(s(0))
        Next

    End Sub

    Private Sub h_btl_Click(sender As Object, e As EventArgs) Handles h_btl.Click

        modeedit(False)
    End Sub


    Private Sub kom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kom.SelectedIndexChanged
        Dim sel = kom.SelectedItem.ToString.Replace(" > ", "").Split(" - ")(0)
        If modeISI Then
            Try
                Dim skom = "select * from kompetensi where (id_kompetensi='" + tbs.CurrentRow.Cells(4).Value + "' or kode_jurusan='" + tbs.CurrentRow.Cells(4).Value + "')"
                skom += "and (id_kompetensi='" + sel + "' or id_kompetensi=(select id_kompetensi from sub_kompetensi where id_sub_kompetensi='" + sel + "'))"
                If Not kom.SelectedItem.ToString.Contains("Semua") AndAlso db.QueryTable(skom).Rows.Count = 0 Then MessageBox.Show("Siswa bukan dari Kompetensi ini.") : kom.ClearSelected() : Return

                If kom.SelectedItem.ToString.Contains("Semua") AndAlso Not punyachildkompetensi Then
                    isiTabelKriteria(Nothing)
                    isinilaikriteria()
                    Return

                ElseIf kom.SelectedItem.ToString.Contains("Semua") Then
                    isiTabelKriteria(tbs.CurrentRow.Cells(4).Value) : isinilaikriteria()
                    Return
                End If
                isiTabelKriteria(sel)
                isinilaikriteria()
                Catch
            End Try

        Else
            isiTabelKriteria(Nothing)
            If kom.SelectedItem.ToString.Contains("Semua") Then isisiswa() : Return
            tbs.DataSource = db.QueryDS(sw.siswa(dt(0), "kode_kompetensi", sel, "tahun=" & thn.Value & " and peringkat between 1 and " & up.Value & " "))
        End If

            End Sub

    Private Sub nil_kat_Leave(sender As Object, e As EventArgs) Handles nil_kat.SelectedIndexChanged
        Try
            dgK.CurrentRow.Cells(2).Value = nil_kat.Text
        Catch
        End Try
    End Sub


    Private Sub tbs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tbs.CellClick, tbs.CellEnter
        h_sisw.Text = tbs.CurrentRow.Cells(1).Value
        h_nis.Text = tbs.CurrentRow.Cells(0).Value
        Try
            dgH.DataSource = db.QueryDS(hasil(h_nis.Text))
        Catch
        End Try
        'isiTabelKriteria(tbs.CurrentRow.Cells(4).Value)
        ' isiPilihanFilter()
    End Sub
    Private Function hasil(ByVal nis As String) As String
        Return hasil(nis, Nothing, Nothing)
    End Function
    Private Function hasil(nis As String, filterkolom As String, isifilter As String) As String
        Dim sss As String = ""
        sss &= IIf(filterkolom IsNot Nothing, "instr(" + filterkolom + ",'" + isifilter + "')<>0 and ", "")
        sss &= IIf(isifilter IsNot Nothing, "instr(*,'" + isifilter + "')<>0 and ", "")
        Return "select h.id_hasil_tes as [ID], h.nis As [NIS], h.id_kriteria As [ID KRITERIA] , (select nama from kriteria as k where k.id_kriteria=h.id_kriteria) As [NAMA KRITERIA], NILAI from hasil_tes As h where nis='" + nis + "'"
    End Function

End Class