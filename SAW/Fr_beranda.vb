Public Class Fr_beranda
    Dim childForm As Form
    Dim dt() As Object

    Private Sub tampil(ByVal f As Form)
        IsMdiContainer = True
        PictureBox1.Visible = False
        f.MdiParent = Me
        AddHandler f.FormClosed, AddressOf Fr_beranda_FormClosed
        f.Show()
    End Sub


    Private Sub KriteriaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KriteriaToolStripMenuItem1.Click
        Dim f As New Fr_kriteria
        f.dt = dt
        tampil(f)
    End Sub

    Private Sub DataSiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSiswaToolStripMenuItem.Click

        Dim f As New Fr_siswa
        f.dt = dt
        tampil(f)
    End Sub

    Private Sub HasilTesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HasilTesToolStripMenuItem.Click
        Dim f As New Fr_hasiltes
        f.dt = dt
        tampil(f)
    End Sub
    Private Sub restitle()
        Text = "Beranda - " & IIf(dt(3) = 1, "Ketua Jurusan", "Wali Kelas") & " " & dt(1)

    End Sub
    Private Sub Fr_beranda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case dt(3)
            Case 1
                SiswaToolStripMenuItem.Visible = False
                PerhitunganSAWToolStripMenuItem.Visible = False
            Case 2
                BidangToolStripMenuItem.Visible = False
                KriteriaToolStripMenuItem.Visible = False
        End Select
        restitle()
    End Sub
    Public Sub dataLogin(ByVal dd() As Object)
        dt = dd
    End Sub

    Private Sub PembobotanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembobotanToolStripMenuItem.Click
        Dim f As New Fr_pembobotan
        f.dt = dt
        tampil(f)
    End Sub

    Private Sub LoginJendelaBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginJendelaBaruToolStripMenuItem.Click
        Fr_login.Show()
        Close()
    End Sub

    Private Sub DataBidangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBidangToolStripMenuItem.Click
        Dim f As New Fr_kompetensi
        f.dt = dt

        tampil(f)
    End Sub

    Private Sub DataSubBidangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSubBidangToolStripMenuItem.Click
        Dim f As New Fr_Subkompetensi
        f.dt = dt

        tampil(f)
    End Sub

    Private Sub DataSubKriteriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSubKriteriaToolStripMenuItem.Click
        Dim f As New Fr_subkriteria
        f.dt = dt
        tampil(f)
    End Sub

    Private Sub PerhitunganSAWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerhitunganSAWToolStripMenuItem.Click
        Dim f As New Fr_SAW
        f.dt = dt
        tampil(f)

    End Sub

    Private Sub Fr_beranda_FormClosed(sender As Object, e As FormClosedEventArgs)

        If MdiChildren.Count = 1 Then
            IsMdiContainer = False
            PictureBox1.Visible = True
        End If
        restitle()
    End Sub
End Class