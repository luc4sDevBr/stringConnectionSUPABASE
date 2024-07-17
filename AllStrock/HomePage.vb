Public Class HomePage

    Public Sub ProximaPagina(PanelDinamico As Panel)

        Try

            tabEscolhaEPI.Location = New Point(0, 0)
            tabEscolhaEPI.Controls.Clear()
            tabEscolhaEPI.Controls.Add(PanelDinamico)
            PanelDinamico.Location = New Point(0, 0)
            PanelDinamico.Dock = DockStyle.Fill

        Catch ex As Exception

        End Try

    End Sub

    Public Sub AddFormDinamico(FormDinamico As Form)

        Try
            FormDinamico.TopLevel = False
            tabEscolhaEPI.Location = New Point(0, 0)
            tabEscolhaEPI.Controls.Clear()
            tabEscolhaEPI.Controls.Add(FormDinamico)
            FormDinamico.Location = New Point(0, 0)
            FormDinamico.Dock = DockStyle.Fill

        Catch ex As Exception

        End Try

    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ProximaPagina(Me.HomeLogo)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonFuncionario.Click
        ProximaPagina(pnlEscolhaFun)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ProximaPagina(pnlEscolhaMaq)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProximaPagina(tabEscolhaFerr)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ProximaPagina(PnlEscolhaEPI)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ProximaPagina(PnlEscolhaLub)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ProximaPagina(TabForm)

        Dim frm2 As New CadastroUsuario
        frm2.TopLevel = False
        frm2.FormBorderStyle = FormBorderStyle.None
        Me.TabForm.Controls.Add(frm2)
        frm2.Dock = DockStyle.Fill
        frm2.Show()

    End Sub
End Class