Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Public Class statistique
    Public cmd As SqlCommand
    Public rq As String
    Public datar As SqlDataReader

    Public Sub chargerreader(ByRef rq, ByRef dr)
        Try

           

        Catch ex As Exception
            MsgBox("Erreur dans le reader")
        End Try
    End Sub

    Private Sub statistique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'GestionRHDataSet.العطلة'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.العطلةTableAdapter.Fill(Me.GestionRHDataSet.العطلة)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Chart2 As New Chart
        'Il ne contient rien

        ' Créer ChartArea (zone graphique)
        Dim ChartArea1 As New ChartArea()
        ' Ajouter le  Chart Area à la Collection ChartAreas du  Chart
        Chart2.ChartAreas.Add(ChartArea1)

        ' Créer deux  data series (qui contiendront les DataPoint)
        Dim series1 As New Series()
        Dim series2 As New Series()




        Dim dr As SqlDataReader()
        Dim co As New SqlConnection
        Try
            co.ConnectionString = "Data Source=PC-MARWA\SQLEXPRESS;Initial Catalog=GestionRH;Integrated Security=True"
            co.Open()
        Catch ex As Exception
            MsgBox("Erreur de connexion")
        End Try
        Dim m As String
        m = TextBox1.Text

        rq = "select * from العطلة where السنة='" & m & "' "
        cmd = New SqlCommand(rq, co)
        Dim dta As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New DataTable

        dta.Fill(ds, "العطلة")
        dt = ds.Tables("العطلة")
        Dim c As Integer
        c = dt.Rows.Count() - 1

        For i As Integer = 0 To c
            ' Ajouter des points à la collections Points de la première series
            series1.Points.Add(dt.Rows(i)(0).ToString())


            ' Ajouter des points à la collection Points de la seconde series
            series2.Points.Add(dt.Rows(i)(7).ToString())


        Next

        'On indique d'afficher ces Series sur le ChartArea1
        series1.ChartArea = "ChartArea1"
        series2.ChartArea = "ChartArea1"

        ' Ajouter les series à la collection Series du chart
        Chart2.Series.Add(series1)
        Chart2.Series.Add(series2)

        ' Positionner le controle Chart
        Chart2.Location = New System.Drawing.Point(55, 95)

        ' Dimensionner le Chart
        Chart2.Size = New System.Drawing.Size(800, 500)

        ' Ajouter le chart à la form
        Me.Controls.Add(Chart2)

    End Sub
End Class