<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroUsuario
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
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel2 = New Panel()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Button2 = New Button()
        Button1 = New Button()
        TbConfirmaSenha = New TextBox()
        Label4 = New Label()
        TbSenha = New TextBox()
        Label3 = New Label()
        TbMatricula = New TextBox()
        Label2 = New Label()
        TbNome = New TextBox()
        Label1 = New Label()
        Panel3 = New Panel()
        usuListview = New ListView()
        Panel4 = New Panel()
        Button3 = New Button()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(849, 540)
        Panel1.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 38.5159F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 61.4841F))
        TableLayoutPanel1.Controls.Add(Panel2, 0, 1)
        TableLayoutPanel1.Controls.Add(Panel3, 1, 1)
        TableLayoutPanel1.Controls.Add(Panel4, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.900208F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 92.09979F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 43F))
        TableLayoutPanel1.Size = New Size(849, 540)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(TbConfirmaSenha)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(TbSenha)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(TbMatricula)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TbNome)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 42)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(320, 451)
        Panel2.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Location = New Point(9, 148)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 20)
        Label5.TabIndex = 11
        Label5.Text = "Perfil do Usuário"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.None
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(9, 178)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(298, 28)
        ComboBox1.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.BackColor = Color.Coral
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(9, 379)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 9
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.BackColor = Color.LimeGreen
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(213, 379)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 8
        Button1.Text = "Cadastrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TbConfirmaSenha
        ' 
        TbConfirmaSenha.Anchor = AnchorStyles.None
        TbConfirmaSenha.Location = New Point(9, 313)
        TbConfirmaSenha.Name = "TbConfirmaSenha"
        TbConfirmaSenha.Size = New Size(298, 27)
        TbConfirmaSenha.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Location = New Point(9, 283)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 20)
        Label4.TabIndex = 6
        Label4.Text = "Confirmar Senha"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TbSenha
        ' 
        TbSenha.Anchor = AnchorStyles.None
        TbSenha.Location = New Point(9, 246)
        TbSenha.Name = "TbSenha"
        TbSenha.Size = New Size(298, 27)
        TbSenha.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(9, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 4
        Label3.Text = "Senha"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TbMatricula
        ' 
        TbMatricula.Anchor = AnchorStyles.None
        TbMatricula.Location = New Point(9, 111)
        TbMatricula.Name = "TbMatricula"
        TbMatricula.Size = New Size(298, 27)
        TbMatricula.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(9, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 20)
        Label2.TabIndex = 2
        Label2.Text = "Matricula"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TbNome
        ' 
        TbNome.Anchor = AnchorStyles.None
        TbNome.Location = New Point(9, 44)
        TbNome.Name = "TbNome"
        TbNome.Size = New Size(298, 27)
        TbNome.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(9, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nome:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(usuListview)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(329, 42)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(517, 451)
        Panel3.TabIndex = 1
        ' 
        ' usuListview
        ' 
        usuListview.Dock = DockStyle.Fill
        usuListview.Location = New Point(0, 0)
        usuListview.Name = "usuListview"
        usuListview.Size = New Size(517, 451)
        usuListview.TabIndex = 0
        usuListview.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Button3)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(3, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(320, 33)
        Panel4.TabIndex = 2
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(3, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(29, 27)
        Button3.TabIndex = 3
        Button3.Text = "<"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.TextImageRelation = TextImageRelation.TextAboveImage
        Button3.UseVisualStyleBackColor = True
        ' 
        ' CadastroUsuario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(849, 540)
        Controls.Add(Panel1)
        Name = "CadastroUsuario"
        Text = "CadastroUsuario"
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TbSenha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbMatricula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TbConfirmaSenha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents usuListview As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button3 As Button
End Class
