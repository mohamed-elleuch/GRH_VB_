Imports System.Data.SqlClient

Public Class عرض_العطل
    Public cmd As SqlCommand
    Public rq As String
    Public datar As SqlDataReader

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DataGridView1.Visible = False


        Dim co As New SqlConnection
        Try
            co.ConnectionString = "Data Source=PC-MARWA\SQLEXPRESS;Initial Catalog=GestionRH;Integrated Security=True"
            co.Open()
            MsgBox("okkkk")
        Catch ex As Exception
            MsgBox("Erreur de connexion")
        End Try

        If (TextBox2.Text = "") And (ComboBox1.SelectedItem.ToString() = "") Then
            MsgBox("Entrer critères de recherche")
        ElseIf (Not (TextBox2.Text = "")) And (ComboBox1.SelectedItem.ToString() = "") Then
            rq = "select * from العطلة where الترقيم_الاداري= '" & TextBox2.Text & "' "

        ElseIf (TextBox2.Text = "") And (Not (ComboBox1.SelectedItem.ToString() = "")) Then
            rq = "select * from الموظف,العطلة where الترقيم_الاداري.الموظف=الترقيم_الاداري.العطلة and المصلحة.الموظف='" & ComboBox1.SelectedItem.ToString() & "' "

        ElseIf (Not (TextBox2.Text = "")) And (Not (ComboBox1.SelectedItem.ToString() = "")) Then
            rq = "select * from الموظف,العطلة where الترقيم_الاداري.الموظف=الترقيم_الاداري.العطلة and المصلحة.الموظف='" & ComboBox1.SelectedItem.ToString() & "' and الترقيم_الاداري= '" & TextBox2.Text & "' "

        End If
        cmd = New SqlCommand(rq, co)
        Dim dta As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New DataTable

        dta.Fill(ds, "العطلة")
        dta.Fill(ds, "الموظف")
        dt = ds.Tables("العطلة")
        Dim c As Integer
        c = dt.Rows.Count() - 1

        For i As Integer = 0 To c

            DataGridView1.Rows.Add(dt.Rows(i).ToString())
        Next
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub عرض_العطل_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet2.العطلة'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.العطلةTableAdapter.Fill(Me.DataSet2.العطلة)
        Dim co As New SqlConnection
        Try
            co.ConnectionString = "Data Source=PC-MARWA\SQLEXPRESS;Initial Catalog=GestionRH;Integrated Security=True"
            co.Open()
        Catch ex As Exception
            MsgBox("Erreur de connexion")
        End Try

        rq = "select * from الموظف"
        cmd = New SqlCommand(rq, co)
        Dim dta As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New DataTable

        dta.Fill(ds, "الموظف")
        dt = ds.Tables("الموظف")
        Dim c As Integer
        c = dt.Rows.Count() - 1

        For i As Integer = 0 To c

            ComboBox1.Items.Add(dt.Rows(i)(2).ToString())
        Next



        co.Close()
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub
End Class