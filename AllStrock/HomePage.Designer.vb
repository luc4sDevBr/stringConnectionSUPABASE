<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        tabEscolhaEPI = New TabControl()
        HomeLogo = New TabPage()
        pnlEscolhaFun = New TabPage()
        Button6 = New Button()
        Button5 = New Button()
        pnlEscolhaMaq = New TabPage()
        tabEscolhaFerr = New TabPage()
        PnlEscolhaEPI = New TabPage()
        PnlEscolhaLub = New TabPage()
        TabForm = New TabPage()
        Panel2 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        buttonFuncionario = New Button()
        Panel3 = New Panel()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        tabEscolhaEPI.SuspendLayout()
        pnlEscolhaFun.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.WhiteSmoke
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Panel1, 0, 2)
        TableLayoutPanel1.Controls.Add(Panel2, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel3, 0, 3)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80.14343F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 639F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 19.8565712F))
        TableLayoutPanel1.Size = New Size(1009, 905)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(tabEscolhaEPI)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 222)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1003, 633)
        Panel1.TabIndex = 0
        ' 
        ' tabEscolhaEPI
        ' 
        tabEscolhaEPI.Controls.Add(HomeLogo)
        tabEscolhaEPI.Controls.Add(pnlEscolhaFun)
        tabEscolhaEPI.Controls.Add(pnlEscolhaMaq)
        tabEscolhaEPI.Controls.Add(tabEscolhaFerr)
        tabEscolhaEPI.Controls.Add(PnlEscolhaEPI)
        tabEscolhaEPI.Controls.Add(PnlEscolhaLub)
        tabEscolhaEPI.Controls.Add(TabForm)
        tabEscolhaEPI.Dock = DockStyle.Fill
        tabEscolhaEPI.Location = New Point(0, 0)
        tabEscolhaEPI.Name = "tabEscolhaEPI"
        tabEscolhaEPI.SelectedIndex = 0
        tabEscolhaEPI.Size = New Size(1003, 633)
        tabEscolhaEPI.TabIndex = 0
        ' 
        ' HomeLogo
        ' 
        HomeLogo.Location = New Point(4, 29)
        HomeLogo.Name = "HomeLogo"
        HomeLogo.Padding = New Padding(3)
        HomeLogo.Size = New Size(995, 600)
        HomeLogo.TabIndex = 0
        HomeLogo.Text = "HomeLogo"
        HomeLogo.UseVisualStyleBackColor = True
        ' 
        ' pnlEscolhaFun
        ' 
        pnlEscolhaFun.Controls.Add(Button6)
        pnlEscolhaFun.Controls.Add(Button5)
        pnlEscolhaFun.Location = New Point(4, 29)
        pnlEscolhaFun.Name = "pnlEscolhaFun"
        pnlEscolhaFun.Padding = New Padding(3)
        pnlEscolhaFun.Size = New Size(995, 600)
        pnlEscolhaFun.TabIndex = 1
        pnlEscolhaFun.Text = "Selecione Operação"
        pnlEscolhaFun.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Anchor = AnchorStyles.None
        Button6.BackColor = Color.WhiteSmoke
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = Color.Silver
        Button6.FlatAppearance.MouseOverBackColor = Color.Gainsboro
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI Light", 16.2F)
        Button6.ForeColor = Color.Black
        Button6.Location = New Point(592, 67)
        Button6.Name = "Button6"
        Button6.Size = New Size(287, 234)
        Button6.TabIndex = 11
        Button6.Text = "Cadastrar Usuário"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.None
        Button5.BackColor = Color.WhiteSmoke
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseDownBackColor = Color.Silver
        Button5.FlatAppearance.MouseOverBackColor = Color.Gainsboro
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI Light", 16.2F)
        Button5.ForeColor = Color.Black
        Button5.Location = New Point(105, 67)
        Button5.Name = "Button5"
        Button5.Size = New Size(287, 234)
        Button5.TabIndex = 10
        Button5.Text = "Vizualizar Usuários"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' pnlEscolhaMaq
        ' 
        pnlEscolhaMaq.Location = New Point(4, 29)
        pnlEscolhaMaq.Name = "pnlEscolhaMaq"
        pnlEscolhaMaq.Padding = New Padding(3)
        pnlEscolhaMaq.Size = New Size(995, 600)
        pnlEscolhaMaq.TabIndex = 2
        pnlEscolhaMaq.Text = "Selecione o tipo de Máquina"
        pnlEscolhaMaq.UseVisualStyleBackColor = True
        ' 
        ' tabEscolhaFerr
        ' 
        tabEscolhaFerr.Location = New Point(4, 29)
        tabEscolhaFerr.Name = "tabEscolhaFerr"
        tabEscolhaFerr.Padding = New Padding(3)
        tabEscolhaFerr.Size = New Size(995, 600)
        tabEscolhaFerr.TabIndex = 3
        tabEscolhaFerr.Text = "Ferramentas"
        tabEscolhaFerr.UseVisualStyleBackColor = True
        ' 
        ' PnlEscolhaEPI
        ' 
        PnlEscolhaEPI.Location = New Point(4, 29)
        PnlEscolhaEPI.Name = "PnlEscolhaEPI"
        PnlEscolhaEPI.Padding = New Padding(3)
        PnlEscolhaEPI.Size = New Size(995, 600)
        PnlEscolhaEPI.TabIndex = 4
        PnlEscolhaEPI.Text = "EPI"
        PnlEscolhaEPI.UseVisualStyleBackColor = True
        ' 
        ' PnlEscolhaLub
        ' 
        PnlEscolhaLub.Location = New Point(4, 29)
        PnlEscolhaLub.Name = "PnlEscolhaLub"
        PnlEscolhaLub.Padding = New Padding(3)
        PnlEscolhaLub.Size = New Size(995, 600)
        PnlEscolhaLub.TabIndex = 5
        PnlEscolhaLub.Text = "Lubrificantes"
        PnlEscolhaLub.UseVisualStyleBackColor = True
        ' 
        ' TabForm
        ' 
        TabForm.Location = New Point(4, 29)
        TabForm.Name = "TabForm"
        TabForm.Padding = New Padding(3)
        TabForm.Size = New Size(995, 600)
        TabForm.TabIndex = 6
        TabForm.Text = "Formulário"
        TabForm.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(buttonFuncionario)
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1003, 183)
        Panel2.TabIndex = 1
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.None
        Button4.BackColor = Color.WhiteSmoke
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(766, 39)
        Button4.Name = "Button4"
        Button4.Size = New Size(117, 101)
        Button4.TabIndex = 9
        Button4.Text = "Lubrificantes"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.BackColor = Color.WhiteSmoke
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(612, 39)
        Button3.Name = "Button3"
        Button3.Size = New Size(117, 101)
        Button3.TabIndex = 8
        Button3.Text = "EPI"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.BackColor = Color.WhiteSmoke
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(458, 39)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 101)
        Button2.TabIndex = 7
        Button2.Text = "Ferramentas"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.BackColor = Color.WhiteSmoke
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(304, 39)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 101)
        Button1.TabIndex = 6
        Button1.Text = "Maquinas"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' buttonFuncionario
        ' 
        buttonFuncionario.Anchor = AnchorStyles.None
        buttonFuncionario.BackColor = Color.WhiteSmoke
        buttonFuncionario.FlatAppearance.BorderSize = 0
        buttonFuncionario.FlatStyle = FlatStyle.Flat
        buttonFuncionario.Location = New Point(150, 39)
        buttonFuncionario.Name = "buttonFuncionario"
        buttonFuncionario.Size = New Size(117, 101)
        buttonFuncionario.TabIndex = 5
        buttonFuncionario.Text = "Funcionários"
        buttonFuncionario.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(StatusStrip1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(3, 861)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1003, 41)
        Panel3.TabIndex = 2
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 15)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1003, 26)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(101, 20)
        ToolStripStatusLabel1.Text = "Versão: 0.0.0.0"
        ' 
        ' HomePage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1009, 905)
        Controls.Add(TableLayoutPanel1)
        Name = "HomePage"
        Text = "HomePage"
        TopMost = True
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        tabEscolhaEPI.ResumeLayout(False)
        pnlEscolhaFun.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tabEscolhaEPI As TabControl
    Friend WithEvents HomeLogo As TabPage
    Friend WithEvents pnlEscolhaFun As TabPage
    Friend WithEvents buttonFuncionario As Button
    Friend WithEvents pnlEscolhaMaq As TabPage
    Friend WithEvents tabEscolhaFerr As TabPage
    Friend WithEvents PnlEscolhaEPI As TabPage
    Friend WithEvents PnlEscolhaLub As TabPage
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TabForm As TabPage
End Class
