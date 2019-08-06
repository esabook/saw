Public Class Fr_kriteria
    Public dt() As Object
    Dim db As New C_database, ub As ubah, valid As Boolean
    Private Sub Fr_kriteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Text &= "- " & IIf(dt(3) = 1, "Ketua Jurusan", "Wali Kelas") & " " & dt(1)
        cl()
    End Sub

    Private Enum ubah
        ubah
        baru
    End Enum
    Private Sub edit(boo As Boolean)
        k_bid.Enabled = boo
        k_sb.Enabled = boo
        k_nm.Enabled = boo
        dgK.Enabled = Not boo

        k_tbh.Enabled = Not boo
        k_ubh.Enabled = Not boo
        k_hps.Enabled = Not boo
        k_sp.Enabled = boo
        k_btl.Enabled = boo
    End Sub

    Private Sub cy(sender As Object, e As DataGridViewCellEventArgs) Handles dgK.CellClick


        dgSk.DataSource = db.QueryDS("select sk.id_sub_kriteria as ID, k.nama  as [NAMA KRITERIA], sk.NAMA as [NILAI], sk.BOBOT 
from sub_kriteria  as sk inner join kriteria as k on k.id_kriteria=sk.id_kriteria  
where sk.id_kriteria='" + dgK.CurrentRow.Cells(0).Value + "'")
        Try
            k_id.Text = dgK.CurrentRow.Cells(0).Value

            k_nm.Text = dgK.CurrentRow.Cells(2).Value
            k_sb.Text = dgK.CurrentRow.Cells(1).Value
            k_sb.Text = ""
            k_bid.Text = ""

            If dgK.CurrentRow.Cells(1).Value.ToString.Contains(db.awalan_PKkompetensi) Then
                k_bid.Text = db.QueryStr("select b.nama from kompetensi as b where b.id_kompetensi='" + dgK.CurrentRow.Cells(1).Value + "'")
                k_bid_SelectedIndexChanged(Nothing, Nothing)
            ElseIf dgK.CurrentRow.Cells(1).Value.ToString.Contains(db.awalan_PKSubBid) Then
                k_sb.Text = db.QueryStr("select b.nama from sub_kompetensi as b where b.id_sub_kompetensi='" + dgK.CurrentRow.Cells(1).Value + "'")
                k_bid.Text = db.QueryStr("select b.nama from kompetensi as b inner join sub_kompetensi as sb on b.id_kompetensi=sb.id_kompetensi where sb.id_sub_kompetensi='" + dgK.CurrentRow.Cells(1).Value + "'")

            End If
        Catch

        End Try
    End Sub
    Private Sub cl()
        k_bid.ResetText()
        k_sb.ResetText()
        k_nm.ResetText()
        isi()
        edit(False)
    End Sub
    Private Function tbelkriteria(jurusan As String, filter As String) As String
        Return "SELECT  k.id_kriteria as [ID], k.bcnf as [KOMPETENSI/SUB KOMPETENSI], k.nama as NAMA,   

ko.id_kompetensi as [ID KOMPETENSI],
ko.nama as [NAMA KOMPETENSI],
sko.id_sub_kompetensi as [ID SUB KOMPETENSI],
sko.nama as [NAMA SUB KOMPETENSI]
from kriteria as k 

inner join
(select *  from kompetensi as ko inner join sub_kompetensi as sko on sko.id_kompetensi=ko.id_kompetensi) as sk 
on sk.sko.id_sub_kompetensi=k.bcnf or sk.ko.id_kompetensi=k.bcnf 

where " & IIf(filter Is Nothing, "", filter + " and ") & " (bcnf=(select id_sub_kompetensi from sub_kompetensi as sb inner join kompetensi as b on sb.id_kompetensi=b.id_kompetensi where b.kode_jurusan='" + jurusan + "' and sb.id_sub_kompetensi=k.bcnf ) or bcnf=(select id_kompetensi from kompetensi where id_kompetensi=k.bcnf and kode_jurusan='" + jurusan + "'))"
    End Function
    Private Function tbelkriteria(jurusan As String) As String
        Return tbelkriteria(jurusan, Nothing)
    End Function

    Private Sub isi()
        dgK.DataSource = db.QueryDS(tbelkriteria(dt(0)))

        k_bid.Items.Clear()
        filter1.Items.Clear()
        ket.Items.Clear()
        ket.Items.Add("Keterangan :")

        For Each cc As DataGridViewColumn In dgK.Columns
            filter1.Items.Add(cc.Name)
        Next
        For Each r As DataRow In db.QueryTable("select id_kompetensi &' - '& nama from kompetensi where kode_jurusan='" + dt(0) + "'").Rows
            k_bid.Items.Add(r(0))
            ket.Items.Add(r(0))
            For Each subr As DataRow In db.QueryTable("select ' > '&id_sub_kompetensi &' - '& nama from sub_kompetensi where id_kompetensi='" + r(0).ToString.Replace(" - ", "-").Split("-")(0) + "'").Rows
                ket.Items.Add(subr(0))
            Next

        Next


        k_btl.PerformClick()
    End Sub

    Private Sub bd_tbh_Click(sender As Object, e As EventArgs) Handles k_tbh.Click
        cl()
        k_id.Text = db.IDBaruBerdasarTabel(db.tabel_Krit)
        edit(True)
        ub = ubah.baru
    End Sub

    Private Sub bd_ubh_Click(sender As Object, e As EventArgs) Handles k_ubh.Click
        edit(True)
        ub = ubah.ubah

        For Each s As String In k_bid.Items
            If s.Contains(k_bid.Text) Then
                k_bid.SelectedItem = s
                Exit For
            End If
        Next

        For Each s As String In k_sb.Items
            If s.Contains(k_sb.Text) Then
                k_sb.SelectedItem = s
                Exit For
            End If
        Next
    End Sub

    Private Sub bd_hps_Click(sender As Object, e As EventArgs) Handles k_hps.Click
        db.QueryIUD("delete from kriteria where id_KRITERIA='" + k_id.Text + "'")

        isi()
    End Sub

    Private Sub bd_sp_Click(sender As Object, e As EventArgs) Handles k_sp.Click

        If valid AndAlso k_bid.Text.Length > 0 Then
            If ub = ubah.baru Then
                db.QueryIUD("insert into kriteria (id_kriteria, bcnf, nama) values ('" + k_id.Text + "','" + IIf(k_sb.Text.Length = 0 Or Not k_sb.Enabled, k_bid.Text.Replace(" - ", "-").Split("-")(0), k_sb.Text.Replace(" - ", "-").Split("-")(0)) + "','" + k_nm.Text + "')")

            Else
                db.QueryIUD("UPDATE kriteria set nama='" + k_nm.Text + "', bcnf='" + IIf(k_sb.Text.Length = 0 Or Not k_sb.Enabled, k_bid.Text.Replace(" - ", "-").Split("-")(0), k_sb.Text.Replace(" - ", "-").Split("-")(0)) + "' where id_kriteria='" + k_id.Text + "'")

            End If

            isi()
            dgK.PerformLayout()
            k_btl.PerformClick()
        Else
            MessageBox.Show("Ada yang belum lengkap.")
        End If
    End Sub

    Private Sub k_bid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles k_bid.SelectedIndexChanged
        Dim d As DataTable = db.QueryTable("select id_sub_kompetensi &' - '& nama from sub_kompetensi where id_kompetensi='" + k_bid.Text.Replace(" - ", "-").Split("-")(0) + "'")
        If d.Rows.Count > 0 Then
            k_sb.Items.Clear()
            For Each dr As DataRow In d.Rows
                k_sb.Items.Add(dr(0))
            Next
            k_sb.Enabled = True And k_bid.Enabled

        Else
            k_sb.Enabled = False
            k_sb.Text = "Tidak terdapat sub kompetensi"
            k_sb.Items.Clear()
        End If
        k_nm_TextChanged(sender, e)
    End Sub

    Private Sub filter2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles filter2.KeyPress
        If e.KeyChar <> Chr(13) Then Return
        If filter2.Text.Length = 0 Then isi() : Return
        Dim ass = ""
        Dim filter = IIf(filter1.Text.Contains("ID"), "k.id_kriteria", IIf(filter1.Text.Contains("KOM"), "k.bcnf", "k.nama"))
        If filter.ToString.Length > 0 Then ass &= " instr(" + filter + ",'" + filter2.Text + "')<>0" Else ass &= "instr (k.id_kriteria&k.bcnf&k.nama,'" + filter2.Text + "')<>0"

        dgK.DataSource = db.QueryDS(tbelkriteria(dt(0), ass))
    End Sub

    Private Sub k_nm_TextChanged(sender As Object, e As EventArgs) Handles k_nm.TextChanged
        Dim b As String, sb As String = Nothing

        If k_bid.Text.Length = 0 AndAlso k_nm.Enabled Then
            MessageBox.Show("Silakan pilih kompetensi dahulu.")
            Return
        Else
            b = " bcnf ='" + k_bid.Text.Replace(" - ", "-").Split("-")(0) + "'"
        End If
        If k_sb.Text.Length <> 0 Then
            sb = " bcnf='" + k_sb.Text.Replace(" - ", "-").Split("-")(0) + "'"
        End If
        If b IsNot Nothing Then
            b = " and ( " + b + " " + IIf(sb IsNot Nothing, " or " + sb, Nothing) + ")"
        End If

        If db.QueryTable("select * from kriteria where nama='" + k_nm.Text + "' and id_kriteria <>'" +
                         k_id.Text + "'" + b).Rows.Count > 0 Then
            ErrorProvider1.SetError(k_nm, "Nama Sudah ada, Silakan gunakan nama lain.")
            valid = False
        Else
            ErrorProvider1.Clear()
            valid = True
        End If
    End Sub



    Private Sub bd_batal_Click(sender As Object, e As EventArgs) Handles k_btl.Click
        edit(False)
    End Sub


End Class