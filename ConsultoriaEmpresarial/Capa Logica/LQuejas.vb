Imports MySql.Data.MySqlClient
Public Class LQuejas
    Public Function InsertarQueja(idCl As String, idAs As String, quejas As String)
        Dim idCli = Val(idCl)
        Dim idAse = Val(idAs)
        Dim DQu As New DQuejas(idCli, idAse, quejas)
        If DQu.InsertarQuejas(DQu) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function SelectQuejaIdCl(id As Integer) As DataTable
        Try
            Dim dqu As New DQuejas
            Dim dt As DataTable = dqu.SelectQuejasIdCl(id)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function SelectQuejas() As DataTable
        Try
            Dim dqu As New DQuejas
            Dim dt As DataTable = dqu.SelectQuejas()
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
