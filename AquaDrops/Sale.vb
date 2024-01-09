Imports System.Data.Odbc

Public Class Sale
    Dim mycmd1, mycmd2, mycmd3, mycmd4 As New OdbcCommand

    Private Sub Action_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect_me()
        Me.TblsaleTableAdapter.Fill(Me.DataSet2.tblsale)
        Dim mycmd3 As New OdbcCommand("SELECT tblsale.ID, tblsale.DATECREATED, tblsale.CUSTOMER_NAME, tblsale.TYPE, tblsale.TOTAL_ITEM, tblconfirmtotal.Jar_Type, tblconfirmtotal.Price, tblconfirmtotal.QTY, tblconfirmtotal.Total_Amount, tblsale.STATUS FROM tblsale LEFT OUTER JOIN tblconfirmtotal ON tblsale.ID = tblconfirmtotal.ID", con)
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

    Sub refreshMe()
        con.Close()

        Try
            con.Open()
            Me.TblsaleTableAdapter.Fill(Me.DataSet2.tblsale)
            Dim mycmd3 As New OdbcCommand("SELECT tblsale.ID, tblsale.DATECREATED, tblsale.CUSTOMER_NAME, tblsale.TYPE, tblsale.TOTAL_ITEM, tblconfirmtotal.Jar_Type, tblconfirmtotal.Price, tblconfirmtotal.QTY, tblconfirmtotal.Total_Amount, tblsale.STATUS FROM tblsale LEFT OUTER JOIN tblconfirmtotal ON tblsale.ID = tblconfirmtotal.ID", con)
            Dim dta As New OdbcDataAdapter(mycmd3)
            Dim ds As New Data.DataSet
            Dim btnedit As New DataGridViewComboBoxDisplayStyle

            dta.Fill(ds, "tblsale")



            dgvsale.DataSource = ds.Tables(0)
            dgvsale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvsale.RowsDefaultCellStyle.BackColor = Drawing.Color.SkyBlue
            dgvsale.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Snow
            dgvsale.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dgvsale_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsale.CellClick

        Dim i As Integer
        i = dgvsale.CurrentRow.Index
        CreateNewSale.txtid.Text = dgvsale.Item(0, i).Value
        CreateNewSale.txtcn.Text = dgvsale.Item(1, i).Value
        CreateNewSale.cbtype.Text = dgvsale.Item(3, i).Value
        CreateNewSale.cbstatus.Text = dgvsale.Item(4, i).Value
        CreateNewSale.cbjartype.SelectedValue = dgvsale.Item(5, i).Value
        CreateNewSale.txtqty.Text = dgvsale.Item(6, i).Value


        Try
            If dgvsale.Columns(e.ColumnIndex).Name = "btnedit" Then
                CreateNewSale.btnupdate.Show()
                CreateNewSale.txthash.Show()
                CreateNewSale.txtid.Show()
                CreateNewSale.btnadd.Hide()
                CreateNewSale.Show()
                Me.Enabled = False

            ElseIf dgvsale.Columns(e.ColumnIndex).Name = "btndel" Then
                Dim mycmd5, mycmd6, mycmd7, mycmd8 As New OdbcCommand
                Dim i3 As String
                Dim result3 As New DialogResult

                i3 = CreateNewSale.txtid.Text

                con.Close()

                con.Open()
                result3 = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result3 = Windows.Forms.DialogResult.Yes Then
                    With mycmd5
                        .Connection = con
                        .CommandText = "delete from tblconfirmtotal where ID = '" & i3 & "'"
                        .ExecuteNonQuery()
                    End With
                    With mycmd6
                        .Connection = con
                        .CommandText = "set @autoquestionnum :=0;"
                        .ExecuteNonQuery()
                    End With

                    With mycmd7
                        .Connection = con
                        .CommandText = "update tblconfirmtotal set ID = @autoquestionnum :=(@autoquestionnum+1);"
                        .ExecuteNonQuery()
                    End With

                    With mycmd8
                        .Connection = con
                        .CommandText = "alter TABLE tblconfirmtotal AUTO_INCREMENT = 1"
                        .ExecuteNonQuery()
                    End With
                    With mycmd1
                        .Connection = con
                        .CommandText = "delete from tblsale where ID = '" & i3 & "'"
                        .ExecuteNonQuery()

                        With mycmd2
                            .Connection = con
                            .CommandText = "set @autoquestionnum :=0;"
                            .ExecuteNonQuery()
                        End With

                        With mycmd3
                            .Connection = con
                            .CommandText = "update tblsale set ID = @autoquestionnum :=(@autoquestionnum+1);"
                            .ExecuteNonQuery()
                        End With

                        With mycmd4
                            .Connection = con
                            .CommandText = "alter TABLE tblsale AUTO_INCREMENT = 1"
                            .ExecuteNonQuery()
                        End With

                    End With
                    MessageBox.Show("Delete record Success !", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                refreshMe()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvsale_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvsale.CellFormatting
        For Each row As DataGridViewRow In dgvsale.Rows
            If row.Cells("STATUSDataGridViewTextBoxColumn").Value = "PAID" Then
                row.Cells("STATUSDataGridViewTextBoxColumn").Style.BackColor = Color.SpringGreen
            End If

            If row.Cells("STATUSDataGridViewTextBoxColumn").Value = "UNPAID" Then
                row.Cells("STATUSDataGridViewTextBoxColumn").Style.BackColor = Color.Tomato
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main.Enabled = True
        Me.Hide()
    End Sub

    Private Sub btncn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncn.Click
        CreateNewSale.txthash.Hide()
        CreateNewSale.txtid.Hide()
        CreateNewSale.Show()
        CreateNewSale.btnadd.Show()
        CreateNewSale.btnupdate.Hide()
        Me.Enabled = False
    End Sub

    
    
End Class