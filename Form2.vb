Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Threading

Public Class Form2
    Private Sub btnLerImagens_Click(sender As Object, e As EventArgs) Handles btnLerImagens.Click
        GetImagens()
    End Sub

    Private Sub GetImagens()
        'Throw New NotImplementedException()
        Dim _conexaoMySQL As String = "server=localhost;user id=root;password=123123;database=escola"

        Dim con As MySqlConnection = New MySqlConnection(_conexaoMySQL)
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader

        Dim AlunoId As Integer
        Dim cmdSQL As String = "SELECT id, imagem FROM alunos"

        Dim fs As FileStream
        Dim bw As BinaryWriter
        Dim TamanhoBuffer As Integer = 1024

        'Os Arrays em VB.NET contam elementos a partir do 0(lower bound) até um dado tamanho(upper bound).
        'Logo para declarar um array de 1024 elements seu tamanho deve ser de 1023
        Dim DadosImagem(TamanhoBuffer - 1) As Byte
        Dim nBytesRetornados, IndiceInicio As Long

        Try
            cmd = New MySqlCommand(cmdSQL, con)
            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess)

            If (Directory.Exists("Imagens") = False) Then
                Directory.CreateDirectory("Imagens")
            End If

            While (reader.Read())
                AlunoId = reader.GetInt32("id")
                fs = New FileStream("Imagens/Imagem_" + AlunoId.ToString() + ".jpg", FileMode.OpenOrCreate, FileAccess.Write)
                bw = New BinaryWriter(fs)

                IndiceInicio = 0
                nBytesRetornados = reader.GetBytes(1, IndiceInicio, DadosImagem, 0, TamanhoBuffer)

                While (nBytesRetornados = TamanhoBuffer)
                    bw.Write(DadosImagem)
                    bw.Flush()
                    IndiceInicio += TamanhoBuffer
                    nBytesRetornados = reader.GetBytes(1, IndiceInicio, DadosImagem, 0, TamanhoBuffer)
                End While
                bw.Close()
                fs.Close()
            End While

            reader.Close()
            con.Close()
            bckwrk1.RunWorkerAsync()

        Catch ex As Exception
            MessageBox.Show("Erro : " & ex.Message)
        End Try
    End Sub

    Private Sub bckwrk1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bckwrk1.DoWork
        For Each img As String In Directory.GetFiles("Imagens")
            picImagens.BackColor = Color.Transparent 'Adicionei esse tratamento, para o fundo do local que será exibido a imagem
            picImagens.BackgroundImage = Image.FromFile(img)
            picImagens.BackgroundImageLayout = ImageLayout.Zoom
            Thread.Sleep(1000)
        Next
    End Sub

    Private Sub bckwrk1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bckwrk1.RunWorkerCompleted
        bckwrk1.RunWorkerAsync()
    End Sub
End Class