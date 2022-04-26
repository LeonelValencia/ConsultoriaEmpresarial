Imports MySql.Data.MySqlClient
Public Class DOT
    Inherits Conexion

    Private idOT As String
    Private idOR As Integer
    Private nomC As String
    Private nomP As String
    Private Pago As String
    Private materiales As String
    Private fechaProgr As String
    Private nomAnalista As String
    Private cmd As MySqlCommand
    Public Sub New(mate As String, cl As String, emp As String, fecha As String, analis As String)
        materiales = mate
        nomC = cl
        nomP = emp
        fechaProgr = fecha
        nomAnalista = analis
    End Sub
    Public Sub New(idOt As String, nomC As String, nomP As String, pago As String)
        Me.idOT = idOt
        Me.nomC = nomC
        Me.nomP = nomP
        Me.Pago = pago
    End Sub
    Public Sub New()

    End Sub

    Public Function insertarOT(dot As DOT) As Boolean
        Try
            Conectar()
            Dim sql As String = "insert into ordensalida(idOT,nomC,nomP,Pago) values('" & dot.idOT & "', '" &
                dot.nomC & "', '" & dot.nomP & "','" & dot.Pago & "')"
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery() Then
                MsgBox("El OT se ha ingresado correctamente")
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
    Public Function ProgramarOT(dot As DOT) As Boolean
        Try
            Conectar()
            Dim sql As String = "insert into progrmarOT(materiales,cliente,empleado,fechaProg,analista) values('" & dot.materiales & "', '" &
                dot.nomC & "', '" & dot.nomP & "','" & dot.fechaProgr & "','" & dot.nomAnalista & "')"
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery() Then
                MsgBox("El OT se ha programado correctamente")
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
    Public Function ConsultarOTs() As DataTable
        Try
            Conectar()
            Dim sql As String = "select * from ordensalida"
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery Then
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
