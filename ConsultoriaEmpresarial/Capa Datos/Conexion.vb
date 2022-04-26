Imports MySql.Data.MySqlClient
Public Class Conexion
    'base de datos remota
    Protected con As New MySqlConnection("server=by3x4i2wvwk4hapeirae-mysql.services.clever-cloud.com;database=by3x4i2wvwk4hapeirae;
        user=uzk0k2l2df7my6y0;password=CjIFMq7m6kOMCygXRMZw")
    Public Function Conectar() As Boolean
        Try
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub desconectar()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
