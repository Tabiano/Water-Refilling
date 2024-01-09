Imports System.Data.Odbc
Imports System.Globalization

Public Class cnjartype

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


    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = 13 Then
            If txtname.Text = "" Then
                MessageBox.Show("Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtname.Focus()
            Else
                txtdesc.Focus()
            End If
        End If
    End Sub

    Private Sub txtdesc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdesc.KeyDown
        If e.KeyCode = 13 Then
            If txtdesc.Text = "" Then
                MessageBox.Show("Enter Discription", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtdesc.Focus()
            Else
                txtpricing.Focus()
            End If
        End If
    End Sub

    Private Sub txtpricing_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = 13 Then
            If txtpricing.Text = "" Then
                MessageBox.Show("Enter Pricing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtpricing.Focus()
            Else
                btnsave.Focus()
            End If
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtname.Text = "" Or txtdesc.Text = "" Or txtpricing.Text = "" Then
            MessageBox.Show("Complete all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim dtc As String
            Dim name As String
            Dim desc As String
            Dim price As Integer

            lbldt.Text = Date.Now.ToString("yyyy-MM-dd")

            dtc = lbldt.Text.ToUpper.Trim
            name = txtname.Text.ToUpper.Trim
            desc = txtdesc.Text.ToUpper.Trim
            price = txtpricing.Value

            con.Close()
            Try
                con.Open()
                Dim mycmd As New OdbcCommand

                With mycmd
                    .Connection = con
                    .CommandText = "Insert tbljartype values ('" & id & "', '" & dtc & "', '" & name & "', '" & desc & "', '" & price & "')"
                    .ExecuteNonQuery()

                End With
                MessageBox.Show("Add succes!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Call get_id()
                txtname.Clear()
                txtdesc.Clear()
                JandTP.Enabled = True
                refreshMe()
                txtname.Clear()
                txtdesc.Clear()
                CreateNewSale.Close()
                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub cnjartype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbldt.Text = Date.Now.ToString("yyyy-MM-dd")
        txtpricing.Value = 1
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        JandTP.Enabled = True
        txtname.Clear()
        txtdesc.Clear()
        Me.Hide()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtname.Text = "" Or txtdesc.Text = "" Or txtpricing.Text = "" Then
            MessageBox.Show("Complete all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else



            lbldt.Text = Date.Now.ToString("yyyy-MM-dd")
            Dim id As String
            Dim dtc As String
            Dim name As String
            Dim desc As String
            Dim price As Integer

            id = txtid.Text.ToUpper.Trim
            dtc = lbldt.Text.ToUpper.Trim
            name = txtname.Text.ToUpper.Trim
            desc = txtdesc.Text.ToUpper.Trim
            price = txtpricing.Value

            con.Close()
            Try
                con.Open()
                Dim mycmd As New OdbcCommand

                With mycmd
                    .Connection = con
                    .CommandText = "UPDATE tbljartype SET DATECREATED = '" & dtc & "', NAME = '" & name & "', DESCRIPTION = '" & desc & "', PRICE = '" & price & "' WHERE ID = '" & id & "'"
                    .ExecuteNonQuery()

                End With
                MessageBox.Show("UPDATE success!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Call get_id()
                txtname.Clear()
                txtdesc.Clear()
                JandTP.Enabled = True
                refreshMe()
                txtname.Clear()
                txtdesc.Clear()
                CreateNewSale.Close()
                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub
End Class