<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Subbidang
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
        Me.components = New System.ComponentModel.Container()
        Me.bd_bid = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bd_sbid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgW = New System.Windows.Forms.DataGridView()
        Me.bd_batal = New System.Windows.Forms.Button()
        Me.bd_sp = New System.Windows.Forms.Button()
        Me.bd_hps = New System.Windows.Forms.Button()
        Me.bd_ubh = New System.Windows.Forms.Button()
        Me.bd_tbh = New System.Windows.Forms.Button()
        Me.dgV = New System.Windows.Forms.DataGridView()
        Me.bd_idbid = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bd_bid
        '
        Me.bd_bid.FormattingEnabled = True
        Me.bd_bid.Location = New System.Drawing.Point(542, 75)
        Me.bd_bid.Name = "bd_bid"
        Me.bd_bid.Size = New System.Drawing.Size(191, 21)
        Me.bd_bid.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(449, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nama Bidang"
        '
        'bd_sbid
        '
        Me.bd_sbid.Location = New System.Drawing.Point(542, 117)
        Me.bd_sbid.Name = "bd_sbid"
        Me.bd_sbid.Size = New System.Drawing.Size(191, 20)
        Me.bd_sbid.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(449, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nama Sub-Bidang"
        '
        'dgW
        '
        Me.dgW.AllowUserToAddRows = False
        Me.dgW.AllowUserToDeleteRows = False
        Me.dgW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgW.Location = New System.Drawing.Point(407, 255)
        Me.dgW.Name = "dgW"
        Me.dgW.ReadOnly = True
        Me.dgW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgW.Size = New System.Drawing.Size(449, 141)
        Me.dgW.TabIndex = 16
        '
        'bd_batal
        '
        Me.bd_batal.Location = New System.Drawing.Point(658, 195)
        Me.bd_batal.Name = "bd_batal"
        Me.bd_batal.Size = New System.Drawing.Size(75, 23)
        Me.bd_batal.TabIndex = 21
        Me.bd_batal.Text = "Batal"
        Me.bd_batal.UseVisualStyleBackColor = True
        '
        'bd_sp
        '
        Me.bd_sp.Location = New System.Drawing.Point(556, 195)
        Me.bd_sp.Name = "bd_sp"
        Me.bd_sp.Size = New System.Drawing.Size(75, 23)
        Me.bd_sp.TabIndex = 20
        Me.bd_sp.Text = "Simpan"
        Me.bd_sp.UseVisualStyleBackColor = True
        '
        'bd_hps
        '
        Me.bd_hps.Location = New System.Drawing.Point(452, 195)
        Me.bd_hps.Name = "bd_hps"
        Me.bd_hps.Size = New System.Drawing.Size(75, 23)
        Me.bd_hps.TabIndex = 19
        Me.bd_hps.Text = "Hapus"
        Me.bd_hps.UseVisualStyleBackColor = True
        '
        'bd_ubh
        '
        Me.bd_ubh.Location = New System.Drawing.Point(556, 166)
        Me.bd_ubh.Name = "bd_ubh"
        Me.bd_ubh.Size = New System.Drawing.Size(75, 23)
        Me.bd_ubh.TabIndex = 18
        Me.bd_ubh.Text = "Ubah"
        Me.bd_ubh.UseVisualStyleBackColor = True
        '
        'bd_tbh
        '
        Me.bd_tbh.Location = New System.Drawing.Point(452, 166)
        Me.bd_tbh.Name = "bd_tbh"
        Me.bd_tbh.Size = New System.Drawing.Size(75, 23)
        Me.bd_tbh.TabIndex = 17
        Me.bd_tbh.Text = "Tambah"
        Me.bd_tbh.UseVisualStyleBackColor = True
        '
        'dgV
        '
        Me.dgV.AllowUserToAddRows = False
        Me.dgV.AllowUserToDeleteRows = False
        Me.dgV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgV.Location = New System.Drawing.Point(31, 32)
        Me.dgV.Name = "dgV"
        Me.dgV.ReadOnly = True
        Me.dgV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgV.Size = New System.Drawing.Size(370, 364)
        Me.dgV.TabIndex = 22
        '
        'bd_idbid
        '
        Me.bd_idbid.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bd_idbid.Location = New System.Drawing.Point(542, 47)
        Me.bd_idbid.Name = "bd_idbid"
        Me.bd_idbid.Size = New System.Drawing.Size(191, 13)
        Me.bd_idbid.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(449, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Id Bidang"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(370, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Refresh Bidang"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Tabel Data Bidang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(407, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Tabel Data Sub Bidang"
        '
        'Fr_Subbidang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 442)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bd_idbid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgV)
        Me.Controls.Add(Me.bd_batal)
        Me.Controls.Add(Me.bd_sp)
        Me.Controls.Add(Me.bd_hps)
        Me.Controls.Add(Me.bd_ubh)
        Me.Controls.Add(Me.bd_tbh)
        Me.Controls.Add(Me.dgW)
        Me.Controls.Add(Me.bd_bid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bd_sbid)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Fr_Subbidang"
        Me.Text = "Sub bidang "
        CType(Me.dgW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bd_bid As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents bd_sbid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgW As DataGridView
    Friend WithEvents bd_batal As Button
    Friend WithEvents bd_sp As Button
    Friend WithEvents bd_hps As Button
    Friend WithEvents bd_ubh As Button
    Friend WithEvents bd_tbh As Button
    Friend WithEvents dgV As DataGridView
    Friend WithEvents bd_idbid As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
