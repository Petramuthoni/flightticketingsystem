Imports System.Data.OleDb
Public Class login

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        'If txtUsername.Text = "Petra" And TxtPassword.Text = "4128" Then
        'Form1.Show()
        'Else
        'MsgBox("enter correct credentials")
        'End If
        Dim ConnectionString As String
        ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Environment.CurrentDirectory & "\flightdb.mdb")
        Dim conn As New OleDbConnection(ConnectionString)
        Dim cmd As New OleDbCommand("SELECT Username, password FROM register", conn)
        Dim reader As OleDbDataReader
        Dim valid As Boolean = False
        Try
            conn.Open()
            Dim uName = txtUsername.Text
            Dim password = TxtPassword.Text
            reader = cmd.ExecuteReader
            While reader.Read
                Dim databaseUName = CStr(reader.Item(0))
                Dim databasePassword = CStr(reader.Item(1))
                If uName = databaseUName And password = databasePassword Then
                    valid = True
                    
                
                    Exit While
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally

            conn.Close()
        End Try
        

        If valid Then
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect details")
            'register.Show()
            'Me.Hide()
        End If


        'End TrynString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Environment.CurrentDirectory & "\flightdb.mdb"
        'Dim conn A

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Application.Exit()
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        txtUsername.Clear()
        TxtPassword.Clear()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        forgot.Show()
        Me.Hide()

    End Sub
End Class