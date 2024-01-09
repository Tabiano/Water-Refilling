Imports System.Data.Odbc

Module ModCon
    Public Sub connect_me()
        If con.State = System.Data.ConnectionState.Open Then con.Close()
        constring = "driver=MySQL ODBC 8.0 Unicode Driver;localhost;port=3306;uid='root';pwd=;database=aquadrops"
        con.ConnectionString = constring
        con.Open()
    End Sub
End Module
