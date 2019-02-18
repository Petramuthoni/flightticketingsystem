Imports System.Data.OleDb
Public Class forgot

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtCn.Text = "5AB" Then
            login.Show()
            Me.Hide()
        Else
            MessageBox.Show("identify the red content correctly")

        End If
        ' Dim ConnectionString As String
        ' ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Environment.CurrentDirectory & "\flightdb.mdb"
        'Dim conn As New OleDbConnection(ConnectionString)
        'Dim cmd As New OleDbCommand("SELECT Username, Password FROM register", conn)
        'Dim reader As OleDbDataReader
        ' Dim valid As Boolean = False
        'Try
        'conn.Open()
        ' Dim uName = txtU.Text
        'Dim password = txtN.Text
        'reader = cmd.ExecuteReader
        'While reader.Read
        'Dim databaseUName = CStr(reader.Item(0))
        'Dim databasePassword = CStr(reader.Item(1))
        'If uName = databaseUName And password = databasePassword Then
        'valid = True
        'login.Show()
        'Me.Hide()
        'Exit While
        'End If
        'End While
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        ' Finally
        'conn.Close()

        'End Try
        Dim ConnectionString As String
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Environment.CurrentDirectory & "\flightdb.mdb"
        Dim conn As New OleDbConnection(ConnectionString)
        Dim insertdata As String = "INSERT INTO register VALUES('" & txtU.Text & "','" & txtN.Text & "')"
        Dim cmd As New OleDbCommand(insertdata, conn)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data saved successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()

        End Try

    End Sub
End Class