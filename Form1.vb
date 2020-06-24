Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form1
    Dim nomeArquivoImagem As String


    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        Try
            Dim ofd1 As New OpenFileDialog()
            ofd1.Filter = "Imagens | *.jpg"
            If ofd1.ShowDialog() = DialogResult.OK Then
                nomeArquivoImagem = ofd1.FileName
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

                Dim CmdSql As String = "INSERT INTO alunos(nome, email, imagem) VALUES(@Nome, @Email, @Imagem)"
                cmd = New MySqlCommand(CmdSql, con)

                cmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 100)
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar, 150)
                cmd.Parameters.Add("@Imagem", MySqlDbType.Blob)

                cmd.Parameters("@Nome").Value = txtNome.Text
                cmd.Parameters("@Email").Value = txtNome.Text
                cmd.Parameters("@Imagem").Value = DadosImagem

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
                con.Close()
            End If
        End Try
    End Sub

    Private Sub btnEncerrar_Click(sender As Object, e As EventArgs) Handles btnEncerrar.Click
        Form1.ActiveForm.Close()
    End Sub
End Class
