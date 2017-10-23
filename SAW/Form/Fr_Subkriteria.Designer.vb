<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fr_subkriteria
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
        Me.components = New System.ComponentModel.Container()
        Me.k_tbh = New System.Windows.Forms.Button()
        Me.k_ubh = New System.Windows.Forms.Button()
        Me.k_hps = New System.Windows.Forms.Button()
        Me.k_sp = New System.Windows.Forms.Button()
        Me.dgK = New System.Windows.Forms.DataGridView()
        Me.dgSk = New System.Windows.Forms.DataGridView()
        Me.k_btl = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rak = New System.Windows.Forms.NumericUpDown()
        Me.raw = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.k_nm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sk_nm = New System.Windows.Forms.TextBox()
        Me.sk_nil = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sk_id = New System.Windows.Forms.Label()
        Me.kompetensi = New System.Windows.Forms.Label()
        Me.sk_bid = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sk_sb = New System.Windows.Forms.ComboBox()
        Me.sk_reset = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.dgK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.rak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sk_nil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'k_tbh
        '
        Me.k_tbh.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.k_tbh.ForeColor = System.Drawing.Color.White
        Me.k_tbh.Location = New System.Drawing.Point(392, 35)
        Me.k_tbh.Name = "k_tbh"
        Me.k_tbh.Size = New System.Drawing.Size(175, 38)
        Me.k_tbh.TabIndex = 0
        Me.k_tbh.Text = "Tambah"
        Me.k_tbh.UseVisualStyleBackColor = False
        '
        'k_ubh
        '
        Me.k_ubh.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.k_ubh.ForeColor = System.Drawing.Color.White
        Me.k_ubh.Location = New System.Drawing.Point(392, 77)
        Me.k_ubh.Name = "k_ubh"
        Me.k_ubh.Size = New System.Drawing.Size(86, 37)
        Me.k_ubh.TabIndex = 1
        Me.k_ubh.Text = "Ubah"
        Me.k_ubh.UseVisualStyleBackColor = False
        '
        'k_hps
        '
        Me.k_hps.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.k_hps.ForeColor = System.Drawing.Color.White
        Me.k_hps.Location = New System.Drawing.Point(481, 77)
        Me.k_hps.Name = "k_hps"
        Me.k_hps.Size = New System.Drawing.Size(86, 36)
        Me.k_hps.TabIndex = 2
        Me.k_hps.Text = "Hapus"
        Me.k_hps.UseVisualStyleBackColor = False
        '
        'k_sp
        '
        Me.k_sp.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.k_sp.ForeColor = System.Drawing.Color.White
        Me.k_sp.Location = New System.Drawing.Point(392, 118)
        Me.k_sp.Name = "k_sp"
        Me.k_sp.Size = New System.Drawing.Size(86, 34)
        Me.k_sp.TabIndex = 3
        Me.k_sp.Text = "Simpan"
        Me.k_sp.UseVisualStyleBackColor = False
        '
        'dgK
        '
        Me.dgK.AllowUserToAddRows = False
        Me.dgK.AllowUserToDeleteRows = False
        Me.dgK.AllowUserToResizeRows = False
        Me.dgK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgK.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.dgK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgK.Location = New System.Drawing.Point(3, 23)
        Me.dgK.MultiSelect = False
        Me.dgK.Name = "dgK"
        Me.dgK.ReadOnly = True
        Me.dgK.RowHeadersVisible = False
        Me.dgK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgK.Size = New System.Drawing.Size(291, 413)
        Me.dgK.TabIndex = 4
        '
        'dgSk
        '
        Me.dgSk.AllowUserToAddRows = False
        Me.dgSk.AllowUserToDeleteRows = False
        Me.dgSk.AllowUserToResizeRows = False
        Me.dgSk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSk.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.dgSk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSk.Location = New System.Drawing.Point(3, 23)
        Me.dgSk.MultiSelect = False
        Me.dgSk.Name = "dgSk"
        Me.dgSk.ReadOnly = True
        Me.dgSk.RowHeadersVisible = False
        Me.dgSk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSk.Size = New System.Drawing.Size(594, 315)
        Me.dgSk.TabIndex = 7
        '
        'k_btl
        '
        Me.k_btl.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.k_btl.ForeColor = System.Drawing.Color.White
        Me.k_btl.Location = New System.Drawing.Point(481, 119)
        Me.k_btl.Name = "k_btl"
        Me.k_btl.Size = New System.Drawing.Size(86, 34)
        Me.k_btl.TabIndex = 4
        Me.k_btl.Text = "Batal"
        Me.k_btl.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.rak)
        Me.GroupBox1.Controls.Add(Me.raw)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.k_nm)
        Me.GroupBox1.Controls.Add(Me.k_btl)
        Me.GroupBox1.Controls.Add(Me.k_sp)
        Me.GroupBox1.Controls.Add(Me.k_hps)
        Me.GroupBox1.Controls.Add(Me.k_ubh)
        Me.GroupBox1.Controls.Add(Me.k_tbh)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.sk_nm)
        Me.GroupBox1.Controls.Add(Me.sk_nil)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.sk_id)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 192)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(288, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "-"
        '
        'rak
        '
        Me.rak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rak.Location = New System.Drawing.Point(304, 119)
        Me.rak.Name = "rak"
        Me.rak.Size = New System.Drawing.Size(69, 20)
        Me.rak.TabIndex = 18
        Me.rak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'raw
        '
        Me.raw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.raw.Location = New System.Drawing.Point(196, 119)
        Me.raw.Name = "raw"
        Me.raw.Size = New System.Drawing.Size(79, 20)
        Me.raw.TabIndex = 17
        Me.raw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Nilai rentang awal-akhir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ID Sub kriteria"
        '
        'k_nm
        '
        Me.k_nm.Enabled = False
        Me.k_nm.Location = New System.Drawing.Point(196, 66)
        Me.k_nm.Name = "k_nm"
        Me.k_nm.Size = New System.Drawing.Size(177, 20)
        Me.k_nm.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nama Sub Kriteria"
        '
        'sk_nm
        '
        Me.sk_nm.Location = New System.Drawing.Point(196, 93)
        Me.sk_nm.Name = "sk_nm"
        Me.sk_nm.Size = New System.Drawing.Size(177, 20)
        Me.sk_nm.TabIndex = 12
        '
        'sk_nil
        '
        Me.sk_nil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sk_nil.Location = New System.Drawing.Point(196, 145)
        Me.sk_nil.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.sk_nil.Name = "sk_nil"
        Me.sk_nil.Size = New System.Drawing.Size(79, 20)
        Me.sk_nil.TabIndex = 11
        Me.sk_nil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Bobot Sub kriteria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ID Kriteria"
        '
        'sk_id
        '
        Me.sk_id.BackColor = System.Drawing.Color.White
        Me.sk_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sk_id.Location = New System.Drawing.Point(196, 37)
        Me.sk_id.Name = "sk_id"
        Me.sk_id.Size = New System.Drawing.Size(177, 21)
        Me.sk_id.TabIndex = 5
        Me.sk_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'kompetensi
        '
        Me.kompetensi.AutoSize = True
        Me.kompetensi.Location = New System.Drawing.Point(3, 15)
        Me.kompetensi.Name = "kompetensi"
        Me.kompetensi.Size = New System.Drawing.Size(86, 13)
        Me.kompetensi.TabIndex = 6
        Me.kompetensi.Text = "Filter kompetensi"
        '
        'sk_bid
        '
        Me.sk_bid.FormattingEnabled = True
        Me.sk_bid.Location = New System.Drawing.Point(7, 31)
        Me.sk_bid.Name = "sk_bid"
        Me.sk_bid.Size = New System.Drawing.Size(122, 21)
        Me.sk_bid.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Filter Sub kompetensi"
        '
        'sk_sb
        '
        Me.sk_sb.FormattingEnabled = True
        Me.sk_sb.Location = New System.Drawing.Point(144, 31)
        Me.sk_sb.Name = "sk_sb"
        Me.sk_sb.Size = New System.Drawing.Size(141, 21)
        Me.sk_sb.TabIndex = 16
        '
        'sk_reset
        '
        Me.sk_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.sk_reset.ForeColor = System.Drawing.Color.White
        Me.sk_reset.Location = New System.Drawing.Point(7, 58)
        Me.sk_reset.Name = "sk_reset"
        Me.sk_reset.Size = New System.Drawing.Size(278, 36)
        Me.sk_reset.TabIndex = 15
        Me.sk_reset.Text = "Reset"
        Me.sk_reset.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(291, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Tabel Data Kriteria"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(594, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Tabel Data Sub Kriteria"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(921, 551)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(303, 545)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.dgK, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 103)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(297, 439)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel1.Controls.Add(Me.kompetensi)
        Me.Panel1.Controls.Add(Me.sk_reset)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.sk_sb)
        Me.Panel1.Controls.Add(Me.sk_bid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 94)
        Me.Panel1.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(312, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 198.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(606, 545)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.dgSk, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 201)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(600, 341)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Fr_subkriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 551)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Fr_subkriteria"
        Me.Text = "Sub Kriteria "
        CType(Me.dgK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.rak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sk_nil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents k_tbh As Button
    Friend WithEvents k_ubh As Button
    Friend WithEvents k_hps As Button
    Friend WithEvents k_sp As Button
    Friend WithEvents dgK As DataGridView
    Friend WithEvents dgSk As DataGridView
    Friend WithEvents k_btl As Button
    Friend WithEvents sk_id As Label
    Friend WithEvents kompetensi As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents sk_bid As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sk_nil As NumericUpDown
    Friend WithEvents sk_nm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents sk_sb As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents sk_reset As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents k_nm As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents rak As NumericUpDown
    Friend WithEvents raw As NumericUpDown
    Friend WithEvents Label6 As Label
End Class
