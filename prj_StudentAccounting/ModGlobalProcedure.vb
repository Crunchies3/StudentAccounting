
Imports MySql.Data.MySqlClient

Module ModGlobalProcedure

    Public Function func_connectToDB() As Boolean
        Try
            server_name = "localhost"
            DB_name = "db_studentaccountingmanagement"
            DB_user = "root"
            DB_pass = "root"
            port = "3306"


            If conDB.State = ConnectionState.Closed Then
                conDB = New MySqlConnection
                str_connection = "SERVER=" & server_name & ";" _
                                  & "DATABASE=" & DB_name & ";" _
                                  & "USERNAME=" & DB_user & ";" _
                                  & "PASSWORD=" & DB_pass & ";" _
                                  & "PORT=" & port & ";" _
                                  & "DEFAULT COMMAND TIMEOUT=" & 20 * 60

                conDB.ConnectionString = str_connection
                conDB.Open()
                command.Connection = conDB
                Return True
            Else
                conDB.Close()
                Return False
            End If

        Catch ex As Exception

            MessageBox.Show("" & ex.Message)

        End Try
        Return False
    End Function

    Public Sub checkDatabaseConnection()
        If func_connectToDB() = True Then
        Else
            conDB.Open()
        End If
    End Sub

End Module