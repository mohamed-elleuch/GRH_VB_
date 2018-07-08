Imports System.Data.SqlClient
Imports System.Configuration

Public Class العطل
    Dim MyConnection As SqlConnection
    Public cmd As SqlCommand
    Public rq As String

   

    Private Sub العطلToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim f3 As New العطل
        f3.Show()
    End Sub

    

    Private Sub موظفينToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim f1 As New موظفين
        f1.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        '  Dim c As New المصادقة
        '   c.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        'Dim ce As New الصفحة_الرئيسية
        ' ce.Show()
    End Sub
    Private Sub ajoute_conge_Click(sender As Object, e As EventArgs) Handles ajoute_conge.Click




    



    End Sub
    Private Sub affichage_Click(sender As Object, e As EventArgs) Handles affichage.Click
        عرض_العطل.Show()

    End Sub

    Private Function annee() As Object
        Throw New NotImplementedException
    End Function

    Private Function date_comme() As Object
        Throw New NotImplementedException
    End Function

    Private Function nature() As Object
        Throw New NotImplementedException
    End Function

    Private Function Response() As Object
        Throw New NotImplementedException
    End Function

    Private Sub VALUES(p1 As Object, p2 As Object, p3 As Object, p4 As Object, p5 As Object, p6 As Object, p7 As Object, p8 As Object, p9 As Object)
        Throw New NotImplementedException
    End Sub

    Private Sub ajouter1_Click(sender As Object, e As EventArgs) Handles ajouter.Click
        Dim ch As String
        If (RadioButton1.Checked = True) Then
            ch = "عطلة إستثنائية"
        ElseIf (RadioButton2.Checked = True) Then
            ch = "عطلة مرضية"
        ElseIf (RadioButton3.Checked = True) Then
            ch = "عطلة الأمومة"
        ElseIf (RadioButton4.Checked = True) Then
            ch = "عطلة سنوية"
        ElseIf (RadioButton5.Checked = True) Then
            ch = "ترخيص بالخروج"
        End If
        Dim req As String
        Dim MyConnection As New SqlConnection
        Try
            MyConnection.ConnectionString = "Data Source=PC-MARWA\SQLEXPRESS;Initial Catalog=GestionRH;Integrated Security=True"
            MyConnection.Open()
            MsgBox("okkkk")
        Catch ex As Exception
            MsgBox("Erreur de connexion")
        End Try
        Dim myCommand As SqlCommand


        req = "insert into العطلة values (@id_conge,@num_emp,@anne,@date_debut,@date_fin,@date_reprise,@enregistre,@duree);"
        myCommand = New SqlCommand(req, MyConnection)
        myCommand.Parameters.Add(New SqlParameter("@id_conge", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@id_conge").Value = ch
        myCommand.Parameters.Add(New SqlParameter("@num_emp", SqlDbType.Int))
        myCommand.Parameters("@num_emp").Value = CInt(num.Text)
        myCommand.Parameters.Add(New SqlParameter("@anne", SqlDbType.Date, 31))
        myCommand.Parameters("@anne").Value = anne.Value.Date
        myCommand.Parameters.Add(New SqlParameter("@date_debut", SqlDbType.Date, 31))
        myCommand.Parameters("@date_debut ").Value = date_debut.Value.Date
        myCommand.Parameters.Add(New SqlParameter("@date_fin", SqlDbType.Date, 31))
        myCommand.Parameters("@date_fin ").Value = date_fin.Value.Date
        myCommand.Parameters.Add(New SqlParameter("@date_reprise", SqlDbType.Date, 31))
        myCommand.Parameters("@date_reprise ").Value = date_reprise.Text
        myCommand.Parameters.Add(New SqlParameter("@enregistre", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@enregistre").Value = enregistre.Text
        myCommand.Parameters.Add(New SqlParameter("@duree", SqlDbType.Int))
        myCommand.Parameters("@duree ").Value = CInt(duree.Text)

        myCommand.ExecuteNonQuery()

        MyConnection.Close()

    End Sub

    Sub Page_Load(Src As Object, e As EventArgs)


    End Sub
    
    
  

   

   

    Private Sub Button25_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    
    Private Sub RadioButton5_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

        Label13.Visible = False
        DROIT.Visible = False
        تغيب.Text = "فـــترة التغيب بالساعات"
        SORTE.Visible = True
        SORTEE.Visible = True
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label13.Visible = False
        DROIT.Visible = False
        تغيب.Text = "فـــترة التغيب بالأيام"
        SORTE.Visible = False
        SORTEE.Visible = False
    End Sub

    Private Sub RadioButton4_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        DROIT.Text = CInt(30)
        Label13.Text = "الحـــــق السنــوي"
        تغيب.Text = "فــترة التغيب بالأيام"
        Label13.Visible = True
        DROIT.Visible = True
        SORTE.Visible = False
        SORTEE.Visible = False
    End Sub

    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        DROIT.Text = CInt(60)
        Label13.Text = " حـــــــق الأمــومة "
        تغيب.Text = "فــترة التغــيب بالأيام"
        Label13.Visible = True
        DROIT.Visible = True
        SORTE.Visible = False
        SORTEE.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label13.Visible = False
        DROIT.Visible = False
        تغيب.Text = "فـــترة التغـــيب بالأيام"
        SORTE.Visible = True
        SORTEE.Visible = True
    End Sub

    Private Sub العطل_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub enregistre_TextChanged(sender As Object, e As EventArgs) Handles enregistre.TextChanged
        Dim co As New SqlConnection
        Try
            co.ConnectionString = "Data Source=PC-MARWA\SQLEXPRESS;Initial Catalog=GestionRH;Integrated Security=True"
            co.Open()
        Catch ex As Exception
            MsgBox("Erreur de connexion")
        End Try
        Dim c As String
        c = num.Text.ToString()

        rq = "select * from الموظف where الترقيم_الاداري='" & c & "' "
        cmd = New SqlCommand(rq, co)
        Dim dta As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New DataTable

        dta.Fill(ds, "الموظف")
        dt = ds.Tables("الموظف")
        Label6.Text = dt.Rows(0)(3).ToString
        Label7.Text = dt.Rows(0)(4).ToString
        Label8.Text = dt.Rows(0)(26).ToString
       
    End Sub

    Private Sub date_fin_ValueChanged(sender As Object, e As EventArgs) Handles date_fin.ValueChanged
        Dim day, month, year, day1, month1, year1, d1, d2 As Integer

        day = date_fin.Value.Day
        month = date_fin.Value.Month
        year = date_fin.Value.Year

        d1 = day +
        day1 = date_debut.Value.Day
        month1 = date_debut.Value.Month
        year1 = date_debut.Value.Year

        Dim delay As Integer
     

        If (month = 1) Or (month = 3) Or (month = 5) Or (month = 7) Or (month = 9) Or (month = 11) Then
            d1 = year * 365 + month * 31 + day
            d2 = year1 * 365 + month1 * 31 + day1
            delay = d1 - d2
        ElseIf (month = 4) Or (month = 6) Or (month = 8) Or (month = 10) Or (month = 12) Then
            d1 = year * 365 + month * 30 + day
            d2 = year1 * 365 + month1 * 30 + day1
            delay = d1 - d2
        ElseIf (month = 2) Then
            d1 = year * 365 + month * 29 + day
            d2 = year1 * 365 + month1 * 29 + day1
            delay = d1 - d2
        End If
        duree.Text = CStr(delay)

        If (month = 1) Or (month = 3) Or (month = 5) Or (month = 7) Or (month = 9) Or (month = 11) Then
            If (day <= 30) Then
                day = day + 1
            Else
                If (month <= 11) Then
                    day = 1
                    month = month + 1
                Else
                    day = 1
                    month = 1
                    year = year + 1
                End If
            End If
        ElseIf (month = 4) Or (month = 6) Or (month = 8) Or (month = 10) Or (month = 12) Then
            If (day <= 29) Then
                day = day + 1
            Else
                If (month <= 11) Then
                    day = 1
                    month = month + 1
                Else
                    day = 1
                    month = 1
                    year = year + 1
                End If
            End If
        ElseIf (month = 2) Then
            If (day <= 28) Then
                day = day + 1
            Else

                day = 1
                month = 3
            End If
        End If
        Dim dateretour As String
        dateretour = CStr(day) + "/" + CStr(month) + "/" + CStr(year)
        date_reprise.Text = dateretour




    End Sub
End Class