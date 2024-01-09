Imports System.Data.Odbc
Public Class salesreport
    Dim mycmd1, mycmd2, mycmd3, mycmd4 As New OdbcCommand
    Private Sub btncn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main.Enabled = True
        Me.Hide()
    End Sub

    Private Sub salesreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        connect_me()
        Me.TblsaleTableAdapter.Fill(Me.DataSet2.tblsale)
        Dim mycmd3 As New OdbcCommand("SELECT tblsale.DATECREATED, tblsale.CUSTOMER_NAME, tblsale.TYPE, tblconfirmtotal.Jar_Type, tblconfirmtotal.Price, tblconfirmtotal.QTY, tblconfirmtotal.Total_Amount, tblsale.STATUS FROM tblsale LEFT OUTER JOIN tblconfirmtotal ON tblsale.ID = tblconfirmtotal.ID", con)
        Dim dta As New OdbcDataAdapter(mycmd3)
        Dim ds As New Data.DataSet
        Dim btnedit As New DataGridViewComboBoxDisplayStyle

        dta.Fill(ds, "tblsale")
        dgvsale.DataSource = ds.Tables(0)
        dgvsale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvsale.RowsDefaultCellStyle.BackColor = Drawing.Color.SkyBlue
        dgvsale.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.WhiteSmoke
        dgvsale.Refresh()
        Refresh()
    End Sub
    Public Sub search()
        Dim dtStart As String
        Dim dtEnd As String
        dtStart = dtpstart.Text
        dtEnd = dtpend.Text
        

        If cbtype.Text = "All" Then
            connect_me()
            Me.TblsaleTableAdapter.Fill(Me.DataSet2.tblsale)
            Dim mycmd3 As New OdbcCommand("SELECT tblsale.DATECREATED, tblsale.CUSTOMER_NAME, tblsale.TYPE, tblconfirmtotal.Jar_Type, tblconfirmtotal.Price, tblconfirmtotal.QTY, tblconfirmtotal.Total_Amount FROM tblsale LEFT OUTER JOIN tblconfirmtotal ON tblsale.ID = tblconfirmtotal.ID WHERE tblsale.DATECREATED  BETWEEN  '" & dtStart & "' AND '" & dtEnd & "'", con)
            Dim dta As New OdbcDataAdapter(mycmd3)
            Dim ds As New Data.DataSet
            Dim btnedit As New DataGridViewComboBoxDisplayStyle
            dta.Fill(ds, "tblsale")
            dgvsale.DataSource = ds.Tables(0)
            dgvsale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvsale.Refresh()
            Refresh()
        Else
            connect_me()
            Me.TblsaleTableAdapter.Fill(Me.DataSet2.tblsale)
            Dim mycmd3 As New OdbcCommand("SELECT tblsale.DATECREATED, tblsale.CUSTOMER_NAME, tblsale.TYPE, tblconfirmtotal.Jar_Type, tblconfirmtotal.Price, tblconfirmtotal.QTY, tblconfirmtotal.Total_Amount FROM tblsale LEFT OUTER JOIN tblconfirmtotal ON tblsale.ID = tblconfirmtotal.ID WHERE tblsale.TYPE LIKE '" & cbtype.Text & "%' AND  tblsale.DATECREATED  BETWEEN  '" & dtStart & "' AND '" & dtEnd & "'", con)
            Dim dta As New OdbcDataAdapter(mycmd3)
            Dim ds As New Data.DataSet
            Dim btnedit As New DataGridViewComboBoxDisplayStyle
            dta.Fill(ds, "tblsale")
            dgvsale.DataSource = ds.Tables(0)
            dgvsale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvsale.Refresh()
            Refresh()
        End If

        
        'sql = "SELECT tblsale.DATECREATED, tblsale.CUSTOMER_NAME, tblsale.TYPE, tblconfirmtotal.Jar_Type, tblconfirmtotal.Price, tblconfirmtotal.QTY, tblconfirmtotal.Total_Amount, tblsale.STATUS FROM tblsale LEFT OUTER JOIN tblconfirmtotal ON tblsale.ID = tblconfirmtotal.ID WHERE tblsale.CUSTOMER_NAME like 'n%'"


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        search()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim dtStart As String
        Dim dtEnd As String
        dtStart = dtpstart.Text
        dtEnd = dtpend.Text
        connect_me()
        Dim ds As DataSet
        Dim cmd As New OdbcCommand
        Dim oda As New OdbcDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        Dim report As New CrystalReport1

        cmd.Connection = con
        'If cbtype.Text = "All" Then
        'sql = "SELECT tblsale.DATECREATED, tblsale.CUSTOMER_NAME, tblsale.TYPE, tblconfirmtotal.Jar_Type, tblconfirmtotal.Price, tblconfirmtotal.QTY, tblconfirmtotal.Total_Amount FROM tblsale LEFT OUTER JOIN tblconfirmtotal ON tblsale.ID = tblconfirmtotal.ID WHERE tblsale.DATECREATED  BETWEEN  '" & dtStart & "' AND '" & dtEnd & "'"
        ' Else
        sql = " SELECT `tblconfirmtotal`.`QTY`, `tblconfirmtotal`.`Jar_Type`, `tblconfirmtotal`.`Price`, `tblsale`.`TYPE`, `tblconfirmtotal`.`Total_Amount`, `tblsale`.`CUSTOMER_NAME`, `tblsale`.`DATECREATED` FROM `aquadrops`.`tblconfirmtotal` `tblconfirmtotal` INNER JOIN `aquadrops`.`tblsale` `tblsale` ON `tblconfirmtotal`.`ID`=`tblsale`.`ID` WHERE `tblsale`.`DATECREATED`={d '2023-11-20'} AND (`tblsale`.`TYPE`='FOR DELIVERY' OR `tblsale`.`TYPE`='WALK-IN')"
        'sql = "SELECT tblsale.ID, tblsale.DATECREATED, tblsale.`CUSTOMER_NAME`, tblsale.TYPE, tblsale.STATUS, tblsale.`TOTAL_ITEM`, tblsale.AMOUNT, tblconfirmtotal.Jar_Type, tblconfirmtotal.Price, tblconfirmtotal.QTY,  tblconfirmtotal.`Total_Amount` FROM tblsale LEFT OUTER JOIN tblconfirmtotal ON tblsale.ID = tblconfirmtotal.ID "

        'End If
        cmd.CommandText = sql
        oda.SelectCommand = cmd
        ds = New Data.DataSet
        oda.Fill(ds)
        dt = ds.Tables(0)
        'report.SetDataSource(dt)

        printsalesreport.CrystalReportViewer1.ReportSource = report
        printsalesreport.CrystalReportViewer1.ReportSource.Refresh()


        printsalesreport.Show()
    End Sub
End Class