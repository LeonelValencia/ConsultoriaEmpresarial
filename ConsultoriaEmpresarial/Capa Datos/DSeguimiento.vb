Imports MySql.Data.MySqlClient
Public Class DSeguimiento
    Inherits Conexion

    Private idSegui As Integer
    Private idCliente As Integer
    Private idAsesor As Integer
    Private seguimiento As String
    Private cmd As MySqlCommand

    Public Sub New(idCl As Integer, idAs As Integer, seg As String)
        idCliente = idCl
        idAsesor = idAs
        seguimiento = seg
    End Sub
    Public Sub New()
    End Sub

    Public Function InsertarSeguimiento(ds As DSeguimiento) As Boolean
        Try
            Conectar()
            Dim sql As String = "insert into seguimiento(idCl,idAS,seguimiento) values(" & ds.idCliente & ", " &
                ds.idAsesor & ", '" & ds.seguimiento & "')"
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery() Then
                MsgBox("El seguimiento se ha agregado correctamente")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function
    Public Function SelectSeguimientoIdCl(idCl As Integer) As DataTable
        Try
            Conectar()
            Dim sql As String = "select seguimiento from seguimiento where idCl=" & idCl
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery() Then
                Dim dt As New DataTable
                Dim adp As New MySqlDataAdapter(cmd)
                adp.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
End Class
