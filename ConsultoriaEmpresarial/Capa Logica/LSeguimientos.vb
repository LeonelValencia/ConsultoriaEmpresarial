Imports MySql.Data.MySqlClient
Public Class LSeguimientos
    Public Function InsertarSegui(idCl As Integer, idAs As Integer, segui As String)
        Dim Ds As New DSeguimiento(idCl, idAs, segui)
        If Ds.InsertarSeguimiento(Ds) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function SelectSeguimientoIdCl(idC As Integer) As DataTable
        Try
            Dim ds As New DSeguimiento
            Dim dt As DataTable = ds.SelectSeguimientoIdCl(idC)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
