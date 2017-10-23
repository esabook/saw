<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fr_siswa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.s_nis = New System.Windows.Forms.TextBox()
        Me.s_alm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.s_nm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.s_jk = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.s_kls = New System.Windows.Forms.TextBox()
        Me.kej = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.s_sp = New System.Windows.Forms.Button()
        Me.s_hps = New System.Windows.Forms.Button()
        Me.s_ubh = New System.Windows.Forms.Button()
        Me.s_tbh = New System.Windows.Forms.Button()
        Me.dgV = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.s_filter2 = New System.Windows.Forms.TextBox()
        Me.S_filter = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.s_reset = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.thn = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pr = New System.Windows.Forms.NumericUpDown()
        CType(Me.dgV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.thn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIS"
        '
        's_nis
        '
        Me.s_nis.Location = New System.Drawing.Point(85, 17)
        Me.s_nis.Name = "s_nis"
        Me.s_nis.Size = New System.Drawing.Size(135, 20)
        Me.s_nis.TabIndex = 0
        '
        's_alm
        '
        Me.s_alm.Location = New System.Drawing.Point(85, 81)
        Me.s_alm.Multiline = True
        Me.s_alm.Name = "s_alm"
        Me.s_alm.Size = New System.Drawing.Size(135, 58)
        Me.s_alm.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Alamat"
        '
        's_nm
        '
        Me.s_nm.Location = New System.Drawing.Point(85, 49)
        Me.s_nm.Name = "s_nm"
        Me.s_nm.Size = New System.Drawing.Size(135, 20)
        Me.s_nm.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Jenis Kelamin"
        '
        's_jk
        '
        Me.s_jk.FormattingEnabled = True
        Me.s_jk.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.s_jk.Location = New System.Drawing.Point(84, 148)
        Me.s_jk.Name = "s_jk"
        Me.s_jk.Size = New System.Drawing.Size(136, 21)
        Me.s_jk.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Kelas"
        '
        's_kls
        '
        Me.s_kls.Location = New System.Drawing.Point(85, 210)
        Me.s_kls.Name = "s_kls"
        Me.s_kls.Size = New System.Drawing.Size(135, 20)
        Me.s_kls.TabIndex = 5
        '
        'kej
        '
        Me.kej.FormattingEnabled = True
        Me.kej.Location = New System.Drawing.Point(84, 179)
        Me.kej.Name = "kej"
        Me.kej.Size = New System.Drawing.Size(136, 21)
        Me.kej.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "kompetensi"
        '
        's_sp
        '
        Me.s_sp.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.s_sp.ForeColor = System.Drawing.Color.White
        Me.s_sp.Location = New System.Drawing.Point(142, 316)
        Me.s_sp.Name = "s_sp"
        Me.s_sp.Size = New System.Drawing.Size(77, 96)
        Me.s_sp.TabIndex = 12
        Me.s_sp.Text = "Simpan"
        Me.s_sp.UseVisualStyleBackColor = False
        '
        's_hps
        '
        Me.s_hps.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.s_hps.ForeColor = System.Drawing.Color.White
        Me.s_hps.Location = New System.Drawing.Point(11, 416)
        Me.s_hps.Name = "s_hps"
        Me.s_hps.Size = New System.Drawing.Size(125, 46)
        Me.s_hps.TabIndex = 11
        Me.s_hps.Text = "Hapus"
        Me.s_hps.UseVisualStyleBackColor = False
        '
        's_ubh
        '
        Me.s_ubh.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.s_ubh.ForeColor = System.Drawing.Color.White
        Me.s_ubh.Location = New System.Drawing.Point(11, 367)
        Me.s_ubh.Name = "s_ubh"
        Me.s_ubh.Size = New System.Drawing.Size(125, 43)
        Me.s_ubh.TabIndex = 10
        Me.s_ubh.Text = "Ubah"
        Me.s_ubh.UseVisualStyleBackColor = False
        '
        's_tbh
        '
        Me.s_tbh.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.s_tbh.ForeColor = System.Drawing.Color.White
        Me.s_tbh.Location = New System.Drawing.Point(11, 316)
        Me.s_tbh.Name = "s_tbh"
        Me.s_tbh.Size = New System.Drawing.Size(125, 45)
        Me.s_tbh.TabIndex = 9
        Me.s_tbh.Text = "Tambah"
        Me.s_tbh.UseVisualStyleBackColor = False
        '
        'dgV
        '
        Me.dgV.AllowUserToAddRows = False
        Me.dgV.AllowUserToDeleteRows = False
        Me.dgV.AllowUserToResizeRows = False
        Me.dgV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.dgV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgV.Location = New System.Drawing.Point(3, 38)
        Me.dgV.MultiSelect = False
        Me.dgV.Name = "dgV"
        Me.dgV.ReadOnly = True
        Me.dgV.RowHeadersVisible = False
        Me.dgV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgV.Size = New System.Drawing.Size(604, 393)
        Me.dgV.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(273, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Filter Teks:"
        '
        's_filter2
        '
        Me.s_filter2.Location = New System.Drawing.Point(338, 4)
        Me.s_filter2.Name = "s_filter2"
        Me.s_filter2.Size = New System.Drawing.Size(260, 20)
        Me.s_filter2.TabIndex = 7
        '
        'S_filter
        '
        Me.S_filter.FormattingEnabled = True
        Me.S_filter.Location = New System.Drawing.Point(108, 3)
        Me.S_filter.Name = "S_filter"
        Me.S_filter.Size = New System.Drawing.Size(109, 21)
        Me.S_filter.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Filter Berdasarkan:"
        '
        's_reset
        '
        Me.s_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.s_reset.ForeColor = System.Drawing.Color.White
        Me.s_reset.Location = New System.Drawing.Point(142, 418)
        Me.s_reset.Name = "s_reset"
        Me.s_reset.Size = New System.Drawing.Size(77, 44)
        Me.s_reset.TabIndex = 13
        Me.s_reset.Text = "Batal"
        Me.s_reset.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(865, 440)
        Me.TableLayoutPanel1.TabIndex = 27
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgV, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(252, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.29493!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.70507!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(610, 434)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.S_filter)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.s_filter2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(604, 29)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.pr)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.thn)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.s_reset)
        Me.Panel1.Controls.Add(Me.s_nis)
        Me.Panel1.Controls.Add(Me.s_hps)
        Me.Panel1.Controls.Add(Me.s_sp)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.s_alm)
        Me.Panel1.Controls.Add(Me.s_ubh)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.s_tbh)
        Me.Panel1.Controls.Add(Me.s_nm)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.s_jk)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.s_kls)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.kej)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 434)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(82, 468)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(17, 72)
        Me.Panel3.TabIndex = 14
        '
        'thn
        '
        Me.thn.Location = New System.Drawing.Point(84, 237)
        Me.thn.Maximum = New Decimal(New Integer() {3010, 0, 0, 0})
        Me.thn.Minimum = New Decimal(New Integer() {2010, 0, 0, 0})
        Me.thn.Name = "thn"
        Me.thn.Size = New System.Drawing.Size(120, 20)
        Me.thn.TabIndex = 15
        Me.thn.Value = New Decimal(New Integer() {2010, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Tahun"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Peringkat"
        '
        'pr
        '
        Me.pr.Location = New System.Drawing.Point(84, 265)
        Me.pr.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.pr.Name = "pr"
        Me.pr.Size = New System.Drawing.Size(120, 20)
        Me.pr.TabIndex = 17
        '
        'Fr_siswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 440)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Fr_siswa"
        Me.Text = "Data Siswa "
        CType(Me.dgV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.thn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents s_nis As TextBox
    Friend WithEvents s_alm As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents s_nm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents s_jk As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents s_kls As TextBox
    Friend WithEvents kej As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents s_sp As Button
    Friend WithEvents s_hps As Button
    Friend WithEvents s_ubh As Button
    Friend WithEvents s_tbh As Button
    Friend WithEvents dgV As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents s_filter2 As TextBox
    Friend WithEvents S_filter As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents s_reset As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents pr As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents thn As NumericUpDown
End Class
