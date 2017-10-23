<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_olahJurusan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.kj = New System.Windows.Forms.TextBox()
        Me.ub = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nj = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.km = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.np = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.j = New System.Windows.Forms.ComboBox()
        Me.tb = New System.Windows.Forms.Button()
        Me.hp = New System.Windows.Forms.Button()
        Me.sp = New System.Windows.Forms.Button()
        Me.bt = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToResizeRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(25, 169)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersVisible = False
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(798, 342)
        Me.dg.TabIndex = 12
        Me.dg.TabStop = False
        '
        'kj
        '
        Me.kj.Location = New System.Drawing.Point(115, 27)
        Me.kj.Name = "kj"
        Me.kj.Size = New System.Drawing.Size(170, 20)
        Me.kj.TabIndex = 16
        Me.kj.TabStop = False
        '
        'ub
        '
        Me.ub.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ub.ForeColor = System.Drawing.Color.White
        Me.ub.Location = New System.Drawing.Point(306, 60)
        Me.ub.Name = "ub"
        Me.ub.Size = New System.Drawing.Size(104, 43)
        Me.ub.TabIndex = 15
        Me.ub.TabStop = False
        Me.ub.Text = "Ubah"
        Me.ub.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Kode Jurusan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nama Jurusan"
        '
        'nj
        '
        Me.nj.Location = New System.Drawing.Point(115, 53)
        Me.nj.Name = "nj"
        Me.nj.Size = New System.Drawing.Size(170, 20)
        Me.nj.TabIndex = 18
        Me.nj.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Kode Masuk"
        '
        'km
        '
        Me.km.Location = New System.Drawing.Point(115, 79)
        Me.km.Name = "km"
        Me.km.Size = New System.Drawing.Size(170, 20)
        Me.km.TabIndex = 20
        Me.km.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Nama Pejabat"
        '
        'np
        '
        Me.np.Location = New System.Drawing.Point(115, 105)
        Me.np.Name = "np"
        Me.np.Size = New System.Drawing.Size(170, 20)
        Me.np.TabIndex = 22
        Me.np.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Jabatan"
        '
        'j
        '
        Me.j.FormattingEnabled = True
        Me.j.Items.AddRange(New Object() {"Ketua Jurusan", "Wali Kelas"})
        Me.j.Location = New System.Drawing.Point(115, 131)
        Me.j.Name = "j"
        Me.j.Size = New System.Drawing.Size(170, 21)
        Me.j.TabIndex = 26
        '
        'tb
        '
        Me.tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.tb.ForeColor = System.Drawing.Color.White
        Me.tb.Location = New System.Drawing.Point(416, 60)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(104, 43)
        Me.tb.TabIndex = 27
        Me.tb.TabStop = False
        Me.tb.Text = "Tambah"
        Me.tb.UseVisualStyleBackColor = False
        '
        'hp
        '
        Me.hp.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.hp.ForeColor = System.Drawing.Color.White
        Me.hp.Location = New System.Drawing.Point(526, 60)
        Me.hp.Name = "hp"
        Me.hp.Size = New System.Drawing.Size(104, 43)
        Me.hp.TabIndex = 28
        Me.hp.TabStop = False
        Me.hp.Text = "Hapus"
        Me.hp.UseVisualStyleBackColor = False
        '
        'sp
        '
        Me.sp.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.sp.ForeColor = System.Drawing.Color.White
        Me.sp.Location = New System.Drawing.Point(306, 109)
        Me.sp.Name = "sp"
        Me.sp.Size = New System.Drawing.Size(214, 43)
        Me.sp.TabIndex = 29
        Me.sp.TabStop = False
        Me.sp.Text = "Simpan"
        Me.sp.UseVisualStyleBackColor = False
        '
        'bt
        '
        Me.bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.bt.ForeColor = System.Drawing.Color.White
        Me.bt.Location = New System.Drawing.Point(526, 109)
        Me.bt.Name = "bt"
        Me.bt.Size = New System.Drawing.Size(104, 43)
        Me.bt.TabIndex = 30
        Me.bt.TabStop = False
        Me.bt.Text = "Batal"
        Me.bt.UseVisualStyleBackColor = False
        '
        'Fr_olahJurusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 523)
        Me.Controls.Add(Me.bt)
        Me.Controls.Add(Me.sp)
        Me.Controls.Add(Me.hp)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.j)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.np)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.km)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nj)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.kj)
        Me.Controls.Add(Me.ub)
        Me.Controls.Add(Me.dg)
        Me.Name = "Fr_olahJurusan"
        Me.Text = "Fr_olahJurusan"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dg As DataGridView
    Friend WithEvents kj As TextBox
    Friend WithEvents ub As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nj As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents km As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents np As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents j As ComboBox
    Friend WithEvents tb As Button
    Friend WithEvents hp As Button
    Friend WithEvents sp As Button
    Friend WithEvents bt As Button
End Class
