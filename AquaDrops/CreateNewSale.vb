Imports System.Data.Odbc
Imports System.Globalization

Public Class CreateNewSale

    Dim id As Integer = 0
    Public Sub get_number()
        connect_me()
        Dim number As Integer
        Dim cmdnumber As New OdbcCommand("select ifnull(Max(ID), 0) from tbljartype", con)
        number = cmdnumber.ExecuteScalar

        If number > 0 Then
            Call get_id()
        Else
            id = 1
        End If
    End Sub

    Public Sub get_id()
        Dim danumber As New OdbcDataAdapter("select max(ID) ID from tbljartype", con)
        Dim dsnumber As New System.Data.DataSet
        danumber.Fill(dsnumber)
        id = dsnumber.Tables(0).Rows(0).Item("ID") + 1
    End Sub

    Sub refreshMe()
        con.Close()

        Try
            con.Open()
            Dim mycmd3 As New OdbcCommand("select * from `tbljartype`", con)
            Dim da As New OdbcDataAdapter(mycmd3)
            Dim ds As New Data.DataSet
            da.Fill(ds, "tbljartype")

            JandTP.dgvListJTP.DataSource = ds.Tables(0)
            JandTP.dgvListJTP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            JandTP.dgvListJTP.RowsDefaultCellStyle.BackColor = Drawing.Color.SkyBlue
            JandTP.dgvListJTP.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.WhiteSmoke
            JandTP.dgvListJTP.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CreateNewSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        get_number()
        btnupdate.Hide()
        lbldt.Text = Date.Now.ToString("yyyy-MM-dd")
        Me.TbljartypeTableAdapter.Fill(Me.DataSet1.tbljartype)
        txtqty.Value = 1
    End Sub

    Private Sub txtcn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcn.KeyDown
        If e.KeyCode = 13 Then
            If txtcn.Text = "" Then
                MessageBox.Show("Enter Pricing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcn.Focus()
            Else
                cbtype.Focus()
            End If
        End If
    End Sub

    Private Sub cbtype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbtype.KeyDown
        If e.KeyCode = 13 Then
            If cbtype.Text = "" Then
                MessageBox.Show("Enter Pricing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbtype.Focus()
            Else
                cbjartype.Focus()
            End If
        End If
    End Sub

    Private Sub cbjt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbstatus.KeyDown
        If e.KeyCode = 13 Then
            If cbjartype.Text = "" Then
                MessageBox.Show("Enter Pricing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbjartype.Focus()
            Else
                txtqty.Focus()
            End If
        End If
    End Sub

    Private Sub txtqty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = 13 Then
            If txtqty.Text = "" Then
                MessageBox.Show("Enter Pricing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtqty.Focus()
            Else
                btnadd.Focus()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Sale.Enabled = True
        Me.Hide()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtcn.Text = "" Or cbjartype.Text = "" Or txtqty.Value = 0 Or cbtype.Text = "" Or cbstatus.Text = "" Then
            MessageBox.Show("Complete all the fields ", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                connect_me()

                Dim mycmd As New OdbcCommand
                Dim readUser As OdbcDataReader

                With mycmd
                    .Connection = con
                    .CommandText = " select * from tbljartype where name = '" & cbjartype.Text & "'"
                    .ExecuteNonQuery()
                End With
                readUser = mycmd.ExecuteReader
                If readUser.Read Then

                    Dim total As Integer = 0
                    ctotal.lblprice.Text = readUser("price").ToString()
                    ctotal.lbljartype.Text = cbjartype.Text
                    ctotal.lblqty.Text = txtqty.Value
                    ctotal.lbltotal.Text = ctotal.lblprice.Text * ctotal.lblqty.Text

                    ctotal.Show()
                    ctotal.btnupdate.Hide()
                    ctotal.btnsubmit.Show()
                    btnadd.BackColor = Color.Silver
                    btncancel.BackColor = Color.Silver
                    Me.Enabled = False
                Else
                    MessageBox.Show("Jar type not found")
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtcn.Text = "" Or cbjartype.Text = "" Or txtqty.Value = 0 Or cbtype.Text = "" Or cbstatus.Text = "" Then
            MessageBox.Show("Complete all the fields ", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                connect_me()

                Dim mycmd As New OdbcCommand
                Dim readUser As OdbcDataReader

                With mycmd
                    .Connection = con
                    .CommandText = " select * from tbljartype where name = '" & cbjartype.Text & "'"
                    .ExecuteNonQuery()
                End With
                readUser = mycmd.ExecuteReader
                If readUser.Read Then

                    Dim total As Integer = 0
                    ctotal.lblprice.Text = readUser("price").ToString()
                    ctotal.lbljartype.Text = cbjartype.Text
                    ctotal.lblqty.Text = txtqty.Value
                    ctotal.lbltotal.Text = ctotal.lblprice.Text * ctotal.lblqty.Text

                    ctotal.Show()
                    ctotal.btnsubmit.Hide()
                    ctotal.btnupdate.Show()
                    btnadd.BackColor = Color.Silver
                    btncancel.BackColor = Color.Silver
                    Me.Enabled = False
                Else
                    MessageBox.Show("Jar type not found")
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
