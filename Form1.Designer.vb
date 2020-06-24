<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblFoto = New System.Windows.Forms.Label()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnEncerrar = New System.Windows.Forms.Button()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(29, 29)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(32, 45)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(301, 20)
        Me.txtEmail.TabIndex = 1
        '
        'lblFoto
        '
        Me.lblFoto.AutoSize = True
        Me.lblFoto.Location = New System.Drawing.Point(29, 82)
        Me.lblFoto.Name = "lblFoto"
        Me.lblFoto.Size = New System.Drawing.Size(28, 13)
        Me.lblFoto.TabIndex = 2
        Me.lblFoto.Text = "Foto"
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(32, 99)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(200, 200)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFoto.TabIndex = 3
        Me.picFoto.TabStop = False
        '
        'btnLocalizar
        '
        Me.btnLocalizar.Location = New System.Drawing.Point(238, 99)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(57, 23)
        Me.btnLocalizar.TabIndex = 4
        Me.btnLocalizar.Text = "Localizar"
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(32, 329)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(301, 20)
        Me.txtNome.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nome"
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(32, 375)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(96, 23)
        Me.btnSalvar.TabIndex = 7
        Me.btnSalvar.Text = "Salvar Dados"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnEncerrar
        '
        Me.btnEncerrar.Location = New System.Drawing.Point(237, 375)
        Me.btnEncerrar.Name = "btnEncerrar"
        Me.btnEncerrar.Size = New System.Drawing.Size(96, 23)
        Me.btnEncerrar.TabIndex = 9
        Me.btnEncerrar.Text = "Encerrar"
        Me.btnEncerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 413)
        Me.Controls.Add(Me.btnEncerrar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLocalizar)
        Me.Controls.Add(Me.picFoto)
        Me.Controls.Add(Me.lblFoto)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblFoto As Label
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnLocalizar As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnEncerrar As Button
End Class
