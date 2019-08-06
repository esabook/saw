Imports CrystalDecisions.CrystalReports.Engine
Public Class Fr_SAW
    Dim mx_awal_nilaiHasil As New DataTable("nr"),
        mx_awal_bobotHasil As New DataTable("nk"),
        mx_normalisasiMax As New DataTable("r+"),
        mx_hasilAkhir As New DataTable("v"),
        mx_hasilSort As New DataTable("s"),
        db As New C_database
    Dim punyaSubKompetensi = False
    Dim k As ArrayList
    Dim header As SortedList
    Dim headerName As SortedList
    Dim s As String, t As String
    Public dt() As Object

    Public Sub setFilter(ByRef tahunMin As Double, ByRef tahunMax As Double, ByRef peringkat As Double)
        i_tahun_min.Value = tahunMin
        i_tahun_max.Value = tahunMax
        i_peringkat.Value = peringkat
    End Sub

    Public Sub showFilter(ByRef bool As Boolean)
        panel_filter.Visible = bool
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged, RadioButton4.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged

        dgview.DataSource = Nothing

        'Try
        Select Case sender.name
            Case RadioButton1.Name
                dgview.DataSource = mx_awal_nilaiHasil

            Case RadioButton2.Name

                dgview.DataSource = mx_awal_bobotHasil

            Case RadioButton4.Name
                dgview.DataSource = mx_normalisasiMax

            Case RadioButton6.Name
                dgview.DataSource = mx_hasilAkhir

        End Select
        'Catch
        'End Try
    End Sub
    Private Sub refr()
        dgview.DataSource = mx_hasilAkhir
    End Sub
    Private Sub dgview_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgview.CellPainting
        If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
            Dim r2 As Rectangle = e.CellBounds
            r2.Y += e.CellBounds.Height / 2
            r2.Height = e.CellBounds.Height / 2
            e.PaintBackground(r2, True)
            e.PaintContent(r2)
            e.Handled = True
        End If
    End Sub
    Private Sub dgview_ColumnWidthChanged(sender As Object, e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles dgview.ColumnWidthChanged
        Dim rtHeader As Rectangle = Me.dgview.DisplayRectangle
        rtHeader.Height = Me.dgview.ColumnHeadersHeight / 3
        Me.dgview.Invalidate(rtHeader)
    End Sub
    Private Sub dgview_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles dgview.Paint
        If dgview.ColumnCount < 4 Then Return
        Dim j As Integer = 2
        For i = 0 To j
            dgview.Columns.Item(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For head = 0 To header.Count - 1
            Dim jumlahChildKolom = header.GetByIndex(head)

            Dim r1 As Rectangle = Me.dgview.GetCellDisplayRectangle(j, -1, True)

            Dim w2 As Integer = 0
            For i = 1 To jumlahChildKolom - 1
                w2 += Me.dgview.GetCellDisplayRectangle(j + i, -1, True).Width
            Next
            r1.X += 1
            r1.Y += 1
            r1.Width = r1.Width + w2 - 2
            r1.Height = r1.Height / 3 - 2
            e.Graphics.FillRectangle(New SolidBrush(Me.dgview.ColumnHeadersDefaultCellStyle.BackColor), r1)
            Dim format As New StringFormat()
            format.Alignment = StringAlignment.Center
            format.LineAlignment = StringAlignment.Center
            e.Graphics.DrawString(headerName.Item(header.GetKey(head)), Me.dgview.ColumnHeadersDefaultCellStyle.Font, New SolidBrush(Me.dgview.ColumnHeadersDefaultCellStyle.ForeColor), r1, format)
            j += jumlahChildKolom
            'End While
        Next
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If mx_hasilAkhir.Rows.Count > 0 Then mx_hasilAkhir.Rows.Clear()
        If mx_awal_nilaiHasil Is Nothing Or k Is Nothing Then MessageBox.Show("Pilih kompetensi terlebih dahulu.") : Return
        If mx_awal_nilaiHasil.Rows.Count < 2 Then MessageBox.Show("Perhitungan tidak diperlukan sebab data hasil tes siswa kurang.  Minimal 2 (dua) data hasil tes.") : Return
        v()
        hasil()

        RadioButton6.Checked = True
        RadioButton4.Enabled = True
        RadioButton6.Enabled = True
        Try
            Label2.Text = "Nilai terbesar adalah " & mx_hasilAkhir.Rows.Item(0).Item(2) & " milik siswa dengan NIS " & mx_hasilAkhir.Rows.Item(0).Item(0) &
                ", sehingga siswa yang terpilih untuk mengikuti LKS pada Jurusan " & dt(1) & IIf(SplitContainer1.Panel1Collapsed, "", " - Kompetensi " & t) & " adalah " & mx_hasilAkhir.Rows.Item(0).Item(1) & "."
            Dim lb As String = "", rrr As DataRow
            For i = 1 To mx_hasilAkhir.Rows.Count - 1
                rrr = mx_hasilAkhir.Rows.Item(i)
                If rrr.Item(2) = mx_hasilAkhir.Rows.Item(0).Item(2) Then

                    lb &= ", " & rrr.Item(0) & " - " & rrr.Item(1)
                End If
            Next
            If lb.Length > 0 Then
                Label2.Text &= " Siswa lain dengan nilai hasil yang sama dengan " & mx_hasilAkhir.Rows.Item(0).Item(1) & " (nilai " & mx_hasilAkhir.Rows.Item(0).Item(2) & ") adalah " & lb.Remove(0, 1) & "."
            End If
            Label2.Visible = True
        Catch
        End Try
        db.QueryIUD("insert into hasil_pemilihan (id_hasil_pemilihan, nis, nilai_hasil) values ('" + db.IDBaruBerdasarTabel(db.tabel_HasilP) + "','" + mx_hasilAkhir.Rows.Item(0).Item(0) + "','" + mx_hasilAkhir.Rows.Item(0).Item(2).ToString() + "')")
        Button2_Click(sender, e)
    End Sub
    Private Sub isiKOm()
        SplitContainer1.Panel1Collapsed = True
        For Each r As DataRow In db.QueryTable("select id_kompetensi &' - '& nama from kompetensi where kode_jurusan='" + dt(0) + "'").Rows

            kom.Items.Add(r(0))

            For Each subr As DataRow In db.QueryTable("select ' > '&id_sub_kompetensi &' - '& nama from sub_kompetensi where id_kompetensi='" + r(0).ToString.Replace(" - ", "-").Split("-")(0) + "'").Rows

                SplitContainer1.Panel1Collapsed = False
            Next

        Next
    End Sub

    Private Sub Fr_SAW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Text &= "- " & IIf(dt(3) = 1, "Ketua Jurusan", "Wali Kelas") & " " & dt(1)
        isiKOm()
        kom_SelectedIndexChanged(Nothing, Nothing)
        Me.dgview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgview.ColumnHeadersHeight = Me.dgview.ColumnHeadersHeight * 3
        Me.dgview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        Me.dgview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        'AddHandler mx_hasilAkhir.en, AddressOf refr

        AddHandler i_peringkat.ValueChanged, AddressOf filter_changed
        AddHandler i_tahun_min.ValueChanged, AddressOf filter_changed
        AddHandler i_tahun_max.ValueChanged, AddressOf filter_changed
    End Sub


    Private Sub reset()
        Try
            dgview.DataSource = Nothing
            mx_awal_nilaiHasil.Clear()
            mx_awal_bobotHasil.Clear()
            mx_normalisasiMax.Clear()
            mx_hasilAkhir.Clear()
            Label2.ResetText()
            k.Clear()
            header.Clear()
            headerName.Clear()

        Catch
        End Try
    End Sub
    Private Sub kom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kom.SelectedIndexChanged
        reset()

        If kom.SelectedItem Is Nothing Then

            s = kom.Items.Item(0).ToString.Replace(" > ", "").Split(" - ")(0)
            t = kom.Items.Item(0).ToString.Replace(" > ", "").Split("- ")(1)

        Else

            s = kom.SelectedItem.ToString.Replace(" > ", "").Split(" - ")(0)
            t = kom.SelectedItem.ToString.Replace(" > ", "").Split("- ")(1)

        End If

        RadioButton4.Enabled = False
        RadioButton6.Enabled = False
        k = New ArrayList
        header = New SortedList
        headerName = New SortedList

        Dim queryPilihKriteria As String
        If SplitContainer1.Panel1Collapsed Then
            queryPilihKriteria = "SELECT k.id_kriteria, k.bcnf as ID   from kriteria as k " +
                                              "where (bcnf=" + stringbcnfsub("k.bcnf") + " or bcnf=" + stringbcnfko("k.bcnf") + ") order by k.bcnf ASC "
        Else
            queryPilihKriteria = "SELECT k.id_kriteria, k.bcnf as ID   from kriteria as k " +
                                              "where (bcnf=" + stringbcnfsub("k.bcnf and b.id_kompetensi='" + s + "'") + ") order by k.bcnf ASC "
        End If

        For Each d As DataRow In db.QueryTable(queryPilihKriteria).Rows
            k.Add(d(0))

            If header.Contains(d(1)) Then
                header.SetByIndex(header.IndexOfKey(d(1)), header.Item(d(1)) + 1)
            Else
                header.Add(d(1), 1)
            End If
        Next
        For inde = 0 To header.Count - 1
            headerName.Add(header.GetKey(inde), getnameKompetensi(header.GetKey(inde)))
        Next

        awal()
        kat_r()
        RadioButton1.Checked = True
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton1_CheckedChanged(RadioButton1, Nothing)
    End Sub

    Private Function getnameKompetensi(v As Object) As Object
        If v.ToString.Contains(db.awalan_PKkompetensi) Then
            Return db.QueryStr("select nama from kompetensi where id_kompetensi='" + v + "'")
        ElseIf v.ToString.Contains(db.awalan_PKSubBid) Then
            Return db.QueryStr("select nama from sub_kompetensi where id_sub_kompetensi='" + v + "'")
        End If
        Return "Tidak Diketahui"
    End Function

    Private Function stringbcnfsub(isisama As String) As String
        Return " (select id_sub_kompetensi from sub_kompetensi as sb inner join kompetensi as b on sb.id_kompetensi=b.id_kompetensi where b.kode_jurusan='" + dt(0) + "' and sb.id_sub_kompetensi=" + isisama + " ) "

    End Function
    Private Function stringbcnfko(isisama As String) As String
        Return " (select id_kompetensi from kompetensi where id_kompetensi= " + isisama + " and kode_jurusan='" + dt(0) + "')"
    End Function


    Public Function VERTkeHORZ_hasiltes(ByRef Array1DOfFieldName() As Object, filter As String) As String
        Dim nilai
        nilai = "select Distinct s.nis as NIS, s.nama as [NAMA]"
        If Not IsNothing(Array1DOfFieldName) Then
            For index = 0 To Array1DOfFieldName.Length - 1
                nilai += ", (select h.nilai from hasil_tes as h where (h.nis =s.nis) and (h.id_kriteria='" +
                        Array1DOfFieldName(index) + "')) as [" & Array1DOfFieldName(index) & "]"
            Next
        End If

        nilai += " from siswa as s inner join hasil_tes as h on s.nis=h.nis " + filter
        Return nilai

    End Function

    Private Sub awal()
        Dim batasAtasPeringkat = i_peringkat.Value.ToString,
            tahunMin = i_tahun_min.Value.ToString,
            tahunMax = i_tahun_max.Value.ToString

        If SplitContainer1.Panel1Collapsed Then
            mx_awal_nilaiHasil = db.QueryTable(VERTkeHORZ_hasiltes(k.ToArray,
                                                                   " where (peringkat between 0 and " + batasAtasPeringkat + " and tahun_ajaran between " + tahunMin + " and " + tahunMax + " ) 
                                                                   and (s.kode_kompetensi=" + stringbcnfsub("s.kode_kompetensi") + " or s.kode_kompetensi=" + stringbcnfko("s.kode_kompetensi") + " or  s.kode_kompetensi='" + dt(0) + "')"))
        Else
            mx_awal_nilaiHasil = db.QueryTable(VERTkeHORZ_hasiltes(k.ToArray,
                                                                   " where (peringkat between 0 and " + batasAtasPeringkat + " and tahun_ajaran between " + tahunMin + " and " + tahunMax + " )
                                                                   and (s.kode_kompetensi=" + stringbcnfsub("s.kode_kompetensi") + " or s.kode_kompetensi='" + s + "')"))
        End If
    End Sub

    Private Sub dgview_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dgview.Validating
        Dim rtHeader As Rectangle = Me.dgview.DisplayRectangle
        rtHeader.Height = Me.dgview.ColumnHeadersHeight / 3
        Me.dgview.Invalidate(rtHeader)
    End Sub



    Private Sub dgview_Scroll(sender As Object, e As ScrollEventArgs) Handles dgview.Scroll
        Dim rtHeader As Rectangle = Me.dgview.DisplayRectangle
        rtHeader.Height = Me.dgview.ColumnHeadersHeight / 3
        Me.dgview.Invalidate(rtHeader)
    End Sub

    Private Sub filter_changed(sender As Object, e As EventArgs)
        kom_SelectedIndexChanged(Nothing, Nothing)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            Dim crr As New Laporan

            Dim tx As TextObject = crr.ReportDefinition.ReportObjects.Item("jur")
            Dim txnm As TextObject = crr.ReportDefinition.ReportObjects.Item("jurnm")
            Dim ha As TextObject = crr.ReportDefinition.ReportObjects.Item("ha")
            Dim tgl As TextObject = crr.ReportDefinition.ReportObjects.Item("tgl")
            tx.Text = IIf(SplitContainer1.Panel1Collapsed, dt(0), dt(0) & " / " & s)
            txnm.Text = IIf(SplitContainer1.Panel1Collapsed, dt(1), dt(1) & " / " & t.Substring(1))
            ha.Text = Label2.Text
            Dim hr() = {"Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu"}
            Dim dte() = {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"}
            tgl.Text = hr(Now.DayOfWeek.GetHashCode) & ", " & Now.Day & "-" & dte(Now.Month - 1) & "-" & Now.Year

            crr.SetDataSource(mx_hasilAkhir)

            CrystalReportViewer1.ReportSource = crr
            CrystalReportViewer1.Refresh()
            'TabControl1.SelectedTab = TabPage2
        Catch
            MessageBox.Show("Gagal ketika membuat laporan." +
                            Chr(13) + "Pastikan komputer telah terpasang Crystal Report Runtime SP 1 17, atau silakan hubungi administrator.")
        End Try
    End Sub

    Private Sub kat_r()
        mx_awal_bobotHasil = mx_awal_nilaiHasil.Copy

        Dim nm = ""
        Dim idkoolom As String, ST As String
        For kolom = 2 To mx_awal_nilaiHasil.Columns.Count - 1
            idkoolom = mx_awal_bobotHasil.Columns.Item(kolom).ColumnName
            For baris = 0 To mx_awal_bobotHasil.Rows.Count - 1

                If mx_awal_bobotHasil.Rows.Item(baris).Item(kolom).ToString.Length > 0 Then
                    ST = deteksiSUB(idkoolom, mx_awal_bobotHasil.Rows.Item(baris).Item(kolom))
                    mx_awal_bobotHasil.Rows.Item(baris).Item(kolom) = IIf(ST.Length > 0, ST, " 0 ")
                Else
                    mx_awal_bobotHasil.Rows.Item(baris).Item(kolom) = " 0 "
                End If
            Next
            nm = db.QueryStr("select nama from kriteria where id_kriteria='" + idkoolom + "'")
            mx_awal_nilaiHasil.Columns.Item(kolom).ColumnName = IIf(mx_awal_nilaiHasil.Columns.IndexOf(nm) > 0, nm + "_" & kolom, nm)
            mx_awal_bobotHasil.Columns.Item(kolom).ColumnName = IIf(mx_awal_bobotHasil.Columns.IndexOf(nm) > 0, nm + "_" & kolom, nm)
        Next

    End Sub

    Private Sub v()
        mx_normalisasiMax = mx_awal_bobotHasil.Copy
        Dim nilai As Double = 0, name = ""

        For kolom = 2 To mx_normalisasiMax.Columns.Count - 1
            nilai = 0
            For Each s As DataRow In mx_normalisasiMax.Rows
                nilai = Math.Max(nilai, s.Item(kolom))
            Next
            For Each d As DataRow In mx_normalisasiMax.Rows
                d.Item(kolom) = IIf(nilai = 0, 0, d.Item(kolom) / nilai)                                       'X(ij)/Max(X(ij))
            Next
        Next
    End Sub
    Private Sub hasil()
        Dim l As New ArrayList, m As String, sum As Double

        'mengambil nilai bobot kriteria
        For Each ink As Object In k
            m = db.QueryStr("select nilai from bobot where id_kriteria='" + ink + "'")
            l.Add(IIf(m.ToString.Length > 0, m, "0"))
        Next
        'total nilai bobot kriteria
        For i = 0 To l.Count - 1
            sum += l.Item(i)
        Next
        'memberi nama header  dgn nilai bobot skala 100
        For i = 0 To l.Count - 1
            l.Item(i) = 100 * l.Item(i) / sum
            mx_awal_nilaiHasil.Columns.Item(i + 2).ColumnName += " (" & Math.Round(l.Item(i), 1) & "%)"
            mx_awal_bobotHasil.Columns.Item(i + 2).ColumnName += " (" & Math.Round(l.Item(i), 1) & "%)"
            mx_normalisasiMax.Columns.Item(i + 2).ColumnName += " (" & Math.Round(l.Item(i), 1) & "%)"

        Next
        'tabel hasil akhir
        'Try
        For i = 0 To 1
            Try
                mx_hasilAkhir.Columns.Add((mx_awal_nilaiHasil.Columns.Item(i).ColumnName))
            Catch
            End Try
        Next

        Try
            mx_hasilAkhir.Columns.Add("HASIL", New Double.GetType())
        Catch
        End Try
        Dim d As DataRow
        For Each baris As DataRow In mx_normalisasiMax.Rows
            d = mx_hasilAkhir.NewRow
            'isi baris nama siswa, nis
            For i = 0 To 1
                d.Item(i) = baris.Item(i)
            Next
            'isi nilainya sesuai norm max
            d.Item(2) = 0

            For kolom = 2 To mx_normalisasiMax.Columns.Count - 1
                d.Item(2) += baris.Item(kolom) * l.Item(kolom - 2)
            Next
            mx_hasilAkhir.Rows.Add(d)
        Next
        mx_hasilAkhir.DefaultView.Sort = "HASIL DESC"

        mx_hasilAkhir = mx_hasilAkhir.DefaultView.ToTable

        '''''''''''''''''''''''''''''mx_hasilAkhir.Columns.Item(2).ColumnName = "HASIL AKHIR"
        'Catch
        'End Try
    End Sub



    Public Function deteksiSUB(ByRef id_krit As String, ByRef NilaiSUB As String) As String
        Return db.QueryStr("select bobot from sub_kriteria where id_kriteria='" + id_krit + "' and nama='" + NilaiSUB + "' ")
    End Function

End Class