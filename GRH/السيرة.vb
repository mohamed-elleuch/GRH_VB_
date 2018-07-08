Imports System.Data.SqlClient
Public Class السيرة

    Public cmd As SqlCommand
    Public rq As String
    Public datar As SqlDataReader


    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub السيرة_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox6.TextChanged, TextBox5.TextChanged, TextBox4.TextChanged, TextBox9.TextChanged, TextBox8.TextChanged, TextBox7.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim co As New SqlConnection
        Try
            co.ConnectionString = "Data Source=PC-MARWA\SQLEXPRESS;Initial Catalog=GestionRH;Integrated Security=True"
            co.Open()
        Catch ex As Exception
            MsgBox("Erreur de connexion")
        End Try
        Dim c As String
        c = TextBox1.Text
        rq = "select * from الموظف where الترقيم_الاداري='" & c & "' "
        cmd = New SqlCommand(rq, co)
        Dim dta As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New DataTable

        dta.Fill(ds, "الموظف")
        dt = ds.Tables("الموظف")
        Label5.Text = dt.Rows(0)(3).ToString
        Label6.Text = dt.Rows(0)(4).ToString
        Label10.Text = dt.Rows(0)(8).ToString
        Label12.Text = dt.Rows(0)(9).ToString
        TextBox3.Text = dt.Rows(0)(31).ToString
        Label20.Text = dt.Rows(0)(7).ToString
        Label24.Text = dt.Rows(0)(5).ToString
        Label16.Text = dt.Rows(0)(23).ToString
        Label18.Text = dt.Rows(0)(25).ToString
        Label22.Text = dt.Rows(0)(10).ToString
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim co As New SqlConnection
        Try
            co.ConnectionString = "Data Source=PC-MARWA\SQLEXPRESS;Initial Catalog=GestionRH;Integrated Security=True"
            co.Open()
        Catch ex As Exception
            MsgBox("Erreur de connexion")
        End Try
        Dim c As String
        c = TextBox1.Text
        rq = "select * from الموظف where الترقيم_الاداري='" & c & "' "
        cmd = New SqlCommand(rq, co)
        Dim dta As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New DataTable

        dta.Fill(ds, "الموظف")
        dt = ds.Tables("الموظف")
        TextBox4.Text = dt.Rows(0)(12).ToString
        TextBox5.Text = dt.Rows(0)(13).ToString
        Dim datejour As Date
        datejour = Date.Now
        Dim dat As String
        dat = CStr(datejour)
        Dim an As Integer
        an = CInt(dat.Substring(6, 4))
        Dim rect As String
        rect = Label22.Text
        Dim a, m, j As Integer
        a = CInt(rect.Substring(0, 2))
        m = CInt(rect.Substring(3, 2))
        j = CInt(rect.Substring(6, 4))
        Dim diff, diff1 As Integer
        diff = an - a
        Dim fil, a1 As String
        fil = dt.Rows(0)(21).ToString
        a1 = CInt(fil.Substring(6, 4))
        diff1 = an - a1


        If (diff >= 15) And (diff1 >= 10) Then
            TextBox6.Text = CStr(a + 15) + "-" + CStr(m) + "-" + CStr(j)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim co As New SqlConnection
        Try
            co.ConnectionString = "Data Source=PC-MARWA\SQLEXPRESS;Initial Catalog=GestionRH;Integrated Security=True"
            co.Open()
        Catch ex As Exception
            MsgBox("Erreur de connexion")
        End Try
        Dim c As String
        c = TextBox1.Text
        rq = "select * from الموظف where الترقيم_الاداري='" & c & "' "
        cmd = New SqlCommand(rq, co)
        Dim dta As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New DataTable

        dta.Fill(ds, "الموظف")
        dt = ds.Tables("الموظف")
        TextBox7.Text = dt.Rows(0)(20).ToString
        TextBox8.Text = dt.Rows(0)(21).ToString
        TextBox9.Text = "10"

        Dim prod As String
        prod = dt.Rows(0)(16).ToString
        If (prod.Equals("D")) Then
            If (TextBox7.Text.Equals("C07")) Then
                TextBox7.Text = "C08"
            ElseIf (TextBox7.Text.Equals("C08")) Then
                TextBox7.Text = "C09"
            ElseIf (TextBox7.Text.Equals("C09")) Then
                TextBox7.Text = "C10"
            End If

        End If

        rq = "UPDATE الموظف set قسم الانتاجية='" & TextBox7.Text & "' where الترقيم_الاداري='" & c & "'"
        Dim myCommand As SqlCommand

        myCommand = New SqlCommand(rq, co)
        myCommand.ExecuteNonQuery()
    End Sub
End Class