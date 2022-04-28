Public Class LEmpleados
    Public Function InsertarEmpleado(tipo As String, usuario As String, contra As String, nombre As String, tel As String, fechaI As String) As Boolean
        Try
            Dim de As New DEmpleado(tipo, usuario, contra, nombre, tel, fechaI)
            If de.InsertarEmpleado(de) = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function ActualizarEmpleado(tipo As String, id As Integer, usuario As String, contra As String, nombre As String, tel As String, fechaI As String) As Boolean
        Try
            Dim de As New DEmpleado(tipo, id, usuario, contra, nombre, tel, fechaI)
            If de.ActualizarEmpleado(de) = True Then
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
            Dim de As New DEmpleado()
            If de.EliminarEmpleado(id) = True Then
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
            Dim de As New DEmpleado
            Dim dt As DataTable = de.ConsultarEmpleados(tipo)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function ConsultarAllEmpleados() As DataTable
        Try
            Dim de As New DEmpleado
            Dim dt As DataTable = de.ConsultarAllEmpleados()
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function ConsultarNamesById(idAs As String) As DataTable
        Try
            Dim de As New DEmpleado
            Dim dt As DataTable = de.ConsultarNamesById(idAs)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function iniciarEmpleado(usuario As String, contra As String)
        Dim de As New DEmpleado
        de.UsuarioCliente = usuario
        de.ContraseCliente = contra
        If de.iniciarSesion(de) = True Then
            FrmInicioEmpleado.Show()
            FrmIniciarsesionEmpleado.Hide()
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ConsultarAllNamesEm() As DataSet
        Try
            Dim de As New DEmpleado
            Dim ds As DataSet = de.ConsultarAllNamesEm
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function ConsultarNameTipo(condicion As String, tipo As String) As DataSet
        Try
            Dim de As New DEmpleado
            Dim ds As DataSet = de.ConsultarCondTipoEmpleados(condicion, tipo)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
