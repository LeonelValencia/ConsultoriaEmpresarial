Imports MySql.Data.MySqlClient
Public Class LOT
    Public Function insertarOT(dOt As String, nomC As String, nomP As String, pago As String)
        Dim dOrdenT As New DOT(dOt, nomC, nomP, pago)
        If dOrdenT.insertarOT(dOrdenT) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ProgramarOT(mate As String, cl As String, emp As String, fecha As String, analis As String) As Boolean
        Dim dot As New DOT(mate, cl, emp, fecha, analis)
        If dot.ProgramarOT(dot) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ConsultarOTs() As DataTable
        Try
            Dim dot As New DOT
            Dim dt As DataTable = dot.ConsultarOTs
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
