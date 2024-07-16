Public Class HomePage

    Public Sub ProximaPagina(PanelDinamico As Panel)

        Try

            tabEscolhaFun.Location = New Point(0, 0)
            tabEscolhaFun.Controls.Clear()
            tabEscolhaFun.Controls.Add(PanelDinamico)
            PanelDinamico.Location = New Point(0, 0)
            PanelDinamico.Dock = DockStyle.Fill

        Catch ex As Exception

        End Try

    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ProximaPagina(Me.HomeLogo)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btnfuncionario_Click(sender As Object, e As EventArgs) Handles Btnfuncionario.Click
        ProximaPagina(Me.pnlEscolhaFun)
    End Sub
End Class