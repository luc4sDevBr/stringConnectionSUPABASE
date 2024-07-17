Imports Npgsql

Public Class CadastroUsuario
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

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

            Dim objN As New Dao


            objN.conectar()
            '"select * FROM ""AS_FUNCAO"""
            Dim sql As New NpgsqlCommand($"select * FROM ""AS_USUARIO"" where ""NOME"" = '{funcionario.Nome}'", objN.SQLCNN)
            Dim newresult As NpgsqlDataReader = sql.ExecuteReader()

            If newresult.HasRows() Then
                MsgBox("Este nome de usuario ja existe na base!")
                objN.desconectar()
                Exit Sub
            End If

            objN.desconectar()

            Querys.ExecutaQuerySimples($"insert into 
                                            ""AS_USUARIO"" (""NOME"",""SENHA"",""HABILITADO"",""DT_REGEISTRO"",""FUNCAO"",""MTRICULA"") 
                                        values 
                                            ('{funcionario.Nome}','{funcionario.Senha}',1,current_timestamp,{funcionario.Funcao},'{funcionario.Matricula}');")
            MsgBox("Usuário inserido com sucesso!")
            AtualizaUsuListiview(Me.usuListview, funcionario.Nome)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CadastroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CarregaCombo("select * FROM ""AS_FUNCAO""", Me.ComboBox1)
            ComboBox1.SelectedItem = ComboBox1.Items(0)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub CarregaCombo(Query As String, Combo As ComboBox)
        Try
            Dim obj As New Dao
            Dim retorno As NpgsqlDataReader = Nothing

            obj.conectar()
            '"select * FROM ""AS_FUNCAO"""
            Dim sql As New NpgsqlCommand(Query, obj.SQLCNN)
            Dim result As NpgsqlDataReader = sql.ExecuteReader()

            Combo.Items.Clear()
            Combo.Items.Add("<-- -->")


            While result.Read()
                Combo.Items.Add(result(1).ToString())
            End While

            obj.desconectar()

        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub AtualizaUsuListiview(usuListview, NOMEUSU)
        Try
            ' Configura o ListView
            usuListview.View = View.Details
            usuListview.FullRowSelect = True
            usuListview.GridLines = False

            ' Adiciona colunas ao ListView
            usuListview.Columns.Add("#", 50, HorizontalAlignment.Left)
            usuListview.Columns.Add("Nome", 100, HorizontalAlignment.Left)
            usuListview.Columns.Add("Matricula", 100, HorizontalAlignment.Left)
            usuListview.Columns.Add("Data Registro", 100, HorizontalAlignment.Left)
            usuListview.Columns.Add("Função", 100, HorizontalAlignment.Left)

            Dim obj As New Dao
            Dim retorno As NpgsqlDataReader = Nothing

            obj.conectar()

            Dim sql As New NpgsqlCommand($"select 
                                            ""AS_USUARIO"".""CODUSUARIO"",""AS_USUARIO"".""NOME"",""AS_USUARIO"".""MTRICULA"",""AS_USUARIO"".""DT_REGEISTRO"",""AS_FUNCAO"".""FUNCAO"" 
                                          FROM 
                                            ""AS_USUARIO"" 
                                          INNER JOIN 
                                            ""AS_FUNCAO"" ON ""AS_FUNCAO"".""CODFUNCAO"" = ""AS_USUARIO"".""FUNCAO"" 
                                          WHERE ""NOME"" = '{NOMEUSU}'", obj.SQLCNN)
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
End Class