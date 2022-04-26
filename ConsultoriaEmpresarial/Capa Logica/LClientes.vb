Imports MySql.Data.MySqlClient
Public Class LClientes
    Public Function insertarCliente(nom As String, tel As String, direm As String, nomem As String, email As String, usuario As String, contra As String)
        Dim dc As New DClientes(nom, tel, direm, nomem, email, usuario, contra)
        If dc.insertarCliente(dc) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function iniciarCliente(usuario As String, contra As String)
        Dim dc As New DClientes()
        dc.UsuarioCliente = usuario
        dc.ContraseñaCliente = contra
        If dc.iniciarSesion(dc) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ActualizarCliente(id As String, nom As String, tel As String, direm As String, nomem As String, email As String, usuario As String, contra As String)
        Dim dc As New DClientes(id, nom, tel, direm, nomem, email, usuario, contra)
        If dc.ActualizarCliente(dc) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ConsultarCliente(id As String) As DataTable
        Try
            Dim dc As New DClientes
            Dim dt As DataTable = dc.ConsultarCliente(id)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function ConsultarClientes() As DataTable
        Try
            Dim dc As New DClientes
            Dim dt As DataTable = dc.ConsultarClientes()
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function ConsultarAllNamesCl() As DataSet
        Try
            Dim dc As New DClientes
            Dim ds As DataSet = dc.ConsultarAllNamesCl
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function EliminarCliente(contra As String)
        Dim dc As New DClientes()
        If dc.EliminarCliente(contra) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function GetIdCliente(usuario As String) As DataTable
        Try
            Dim dc As New DClientes
            Dim dt As DataTable = dc.GetIdCliente(usuario)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function SetIdCliente(id As String) As Boolean
        Try
            Dim idc As Integer = Val(id)
            Dim dc As New DClientes
            Dim dsc As New DSolConsultoria
            dc.IdCliente = idc
            dc.SetIdCliente(idc)
            dsc.IdClienteSolConsul = idc
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
