<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fr_beranda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BidangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBidangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSubBidangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KriteriaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSubKriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PembobotanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HasilTesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerhitunganSAWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginJendelaBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.olahJur = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BidangToolStripMenuItem, Me.KriteriaToolStripMenuItem, Me.SiswaToolStripMenuItem, Me.PerhitunganSAWToolStripMenuItem, Me.LoginJendelaBaruToolStripMenuItem, Me.olahJur})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(944, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BidangToolStripMenuItem
        '
        Me.BidangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBidangToolStripMenuItem, Me.DataSubBidangToolStripMenuItem})
        Me.BidangToolStripMenuItem.Name = "BidangToolStripMenuItem"
        Me.BidangToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.BidangToolStripMenuItem.Text = "&Kompetensi"
        '
        'DataBidangToolStripMenuItem
        '
        Me.DataBidangToolStripMenuItem.Name = "DataBidangToolStripMenuItem"
        Me.DataBidangToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DataBidangToolStripMenuItem.Text = "Data Kompetensi"
        '
        'DataSubBidangToolStripMenuItem
        '
        Me.DataSubBidangToolStripMenuItem.Name = "DataSubBidangToolStripMenuItem"
        Me.DataSubBidangToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DataSubBidangToolStripMenuItem.Text = "Data Sub Kompetensi"
        '
        'KriteriaToolStripMenuItem
        '
        Me.KriteriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KriteriaToolStripMenuItem1, Me.DataSubKriteriaToolStripMenuItem, Me.ToolStripSeparator1, Me.PembobotanToolStripMenuItem})
        Me.KriteriaToolStripMenuItem.Name = "KriteriaToolStripMenuItem"
        Me.KriteriaToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.KriteriaToolStripMenuItem.Text = "&Kriteria"
        '
        'KriteriaToolStripMenuItem1
        '
        Me.KriteriaToolStripMenuItem1.Name = "KriteriaToolStripMenuItem1"
        Me.KriteriaToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.KriteriaToolStripMenuItem1.Text = "Data Kriteria"
        '
        'DataSubKriteriaToolStripMenuItem
        '
        Me.DataSubKriteriaToolStripMenuItem.Name = "DataSubKriteriaToolStripMenuItem"
        Me.DataSubKriteriaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DataSubKriteriaToolStripMenuItem.Text = "Data Sub Kriteria"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'PembobotanToolStripMenuItem
        '
        Me.PembobotanToolStripMenuItem.Name = "PembobotanToolStripMenuItem"
        Me.PembobotanToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PembobotanToolStripMenuItem.Text = "Pembobotan"
        '
        'SiswaToolStripMenuItem
        '
        Me.SiswaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataSiswaToolStripMenuItem, Me.HasilTesToolStripMenuItem})
        Me.SiswaToolStripMenuItem.Name = "SiswaToolStripMenuItem"
        Me.SiswaToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.SiswaToolStripMenuItem.Text = "&Siswa"
        '
        'DataSiswaToolStripMenuItem
        '
        Me.DataSiswaToolStripMenuItem.Name = "DataSiswaToolStripMenuItem"
        Me.DataSiswaToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.DataSiswaToolStripMenuItem.Text = "Data Siswa"
        '
        'HasilTesToolStripMenuItem
        '
        Me.HasilTesToolStripMenuItem.Name = "HasilTesToolStripMenuItem"
        Me.HasilTesToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.HasilTesToolStripMenuItem.Text = "Hasil Tes"
        '
        'PerhitunganSAWToolStripMenuItem
        '
        Me.PerhitunganSAWToolStripMenuItem.Name = "PerhitunganSAWToolStripMenuItem"
        Me.PerhitunganSAWToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.PerhitunganSAWToolStripMenuItem.Text = "&Perhitungan SAW"
        '
        'LoginJendelaBaruToolStripMenuItem
        '
        Me.LoginJendelaBaruToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LoginJendelaBaruToolStripMenuItem.Name = "LoginJendelaBaruToolStripMenuItem"
        Me.LoginJendelaBaruToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.LoginJendelaBaruToolStripMenuItem.Text = "Login Jendela Baru"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.SAW.My.Resources.Resources.bg
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(944, 520)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'olahJur
        '
        Me.olahJur.Name = "olahJur"
        Me.olahJur.Size = New System.Drawing.Size(87, 20)
        Me.olahJur.Text = "Olah Jurusan"
        '
        'Fr_beranda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(944, 544)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Fr_beranda"
        Me.Text = "Beranda "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BidangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KriteriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembobotanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HasilTesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KriteriaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataSiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerhitunganSAWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginJendelaBaruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBidangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSubBidangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSubKriteriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents olahJur As ToolStripMenuItem
End Class
