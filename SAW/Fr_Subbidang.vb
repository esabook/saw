Public Class Fr_Subbidang

    Public dt() As Object
        Dim db As New C_database
    Dim ub As ubah, valid As Boolean
    Private Sub Fr_bidang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text += " - " + IIf(dt(3) = 1, "Ketua ", "Wali ") & "Jurusan " & dt(1)
        cl()
        Button1.PerformClick()
    End Sub

    Private Sub tx(sender As Object, e As EventArgs) Handles bd_sbid.KeyPress
        If db.QueryTable("select * from sub_bidang where nama='" + bd_sbid.Text + "' and id_sub_bidang<>'" + bd_idbid.Text + "'").Rows.Count > 0 Then
            ErrorProvider1.SetError(sender, "Nama Sudah Ada ")
            valid = False
        Else
            valid = True
            ErrorProvider1.Clear()
        End If

    End Sub

    Private Sub cx(sender As Object, e As DataGridViewCellEventArgs) Handles dgV.CellClick
        dgW.DataSource = db.QueryDS("select * from sub_bidang where id_bidang='" + dgV.CurrentRow.Cells(0).Value + "'")
        bd_bid.SelectedIndex = dgV.CurrentRow.Index
    End Sub

    Private Enum ubah
        ubah
        baru
    End Enum
    Private Sub edit(boo As Boolean)
        bd_bid.Enabled = boo
        bd_sbid.Enabled = boo
        dgV.Enabled = Not boo
        dgW.Enabled = Not boo
        If boo Then AddHandler bd_bid.TextChanged, AddressOf tx Else RemoveHandler bd_bid.TextChanged, AddressOf tx
        bd_tbh.Enabled = Not boo
        bd_ubh.Enabled = Not boo
        bd_hps.Enabled = Not boo
        bd_sp.Enabled = boo
        bd_batal.Enabled = boo
    End Sub

    Private Sub cy(sender As Object, e As DataGridViewCellEventArgs) Handles dgW.CellClick
        Try
            bd_idbid.Text = dgW.CurrentRow.Cells(0).Value
            bd_bid.Text = db.QueryStr("select nama from bidang where id_bidang='" + dgW.CurrentRow.Cells(1).Value + "'")
            bd_sbid.Text = dgW.CurrentRow.Cells(2).Value
        Catch
        End Try
    End Sub
    Private Sub cl()
        bd_sbid.Clear()
        bd_bid.Items.Clear()
        bd_sbid.Clear()
        isi()
        edit(False)
    End Sub
    Private Sub isi()

        bd_bid.Items.Clear()
        For Each r As DataRow In db.QueryTable("select nama from bidang where kode_jurusan='" + dt(0) + "'").Rows
            bd_bid.Items.Add(r(0))
        Next
    End Sub

    Private Sub bd_tbh_Click(sender As Object, e As EventArgs) Handles bd_tbh.Click
        cl()
        bd_idbid.Text = db.IDBaruBerdasarTabel(db.tabel_SubBid)
        edit(True)
        ub = ubah.baru
    End Sub

    Private Sub bd_ubh_Click(sender As Object, e As EventArgs) Handles bd_ubh.Click
        If bd_idbid.Text.Length > 0 Then
            edit(True)
            ub = ubah.ubah
        Else
            MessageBox.Show("Belum ada yang dipilih, silaka pilih dahulu.")
        End If
    End Sub

    Private Sub bd_hps_Click(sender As Object, e As EventArgs) Handles bd_hps.Click
        If bd_idbid.Text.Length > 0 Then

            db.QueryIUD("delete from sub_bidang where id_sub_bidang='" + bd_idbid.Text + "'")
            cx(Nothing, Nothing)
            isi()
        Else
            MessageBox.Show("Belum ada yang dipilih, silaka pilih dahulu.")
        End If
    End Sub

    Private Sub bd_sp_Click(sender As Object, e As EventArgs) Handles bd_sp.Click
        If valid Then
            If ub = ubah.baru Then
                db.QueryIUD("insert into sub_bidang (id_sub_bidang, id_bidang,nama) values ('" + bd_idbid.Text + "','" + db.IDBerdasarNama_Bidang(bd_bid.Text) + "','" + bd_sbid.Text + "')")
            Else
                db.QueryIUD("UPDATE sub_bidang set id_bidang='" + db.IDBerdasarNama_Bidang(bd_bid.Text) + "', nama='" + bd_sbid.Text + "' where id_sub_bidang='" + bd_idbid.Text + "'")
            End If

            isi()
            cx(Nothing, Nothing)
            bd_batal.PerformClick()
        Else
            MessageBox.Show("Masih ada yang belum valid.")
        End If
    End Sub

    Private Sub bd_bid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bd_bid.SelectedIndexChanged
        dgV.CurrentCell = dgV.Rows(bd_bid.SelectedIndex).Cells(0)
        cx(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgV.DataSource = db.QueryDS("select * from bidang where kode_jurusan='" + dt(0) + "'")

    End Sub

    Private Sub bd_batal_Click(sender As Object, e As EventArgs) Handles bd_batal.Click
        edit(False)
        cl()
    End Sub




End Class