Imports Npgsql

Public Class VizualizarUsuario

    Private Sub VizualizarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AtualizaAllUsuListiview(Me.ListView1)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub AtualizaAllUsuListiview(usuListview As ListView)
        Try
            ' Configura o ListView
            usuListview.View = View.Details
            usuListview.FullRowSelect = True
            usuListview.GridLines = False


            Dim totalWidth As Integer = usuListview.ClientSize.Width

            usuListview.Columns.Add("#", CInt(totalWidth * 0.1), HorizontalAlignment.Left) ' 10% da largura total
            usuListview.Columns.Add("Nome", CInt(totalWidth * 0.2), HorizontalAlignment.Left) ' 20% da largura total
            usuListview.Columns.Add("Matricula", CInt(totalWidth * 0.1), HorizontalAlignment.Left) ' 10% da largura total
            usuListview.Columns.Add("Data Registro", CInt(totalWidth * 0.3), HorizontalAlignment.Left) ' 30% da largura total
            usuListview.Columns.Add("Função", CInt(totalWidth * 0.3), HorizontalAlignment.Left) ' 30%
            Dim obj As New Dao
            Dim retorno As NpgsqlDataReader = Nothing

            obj.conectar()

            Dim sql As New NpgsqlCommand($"select 
                                            ""AS_USUARIO"".""CODUSUARIO"",""AS_USUARIO"".""NOME"",""AS_USUARIO"".""MTRICULA"",""AS_USUARIO"".""DT_REGEISTRO"",""AS_FUNCAO"".""FUNCAO"" 
                                          FROM 
                                            ""AS_USUARIO"" 
                                          INNER JOIN 
                                            ""AS_FUNCAO"" ON ""AS_FUNCAO"".""CODFUNCAO"" = ""AS_USUARIO"".""FUNCAO"" 
                                          ", obj.SQLCNN)
            Dim result As NpgsqlDataReader = sql.ExecuteReader()

            While result.Read()
                Dim item As New ListViewItem(result(0).ToString())
                item.SubItems.Add(result(1).ToString())
                item.SubItems.Add(result(2).ToString())
                item.SubItems.Add(result(3).ToString())
                item.SubItems.Add(result(4).ToString())
                usuListview.Items.Add(item)
            End While

            obj.desconectar()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HomePage.ProximaPagina(HomePage.pnlEscolhaFun)
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Try
            If Me.ListView1.SelectedItems.Count <> 0 Then

                Dim selectedItem As ListViewItem = Me.ListView1.SelectedItems(0)
                Variaveis.codusuario = selectedItem.Text
                AlteraUsuario.Show()

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class