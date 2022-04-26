Imports MySql.Data.MySqlClient
Public Class DEmpleado
    Inherits Conexion

    Private id As Integer
    Private tipo As String
    Private usuario As String
    Private contraseña As String
    Private nombre As String
    Private tel As String
    Private fechaInicio As String
    Private cmd As MySqlCommand

    Public Sub New(tipo As String, user As String, contra As String, nom As String, tel As String, fechInicio As String)
        Me.tipo = tipo
        usuario = user
        contraseña = contra
        nombre = nom
        Me.tel = tel
        fechaInicio = fechInicio
    End Sub
    Public Sub New(id As Integer, user As String, contra As String, nom As String, tel As String, fechInicio As String)
        Me.id = id
        usuario = user
        contraseña = contra
        nombre = nom
        Me.tel = tel
        fechaInicio = fechInicio
    End Sub
    Public Sub New()

    End Sub
    Property IdEmpleado As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property
    Property TipoCliente As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property
    Property UsuarioCliente As String
        Get
            Return usuario
        End Get
        Set(value As String)
            usuario = value
        End Set
    End Property
    Property ContraseCliente As String
        Get
            Return contraseña
        End Get
        Set(value As String)
            contraseña = value
        End Set
    End Property
    Property NomCliente As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Property TellCliente As String
        Get
            Return tel
        End Get
        Set(value As String)
            tel = value
        End Set
    End Property
    Property FechaIniCliente As String
        Get
            Return fechaInicio
        End Get
        Set(value As String)
            fechaInicio = value
        End Set
    End Property
    Public Function iniciarSesion(de As DEmpleado) As Boolean
        Try
            Conectar()
            Dim sql As String = "SELECT * FROM empleado WHERE usuario='" & de.UsuarioCliente & "' AND contraseña='" & de.ContraseCliente & "'"
            cmd = New MySqlCommand(sql, con)
            Dim tabla As MySqlDataReader
            tabla = cmd.ExecuteReader
            Dim cantidad As Integer = 0
            While tabla.Read
                cantidad += 1
            End While

            If cantidad = 1 Then
                MsgBox("Usuario y contraseña correctas")
                FrmInicioEmpleado.Show()
                FrmIniciarsesionEmpleado.Hide()
                Return True
            ElseIf cantidad > 1 Then
                MsgBox("Error hay datos duplicados")
                Return False
            ElseIf de.UsuarioCliente = "" Or de.ContraseCliente = "" Then
                MsgBox("Los campos no pueden estar vacios")
                Return False
            Else
                MsgBox("Error usuario y contraseña no validos")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function
    Public Function InsertarEmpleado(de As DEmpleado) As Boolean
        Try
            Conectar()
            Dim sql As String = "insert into empleado(tipo,usuario,contraseña,nombre,tel,fechaInicio) values('" & de.TipoCliente & "','" & de.UsuarioCliente &
                "','" & de.ContraseCliente & "','" & de.NomCliente & "','" & de.TellCliente & "','" & de.FechaIniCliente & "')"
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery = True Then
                MsgBox("Se ingreso el " & de.TipoCliente & " correctamente")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function ConsultarEmpleados(tipo As String) As DataTable
        Try
            Conectar()
            Dim sql As String = "select * from empleado where tipo='" & tipo & "'"
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery = True Then
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
        End Try
    End Function
    Public Function ActualizarEmpleado(de As DEmpleado) As Boolean
        Try
            Conectar()
            Dim sql As String = "update empleado set usuario='" & de.UsuarioCliente & "',contraseña='" & de.ContraseCliente & "',nombre='" & de.NomCliente &
                "',tel='" & de.TellCliente & "',fechaInicio='" & de.FechaIniCliente & "' where id=" & de.IdEmpleado & ""
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery = True Then
                MsgBox("Se actualizo correctamente")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function EliminarEmpleado(id As Integer) As Boolean
        Try
            Conectar()
            Dim sql As String = "delete from empleado where id=" & id & ""
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery = True Then
                MsgBox("Se elimino correctamente correctamente")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function ConsultarAllNamesEm() As DataSet
        Try
            Conectar()
            Dim sql As String = "select nombre from empleado"
            cmd = New MySqlCommand(sql, con)
            Dim adt As New MySqlDataAdapter(sql, con)
            Dim ds As New DataSet
            adt.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function ConsultarCondTipoEmpleados(condicion As String, tipo As String) As DataSet
        Try
            Conectar()
            Dim sql As String = "select " & condicion & " from empleado where tipo='" & tipo & "'"
            cmd = New MySqlCommand(sql, con)
            Dim adt As New MySqlDataAdapter(sql, con)
            Dim ds As New DataSet
            adt.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
