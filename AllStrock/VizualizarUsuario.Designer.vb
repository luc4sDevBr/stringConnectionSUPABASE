<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VizualizarUsuario
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
        Button3 = New Button()
        Panel4 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel2 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Panel3 = New Panel()
        ListView1 = New ListView()
        Panel5 = New Panel()
        MaskedTextBox2 = New MaskedTextBox()
        MaskedTextBox1 = New MaskedTextBox()
        Label3 = New Label()
        Button4 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Panel1 = New Panel()
        Panel4.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel5.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
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
        ' Panel4
        ' 
        Panel4.Controls.Add(Button3)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(3, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(843, 33)
        Panel4.TabIndex = 2
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 38.5159F))
        TableLayoutPanel1.Controls.Add(Panel4, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 0, 2)
        TableLayoutPanel1.Controls.Add(Panel3, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.900208F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 92.09979F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 43F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(849, 540)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 499)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(843, 38)
        Panel2.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Right
        Button2.BackColor = Color.DeepSkyBlue
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(630, 6)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 11
        Button2.Text = "Dashboard"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Right
        Button1.BackColor = Color.LimeGreen
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(730, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 10
        Button1.Text = "Importar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(ListView1)
        Panel3.Controls.Add(Panel5)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(3, 42)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(843, 451)
        Panel3.TabIndex = 4
        ' 
        ' ListView1
        ' 
        ListView1.Dock = DockStyle.Fill
        ListView1.Location = New Point(0, 85)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(843, 366)
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(MaskedTextBox2)
        Panel5.Controls.Add(MaskedTextBox1)
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(Button4)
        Panel5.Controls.Add(TextBox1)
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(Label1)
        Panel5.Controls.Add(DateTimePicker2)
        Panel5.Controls.Add(DateTimePicker1)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(843, 85)
        Panel5.TabIndex = 0
        ' 
        ' MaskedTextBox2
        ' 
        MaskedTextBox2.Anchor = AnchorStyles.Left
        MaskedTextBox2.Location = New Point(147, 29)
        MaskedTextBox2.Mask = "00:00:00"
        MaskedTextBox2.Name = "MaskedTextBox2"
        MaskedTextBox2.Size = New Size(78, 27)
        MaskedTextBox2.TabIndex = 8
        MaskedTextBox2.Text = "000000"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Anchor = AnchorStyles.Left
        MaskedTextBox1.Location = New Point(412, 29)
        MaskedTextBox1.Mask = "00:00:00"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(78, 27)
        MaskedTextBox1.TabIndex = 7
        MaskedTextBox1.Text = "000000"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(544, 6)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 20)
        Label3.TabIndex = 6
        Label3.Text = "Nome ou Matricula"
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Right
        Button4.Location = New Point(800, 29)
        Button4.Name = "Button4"
        Button4.Size = New Size(34, 27)
        Button4.TabIndex = 5
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Right
        TextBox1.Location = New Point(547, 29)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(250, 27)
        TextBox1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(267, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 20)
        Label2.TabIndex = 3
        Label2.Text = "Fim"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(3, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 20)
        Label1.TabIndex = 2
        Label1.Text = "Inicio"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Anchor = AnchorStyles.Left
        DateTimePicker2.Location = New Point(271, 29)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(135, 27)
        DateTimePicker2.TabIndex = 1
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Anchor = AnchorStyles.Left
        DateTimePicker1.Location = New Point(6, 29)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(135, 27)
        DateTimePicker1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(849, 540)
        Panel1.TabIndex = 1
        ' 
        ' VizualizarUsuario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(849, 540)
        Controls.Add(Panel1)
        Name = "VizualizarUsuario"
        Text = "VizualizarUsuario"
        Panel4.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
