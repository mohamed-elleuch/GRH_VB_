Imports System.Data.SqlClient
Imports System.IO



Public Class موظفين

    Public rq As String
    Public r As SqlDataReader()
    Dim conn As New SqlConnection


    Public a As New OpenFileDialog

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim picl As String
        a.Filter = Nothing
        picl = a.FileName
        a.ShowDialog()
        PictureBox7.Image = Image.FromFile(a.FileName)
    End Sub
    Private Sub nationalite_TextChanged(sender As Object, e As EventArgs) Handles nationalite.TextChanged
        If (Not (nationalite.Text.Equals(""))) Then
            etat_sociale.Enabled = True
        End If
    End Sub
    Private Sub niveau_TextChanged(sender As Object, e As EventArgs) Handles niveau.TextChanged
        If (Not (niveau.Text.Equals(""))) Then
            date_nais.Enabled = True
        End If
    End Sub

    Private Sub date_nais_ValueChanged(sender As Object, e As EventArgs) Handles date_nais.ValueChanged
        If (Not (date_nais.Value().ToString.Equals(""))) Then
            lieu_nais.Enabled = True
        End If
    End Sub

    Private Sub lieu_nais_TextChanged(sender As Object, e As EventArgs) Handles lieu_nais.TextChanged
        If (Not (lieu_nais.Text.Equals(""))) Then
            cin.Enabled = True
        End If
    End Sub

    Private Sub etat_sociale_TextChanged(sender As Object, e As EventArgs) Handles etat_sociale.TextChanged
        If (Not (etat_sociale.Text.Equals(""))) Then
            telf.Enabled = True
        End If
    End Sub

    Private Sub telf_TextChanged(sender As Object, e As EventArgs) Handles telf.TextChanged
        If (Not (telf.Text.Equals(""))) Then
            niveau.Enabled = True
        End If
    End Sub
    Private Sub cin_TextChanged(sender As Object, e As EventArgs) Handles cin.TextChanged
        If (Not (cin.Text.Equals(""))) Then
            lieu_cin.Enabled = True
        End If
    End Sub

    Private Sub lieu_cin_TextChanged(sender As Object, e As EventArgs) Handles lieu_cin.TextChanged
        If (Not (lieu_cin.Text.Equals(""))) Then
            rib.Enabled = True
        End If
    End Sub

    Private Sub rib_TextChanged(sender As Object, e As EventArgs) Handles rib.TextChanged
        If (Not (rib.Text.Equals(""))) Then
            banque.Enabled = True
        End If
    End Sub

    Private Sub banque_TextChanged(sender As Object, e As EventArgs) Handles banque.TextChanged
        If (Not (banque.Text.Equals(""))) Then
            adresse.Enabled = True
        End If
    End Sub

    Private Sub adresse_TextChanged(sender As Object, e As EventArgs) Handles adresse.TextChanged
        If (Not (adresse.Text.Equals(""))) Then
            telm.Enabled = True
        End If
    End Sub

    Private Sub telm_TextChanged(sender As Object, e As EventArgs) Handles telm.TextChanged
        If (Not (telm.Text.Equals(""))) Then
            cnr.Enabled = True
        End If
    End Sub

    Private Sub filiere_TextChanged(sender As Object, e As EventArgs) Handles filiere.TextChanged
        If (Not (filiere.Text.Equals(""))) Then
            degre.Enabled = True
        End If
    End Sub

    Private Sub metier_TextChanged(sender As Object, e As EventArgs) Handles metier.TextChanged
        If (Not (metier.Text.Equals(""))) Then
            filiere.Enabled = True
        End If
    End Sub

    Private Sub degre_TextChanged(sender As Object, e As EventArgs) Handles degre.TextChanged
        If (Not (degre.Text.Equals(""))) Then
            rotba.Enabled = True
        End If
    End Sub

    Private Sub rotba_TextChanged(sender As Object, e As EventArgs) Handles rotba.TextChanged
        If (Not (rotba.Text.Equals(""))) Then
            production.Enabled = True
        End If
    End Sub

    Private Sub production_TextChanged(sender As Object, e As EventArgs) Handles production.TextChanged
        If (Not (production.Text.Equals(""))) Then
            classe.Enabled = True
        End If
    End Sub

    Private Sub classe_TextChanged(sender As Object, e As EventArgs) Handles classe.TextChanged
        If (Not (classe.Text.Equals(""))) Then
            DateTimePicker1.Enabled = True
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If (Not (DateTimePicker1.Value.ToString().Equals(""))) Then
            service.Enabled = True
        End If
    End Sub

    Private Sub service_TextChanged(sender As Object, e As EventArgs) Handles service.TextChanged
        If (Not (service.Text.Equals(""))) Then
            date_filiere.Enabled = True
        End If
    End Sub

    Private Sub date_filiere_ValueChanged(sender As Object, e As EventArgs) Handles date_filiere.ValueChanged
        If (Not (date_filiere.Value.ToString.Equals(""))) Then
            date_degre.Enabled = True
        End If
    End Sub

    Private Sub date_degre_ValueChanged(sender As Object, e As EventArgs) Handles date_degre.ValueChanged
        If (Not (date_degre.Value.ToString.Equals(""))) Then
            date_rotba.Enabled = True
        End If
    End Sub
    Private Sub date_rotba_ValueChanged(sender As Object, e As EventArgs) Handles date_rotba.ValueChanged
        If (Not (date_rotba.Value.ToString.Equals(""))) Then
            date_production.Enabled = True
        End If
    End Sub

    Private Sub date_production_ValueChanged(sender As Object, e As EventArgs) Handles date_production.ValueChanged
        If (Not (date_production.Value.ToString.Equals(""))) Then
            date_classe.Enabled = True
        End If
    End Sub

    Private Sub date_classe_ValueChanged(sender As Object, e As EventArgs) Handles date_classe.ValueChanged
        If (Not (date_classe.Value.ToString.Equals(""))) Then
            num_service.Enabled = True
        End If
    End Sub
    Private Sub ajouter1_Click(sender As Object, e As EventArgs) Handles ajouter1.Click
        Dim co As New SqlConnection
        Try
            co.ConnectionString = "Data Source=PC-MARWA\SQLEXPRESS;Initial Catalog=GestionRH;Integrated Security=True"
            co.Open()
            MsgBox("okkkk")
        Catch ex As Exception
            MsgBox("Erreur de connexion")
        End Try
        rq = "insert into الموظف values (@id,@nserv,@ide,@n,@p,@f,@e,@a,@dn,@ln,@r,@d,@m,@dm,@g,@dg,@i,@di,@ech,@dech,@t,@dt,@civ,@cin,@lieu,@tel,@mob,@img,@b,@mb,@cnss,@nat);"
        Dim myCommand As SqlCommand

        myCommand = New SqlCommand(rq, co)
        myCommand.Parameters.Add(New SqlParameter("@id", SqlDbType.Int))
        myCommand.Parameters("@id").Value = CInt(number.Text)
        myCommand.Parameters.Add(New SqlParameter("@nserv", SqlDbType.Int))
        myCommand.Parameters("@nserv").Value = CInt(num_service.Text)
        myCommand.Parameters.Add(New SqlParameter("@ide", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@ide").Value = service.Text
        myCommand.Parameters.Add(New SqlParameter("@n", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@n").Value = nom.Text
        myCommand.Parameters.Add(New SqlParameter("@p", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@p").Value = prenom.Text
        myCommand.Parameters.Add(New SqlParameter("@f", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@f").Value = metier.Text
        myCommand.Parameters.Add(New SqlParameter("@e", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@e").Value = niveau.Text
        myCommand.Parameters.Add(New SqlParameter("@a", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@a").Value = adresse.Text
        myCommand.Parameters.Add(New SqlParameter("@dn", SqlDbType.Date))
        myCommand.Parameters("@dn").Value = date_nais.Value.Date
        myCommand.Parameters.Add(New SqlParameter("@ln", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@ln").Value = lieu_nais.Text
        myCommand.Parameters.Add(New SqlParameter("@r", SqlDbType.Date))
        myCommand.Parameters("@r").Value = DateTimePicker1.Value.Date
        myCommand.Parameters.Add(New SqlParameter("@d", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@d").Value = Label18.Text
        myCommand.Parameters.Add(New SqlParameter("@m", SqlDbType.Int))
        myCommand.Parameters("@m").Value = CInt(filiere.Text)
        myCommand.Parameters.Add(New SqlParameter("@dm", SqlDbType.Date))
        myCommand.Parameters("@dm").Value = date_filiere.Value.Date
        myCommand.Parameters.Add(New SqlParameter("@g", SqlDbType.Int))
        myCommand.Parameters("@g").Value = CInt(rotba.Text)
        myCommand.Parameters.Add(New SqlParameter("@dg", SqlDbType.Date))
        myCommand.Parameters("@dg").Value = date_rotba.Value.Date
        myCommand.Parameters.Add(New SqlParameter("@i", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@i").Value = production.Text
        myCommand.Parameters.Add(New SqlParameter("@di", SqlDbType.Date))
        myCommand.Parameters("@di").Value = date_production.Value.Date
        myCommand.Parameters.Add(New SqlParameter("@ech", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@ech").Value = degre.Text
        myCommand.Parameters.Add(New SqlParameter("@dech", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@dech").Value = date_degre.Text
        myCommand.Parameters.Add(New SqlParameter("@t", SqlDbType.Int))
        myCommand.Parameters("@t").Value = CInt(classe.Text)
        myCommand.Parameters.Add(New SqlParameter("@dt", SqlDbType.Date))
        myCommand.Parameters("@dt").Value = date_classe.Value.Date
        myCommand.Parameters.Add(New SqlParameter("@civ", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@civ").Value = etat_sociale.Text
        myCommand.Parameters.Add(New SqlParameter("@cin", SqlDbType.Int))
        myCommand.Parameters("@cin").Value = CInt(cin.Text)
        myCommand.Parameters.Add(New SqlParameter("@lieu", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@lieu").Value = lieu_cin.Text
        myCommand.Parameters.Add(New SqlParameter("@tel", SqlDbType.Int))
        myCommand.Parameters("@tel").Value = CInt(telm.Text)
        myCommand.Parameters.Add(New SqlParameter("@mob", SqlDbType.Int))
        myCommand.Parameters("@mob").Value = CInt(telf.Text)
        myCommand.Parameters.Add(New SqlParameter("@img", SqlDbType.Image)).Value = IO.File.ReadAllBytes(a.FileName)
        myCommand.Parameters.Add(New SqlParameter("@b", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@b").Value = banque.Text
        myCommand.Parameters.Add(New SqlParameter("@mb", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@mb").Value = rib.Text
        myCommand.Parameters.Add(New SqlParameter("@cnss", SqlDbType.Int))
        myCommand.Parameters("@cnss").Value = CInt(cnr.Text)
        myCommand.Parameters.Add(New SqlParameter("@nat", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@nat").Value = nationalite.Text


        myCommand.ExecuteNonQuery()

        conn.Close()
    End Sub

    Sub Page_Load(Src As Object, e As EventArgs)




    End Sub

    Private Sub nom_TextChanged(sender As Object, e As EventArgs) Handles nom.TextChanged
        If (Not (nom.Text.Equals(""))) Then
            prenom.Enabled = True
        End If
    End Sub

    Private Sub number_TextChanged(sender As Object, e As EventArgs) Handles number.TextChanged
        If (Not (number.Text.Equals(""))) Then
            nom.Enabled = True
        End If
    End Sub

    Private Sub prenom_TextChanged(sender As Object, e As EventArgs) Handles prenom.TextChanged
        If (Not (prenom.Text.Equals(""))) Then
            nationalite.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TabControl1.SelectedIndex() = 0) Then
            number.Text = ""
            service.Text = ""
            nom.Text = ""
            prenom.Text = ""
            niveau.Text = ""
            adresse.Text = ""
            date_nais.Text = ""
            lieu_nais.Text = ""
            DateTimePicker1.Text = ""
            Label18.Text = ""
            date_filiere.Text = ""
            date_rotba.Text = ""
            date_production.Text = ""
            date_degre.Text = ""
            date_classe.Text = ""
            etat_sociale.Text = ""
            cin.Text = ""
            lieu_cin.Text = ""
            telm.Text = ""
            telf.Text = ""
            banque.Text = ""
            rib.Text = ""
            cnr.Text = ""
            nationalite.Text = ""
        ElseIf (TabControl1.SelectedIndex() = 1) Then
            metier.Text = ""
            filiere.Text = ""
            degre.Text = ""
            rotba.Text = ""
            production.Text = ""
            classe.Text = ""
            num_service.Text = ""
        ElseIf (TabControl1.SelectedIndex() = 2) Then
            TextBox29.Text = ""
            TextBox33.Text = ""
            TextBox30.Text = ""
            TextBox31.Text = ""
            TextBox32.Text = ""
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If (TabControl1.SelectedIndex() = 2) Then
            MsgBox("صفحة غير موجودة")
        Else
            TabControl1.SelectTab(TabControl1.SelectedIndex() + 1)
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If (TabControl1.SelectedIndex() = 0) Then
            MsgBox("صفحة غير موجودة")
        Else
            TabControl1.SelectTab(TabControl1.SelectedIndex() - 1)
        End If

    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If (TabControl1.SelectedIndex() = 1) Then
            If ((number.Text = "") Or (nom.Enabled = False) Or (prenom.Enabled = False) Or (nationalite.Enabled = False) Or (etat_sociale.Enabled = False) Or (telf.Enabled = False) Or (niveau.Enabled = False) Or (date_nais.Enabled = False) Or (lieu_nais.Enabled = False) Or (cin.Enabled = False) Or (lieu_cin.Enabled = False) Or (rib.Enabled = False) Or (banque.Enabled = False) Or (adresse.Enabled = False) Or (telm.Enabled = False) Or (cnr.Enabled = False)) Then
                MsgBox("الرجاء أكمل بيانات المعطيات الشخصية")
                TabControl1.SelectTab(TabControl1.SelectedIndex() - 1)
            Else
                Dim a As Integer
                Dim j As Integer
                Dim m As Integer
                Dim ret As String

                a = date_nais.Value.Year + 60
                j = date_nais.Value.Day
                m = date_nais.Value.Month
                ret = j.ToString + "/" + m.ToString + "/" + a.ToString
                Label18.Text = ret
            End If
        ElseIf (TabControl1.SelectedIndex() = 2) Then
            If ((number.Text = "") Or (nom.Enabled = False) Or (prenom.Enabled = False) Or (nationalite.Enabled = False) Or (etat_sociale.Enabled = False) Or (telf.Enabled = False) Or (niveau.Enabled = False) Or (date_nais.Enabled = False) Or (lieu_nais.Enabled = False) Or (cin.Enabled = False) Or (lieu_cin.Enabled = False) Or (rib.Enabled = False) Or (banque.Enabled = False) Or (adresse.Enabled = False) Or (telm.Enabled = False) Or (cnr.Enabled = False)) Then
                MsgBox("الرجاء أكمل بيانات المعطيات الشخصية")
                TabControl1.SelectTab(TabControl1.SelectedIndex() - 2)
            ElseIf ((metier.Text = "") Or (filiere.Enabled = False) Or (degre.Enabled = False) Or (rotba.Enabled = False) Or (production.Enabled = False) Or (classe.Enabled = False) Or (DateTimePicker1.Enabled = False) Or (service.Enabled = False) Or (date_filiere.Enabled = False) Or (date_degre.Enabled = False) Or (date_rotba.Enabled = False) Or (date_production.Enabled = False) Or (date_classe.Enabled = False) Or (num_service.Enabled = False)) Then
                MsgBox("الرجاء أكمل بيانات المعطيات المهنية")
                TabControl1.SelectTab(TabControl1.SelectedIndex() - 1)
            End If
        End If


    End Sub

    Private Sub موظفين_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox30.Enabled = False
        TextBox31.Enabled = False
        TextBox32.Enabled = False

        nom.Enabled = False
        prenom.Enabled = False
        nationalite.Enabled = False
        etat_sociale.Enabled = False
        telf.Enabled = False
        niveau.Enabled = False
        date_nais.Enabled = False
        lieu_nais.Enabled = False
        cin.Enabled = False
        lieu_cin.Enabled = False
        rib.Enabled = False
        banque.Enabled = False
        adresse.Enabled = False
        telm.Enabled = False
        cnr.Enabled = False

        filiere.Enabled = False
        degre.Enabled = False
        rotba.Enabled = False
        production.Enabled = False
        classe.Enabled = False
        DateTimePicker1.Enabled = False
        service.Enabled = False
        date_filiere.Enabled = False
        date_degre.Enabled = False
        date_rotba.Enabled = False
        date_production.Enabled = False
        date_classe.Enabled = False
        num_service.Enabled = False
    End Sub

    Private Sub affichage_Click(sender As Object, e As EventArgs) Handles affichage.Click
        عرض_الموظفين.Show()
        Me.Hide()
    End Sub
End Class