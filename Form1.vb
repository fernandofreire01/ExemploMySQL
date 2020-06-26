'Exemplo retirado de:
'Link: https://www.portugal-a-programar.pt/forums/topic/61445-mostrar-valor-dos-pontos-do-gr%C3%A1fico/

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Definindo variável List do tipo String
        Dim lstPersons As New List(Of String)
        'Adicionado dados para a List Persons
        lstPersons.AddRange(New String() {"Bob", "Mary", "Greg", "Rachel"})
        'Definindo variável List do tipo String
        Dim lstSales As New List(Of Integer)
        'Adicionado dados para a List Sales
        lstSales.AddRange(New Integer() {10, 5, 20, 15}.ToList)

        'Adicionando os dados em pontos no gráfico
        Chart1.Series(0).Points.DataBindXY(lstPersons, lstSales)
        'Usado para mostrar as info de cada ponto ao passar o mouse pelo o ponto do gráfico
        Chart1.Series(0).ToolTip = "SalesPerson = #VALX" & vbCrLf & "Sales = #VALY{C}"
    End Sub
End Class
