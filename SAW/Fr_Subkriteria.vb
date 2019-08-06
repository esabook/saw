Public Class Fr_subkriteria
    Public dt() As Object
    Dim db As New C_database, ub As ubah, valid As Boolean

    Private Sub Fr_kriteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Text &= "- " & IIf(dt(3) = 1, "Ketua Jurusan", "Wali Kelas") & " " & dt(1)
        cl()
        sk_reset.PerformClick()
    End Sub

    Private Enum ubah
        ubah
        baru
    End Enum
    Private Sub edit(boo As Boolean)

        ' If ub = ubah.baru Then k_nm.Enabled = boo Else k_nm.Enabled = False
        sk_nm.Enabled = boo
        sk_nil.Enabled = boo
        'NUM1.Enabled = boo
        'NUM2.Enabled = boo
        dgK.Enabled = Not boo
        dgSk.Enabled = Not boo

        k_tbh.Enabled = Not boo
        k_ubh.Enabled = Not boo
        k_hps.Enabled = Not boo
        k_sp.Enabled = boo
        k_btl.Enabled = boo
    End Sub

    Private Sub cy(sender As Object, e As DataGridViewCellEventArgs) Handles dgK.CellClick, dgK.CellEnter

        Try
            k_nm.Text = dgK.CurrentRow.Cells(0).Value
            sk_id.ResetText()
            ' NUM2.ResetText()
            ' NUM1.ResetText()
            sk_nil.Value = 0
            sk_nm.ResetText()

        Catch
        End Try
        ISISUBKRITERIA()
    End Sub
    Private Sub ISISUBKRITERIA()
        dgSk.DataSource = db.QueryDS("select sk.id_sub_kriteria as ID, sk.id_kriteria as [ID KRITERIA], k.nama  as [NAMA KRITERIA], sk.NAMA as [NILAI], sk.BOBOT 
from sub_kriteria  as sk inner join kriteria as k on k.id_kriteria=sk.id_kriteria  
where sk.id_kriteria='" + dgK.CurrentRow.Cells(0).Value + "'")

    End Sub
    Private Sub cyK(sender As Object, e As DataGridViewCellEventArgs) Handles dgSk.CellClick, dgSk.CellEnter
        'Try
        sk_id.Text = dgSk.CurrentRow.Cells(0).Value
        k_nm.Text = dgSk.CurrentRow.Cells(1).Value
        sk_nm.Text = dgSk.CurrentRow.Cells(3).Value
        'NUM1.Value = IIf(IsNumeric(dgSk.CurrentRow.Cells(3).Value), dgSk.CurrentRow.Cells(3).Value, 0)
        'NUM2.Value = IIf(IsNumeric(dgSk.CurrentRow.Cells(4).Value), dgSk.CurrentRow.Cells(4).Value, 0)
        sk_nil.Value = IIf(IsNumeric(dgSk.CurrentRow.Cells(4).Value), dgSk.CurrentRow.Cells(4).Value, 0)


        'Catch
        'End Try


    End Sub
    Private Sub cl()
        sk_id.ResetText()
        sk_nm.ResetText()
        sk_nil.ResetText()
        '  NUM1.ResetText()
        ' NUM2.ResetText()
        sk_nil.Value = 0
        isi()
        edit(False)

    End Sub
    Private Sub isi()
        sk_bid.Items.Clear()
        ' k_nm.Items.Clear()

        For Each d As DataRow In db.QueryTable("SELECT k.nama as NAMA   " +
            "from kriteria as k where bcnf = (select id_sub_kompetensi from sub_kompetensi as sb inner join kompetensi as b on sb.id_kompetensi=b.id_kompetensi where b.kode_jurusan='" + dt(0) + "' " +
            "and sb.id_sub_kompetensi=k.bcnf ) " +
            "or bcnf = (select id_kompetensi from kompetensi where id_kompetensi=k.bcnf and kode_jurusan='" + dt(0) + "' )").Rows
            'k_nm.Items.Add(d(0))
        Next
        For Each r As DataRow In db.QueryTable("select id_kompetensi&' - '&nama from kompetensi where kode_jurusan='" + dt(0) + "'").Rows
            sk_bid.Items.Add(r(0))
        Next
    End Sub

    Private Sub bd_tbh_Click(sender As Object, e As EventArgs) Handles k_tbh.Click
        If k_nm.Text.Length = 0 Then
            MessageBox.Show("Silakan pilih kriteria dahulu untuk menambah sub-kriteria.")
            Return
        End If
        cl()
        sk_id.Text = db.IDBaruBerdasarTabel(db.tabel_SKrit)
        edit(True)
        ub = ubah.baru
    End Sub

    Private Sub bd_ubh_Click(sender As Object, e As EventArgs) Handles k_ubh.Click
        If sk_id.Text.Length > 0 Then
            valid = True
            edit(True)
            ub = ubah.ubah
        Else
            MessageBox.Show("Pilih dahulu item yang akan diubah.")
        End If
    End Sub

    Private Sub bd_hps_Click(sender As Object, e As EventArgs) Handles k_hps.Click
        If sk_id.Text.Length > 0 Then
            db.QueryIUD("delete from sub_kriteria where id_sub_kriteria='" + sk_id.Text + "'")

            isi()
            ISISUBKRITERIA()
        Else
            MessageBox.Show("Pilih dahulu item yang akan dihapus.")
        End If
    End Sub

    Private Sub bd_sp_Click(sender As Object, e As EventArgs) Handles k_sp.Click
        If valid And sk_nil.Value > 0 Then

            If ub = ubah.baru Then
                db.QueryIUD("insert into sub_kriteria (id_sub_kriteria, id_kriteria,nama, bobot) values ('" +
                            sk_id.Text + "','" + k_nm.Text + "','" + sk_nm.Text + "','" & sk_nil.Value.ToString & "')")
            Else
                db.QueryIUD("UPDATE sub_kriteria set id_kriteria='" + k_nm.Text + "', nama='" + sk_nm.Text + "', bobot='" & sk_nil.Value.ToString & "' where id_sub_kriteria='" + sk_id.Text + "'")
            End If

            ISISUBKRITERIA()
            k_btl.PerformClick()
        Else
            MessageBox.Show("Ada yang belum lengkap.")
        End If
    End Sub

    Private Sub k_bid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sk_bid.SelectedIndexChanged
        dgK.DataSource = db.QueryDS("select k.id_kriteria as [ID], k.bcnf as [KOMPETENSI/SUB KOMPETENSI], k.nama as NAMA from kriteria as k where bcnf='" +
                                    sk_bid.Text.Split(" - ")(0) + "' or bcnf=(select id_sub_kompetensi from sub_kompetensi as s where s.id_sub_kompetensi=k.bcnf and s.id_kompetensi='" + sk_bid.Text.Split(" - ")(0) + "')")
        Dim d As DataTable = db.QueryTable("select id_sub_kompetensi&' - '&nama from sub_kompetensi where id_kompetensi='" + sk_bid.Text.Split(" - ")(0) + "'")
        If d.Rows.Count > 0 AndAlso sk_bid.Enabled Then
            sk_sb.Items.Clear()
            For Each dr As DataRow In d.Rows
                sk_sb.Items.Add(dr(0))
            Next
            sk_sb.Enabled = True
        Else
            sk_sb.ResetText()
            sk_sb.Enabled = False
            sk_sb.Items.Clear()
        End If
    End Sub

    Private Sub k_sb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sk_sb.SelectedIndexChanged
        dgK.DataSource = db.QueryDS("select k.id_kriteria as [ID KRITERIA], k.bcnf as [KOMPETENSI/SUB KOMPETENSI], k.nama as NAMA from kriteria as k where bcnf='" + sk_sb.Text.Split(" - ")(0) + "'")

    End Sub

    Private Sub sk_nm_TextChanged(sender As Object, e As EventArgs) Handles sk_nm.TextChanged
        If sk_nm.Enabled AndAlso db.QueryTable("select * from sub_kriteria where nama='" + sk_nm.Text + "' and id_kriteria ='" + k_nm.Text + "'  and id_sub_kriteria <>'" + sk_bid.Text + "'").Rows.Count > 0 Then

            ErrorProvider1.SetError(sender, "Nama Sudah ada, Silakan gunakan nama lain.")
            valid = False
        Else
            ErrorProvider1.Clear()
            valid = True
        End If
    End Sub

    Private Sub bd_batal_Click(sender As Object, e As EventArgs) Handles k_btl.Click
        edit(False)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles sk_reset.Click
        sk_sb.ResetText()
        sk_bid.ResetText()
        dgK.DataSource = db.QueryDS("SELECT  k.id_kriteria as [ID KRITERIA], k.bcnf as [KOMPETENSI/SUB KOMPETENSI], k.nama as NAMA,

ko.id_kompetensi as [ID KOMPETENSI],
ko.nama as [NAMA KOMPETENSI],
sko.id_sub_kompetensi as [ID SUB KOMPETENSI],
sko.nama as [NAMA SUB KOMPETENSI]
from kriteria as k 

inner join
(select *  from kompetensi as ko inner join sub_kompetensi as sko on sko.id_kompetensi=ko.id_kompetensi) as sk 
on sk.sko.id_sub_kompetensi=k.bcnf or sk.ko.id_kompetensi=k.bcnf 

where bcnf = (select id_sub_kompetensi from sub_kompetensi as sb inner join kompetensi as b on sb.id_kompetensi=b.id_kompetensi where b.kode_jurusan='" + dt(0) + "' " +
            "and sb.id_sub_kompetensi=k.bcnf ) " +
            "or bcnf = (select id_kompetensi from kompetensi where id_kompetensi=k.bcnf and kode_jurusan='" + dt(0) + "' )")


    End Sub


End Class