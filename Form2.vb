Imports System.Windows.Forms.DataVisualization.Charting

'Exemplo retirado de:
'https://social.msdn.microsoft.com/Forums/vstudio/en-US/d123e08b-21a1-4c21-911b-4736b3337ed6/how-to-insert-image-in-chart?forum=vbgeneral
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Series.Clear()

        With Chart1.ChartAreas(0)
            .AxisX.Interval = 2
            ' Adiciona linha de grade no gráfico - interessante
            .AxisX.MajorGrid.LineColor = Color.LightGray
            .AxisX.Minimum = 0
            .AxisX.Maximum = 10
            .AxisX.Title = "X Axis"

            .AxisY.Interval = 2
            .AxisY.Minimum = -10
            .AxisY.Maximum = 10
            .AxisY.Title = "Y Axis"

            Chart1.Series.Clear()
            Chart1.Series.Add("")

            With Chart1.Series(0)
                ' Para não mostrar a legenda superior direita
                .IsVisibleInLegend = False
                'criação do gráfico com os dados
                For m = 1 To 9
                    .Points.AddXY(m, m)
                Next
            End With
        End With

    End Sub

    ' Após gerar o gráfico
    Private Sub Chart1_PostPaint(sender As Object, e As ChartPaintEventArgs) Handles Chart1.PostPaint

        Dim x As Single = CSng(e.ChartGraphics.GetPositionFromAxis(Chart1.ChartAreas(0).Name, AxisName.X, 0))
        Dim y As Single = CSng(e.ChartGraphics.GetPositionFromAxis(Chart1.ChartAreas(0).Name, AxisName.Y, 0))

        'Converte para o model
        Dim point1 As PointF = New Point(x, y)
        point1 = e.ChartGraphics.GetAbsolutePoint(point1)

        ' Adicioanr a imagem no ponto
        Dim bmp As Bitmap = New Bitmap("c:\bitmaps\gif_test.gif")
        Dim destRect As Rectangle = New Rectangle(point1.X, point1.Y - 100, 100, 100)
        Dim sourceRect As Rectangle = New Rectangle(0, 0, bmp.Width, bmp.Height)
        e.ChartGraphics.Graphics.DrawImage(bmp, destRect, sourceRect, GraphicsUnit.Pixel)

    End Sub

End Class