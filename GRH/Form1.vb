

Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Sql
Imports GRH.etablirconnexion

Public Class Form1
    Public cmd As SqlCommand
    Public rq As String
    Dim monreader As New reader

    Public datar As SqlDataReader

    Dim conn As New CONNEXION
    Dim maj As New maj
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim co As New SqlConnection
        Try
            co.ConnectionString = "Data Source=PC-MARWA\SQLEXPRESS;Initial Catalog=GestionRH;Integrated Security=True"
            co.Open()
            MsgBox("okkkk")
        Catch ex As Exception
            MsgBox("Erreur de connexion")
        End Try
        rq = "INSERT INTO employe Values (@id,@nom) "
        Dim myCommand As SqlCommand

        myCommand = New SqlCommand(rq, co)
        myCommand.Parameters.Add(New SqlParameter("@id", SqlDbType.NVarChar))
        myCommand.Parameters("@id").Value = TextBox1.Text
        myCommand.Parameters.Add(New SqlParameter("@nom", SqlDbType.NVarChar))
        myCommand.Parameters("@nom").Value = TextBox2.Text
        myCommand.ExecuteNonQuery()
    End Sub
End Class
