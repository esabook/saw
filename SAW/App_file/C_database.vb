Imports System.Data.OleDb

Public Class C_database



    Dim koneksiDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb")
    Dim dataAdapter As OleDb.OleDbDataAdapter
    Dim DBCommand As OleDbCommand
    Dim DBCBuilder As OleDbCommandBuilder
    Dim dataset As New DataSet
    Dim bindingSource As BindingSource

    Dim jumlahNol As Integer = 4

    Public awalan_PKkompetensi = "KM"
    Public awalan_PKSubBid = "SP"
    Dim awalan_PKHsilT = "HT"
    Dim awalan_PKHsilP = "HP"
    Dim awalan_PKKrit = "KR"
    Dim awalan_PKSKrit = "SK"
    Dim awalan_PKBobot = "BW"

    Dim seleksiT = "select * from "


    Public tabel_kompetensi = "kompetensi"
    Public tabel_SubBid = "sub_kompetensi"
    Public tabel_Bobot = "bobot"
    Public tabel_HasilP = "hasil_pemilihan"
    Public tabel_Siswa = "siswa"
    Public tabel_HasilT = "hasil_tes"
    Public tabel_Krit = "kriteria"
    Public tabel_SKrit = "sub_kriteria"



    Public Function IDBerdasarNama_kompetensi(ByRef nama As String) As String
        Return QueryStr("select id_kompetensi from kompetensi where nama like '" + nama + "' ")
    End Function
    Public Function IDBerdasarNama_Skompetensi(ByRef nama As String) As String
        Return QueryStr("select id_sub_kompetensi from sub_kompetensi where nama like '" + nama + "' ")
    End Function
    Public Function IDBerdasarNama_Kriteria(ByRef nama As String) As String
        Return QueryStr("select id_kriteria from kriteria where nama like '" + nama + "' ")
    End Function
    Public Function IDBerdasarNama_SKriteria(ByRef nama As String) As String
        Return QueryStr("select id_sub_kriteria from sub_kriteria where nama like '" + nama + "' ")
    End Function
    Public Function IDBaruBerdasarTabel(ByRef tabel As String) As String
        Dim cek As Boolean = True
        Dim i As Integer = QueryTable(seleksiT & tabel).Rows.Count + 1
        Dim r As String = Nothing

        While cek
            r = i.ToString
            For index = i.ToString.Length To jumlahNol - 1
                r = "0" & r
            Next
            Select Case tabel
                Case tabel_Bobot : r = awalan_PKBobot & r
                Case tabel_HasilP : r = awalan_PKHsilP & r
                Case tabel_kompetensi : r = awalan_PKkompetensi & r
                Case tabel_SubBid : r = awalan_PKSubBid & r
                Case tabel_HasilT : r = awalan_PKHsilT & r
                Case tabel_Krit : r = awalan_PKKrit & r
                Case tabel_SKrit : r = awalan_PKSKrit & r
                Case Else

            End Select
            If QueryTable(seleksiT + tabel + " where id_" + tabel.ToLower + "='" + r + "'").Rows.Count > 0 Then
                i += 1
            Else
                cek = False
            End If
        End While

        Return r
    End Function


    Public Function QueryIUD(ByVal QueryString As String) As Boolean
        'Debug.Print("iud " + QueryString)
        Dim r As Integer
        Try

            open()
            DBCommand = New OleDbCommand(QueryString, koneksiDB)
            r = DBCommand.ExecuteNonQuery()
            close()
        Catch
        End Try
        Return r > 0
    End Function
    Public Function QueryTable(ByRef QueryString As String) As DataTable
        Debug.Print("tabel " + QueryString)
        dataAdapter = New OleDbDataAdapter(QueryString, koneksiDB)
        DBCBuilder = New OleDbCommandBuilder(dataAdapter)

        Dim dt As New DataTable
        dataAdapter.Fill(dt)
        Return dt
    End Function
    Public Function QueryDS(ByRef QueryString As String) As BindingSource
        Debug.Print("DS " + QueryString)
        Dim record As New BindingSource
        Try
            open()
            dataAdapter = New OleDbDataAdapter(QueryString, koneksiDB)
            dataset = New DataSet
            dataAdapter.Fill(dataset)

            record.DataSource = dataset
            record.DataMember = dataset.Tables(0).ToString
            close()
        Catch
        End Try

        Return record

    End Function
    Public Function QueryStr(ByRef QueryString As String) As String
        Debug.Print("Str " + QueryString)

        Dim s As String = ""
        DBCommand = New OleDbCommand(QueryString, koneksiDB)
        open()
        Dim dr As OleDbDataReader = DBCommand.ExecuteReader(CommandBehavior.CloseConnection)
        If dr.HasRows Then
            dr.Read()
            s = dr(0)
        End If
        Return s
    End Function
    Private Function open() As OleDbConnection
        Try
            koneksiDB.Open()
        Catch
        End Try

        Return koneksiDB
    End Function
    Private Function close() As OleDbConnection
        Try
            koneksiDB.Close()
        Catch
        End Try
        Return koneksiDB
    End Function


End Class
