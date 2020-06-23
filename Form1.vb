Imports MySql.Data.MySqlClient
Public Class Form1
    Private conexao As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Try
            conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123123;")

            strSQL = "INSERT INTO CAD_CLIENTE (NOME, NUMERO) VALUES (@NOME, @NUMERO)"

            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@NOME", txtNome.Text)
            comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text)

            conexao.Open()
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123123;")

            strSQL = "UPDATE CAD_CLIENTE SET NOME = @NOME, NUMERO = @NUMERO WHERE ID = @ID"

            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@ID", txtID.Text)
            comando.Parameters.AddWithValue("@NOME", txtNome.Text)
            comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text)

            conexao.Open()
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123123;")

            strSQL = "DELETE FROM CAD_CLIENTE WHERE ID = @ID"

            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@ID", txtID.Text)

            conexao.Open()
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123123;")

            strSQL = "SELECT * FROM CAD_CLIENTE WHERE ID = @ID"

            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@ID", txtID.Text)

            conexao.Open()
            dr = comando.ExecuteReader()
            Do While dr.Read
                txtNome.Text = dr("nome")
                txtNumero.Text = dr("numero")
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Try
            conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123123;")

            strSQL = "SELECT * FROM CAD_CLIENTE"

            Dim dt As New DataTable

            da = New MySqlDataAdapter(strSQL, conexao)

            da.Fill(dt)

            dgvDados.DataSource = dt



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtID.Text = ""
        txtNome.Text = ""
        txtNumero.Text = ""
    End Sub
End Class
