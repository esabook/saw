<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fr_bidang
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
        Me.bd_bid = New System.Windows.Forms.ComboBox()
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
        CType(Me.dgV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(448, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jurusan"
        '
        'sp_jur
        '
        Me.sp_jur.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.sp_jur.Location = New System.Drawing.Point(541, 65)
        Me.sp_jur.Name = "sp_jur"
        Me.sp_jur.Size = New System.Drawing.Size(212, 13)
        Me.sp_jur.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(448, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Id Bidang"
        '
        'bd_idbid
        '
        Me.bd_idbid.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bd_idbid.Location = New System.Drawing.Point(541, 101)
        Me.bd_idbid.Name = "bd_idbid"
        Me.bd_idbid.Size = New System.Drawing.Size(212, 13)
        Me.bd_idbid.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(448, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Nama Bidang"
        '
        'bd_bid
        '
        Me.bd_bid.FormattingEnabled = True
        Me.bd_bid.Location = New System.Drawing.Point(541, 134)
        Me.bd_bid.Name = "bd_bid"
        Me.bd_bid.Size = New System.Drawing.Size(212, 21)
        Me.bd_bid.TabIndex = 9
        '
        'dgV
        '
        Me.dgV.AllowUserToAddRows = False
        Me.dgV.AllowUserToDeleteRows = False
        Me.dgV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgV.Location = New System.Drawing.Point(12, 50)
        Me.dgV.Name = "dgV"
        Me.dgV.ReadOnly = True
        Me.dgV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgV.Size = New System.Drawing.Size(416, 364)
        Me.dgV.TabIndex = 10
        '
        'bd_tbh
        '
        Me.bd_tbh.Location = New System.Drawing.Point(455, 192)
        Me.bd_tbh.Name = "bd_tbh"
        Me.bd_tbh.Size = New System.Drawing.Size(75, 23)
        Me.bd_tbh.TabIndex = 11
        Me.bd_tbh.Text = "Tambah"
        Me.bd_tbh.UseVisualStyleBackColor = True
        '
        'bd_ubh
        '
        Me.bd_ubh.Location = New System.Drawing.Point(562, 192)
        Me.bd_ubh.Name = "bd_ubh"
        Me.bd_ubh.Size = New System.Drawing.Size(75, 23)
        Me.bd_ubh.TabIndex = 12
        Me.bd_ubh.Text = "Ubah"
        Me.bd_ubh.UseVisualStyleBackColor = True
        '
        'bd_hps
        '
        Me.bd_hps.Location = New System.Drawing.Point(455, 221)
        Me.bd_hps.Name = "bd_hps"
        Me.bd_hps.Size = New System.Drawing.Size(75, 23)
        Me.bd_hps.TabIndex = 13
        Me.bd_hps.Text = "Hapus"
        Me.bd_hps.UseVisualStyleBackColor = True
        '
        'bd_sp
        '
        Me.bd_sp.Location = New System.Drawing.Point(562, 221)
        Me.bd_sp.Name = "bd_sp"
        Me.bd_sp.Size = New System.Drawing.Size(75, 23)
        Me.bd_sp.TabIndex = 14
        Me.bd_sp.Text = "Simpan"
        Me.bd_sp.UseVisualStyleBackColor = True
        '
        'dgW
        '
        Me.dgW.AllowUserToAddRows = False
        Me.dgW.AllowUserToDeleteRows = False
        Me.dgW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgW.Location = New System.Drawing.Point(451, 298)
        Me.dgW.Name = "dgW"
        Me.dgW.ReadOnly = True
        Me.dgW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgW.Size = New System.Drawing.Size(302, 116)
        Me.dgW.TabIndex = 15
        '
        'bd_batal
        '
        Me.bd_batal.Location = New System.Drawing.Point(678, 221)
        Me.bd_batal.Name = "bd_batal"
        Me.bd_batal.Size = New System.Drawing.Size(75, 23)
        Me.bd_batal.TabIndex = 16
        Me.bd_batal.Text = "Batal"
        Me.bd_batal.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Tabel Data Bidang dalam Juurusan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(448, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Tabel Data Sub Bidang"
        '
        'Fr_bidang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 525)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bd_batal)
        Me.Controls.Add(Me.dgW)
        Me.Controls.Add(Me.bd_sp)
        Me.Controls.Add(Me.bd_hps)
        Me.Controls.Add(Me.bd_ubh)
        Me.Controls.Add(Me.bd_tbh)
        Me.Controls.Add(Me.dgV)
        Me.Controls.Add(Me.bd_bid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bd_idbid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sp_jur)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Fr_bidang"
        Me.Text = "Bidang "
        CType(Me.dgV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents sp_jur As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bd_idbid As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents bd_bid As ComboBox
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
End Class
