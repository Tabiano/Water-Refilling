Imports System.Data.Odbc

Public Class Login


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtusername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyCode = 13 Then
            If txtusername.Text = "" Then
                MessageBox.Show("Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtusername.Focus()
            Else
                txtpass.Focus()
            End If
        End If
    End Sub

    Private Sub txtpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = 13 Then
            If txtpass.Text = "" Then
                MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtpass.Focus()
            Else
                btnlogin.Focus()
                btnlogin.Enabled = True
                btnlogin.BackColor = Color.SpringGreen
            End If
        End If
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        connect_me()
        Try
            Dim cmd As New OdbcCommand
            Dim readUser As OdbcDataReader
            Dim uname As String
            Dim pass As String

            uname = txtusername.Text.Trim
            pass = txtpass.Text.Trim

            With cmd
                .Connection = con
                .CommandText = " select * from tbluser where USERNAME = '" & uname & "' and PASSWORD = '" & pass & "'"
                .ExecuteNonQuery()
            End With
            readUser = cmd.ExecuteReader

            If readUser.HasRows Then
                Dim response As Integer
                response = MessageBox.Show("LOGIN Succes Welcome " + txtusername.Text, "INFO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If response = vbOK Then
                    readUser.Read()
                    txtusername.Clear()
                    txtpass.Clear()
                    Main.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Admn Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtusername.Clear()
                txtpass.Clear()
                txtusername.Focus()
                btnlogin.Enabled = False
                btnlogin.BackColor = Color.LightGray
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class
