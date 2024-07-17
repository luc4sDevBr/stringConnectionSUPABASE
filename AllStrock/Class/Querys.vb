Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Npgsql

Public Class Querys
    Public Shared Sub ExecutaQuerySimples(Query As String)
        Dim obj As New Dao

        Try
            obj.conectar()
            Dim sql As New NpgsqlCommand(Query, obj.SQLCNN)
            sql.ExecuteNonQuery()

        Catch ex As Exception
            ' MsgBox($"Exceção {ex.Message.ToString}")
        Finally
            obj.desconectar()
        End Try

    End Sub

End Class
