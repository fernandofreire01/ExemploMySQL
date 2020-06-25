<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.picImagens = New System.Windows.Forms.PictureBox()
        Me.btnLerImagens = New System.Windows.Forms.Button()
        Me.bckwrk1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.picImagens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picImagens
        '
        Me.picImagens.BackColor = System.Drawing.Color.LightGray
        Me.picImagens.Location = New System.Drawing.Point(50, 50)
        Me.picImagens.Name = "picImagens"
        Me.picImagens.Size = New System.Drawing.Size(266, 254)
        Me.picImagens.TabIndex = 0
        Me.picImagens.TabStop = False
        '
        'btnLerImagens
        '
        Me.btnLerImagens.Location = New System.Drawing.Point(50, 323)
        Me.btnLerImagens.Name = "btnLerImagens"
        Me.btnLerImagens.Size = New System.Drawing.Size(266, 23)
        Me.btnLerImagens.TabIndex = 1
        Me.btnLerImagens.Text = "Acessar Imagens e Exibir Slide Show"
        Me.btnLerImagens.UseVisualStyleBackColor = True
        '
        'bckwrk1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 413)
        Me.Controls.Add(Me.btnLerImagens)
        Me.Controls.Add(Me.picImagens)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Lendo Imagens no MySQL"
        CType(Me.picImagens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picImagens As PictureBox
    Friend WithEvents btnLerImagens As Button
    Friend WithEvents bckwrk1 As System.ComponentModel.BackgroundWorker
End Class
