Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class DClientes
    Inherits Conexion

    Private idC As Integer
    Private nombreC As String
    Private telefono As String
    Private direccionEmpresa As String
    Private nombreEmpresa As String
    Private emailC As String
    Private usuarioC As String
    Private contraseñaC As String
    Private cmd As MySqlCommand
    Public Sub New(id As Integer, nom As String, tel As String, direm As String, nomem As String, email As String, usuario As String, contra As String)
        idC = id
        nombreC = nom
        telefono = tel
        direccionEmpresa = direm
        nombreEmpresa = nomem
        emailC = email
        usuarioC = usuario
        contraseñaC = contra
    End Sub
    Public Sub New(nom As String, tel As String, direm As String, nomem As String, email As String, usuario As String, contra As String)
        nombreC = nom
        telefono = tel
        direccionEmpresa = direm
        nombreEmpresa = nomem
        emailC = email
        usuarioC = usuario
        contraseñaC = contra
    End Sub
    Public Sub New()

    End Sub
    Property IdCliente As Integer
        Get
            Return idC
        End Get
        Set(value As Integer)
            idC = value
        End Set
    End Property
    Property NombreCliente As String
        Get
            Return nombreC
        End Get
        Set(value As String)
            nombreC = value
        End Set
    End Property

    Property TelefonCliente As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Property DireccionEmpresaCliente As String
        Get
            Return direccionEmpresa
        End Get
        Set(value As String)
            direccionEmpresa = value
        End Set
    End Property

    Property NombreEmpresaCliente As String
        Get
            Return nombreEmpresa
        End Get
        Set(value As String)
            nombreEmpresa = value
        End Set
    End Property

    Property EmailCliente As String
        Get
            Return emailC
        End Get
        Set(value As String)
            emailC = value
        End Set
    End Property

    Property UsuarioCliente As String
        Get
            Return usuarioC
        End Get
        Set(value As String)
            usuarioC = value
        End Set
    End Property

    Property ContraseñaCliente As String
        Get
            Return contraseñaC
        End Get
        Set(value As String)
            contraseñaC = value
        End Set
    End Property
    Public Function insertarCliente(dc As DClientes) As Boolean
        Try
            Conectar()
            Dim sql As String = "insert into cliente(nomC,telC,dirEmp,nomEmp,emailC,userC,passwordC) values('" & dc.NombreCliente & "', '" &
                dc.TelefonCliente & "', '" & dc.DireccionEmpresaCliente & "','" & dc.NombreEmpresaCliente & "','" & dc.EmailCliente & "','" &
                dc.UsuarioCliente & "','" & dc.ContraseñaCliente & "')"
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery() Then
                MsgBox("El cliente se ha ingresado correctamente")
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

    Public Function iniciarSesion(dc As DClientes) As Boolean
        Try
            Conectar()
            Dim sql As String = "SELECT * FROM cliente WHERE userC='" & dc.UsuarioCliente & "' AND passwordC='" & dc.ContraseñaCliente & "'"
                cmd = New MySqlCommand(sql, con)
            Dim tabla As MySqlDataReader
            tabla = cmd.ExecuteReader
            Dim cantidad As Integer = 0
            While tabla.Read
                cantidad += 1
            End While

            If cantidad = 1 Then
                MsgBox("Usuario y contraseña correctas")
                Iniciar_sesion.Hide()
                Main2SesionIniciada.Show()
                Main2SesionIniciada.NombreDeUsuarioToolStripMenuItem.Text = dc.UsuarioCliente
                Return True
            ElseIf cantidad > 1 Then
                MsgBox("Error hay datos duplicados")
                Return False
            ElseIf dc.UsuarioCliente = "" Or dc.ContraseñaCliente = "" Then
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

    Public Function ActualizarCliente(dc As DClientes) As Boolean
        Try
            Conectar()
            Dim sql As String = "update cliente set nomC='" & dc.NombreCliente & "',telC='" & dc.TelefonCliente & "',dirEmp='" & dc.DireccionEmpresaCliente &
            "',nomEmp='" & dc.NombreEmpresaCliente & "',emailC='" & dc.EmailCliente & "',userC='" & dc.UsuarioCliente & "',passwordC='" &
            dc.ContraseñaCliente & "' where idC='" & dc.idC & "'"
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery() Then
                MsgBox("Tus datos se han actualizado correctamente")
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

    Public Function ConsultarCliente(id As String) As DataTable
        Try
            Conectar()
            Dim sql As String = "select nomC,telC,dirEmp,nomEmp,emailC,userC,passwordC from cliente where idC=" & id & ""
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
        End Try
    End Function
    Public Function ConsultarAllNamesCl() As DataSet
        Try
            Conectar()
            Dim sql As String = "select nomC from cliente"
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
    Public Function ConsultarClientes() As DataTable
        Try
            Conectar()
            Dim sql As String = "select idC,nomC,telC,dirEmp,nomEmp,emailC,userC,passwordC from cliente"
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
    Public Function EliminarCliente(contra As String) As Boolean
        Try
            Conectar()
            Dim sql As String = "delete from cliente where passwordC='" & contra & "'"
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery Then
                MsgBox("Cuenta eliminado exitosamente")
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

    Public Function VerificarEmail(correo As String) As Boolean
        Try
            Conectar()
            Dim sql As String = "select * from cliente where emailC='" & correo & "'"
            cmd = New MySqlCommand(sql, con)
            If cmd.ExecuteNonQuery Then
                MsgBox("Correo encontrado")
                Return True
            Else
                MsgBox("Correo no encontrado")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
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
    Public Sub SetIdCliente(id As Integer)
        Dim dsc As New DSolConsultoria
        idC = id
        dsc.IdClienteSolConsul = id
    End Sub
End Class
