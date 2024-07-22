Imports Npgsql

Public Class AlteraUsuario
    Private Sub AlteraUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim infoUsu = CarregaInfoUsuario()
            If infoUsu IsNot Nothing Then
                TbNome.Text = infoUsu.Nome
                TbMatricula.Text = infoUsu.Matricula
                TbSenha.Text = infoUsu.Senha
                TbConfirmaSenha.Text = infoUsu.Senha
            End If

            CadastroUsuario.CarregaCombo("select * FROM ""AS_FUNCAO""", Me.ComboBox1)
            Me.ComboBox1.SelectedItem = Me.ComboBox1.Items(infoUsu.Funcao)
        Catch ex As Exception

        End Try

    End Sub
    Public Shared Function CarregaInfoUsuario() As Variaveis.Usuario
        Try
            Dim obj As New Dao
            Dim infousuario As New Variaveis.Usuario

            obj.conectar()

            Dim sql As New NpgsqlCommand($"select 
                                            ""AS_USUARIO"".""CODUSUARIO"",""AS_USUARIO"".""NOME"",""AS_USUARIO"".""MTRICULA"",""AS_USUARIO"".""SENHA"",""AS_USUARIO"".""FUNCAO"" 
                                          FROM 
                                            ""AS_USUARIO"" 
                                          WHERE 
                                            ""AS_USUARIO"".""CODUSUARIO"" = {Variaveis.codusuario}", obj.SQLCNN)
            Dim result As NpgsqlDataReader = sql.ExecuteReader()

            If result.HasRows Then
                While result.Read()

                    infousuario.Nome = result(1).ToString()
                    infousuario.Matricula = result(2).ToString()
                    infousuario.Senha = result(3).ToString()
                    infousuario.Funcao = result(4).ToString()

                End While
            Else
                infousuario = Nothing
            End If


            obj.desconectar()

            Return infousuario
        Catch ex As Exception

        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TbSenha.Text <> TbConfirmaSenha.Text Then
                MsgBox("A senha é diferente do campo confirmar senha!")
                Exit Sub
            End If

            Dim funcionario As New Variaveis.Usuario
            funcionario.Nome = TbNome.Text.ToString
            funcionario.Matricula = TbMatricula.Text.ToString
            funcionario.Senha = TbSenha.Text.ToString
            funcionario.Funcao = Me.ComboBox1.SelectedIndex

            Querys.ExecutaQuerySimples($"update ""AS_USUARIO"" set ""NOME"" = '{funcionario.Nome}',""SENHA"" = '{funcionario.Senha}',""FUNCAO"" = {funcionario.Funcao}, ""MTRICULA"" = '{funcionario.Matricula}' where ""CODUSUARIO"" = {Variaveis.codusuario}")
            MsgBox("Usuário Atualizado com sucesso!")
            Me.Close()
            'AtualizaUsuListiview(Me.usuListview, funcionario.Nome)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub AlteraUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        VizualizarUsuario.AtualizaAllUsuListiview(VizualizarUsuario.ListView1)
    End Sub
End Class