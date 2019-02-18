Imports System.Data.OleDb
Public Class register


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFn.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtFn.Clear()
        txtLn.Clear()
        txtPd.Clear()
        txtUn.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        Dim ConnectionString As String
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Environment.CurrentDirectory & "\flightdb.mdb"
        Dim conn As New OleDbConnection(ConnectionString)
        Dim insert As String = "INSERT INTO register VALUES('" & txtUn.Text & "','" & txtPd.Text & "')"

        Dim cmd As New OleDbCommand(insert, conn)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data saved successfully")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        login.Show()
        Me.Hide()
    End Sub
End Class