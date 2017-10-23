Public Class Fr_bidang
    Public dt() As Object
    Dim db As New C_database
    Dim ub As ubah, valid As Boolean
    Private Sub Fr_bidang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sp_jur.Text = dt(1)
        cl()
    End Sub

    Private Sub tx(sender As Object, e As EventArgs) Handles bd_bid.TextChanged
        If db.QueryTable("select * from bidang where nama='" + bd_bid.Text + "' and id_bidang<>'" + bd_idbid.Text + "'").Rows.Count > 0 Then
            ErrorProvider1.SetError(sender, "Nama Sudah Ada")
            valid = False

            Else
            ErrorProvider1.Clear()
            valid = True
        End If

    End Sub

    Private Sub cx(sender As Object, e As DataGridViewCellEventArgs) Handles dgV.CellClick
        bd_idbid.Text = dgV.CurrentRow.Cells(0).Value
        bd_bid.Text = dgV.CurrentRow.Cells(2).Value
        dgW.DataSource = db.QueryDS("select * from sub_bidang where id_bidang='" + dgV.CurrentRow.Cells(0).Value + "'")

    End Sub

    Private Enum ubah
        ubah
        baru
    End Enum
    Private Sub edit(boo As Boolean)
        bd_bid.Enabled = boo
        dgV.Enabled = Not boo
        dgW.Enabled = Not boo
        If boo Then AddHandler bd_bid.TextChanged, AddressOf tx Else RemoveHandler bd_bid.TextChanged, AddressOf tx
        bd_tbh.Enabled = Not boo
        bd_ubh.Enabled = Not boo
        bd_hps.Enabled = Not boo
        bd_sp.Enabled = boo
        bd_batal.Enabled = boo
    End Sub

    Private Sub cl()
        bd_bid.Items.Clear()
        isi()
        edit(False)
    End Sub
    Private Sub isi()

        bd_bid.Items.Clear()
        dgV.DataSource = db.QueryDS("select * from bidang where kode_jurusan='" + dt(0) + "'")
        For Each r As DataRow In db.QueryTable("select nama from bidang where kode_jurusan='" + dt(0) + "'").Rows
            bd_bid.Items.Add(r(0))
        Next
    End Sub

    Private Sub bd_tbh_Click(sender As Object, e As EventArgs) Handles bd_tbh.Click
        cl()
        bd_idbid.Text = db.IDBaruBerdasarTabel(db.tabel_Bidang)
        edit(True)
        ub = ubah.baru
    End Sub

    Private Sub bd_ubh_Click(sender As Object, e As EventArgs) Handles bd_ubh.Click
        edit(True)
        ub = ubah.ubah
    End Sub

    Private Sub bd_hps_Click(sender As Object, e As EventArgs) Handles bd_hps.Click
        db.QueryIUD("delete from bidang where id_bidang='" + bd_idbid.Text + "'")
        isi()
    End Sub

    Private Sub bd_sp_Click(sender As Object, e As EventArgs) Handles bd_sp.Click
        If valid Then
            If ub = ubah.baru Then
                db.QueryIUD("insert into bidang (id_bidang, kode_jurusan, nama) values ('" + bd_idbid.Text + "','" + dt(0) + "','" + bd_bid.Text + "')")

            Else
                db.QueryIUD("UPDATE bidang set kode_jurusan='" + dt(0) + "', nama='" + bd_bid.Text + "' where id_bidang='" + bd_idbid.Text + "'")

            End If
            isi()
            bd_batal.PerformClick()
        Else
            MessageBox.Show("Ada yang belum valid. Silakan perbaiki")
        End If
    End Sub

    Private Sub bd_batal_Click(sender As Object, e As EventArgs) Handles bd_batal.Click
        edit(False)
        cl()
    End Sub




End Class