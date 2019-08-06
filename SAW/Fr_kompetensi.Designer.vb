<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fr_kompetensi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sp_jur = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bd_idbid = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgV = New System.Windows.Forms.DataGridView()
        Me.bd_tbh = New System.Windows.Forms.Button()
        Me.bd_ubh = New System.Windows.Forms.Button()
        Me.bd_hps = New System.Windows.Forms.Button()
        Me.bd_sp = New System.Windows.Forms.Button()
        Me.dgW = New System.Windows.Forms.DataGridView()
        Me.bd_batal = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bd_bid = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.dgV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jurusan"
        '
        'sp_jur
        '
        Me.sp_jur.BackColor = System.Drawing.Color.White
        Me.sp_jur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sp_jur.Location = New System.Drawing.Point(160, 28)
        Me.sp_jur.Name = "sp_jur"
        Me.sp_jur.Size = New System.Drawing.Size(240, 21)
        Me.sp_jur.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Id kompetensi"
        '
        'bd_idbid
        '
        Me.bd_idbid.BackColor = System.Drawing.Color.White
        Me.bd_idbid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bd_idbid.Location = New System.Drawing.Point(160, 64)
        Me.bd_idbid.Name = "bd_idbid"
        Me.bd_idbid.Size = New System.Drawing.Size(240, 21)
        Me.bd_idbid.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Nama kompetensi"
        '
        'dgV
        '
        Me.dgV.AllowUserToAddRows = False
        Me.dgV.AllowUserToDeleteRows = False
        Me.dgV.AllowUserToResizeRows = False
        Me.dgV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.dgV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgV.Location = New System.Drawing.Point(3, 23)
        Me.dgV.MultiSelect = False
        Me.dgV.Name = "dgV"
        Me.dgV.ReadOnly = True
        Me.dgV.RowHeadersVisible = False
        Me.dgV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgV.Size = New System.Drawing.Size(352, 506)
        Me.dgV.TabIndex = 10
        '
        'bd_tbh
        '
        Me.bd_tbh.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.bd_tbh.ForeColor = System.Drawing.Color.White
        Me.bd_tbh.Location = New System.Drawing.Point(161, 137)
        Me.bd_tbh.Name = "bd_tbh"
        Me.bd_tbh.Size = New System.Drawing.Size(75, 37)
        Me.bd_tbh.TabIndex = 11
        Me.bd_tbh.Text = "Tambah"
        Me.bd_tbh.UseVisualStyleBackColor = False
        '
        'bd_ubh
        '
        Me.bd_ubh.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.bd_ubh.ForeColor = System.Drawing.Color.White
        Me.bd_ubh.Location = New System.Drawing.Point(161, 180)
        Me.bd_ubh.Name = "bd_ubh"
        Me.bd_ubh.Size = New System.Drawing.Size(75, 37)
        Me.bd_ubh.TabIndex = 12
        Me.bd_ubh.Text = "Ubah"
        Me.bd_ubh.UseVisualStyleBackColor = False
        '
        'bd_hps
        '
        Me.bd_hps.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.bd_hps.ForeColor = System.Drawing.Color.White
        Me.bd_hps.Location = New System.Drawing.Point(325, 137)
        Me.bd_hps.Name = "bd_hps"
        Me.bd_hps.Size = New System.Drawing.Size(75, 37)
        Me.bd_hps.TabIndex = 13
        Me.bd_hps.Text = "Hapus"
        Me.bd_hps.UseVisualStyleBackColor = False
        '
        'bd_sp
        '
        Me.bd_sp.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.bd_sp.ForeColor = System.Drawing.Color.White
        Me.bd_sp.Location = New System.Drawing.Point(243, 137)
        Me.bd_sp.Name = "bd_sp"
        Me.bd_sp.Size = New System.Drawing.Size(75, 80)
        Me.bd_sp.TabIndex = 14
        Me.bd_sp.Text = "Simpan"
        Me.bd_sp.UseVisualStyleBackColor = False
        '
        'dgW
        '
        Me.dgW.AllowUserToAddRows = False
        Me.dgW.AllowUserToDeleteRows = False
        Me.dgW.AllowUserToResizeRows = False
        Me.dgW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgW.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.dgW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgW.Location = New System.Drawing.Point(3, 23)
        Me.dgW.MultiSelect = False
        Me.dgW.Name = "dgW"
        Me.dgW.ReadOnly = True
        Me.dgW.RowHeadersVisible = False
        Me.dgW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgW.Size = New System.Drawing.Size(521, 250)
        Me.dgW.TabIndex = 15
        '
        'bd_batal
        '
        Me.bd_batal.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.bd_batal.ForeColor = System.Drawing.Color.White
        Me.bd_batal.Location = New System.Drawing.Point(325, 180)
        Me.bd_batal.Name = "bd_batal"
        Me.bd_batal.Size = New System.Drawing.Size(75, 37)
        Me.bd_batal.TabIndex = 16
        Me.bd_batal.Text = "Batal"
        Me.bd_batal.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Tabel Data kompetensi dalam Jurusan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(521, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Tabel Data Sub kompetensi"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 364.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(903, 538)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(367, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(533, 532)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.bd_bid)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.sp_jur)
        Me.Panel3.Controls.Add(Me.bd_batal)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.bd_sp)
        Me.Panel3.Controls.Add(Me.bd_idbid)
        Me.Panel3.Controls.Add(Me.bd_hps)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.bd_ubh)
        Me.Panel3.Controls.Add(Me.bd_tbh)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(527, 244)
        Me.Panel3.TabIndex = 20
        '
        'bd_bid
        '
        Me.bd_bid.Location = New System.Drawing.Point(160, 103)
        Me.bd_bid.Name = "bd_bid"
        Me.bd_bid.Size = New System.Drawing.Size(240, 20)
        Me.bd_bid.TabIndex = 18
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dgW, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 253)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(527, 276)
        Me.TableLayoutPanel4.TabIndex = 21
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.dgV, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(358, 532)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Fr_kompetensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 538)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Fr_kompetensi"
        Me.Text = "Kompetensi "
        CType(Me.dgV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents sp_jur As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bd_idbid As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgV As DataGridView
    Friend WithEvents bd_tbh As Button
    Friend WithEvents bd_ubh As Button
    Friend WithEvents bd_hps As Button
    Friend WithEvents bd_sp As Button
    Friend WithEvents dgW As DataGridView
    Friend WithEvents bd_batal As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents bd_bid As TextBox
End Class
