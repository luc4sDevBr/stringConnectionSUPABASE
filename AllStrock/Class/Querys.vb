Imports System.Data.SqlClient
Imports Npgsql

Public Class Querys
    Public Shared Function ExecutaQuerySimples(Query As String) As NpgsqlDataReader
        Dim obj As New Dao
        Dim retorno As NpgsqlDataReader = Nothing
        Try
            obj.conectar()
            Dim sql As New NpgsqlCommand(Query, obj.SQLCNN)
            Dim result As NpgsqlDataReader = sql.ExecuteReader()
            If result IsNot Nothing Then
                retorno = result
            End If
        Catch ex As Exception
            ' MsgBox($"Exceção {ex.Message.ToString}")
        Finally
            obj.desconectar()
        End Try
        Return retorno
    End Function
End Class
