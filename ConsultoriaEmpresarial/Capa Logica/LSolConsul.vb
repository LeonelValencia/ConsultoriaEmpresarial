Imports MySql.Data.MySqlClient
Public Class LSolConsul
    Private idCliente As Integer
    Property IDClienteLSolConsul As Integer
        Get
            Return idCliente
        End Get
        Set(value As Integer)
            idCliente = value
        End Set
    End Property
    Public Function InsertarSolConsul(id As String, nec As String, cap1 As String)
        Dim dsc As New DSolConsultoria()
        dsc.IdClienteSolConsul = idCliente
        If dsc.InsertarSolConsultoria(id, nec, cap1) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ConsultarSolConsuls() As DataTable
        Try
            Dim dsc As New DSolConsultoria
            Dim dt As DataTable = dsc.ConsultarSolConsuls
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function ConsultarAsignarAsesor() As DataTable
        Try
            Dim dsc As New DSolConsultoria
            Dim dt As DataTable = dsc.ConsultarAsignarAsesor
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function AsignarAsesorACliente(idAs As Integer, idCl As Integer) As Boolean
        Try
            Dim dsc As New DSolConsultoria
            If dsc.AsignarAsesorACliente(idAs, idCl) = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function InsertarPresupuesto(presu As Integer, idsc As Integer) As Boolean
        Try
            Dim dsc As New DSolConsultoria
            If dsc.InsertarPresupuesto(presu, idsc) = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Pagar(idSol As Integer)
        Try
            Dim ds As New DSolConsultoria
            If ds.Pagar(idSol) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function ListarAsesores() As DataSet
        Try
            Dim dc As New DSolConsultoria
            Dim ds As DataSet = dc.ListarAsesores()
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function SelectIdSolConsul(idCl As Integer) As DataSet
        Try
            Dim dc As New DSolConsultoria
            Dim ds As DataSet = dc.SelectIdSolConsul(idCl)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function SelectAllIdSol(idSol As Integer) As DataTable
        Try
            Dim ds As New DSolConsultoria
            Dim dt As DataTable = ds.SelectAllIdSol(idSol)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
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
    Public Function SetIdClienteName(nombre As String) As DataTable
        Try
            Dim dc As New DSolConsultoria
            Dim dt As DataTable = dc.GetIdClienteName(nombre)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function SetIdAsesorName(nombre As String) As DataTable
        Try
            Dim dc As New DSolConsultoria
            Dim dt As DataTable = dc.SetIdAsesorName(nombre)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function SetIdCliente(id As String) As Boolean
        Try
            Dim idc As Integer = Val(id)
            idCliente = idc
            Dim dsc As New DSolConsultoria
            dsc.IdClienteSolConsul = idc
            dsc.SetIdCliente(idc)
            MsgBox("Tu ID es= " & idc)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function GetIdClienteName(id As String) As Boolean
        Try
            Dim idc As Integer = Val(id)
            idCliente = idc
            Dim dsc As New DSolConsultoria
            dsc.IdClienteSolConsul = idc
            dsc.SetIdCliente(idc)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
