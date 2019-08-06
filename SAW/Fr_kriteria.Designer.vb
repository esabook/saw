<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fr_kriteria
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
        Me.k_id = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.k_sb = New System.Windows.Forms.ComboBox()
        Me.k_bid = New System.Windows.Forms.ComboBox()
        Me.k_nm = New System.Windows.Forms.TextBox()
        Me.kompetensi = New System.Windows.Forms.Label()
        Me.k_btl = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgSk = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.filter2 = New System.Windows.Forms.TextBox()
        Me.filter1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ket = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgSk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'k_tbh
        '
        Me.k_tbh.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.k_tbh.ForeColor = System.Drawing.Color.White
        Me.k_tbh.Location = New System.Drawing.Point(121, 122)
        Me.k_tbh.Name = "k_tbh"
        Me.k_tbh.Size = New System.Drawing.Size(87, 47)
        Me.k_tbh.TabIndex = 0
        Me.k_tbh.Text = "Tambah"
        Me.k_tbh.UseVisualStyleBackColor = False
        '
        'k_ubh
        '
        Me.k_ubh.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.k_ubh.ForeColor = System.Drawing.Color.White
        Me.k_ubh.Location = New System.Drawing.Point(121, 175)
        Me.k_ubh.Name = "k_ubh"
        Me.k_ubh.Size = New System.Drawing.Size(87, 46)
        Me.k_ubh.TabIndex = 1
        Me.k_ubh.Text = "Ubah"
        Me.k_ubh.UseVisualStyleBackColor = False
        '
        'k_hps
        '
        Me.k_hps.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.k_hps.ForeColor = System.Drawing.Color.White
        Me.k_hps.Location = New System.Drawing.Point(314, 123)
        Me.k_hps.Name = "k_hps"
        Me.k_hps.Size = New System.Drawing.Size(75, 46)
        Me.k_hps.TabIndex = 2
        Me.k_hps.Text = "Hapus"
        Me.k_hps.UseVisualStyleBackColor = False
        '
        'k_sp
        '
        Me.k_sp.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.k_sp.ForeColor = System.Drawing.Color.White
        Me.k_sp.Location = New System.Drawing.Point(211, 121)
        Me.k_sp.Name = "k_sp"
        Me.k_sp.Size = New System.Drawing.Size(97, 99)
        Me.k_sp.TabIndex = 3
        Me.k_sp.Text = "Simpan"
        Me.k_sp.UseVisualStyleBackColor = False
        '
        'dgK
        '
        Me.dgK.AllowUserToAddRows = False
        Me.dgK.AllowUserToDeleteRows = False
        Me.dgK.AllowUserToResizeRows = False
        Me.dgK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgK.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.dgK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgK.Location = New System.Drawing.Point(0, 0)
        Me.dgK.MultiSelect = False
        Me.dgK.Name = "dgK"
        Me.dgK.ReadOnly = True
        Me.dgK.RowHeadersVisible = False
        Me.dgK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgK.Size = New System.Drawing.Size(317, 306)
        Me.dgK.TabIndex = 4
        '
        'k_id
        '
        Me.k_id.BackColor = System.Drawing.Color.White
        Me.k_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.k_id.Location = New System.Drawing.Point(121, 16)
        Me.k_id.Name = "k_id"
        Me.k_id.Size = New System.Drawing.Size(141, 21)
        Me.k_id.TabIndex = 5
        Me.k_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.k_sb)
        Me.GroupBox1.Controls.Add(Me.k_bid)
        Me.GroupBox1.Controls.Add(Me.k_nm)
        Me.GroupBox1.Controls.Add(Me.kompetensi)
        Me.GroupBox1.Controls.Add(Me.k_sp)
        Me.GroupBox1.Controls.Add(Me.k_btl)
        Me.GroupBox1.Controls.Add(Me.k_tbh)
        Me.GroupBox1.Controls.Add(Me.k_ubh)
        Me.GroupBox1.Controls.Add(Me.k_hps)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.k_id)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 246)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Sub kompetensi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Id Kriteria"
        '
        'k_sb
        '
        Me.k_sb.FormattingEnabled = True
        Me.k_sb.Location = New System.Drawing.Point(121, 68)
        Me.k_sb.Name = "k_sb"
        Me.k_sb.Size = New System.Drawing.Size(268, 21)
        Me.k_sb.TabIndex = 16
        '
        'k_bid
        '
        Me.k_bid.FormattingEnabled = True
        Me.k_bid.Location = New System.Drawing.Point(121, 42)
        Me.k_bid.Name = "k_bid"
        Me.k_bid.Size = New System.Drawing.Size(268, 21)
        Me.k_bid.TabIndex = 9
        '
        'k_nm
        '
        Me.k_nm.Location = New System.Drawing.Point(121, 94)
        Me.k_nm.Name = "k_nm"
        Me.k_nm.Size = New System.Drawing.Size(268, 20)
        Me.k_nm.TabIndex = 8
        '
        'kompetensi
        '
        Me.kompetensi.AutoSize = True
        Me.kompetensi.Location = New System.Drawing.Point(35, 46)
        Me.kompetensi.Name = "kompetensi"
        Me.kompetensi.Size = New System.Drawing.Size(62, 13)
        Me.kompetensi.TabIndex = 6
        Me.kompetensi.Text = "Kompetensi"
        '
        'k_btl
        '
        Me.k_btl.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.k_btl.ForeColor = System.Drawing.Color.White
        Me.k_btl.Location = New System.Drawing.Point(314, 175)
        Me.k_btl.Name = "k_btl"
        Me.k_btl.Size = New System.Drawing.Size(75, 46)
        Me.k_btl.TabIndex = 4
        Me.k_btl.Text = "Batal"
        Me.k_btl.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nama Kriteria"
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
        Me.dgSk.Enabled = False
        Me.dgSk.Location = New System.Drawing.Point(3, 23)
        Me.dgSk.MultiSelect = False
        Me.dgSk.Name = "dgSk"
        Me.dgSk.ReadOnly = True
        Me.dgSk.RowHeadersVisible = False
        Me.dgSk.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.dgSk.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgSk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSk.Size = New System.Drawing.Size(473, 177)
        Me.dgSk.TabIndex = 7
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(3, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(317, 21)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Tabel Data Kriteria"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(473, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Tabel Data Sub Kriteria yang terhubung (Read Only)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(820, 476)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Silver
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.SplitContainer1, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(323, 470)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.filter2)
        Me.Panel2.Controls.Add(Me.filter1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(317, 60)
        Me.Panel2.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Filter text"
        '
        'filter2
        '
        Me.filter2.Location = New System.Drawing.Point(90, 30)
        Me.filter2.Name = "filter2"
        Me.filter2.Size = New System.Drawing.Size(224, 20)
        Me.filter2.TabIndex = 17
        '
        'filter1
        '
        Me.filter1.FormattingEnabled = True
        Me.filter1.Location = New System.Drawing.Point(90, 3)
        Me.filter1.Name = "filter1"
        Me.filter1.Size = New System.Drawing.Size(224, 21)
        Me.filter1.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Filter kolom"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 90)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgK)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ket)
        Me.SplitContainer1.Size = New System.Drawing.Size(317, 377)
        Me.SplitContainer1.SplitterDistance = 306
        Me.SplitContainer1.TabIndex = 18
        '
        'ket
        '
        Me.ket.BackColor = System.Drawing.Color.Gold
        Me.ket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ket.FormattingEnabled = True
        Me.ket.Location = New System.Drawing.Point(0, 0)
        Me.ket.Name = "ket"
        Me.ket.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ket.Size = New System.Drawing.Size(317, 67)
        Me.ket.TabIndex = 17
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(332, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.74468!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.25532!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(485, 470)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.dgSk, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 264)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(479, 203)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 255)
        Me.Panel1.TabIndex = 1
        '
        'Fr_kriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 476)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Fr_kriteria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kriteria "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgSk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents k_tbh As Button
    Friend WithEvents k_ubh As Button
    Friend WithEvents k_hps As Button
    Friend WithEvents k_sp As Button
    Friend WithEvents dgK As DataGridView
    Friend WithEvents k_id As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents k_bid As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents kompetensi As Label
    Friend WithEvents dgSk As DataGridView
    Friend WithEvents k_btl As Button
    Friend WithEvents k_sb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents k_nm As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents filter2 As TextBox
    Friend WithEvents filter1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ket As ListBox
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
