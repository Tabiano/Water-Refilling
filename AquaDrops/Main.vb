Imports System.Data.Odbc
Imports System.Data.DataSet
Imports System.Data.DataTable
Imports System.Windows.Forms
Public Class Main


    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        Dim response As Integer
        response = MessageBox.Show("LogOut?", "INFO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If response = vbOK Then
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnsale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsale.Click
        Sale.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnmaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmaintenance.Click
        JandTP.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnsr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsr.Click
       
    
        salesreport.Show()
    End Sub
End Class