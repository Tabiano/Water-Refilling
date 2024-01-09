Imports System.Data.Odbc

Public Class ctotal

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        CreateNewSale.Enabled = True
        CreateNewSale.btnadd.BackColor = Color.SpringGreen
        CreateNewSale.btncancel.BackColor = Color.Tomato
        Me.Hide()
    End Sub

    Public Sub get_number()
        connect_me()
        Dim number As Integer
        Dim cmdnumber As New OdbcCommand("select ifnull(Max(ID), 0) from tblsale", con)
        number = cmdnumber.ExecuteScalar

        If number > 0 Then
            Call get_id()
        Else
            lbl13.Text = 1
        End If
    End Sub

    Public Sub get_id()
        Dim danumber As New OdbcDataAdapter("select max(ID) ID from tblsale", con)
        Dim dsnumber As New System.Data.DataSet
        danumber.Fill(dsnumber)
        lbl13.Text = dsnumber.Tables(0).Rows(0).Item("ID") + 1
    End Sub

    Sub refreshMe()
        con.Close()

        Try
            con.Open()
            Dim mycmd3 As New OdbcCommand("SELECT tblsale.ID, tblsale.DATECREATED, tblsale.CUSTOMER_NAME, tblsale.TYPE, tblsale.TOTAL_ITEM, tblconfirmtotal.Jar_Type, tblconfirmtotal.Price, tblconfirmtotal.QTY, tblconfirmtotal.Total_Amount, tblsale.STATUS FROM tblsale LEFT OUTER JOIN tblconfirmtotal ON tblsale.ID = tblconfirmtotal.ID", con)
            Dim da As New OdbcDataAdapter(mycmd3)
            Dim ds As New Data.DataSet
            da.Fill(ds, "tblsale")

            Sale.dgvsale.DataSource = ds.Tables(0)
            Sale.dgvsale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Sale.dgvsale.RowsDefaultCellStyle.BackColor = Drawing.Color.SkyBlue
            Sale.dgvsale.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.WhiteSmoke
            Sale.dgvsale.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click

        Dim id As String
        Dim dtc As String
        Dim cname As String
        Dim type As String
        Dim status As String
        Dim ti As String
        Dim amount As String
        Dim price As String
        Dim jarType As String

        id = lbl13.Text
        dtc = CreateNewSale.lbldt.Text.ToUpper.Trim
        cname = CreateNewSale.txtcn.Text.ToUpper.Trim
        type = CreateNewSale.cbtype.Text.ToUpper.Trim
        status = CreateNewSale.cbstatus.Text.ToUpper.Trim
        price = lblprice.Text.ToUpper.Trim
        ti = lblqty.Text.ToUpper.Trim
        amount = lbltotal.Text.ToUpper.Trim
        jarType = CreateNewSale.cbjartype.Text.ToUpper.Trim


        con.Close()
        Try
            con.Open()
            Dim mycmd, mycmd1 As New OdbcCommand

            With mycmd
                .Connection = con
                .CommandText = "Insert tblsale values ('" & id & "', '" & dtc & "', '" & cname & "', '" & type & "', '" & status & "', '" & ti & "', '" & amount & "')"
                .ExecuteNonQuery()
                With mycmd1
                    .Connection = con
                    .CommandText = "Insert tblconfirmtotal values ('" & id & "', '" & ti & "', '" & jarType & "', '" & price & "', '" & amount & "')"
                    .ExecuteNonQuery()
                End With



            End With
            MessageBox.Show("Add succes!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call get_id()
            CreateNewSale.Enabled = True
            CreateNewSale.Close()
            Sale.Enabled = True
            refreshMe()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
        refreshMe()
    End Sub

    Private Sub newaddingdata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        get_number()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim id As String
        Dim dtc As String
        Dim cname As String
        Dim type As String
        Dim status As String
        Dim ti As String
        Dim amount As String
        Dim price As String
        Dim jarType As String

        id = CreateNewSale.txtid.Text.ToUpper.Trim
        dtc = CreateNewSale.lbldt.Text.ToUpper.Trim
        cname = CreateNewSale.txtcn.Text.ToUpper.Trim
        type = CreateNewSale.cbtype.Text.ToUpper.Trim
        status = CreateNewSale.cbstatus.Text.ToUpper.Trim
        price = lblprice.Text.ToUpper.Trim
        ti = lblqty.Text.ToUpper.Trim
        amount = lbltotal.Text.ToUpper.Trim
        jarType = CreateNewSale.cbjartype.Text.ToUpper.Trim


        con.Close()
        Try
            con.Open()
            Dim mycmd, mycmd1 As New OdbcCommand

            With mycmd
                .Connection = con
                .CommandText = "Update tblsale set DATECREATED = '" & dtc & "', CUSTOMER_NAME = '" & cname & "', TYPE = '" & type & "', STATUS = '" & status & "' where ID = '" & id & "'"
                .ExecuteNonQuery()
                With mycmd1
                    .Connection = con
                    .CommandText = "Update tblconfirmtotal set  QTY = '" & ti & "', Jar_Type = '" & jarType & "', Price = '" & price & "',Total_Amount	= '" & amount & "' where ID = '" & id & "'"
                    .ExecuteNonQuery()
                End With



            End With
            MessageBox.Show("Update succes!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call get_id()
            CreateNewSale.Enabled = True
            CreateNewSale.Close()
            Sale.Enabled = True
            refreshMe()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
        refreshMe()
    End Sub
End Class
