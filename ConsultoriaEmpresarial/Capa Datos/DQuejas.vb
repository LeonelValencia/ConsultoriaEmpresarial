Imports MySql.Data.MySqlClient
Public Class DQuejas
    Inherits Conexion

    Private idCliente As Integer
    Private idAsesor As Integer
    Private quejas As String
    Private cmd As MySqlCommand

    Public Sub New(idCl As Integer, idAs As Integer, queja As String)
        idCliente = idCl
        idAsesor = idAs
        quejas = queja
    End Sub
    Public Sub New()
    End Sub

    Public Function InsertarQuejas(qu As DQuejas) As Boolean
        Try
            Conectar()
            Dim sql As String = "insert into quejas(idCl,idAS,queja) values(" & qu.idCliente & ", " &
                qu.idAsesor & ", '" & qu.quejas & "')"
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery() Then
                MsgBox("La queja se ha agregado correctamente")
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
    Public Function SelectQuejasIdCl(id As Integer) As DataTable
        Try
            Conectar()
            Dim sql As String = "select queja from quejas where idCl=" & id
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
    Public Function SelectQuejas() As DataTable
        Try
            Conectar()
            Dim sql As String = "select * from quejas"
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
