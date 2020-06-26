Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form1
    'Variável que guarda a string do nome da imagem que será salva no diretório local
    Dim nomeArquivoImagem As String


    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        'Método para procurar a imageno no computador e exibir em seguida na área de reservada para exibir a imagem selecionada
        Try
            Dim ofd1 As New OpenFileDialog()
            'ofd1.Filter = "Imagens |*.jpg" 'comando do exemplo
            ofd1.Filter = "*.jpg|*.jpg|*.png |*.png" 'Comando ajustado para abrir dois tipos imagens
            If ofd1.ShowDialog() = DialogResult.OK Then
                nomeArquivoImagem = ofd1.FileName
                picFoto.BackColor = Color.Transparent 'Adicionei esse tratamento para o fundo do local que será exibido a imagem
                picFoto.Image = Image.FromFile(ofd1.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        'Dim _conexaoMySQL As String = "Server=localhost;Database=escola;Uid=root;Pwd=123123;"
        Dim _conexaoMySQL As String = "server=localhost;user id=root;password=123123;database=escola"

        Dim con As MySqlConnection = New MySqlConnection(_conexaoMySQL)
        Dim cmd As MySqlCommand
        Dim fs As FileStream
        Dim br As BinaryReader

        Try
            If txtNome.Text.Length > 0 And txtEmail.Text.Length > 0 Then
                Dim NomeArquivoFoto As String = nomeArquivoImagem
                Dim DadosImagem() As Byte

                fs = New FileStream(NomeArquivoFoto, FileMode.Open, FileAccess.Read)
                br = New BinaryReader(fs)
                DadosImagem = br.ReadBytes(CType(fs.Length, Integer))
                br.Close()
                fs.Close()

                'Declarando variável e inserido uma string com o comando de inserir dados no banco de dados
                Dim CmdSql As String = "INSERT INTO alunos(nome, email, imagem) VALUES(@Nome, @Email, @Imagem)"
                cmd = New MySqlCommand(CmdSql, con)

                'Não sei direito o que é isso
                cmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 100)
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar, 150)
                cmd.Parameters.Add("@Imagem", MySqlDbType.Blob)

                'Adicionando valor dos campos do form no parâmetros para colocar na string do insert do banco de dados
                cmd.Parameters("@Nome").Value = txtNome.Text
                cmd.Parameters("@Email").Value = txtEmail.Text
                cmd.Parameters("@Imagem").Value = DadosImagem

                'Abrindo conexão
                con.Open()

                Dim linhasAfetadas As Integer = cmd.ExecuteNonQuery()

                If (linhasAfetadas > 0) Then
                    MessageBox.Show("A imagem foi salva com sucesso !", "Salvar Imagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Dados incompletos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            If con.State = ConnectionState.Open Then
                'Fechando conexão
                con.Close()
            End If
        End Try
    End Sub

    Private Sub btnEncerrar_Click(sender As Object, e As EventArgs) Handles btnEncerrar.Click
        'Fechando form (janela)
        Form1.ActiveForm.Close()
    End Sub

    Private Sub btnVerImagens_Click(sender As Object, e As EventArgs) Handles btnVerImagens.Click
        'Chamando form (janela) para exibir imagens do db
        My.Forms.Form2.Show()
    End Sub
End Class
