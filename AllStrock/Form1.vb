Imports System.Diagnostics.Eventing
Imports Npgsql

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Configura o ListView
            ListView1.View = View.Details
            ListView1.FullRowSelect = True
            ListView1.GridLines = True

            ' Adiciona colunas ao ListView
            ListView1.Columns.Add("#", 50, HorizontalAlignment.Left)
            ListView1.Columns.Add("Funcao", 100, HorizontalAlignment.Left)

            Dim obj As New Dao
            Dim retorno As NpgsqlDataReader = Nothing

            obj.conectar()

            Dim sql As New NpgsqlCommand("select * FROM ""AS_FUNCAO""", obj.SQLCNN)
            Dim result As NpgsqlDataReader = sql.ExecuteReader()

            While result.Read()
                Dim item As New ListViewItem(result(0).ToString())
                item.SubItems.Add(result(1).ToString())
                ListView1.Items.Add(item)
            End While

            obj.desconectar()

        Catch ex As Exception

        End Try
    End Sub
End Class
