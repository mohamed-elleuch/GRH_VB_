
Option Strict Off
Imports System.Data
Imports Microsoft.VisualBasic.Strings
Imports System.Data.Sql
Imports System.Data.SqlClient
Namespace etablirconnexion
    Public Class CONNEXION
        Public conn As New SqlConnection
        Public cmd As New SqlCommand(rq, conn)
        Public rq As String
        Public dr As SqlDataReader()
        Public Sub ouvrir()
            Try
                conn.ConnectionString = "Data Source=PC-MARWA\SQLEXPRESS;Initial Catalog=test;Integrated Security=True"
                conn.Open()
            Catch ex As Exception
                MsgBox("Erreur de connexion")
            End Try
        End Sub
        Public Sub fermer()
            conn.Close()
        End Sub
    End Class
    Public Class reader
        Inherits CONNEXION
        Public Sub chargerreader(ByRef rq, ByRef dr)
            Try
                ouvrir()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = rq
                dr = cmd.ExecuteReader

            Catch ex As Exception
                MsgBox("Erreur dans le reader")
            End Try
        End Sub
    End Class
    Public Class maj
        Inherits CONNEXION
        Public Sub sauvegarder(ByRef rq)
            ouvrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = rq
            cmd.ExecuteNonQuery()
            fermer()
        End Sub
    End Class


End Namespace

