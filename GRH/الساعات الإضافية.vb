Imports System.Data.SqlClient

Public Class الساعات_الإضافية
    Dim MyConnection As SqlConnection
    Public req As String
    Public r As SqlDataReader()
    Dim co As New SqlConnection


    Private Sub Button1_Click(sender As Object, e As EventArgs)
    
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        num4.Text = ""
        date_debut.Text = ""
        date_fin.Text = ""

        rque.Text = ""
    End Sub

    Private Sub num4_TextChanged(sender As Object, e As EventArgs)
        If (Not (num4.Text.Equals(""))) Then
            date_debut.Enabled = True
        End If
    End Sub

    Private Sub date_debut_ValueChanged(sender As Object, e As EventArgs)
        If (Not (date_debut.Text.Equals(""))) Then
            date_fin.Enabled = True
        End If
    End Sub

    Private Sub date_fin_ValueChanged(sender As Object, e As EventArgs)
      
    End Sub

    Private Sub dure_TextChanged(sender As Object, e As EventArgs)
     
    End Sub

    

   
    
    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim h As Integer
        Dim m As Integer
        Dim s As Integer
        Dim date_debut As String
        Dim date_fin As String


       
    End Sub

    Private Sub rque_TextChanged(sender As Object, e As EventArgs) Handles rque.TextChanged

    End Sub

    Private Sub ajoute_heure_Click(sender As Object, e As EventArgs) Handles ajoute_heure.Click

        Try
            co.ConnectionString = "Data Source=PC-MARWA\SQLEXPRESS;Initial Catalog=GestionRH;Integrated Security=True"
            co.Open()
            MsgBox("okkkk")
        Catch ex As Exception
            MsgBox("Erreur de connexion")
        End Try

        Dim myCommand As SqlCommand
        req = "insert into ساعات إضافية  values (@idemp,@date_debut,@date_fin,@rqe);"
        myCommand = New SqlCommand(req, MyConnection)
        myCommand.Parameters.Add(New SqlParameter("@idemp", SqlDbType.Int))
        myCommand.Parameters("@idemp").Value = num4.Text
        myCommand.Parameters.Add(New SqlParameter("@date_debut", SqlDbType.Date))
        myCommand.Parameters("@date_debut").Value = date_debut.Text()
        myCommand.Parameters.Add(New SqlParameter("@date_fin", SqlDbType.Date))
        myCommand.Parameters("@date_fin").Value = date_fin.Text()
        myCommand.Parameters.Add(New SqlParameter("@rqe", SqlDbType.NVarChar, 31))
        myCommand.Parameters("@rqe").Value = rque.Text()

        myCommand.ExecuteNonQuery()

        co.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            co.ConnectionString = "Data Source=PC-MARWA\SQLEXPRESS;Initial Catalog=GestionRH;Integrated Security=True"
            co.Open()
            MsgBox("okkkk")
        Catch ex As Exception
            MsgBox("Erreur de connexion")
        End Try

        Dim myCommand As SqlCommand
        req = "delete from ساعات إضافية  where الترقيم_الاداري= @idemp;"
        myCommand = New SqlCommand(req, MyConnection)
        myCommand.Parameters.Add(New SqlParameter("@idemp", SqlDbType.Int))
        myCommand.Parameters("@idemp").Value = num4.Text
        myCommand.ExecuteNonQuery()

        co.Close()
    End Sub
End Class