Imports System.Data.Odbc

Public Class JandTP

    Private Sub JandTP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tbljartype' table. You can move, or remove it, as needed.
        Me.TbljartypeTableAdapter.Fill(Me.DataSet1.tbljartype)
        connect_me()

        Dim mycmd3 As New OdbcCommand("select * from `tbljartype`", con)
        Dim da As New OdbcDataAdapter(mycmd3)
        Dim ds As New Data.DataSet

        da.Fill(ds, "tbljartype")
        dgvListJTP.DataSource = ds.Tables(0)
        dgvListJTP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListJTP.RowsDefaultCellStyle.BackColor = Drawing.Color.SkyBlue
        dgvListJTP.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.WhiteSmoke
        dgvListJTP.Refresh()

        Refresh()
    End Sub

    Public Sub get_number()
        connect_me()
        Dim number As Integer
        Dim cmdnumber As New OdbcCommand("select ifnull(Max(ID), 0) from tbljartype", con)
        number = cmdnumber.ExecuteScalar

        If number > 0 Then
            Call get_id()
        End If
    End Sub

    Public Sub get_id()
        Dim danumber As New OdbcDataAdapter("select max(ID) ID from tbljartype", con)
        Dim dsnumber As New System.Data.DataSet
        danumber.Fill(dsnumber)
    End Sub

    Sub refreshMe()
        con.Close()

        Try
            con.Open()
            Dim mycmd3 As New OdbcCommand("select * from `tbljartype`", con)
            Dim da As New OdbcDataAdapter(mycmd3)
            Dim ds As New Data.DataSet
            da.Fill(ds, "tbljartype")

            dgvListJTP.DataSource = ds.Tables(0)
            dgvListJTP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvListJTP.RowsDefaultCellStyle.BackColor = Drawing.Color.SkyBlue
            dgvListJTP.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.WhiteSmoke
            dgvListJTP.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btncn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncn.Click
        cnjartype.btnupdate.Hide()
        cnjartype.btnsave.Show()
        cnjartype.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main.Enabled = True
        Me.Hide()
    End Sub


    Private Sub dgvListJTP_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListJTP.CellClick

       

        Dim i As Integer
        i = dgvListJTP.CurrentRow.Index
        cnjartype.txtid.Text = dgvListJTP.Item(0, i).Value
        cnjartype.lbldt.Text = dgvListJTP.Item(1, i).Value
        cnjartype.txtname.Text = dgvListJTP.Item(2, i).Value
        cnjartype.txtdesc.Text = dgvListJTP.Item(3, i).Value
        cnjartype.txtpricing.Value = dgvListJTP.Item(4, i).Value

        Try
            If dgvListJTP.Columns(e.ColumnIndex).Name = "btnedit" Then
                'cnjartype.btnupdate.Show()
                ' cnjartype.txthash.Show()
                cnjartype.txtid.Show()
                'cnjartype.btnadd.Hide()
                cnjartype.btnsave.Hide()
                cnjartype.btnupdate.Show()
                cnjartype.Show()
                Me.Enabled = False

            ElseIf dgvListJTP.Columns(e.ColumnIndex).Name = "btndel" Then

                Dim mycmd5, mycmd6, mycmd7, mycmd8 As New OdbcCommand
                Dim i3 As String
                Dim result3 As New DialogResult

                i3 = cnjartype.txtid.Text

                con.Close()

                con.Open()
                result3 = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result3 = Windows.Forms.DialogResult.Yes Then
                    With mycmd5
                        .Connection = con
                        .CommandText = "delete from tbljartype where ID = '" & i3 & "'"
                        .ExecuteNonQuery()
                    End With
                    With mycmd6
                        .Connection = con
                        .CommandText = "set @autoquestionnum :=0;"
                        .ExecuteNonQuery()
                    End With

                    With mycmd7
                        .Connection = con
                        .CommandText = "update tbljartype set ID = @autoquestionnum :=(@autoquestionnum+1);"
                        .ExecuteNonQuery()
                    End With

                    With mycmd8
                        .Connection = con
                        .CommandText = "alter TABLE tbljartype AUTO_INCREMENT = 1"
                        .ExecuteNonQuery()
                    End With

                    MessageBox.Show("Delete record Success !", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                refreshMe()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class