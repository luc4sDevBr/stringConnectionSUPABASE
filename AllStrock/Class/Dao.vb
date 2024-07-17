Imports System.Data.SqlClient
Imports Npgsql

Public Class Dao
    Public SQLCNN As New NpgsqlConnection()
    ' Configuração da string de conexão
    Public host As String = "aws-0-sa-east-1.pooler.supabase.com"
    Public port As String = "5432"
    Public database As String = "postgres"
    Public username As String = "postgres.uocrgevtqfiqtfxioivk"
    Public password As String = "Vickalves562710#"
    Public timeout As Integer = 3
    Public connectionString As String = $"Host={host};Port={port};Database={database};Username={username};Password={password};Timeout={timeout};"

    Public Sub conectar()


        SQLCNN.ConnectionString = connectionString

        Try
            If SQLCNN.State = ConnectionState.Closed Then


                SQLCNN.ConnectionString = connectionString

                SQLCNN.Open()
            End If
        Catch
            'Mostra formulário de erro de conexão com o banco
            'cnconexaobanco.ShowDialog()
            Try
                SQLCNN.Open()
            Catch ex As Exception

            End Try
        Finally
        End Try
    End Sub

    Public Sub TesteConectar()

        SQLCNN.ConnectionString = connectionString
        Try
            If SQLCNN.State = ConnectionState.Closed Then
                SQLCNN.Open()
            End If
        Catch
            Throw
        Finally
        End Try
    End Sub

    Public Sub desconectar()
        If SQLCNN.State <> ConnectionState.Closed Then
            SQLCNN.Close()
        End If
    End Sub
End Class
