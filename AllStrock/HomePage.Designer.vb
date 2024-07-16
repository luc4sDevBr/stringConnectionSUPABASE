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
        Dim Button5 As Button
        Dim Button4 As Button
        Dim Button3 As Button
        Dim Button2 As Button
        Dim Btnfuncionario As Button
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        tabEscolhaFun = New TabControl()
        HomeLogo = New TabPage()
        pnlEscolhaFun = New TabPage()
        Panel2 = New Panel()
        Panel3 = New Panel()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Btnfuncionario = New Button()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        tabEscolhaFun.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.None
        Button5.BackColor = Color.WhiteSmoke
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(758, 39)
        Button5.Name = "Button5"
        Button5.Size = New Size(117, 101)
        Button5.TabIndex = 4
        Button5.Text = "Lubrificante"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.None
        Button4.BackColor = Color.WhiteSmoke
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(606, 39)
        Button4.Name = "Button4"
        Button4.Size = New Size(117, 101)
        Button4.TabIndex = 3
        Button4.Text = "EPI"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.BackColor = Color.WhiteSmoke
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(454, 39)
        Button3.Name = "Button3"
        Button3.Size = New Size(117, 101)
        Button3.TabIndex = 2
        Button3.Text = "Ferramentas"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.BackColor = Color.WhiteSmoke
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(302, 39)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 101)
        Button2.TabIndex = 1
        Button2.Text = "Máquinas"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Btnfuncionario
        ' 
        Btnfuncionario.Anchor = AnchorStyles.None
        Btnfuncionario.BackColor = Color.WhiteSmoke
        Btnfuncionario.FlatAppearance.BorderSize = 0
        Btnfuncionario.FlatStyle = FlatStyle.Flat
        Btnfuncionario.Location = New Point(150, 39)
        Btnfuncionario.Name = "Btnfuncionario"
        Btnfuncionario.Size = New Size(117, 101)
        Btnfuncionario.TabIndex = 0
        Btnfuncionario.Text = "Funcionários"
        Btnfuncionario.UseVisualStyleBackColor = False
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
        Panel1.Controls.Add(tabEscolhaFun)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 222)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1003, 633)
        Panel1.TabIndex = 0
        ' 
        ' tabEscolhaFun
        ' 
        tabEscolhaFun.Controls.Add(HomeLogo)
        tabEscolhaFun.Controls.Add(pnlEscolhaFun)
        tabEscolhaFun.Dock = DockStyle.Fill
        tabEscolhaFun.Location = New Point(0, 0)
        tabEscolhaFun.Name = "tabEscolhaFun"
        tabEscolhaFun.SelectedIndex = 0
        tabEscolhaFun.Size = New Size(1003, 633)
        tabEscolhaFun.TabIndex = 0
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
        pnlEscolhaFun.Location = New Point(4, 29)
        pnlEscolhaFun.Name = "pnlEscolhaFun"
        pnlEscolhaFun.Padding = New Padding(3)
        pnlEscolhaFun.Size = New Size(995, 600)
        pnlEscolhaFun.TabIndex = 1
        pnlEscolhaFun.Text = "Selecione Operação"
        pnlEscolhaFun.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Btnfuncionario)
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1003, 183)
        Panel2.TabIndex = 1
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
        tabEscolhaFun.ResumeLayout(False)
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
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Btnfuncionario As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tabEscolhaFun As TabControl
    Friend WithEvents HomeLogo As TabPage
    Friend WithEvents pnlEscolhaFun As TabPage
End Class
