Imports MySql.Data.MySqlClient
Public Class DSolConsultoria
    Inherits Conexion

    Private idSolConsultoria As Integer
    Private idCliente As Integer
    Private necesidad As String
    Private capacitacion1 As String
    Private presupuesto As Integer
    Private cmd As MySqlCommand

    Public Sub New(idSolCon As Integer, idCl As Integer, nec As String, cap1 As String)
        idSolConsultoria = idSolCon
        idCliente = idCl
        necesidad = nec
        capacitacion1 = cap1
    End Sub
    Public Sub New(idCl As Integer, nec As String, cap1 As String)
        idCliente = idCl
        necesidad = nec
        capacitacion1 = cap1
    End Sub
    Public Sub New()

    End Sub
    Property IdSolucionConsultoria As Integer
        Get
            Return idSolConsultoria
        End Get
        Set(value As Integer)
            idSolConsultoria = value
        End Set
    End Property

    Property IdClienteSolConsul As Integer
        Get
            Return idCliente
        End Get
        Set(value As Integer)
            idCliente = value
        End Set
    End Property
    Property NecesidadSolConsul As String
        Get
            Return necesidad
        End Get
        Set(value As String)
            necesidad = value
        End Set
    End Property
    Property CapacitacionSolConsul As String
        Get
            Return capacitacion1
        End Get
        Set(value As String)
            capacitacion1 = value
        End Set
    End Property
    Property PresupuestoSolConsul As Integer
        Get
            Return presupuesto
        End Get
        Set(value As Integer)
            presupuesto = value
        End Set
    End Property

    Public Function InsertarSolConsultoria(id As String, nece As String, capaci As String) As Boolean
        Try
            Conectar()
            Dim sql As String = "insert into solConsultoria(idCl,necesidad,cap1,pagado) values(" & id & ", '" &
                nece & "', '" & capaci & "',False)"
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery() Then
                MsgBox("La solicitud de consultoria se ha ingresado correctamente")
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
    Public Function ConsultarSolConsuls() As DataTable
        Try
            Conectar()
            Dim sql As String = "select s.idsc,c.nomC,s.necesidad,s.cap1,s.presupuesto from solConsultoria as s inner join cliente as c on s.idCl=c.idC"
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
    Public Function ConsultarAsignarAsesor() As DataTable
        Try
            Conectar()
            Dim sql As String = "select s.idsc,c.nomC,s.necesidad,s.idE from solConsultoria as s inner join cliente as c on s.idCl=c.idC;"
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
    Public Function InsertarPresupuesto(presu As Integer, idsc As Integer) As Boolean
        Try
            Conectar()
            Dim sql As String = "update solConsultoria set presupuesto=" & presu & " where idSC=" & idsc & ""
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery Then
                MsgBox("El presupuesto se asigno correctamente")
                Return True
            Else
                MsgBox("Hubo un problema" & vbNewLine & "No se registro el presupuesto")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function AsignarAsesorACliente(idAsesor As Integer, idCliente As Integer) As Boolean
        Try
            Conectar()
            Dim sql As String = "update solConsultoria set idE=" & idAsesor & " where idCl=" & idCliente
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery Then
                MsgBox("Se asigno el asesor correctamente")
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
    Public Function Pagar(idSol As Integer)
        Try
            Conectar()
            Dim sql As String = "update solConsultoria set pagado=True where idSC=" & idSol
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery Then
                MsgBox("Su pago se realizo correctamente")
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
    Public Function SelectIdSolConsul(idCl As Integer) As DataSet
        Try
            Conectar()
            Dim sql As String = "select idSC from solConsultoria where idCl=" & idCl & " and pagado=False"
            Dim adt As New MySqlDataAdapter(sql, con)
            Dim ds As New DataSet
            adt.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function ListarAsesores() As DataSet
        Try
            Conectar()
            Dim sql As String = "select nombre from empleado where tipo='asesor'"
            Dim adt As New MySqlDataAdapter(sql, con)
            Dim ds As New DataSet
            adt.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function SelectAllIdSol(idSol As Integer) As DataTable
        Try
            Conectar()
            Dim sql As String = "select * from solConsultoria where idSC=" & idSol
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
    Public Function GetIdCliente(usuario As String) As DataTable
        Try
            Conectar()
            Dim sql As String = "select idC from cliente where userC='" & usuario & "'"
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
    Public Function GetIdClienteName(nombre As String) As DataTable
        Try
            Conectar()
            Dim sql As String = "select s.idCl from solConsultoria as s inner join cliente as c on s.idCl=c.idC where c.nomC='" & nombre & "' group by idcl"
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
    Public Function SetIdAsesorName(nombre As String) As DataTable
        Try
            Conectar()
            Dim sql As String = "select id from empleado where nombre='" & nombre & "' "
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
    Public Sub SetIdCliente(id As Integer)
        idCliente = id
    End Sub
End Class