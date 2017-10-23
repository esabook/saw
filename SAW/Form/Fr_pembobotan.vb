Public Class Fr_pembobotan
    Public dt() As Object
    Dim db As New C_database, tot = 0, currentVal = 0, val = 0, punyaSub = False

    Private Sub Fr_pembobotan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Text &= "- " & IIf(dt(3) = 1, "Ketua Jurusan", "Wali Kelas") & " " & dt(1)
        AddHandler dgK.CellEnter, AddressOf dgK_CellClick

        RemoveHandler dgK.CellEnter, AddressOf dgK_CellClick

        lis.Items.Clear()
        lis.Items.Add("Semua :")

        For Each r As DataRow In db.QueryTable("select id_kompetensi &' - '& nama from kompetensi where kode_jurusan='" + dt(0) + "'").Rows

            lis.Items.Add(r(0))
            For Each subr As DataRow In db.QueryTable("select ' > '&id_sub_kompetensi &' - '& nama from sub_kompetensi where id_kompetensi='" + r(0).ToString.Replace(" - ", "-").Split("-")(0) + "'").Rows
                lis.Items.Add(subr(0))
                punyaSub = True
            Next

        Next
        b_reset.PerformClick()
        ErrorProvider1.SetError(total, "Apabila nilai ini telah Mencapai bobot maksimal (100), nilai tidak dapat ditambah.")

    End Sub
    Private Sub fillnilai()
        currentVal = NumericUpDown1.Value
        NumericUpDown1.Enabled = b_sp.Enabled
        Dim str As String
        tot = 0

        total.ResetText()

        For index = 0 To dgK.Rows.Count - 1
            str = db.QueryStr("select nilai from bobot where id_kriteria='" + dgK.Rows(index).Cells(0).Value + "'")
            dgK.Rows(index).Cells(2).Value = IIf(str.Length <> 0, str, "0")
            tot += dgK.Rows(index).Cells(2).Value
        Next
        total.Text = tot

    End Sub

    Private Sub dgK_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgK.CellClick
        dgSk.DataSource = db.QueryDS("select NAMA, BOBOT from sub_kriteria where id_kriteria='" + dgK.CurrentRow.Cells(0).Value + "'")

        Try
            NumericUpDown1.Value = dgK.CurrentRow.Cells(2).Value
            currentVal = dgK.CurrentRow.Cells(2).Value
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b_sp.Click
        Dim s = "select id_bobot from bobot where id_kriteria ='" + dgK.CurrentRow.Cells(0).Value.ToString + "' and nilai=" + dgK.CurrentRow.Cells(2).Value
        If db.QueryTable(s).Rows.Count = 0 Then
            db.QueryIUD("insert into bobot (id_bobot, id_kriteria, nilai) values ('" + db.IDBaruBerdasarTabel(db.tabel_Bobot) + "','" + dgK.CurrentRow.Cells(0).Value.ToString + "'," + NumericUpDown1.Value.ToString + ")")
        Else
            db.QueryIUD("update bobot set nilai=" + NumericUpDown1.Value.ToString + " where id_bobot='" + db.QueryStr(s) + "'")
        End If
        fillnilai()
    End Sub

    Private Sub NumericUpDown1_Leave(sender As Object, e As EventArgs) Handles NumericUpDown1.Leave
        If NumericUpDown1.Value > val Then NumericUpDown1.Value = val
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles b_reset.Click
        semua()
        b_sp.Enabled = Not punyaSub
        fillnilai()

    End Sub
    Private Sub semua()

        dgK.DataSource = db.QueryDS("SELECT distinct k.id_kriteria as ID, k.nama as NAMA, k.nama as NILAI  from kriteria as k where bcnf=(select id_sub_kompetensi from sub_kompetensi as sb inner join kompetensi as b on sb.id_kompetensi=b.id_kompetensi where b.kode_jurusan='" + dt(0) + "' and sb.id_sub_kompetensi=k.bcnf ) or bcnf=(select id_kompetensi from kompetensi where id_kompetensi=k.bcnf and kode_jurusan='" + dt(0) + "')")

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        val = 100 - tot + currentVal
        If NumericUpDown1.Value > val Then
            NumericUpDown1.Value = NumericUpDown1.Value - 1
        End If
    End Sub

    Private Sub lis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lis.SelectedIndexChanged
        'Debug.Print(lis.SelectedItem.ToString)
        If lis.SelectedItem.ToString.Contains("Semua") Then
            b_reset.PerformClick()
            Return
        ElseIf lis.SelectedItem.ToString.Substring(0, 2).Equals(db.awalan_PKkompetensi) Then
            dgK.DataSource = db.QueryDS("select k.id_kriteria as ID, k.nama as NAMA, k.nama as NILAI  from kriteria as k where bcnf=(select sb.id_sub_kompetensi from sub_kompetensi as sb where  sb.id_kompetensi='" +
                                        lis.SelectedItem.ToString.Replace(" > ", "").Split(" - ")(0) + "' and sb.id_sub_kompetensi=k.bcnf) or bcnf= '" + lis.SelectedItem.ToString.Replace(" > ", "").Split(" - ")(0) + "'")
            b_sp.Enabled = punyaSub
        Else
            dgK.DataSource = db.QueryDS("select k.id_kriteria as ID, k.nama as NAMA, k.nama as NILAI  from kriteria as k where bcnf='" + lis.SelectedItem.ToString.Replace(" > ", "").Split(" - ")(0) + "' ")
            b_sp.Enabled = False
        End If
        fillnilai()
    End Sub
End Class