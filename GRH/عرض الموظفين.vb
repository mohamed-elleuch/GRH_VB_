Imports System.Data.SqlClient
Imports System.IO


Public Class عرض_الموظفين
    Public cmd As SqlCommand
    Public rq As String
    Public datar As SqlDataReader
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub عرض_الموظفين_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.الموظف'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.الموظفTableAdapter.Fill(Me.DataSet1.الموظف)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.الموظف'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.الموظفTableAdapter.Fill(Me.DataSet1.الموظف)

        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = False
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).Visible = False
        DataGridView1.Columns(10).Visible = False
        DataGridView1.Columns(11).Visible = False
        DataGridView1.Columns(12).Visible = False
        DataGridView1.Columns(13).Visible = False
        DataGridView1.Columns(14).Visible = False
        DataGridView1.Columns(15).Visible = False
        DataGridView1.Columns(16).Visible = False
        DataGridView1.Columns(17).Visible = False
        DataGridView1.Columns(18).Visible = False
        DataGridView1.Columns(19).Visible = False
        DataGridView1.Columns(20).Visible = False
        DataGridView1.Columns(21).Visible = False
        DataGridView1.Columns(22).Visible = False
        DataGridView1.Columns(23).Visible = False
        DataGridView1.Columns(24).Visible = False
        DataGridView1.Columns(25).Visible = False
        DataGridView1.Columns(26).Visible = False
        DataGridView1.Columns(27).Visible = False
        DataGridView1.Columns(28).Visible = False
        DataGridView1.Columns(29).Visible = False
        DataGridView1.Columns(30).Visible = False
        DataGridView1.Columns(31).Visible = False
        DataGridView1.Visible = False

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.الموظفTableAdapter.fill(Me.DataSet1.الموظف)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        DataGridView1.Visible = True

        If (CheckBox1.Checked = True) Then
            DataGridView1.Columns(0).Visible = True
        Else
            DataGridView1.Columns(0).Visible = False
        End If
        If (CheckBox7.Checked = True) Then
            DataGridView1.Columns(3).Visible = True
        Else
            DataGridView1.Columns(3).Visible = False
        End If
        If (CheckBox6.Checked = True) Then
            DataGridView1.Columns(4).Visible = True
        Else
            DataGridView1.Columns(4).Visible = False
        End If
        If (CheckBox5.Checked = True) Then
            DataGridView1.Columns(31).Visible = True
        Else
            DataGridView1.Columns(31).Visible = False
        End If
        If (CheckBox4.Checked = True) Then
            DataGridView1.Columns(7).Visible = True
        Else
            DataGridView1.Columns(7).Visible = False
        End If
        If (CheckBox3.Checked = True) Then
            DataGridView1.Columns(22).Visible = True
        Else
            DataGridView1.Columns(22).Visible = False
        End If
        If (CheckBox2.Checked = True) Then
            DataGridView1.Columns(26).Visible = True
        Else
            DataGridView1.Columns(26).Visible = False
        End If
        If (CheckBox12.Checked = True) Then
            DataGridView1.Columns(25).Visible = True
        Else
            DataGridView1.Columns(25).Visible = False
        End If
        If (CheckBox9.Checked = True) Then
            DataGridView1.Columns(23).Visible = True
        Else
            DataGridView1.Columns(23).Visible = False
        End If
        If (CheckBox13.Checked = True) Then
            DataGridView1.Columns(24).Visible = True
        Else
            DataGridView1.Columns(24).Visible = False
        End If
        If (CheckBox10.Checked = True) Then
            DataGridView1.Columns(8).Visible = True
        Else
            DataGridView1.Columns(8).Visible = False
        End If
        If (CheckBox8.Checked = True) Then
            DataGridView1.Columns(9).Visible = True
        Else
            DataGridView1.Columns(9).Visible = False
        End If
        If (CheckBox14.Checked = True) Then
            DataGridView1.Columns(28).Visible = True
        Else
            DataGridView1.Columns(28).Visible = False
        End If
        If (CheckBox15.Checked = True) Then
            DataGridView1.Columns(29).Visible = True
        Else
            DataGridView1.Columns(29).Visible = False
        End If
        If (CheckBox16.Checked = True) Then
            DataGridView1.Columns(30).Visible = True
        Else
            DataGridView1.Columns(30).Visible = False
        End If
        If (CheckBox17.Checked = True) Then
            DataGridView1.Columns(5).Visible = True
        Else
            DataGridView1.Columns(5).Visible = False
        End If
        If (CheckBox27.Checked = True) Then
            DataGridView1.Columns(16).Visible = True
        Else
            DataGridView1.Columns(16).Visible = False
        End If
        If (CheckBox28.Checked = True) Then
            DataGridView1.Columns(17).Visible = True
        Else
            DataGridView1.Columns(17).Visible = False
        End If
        If (CheckBox21.Checked = True) Then
            DataGridView1.Columns(18).Visible = True
        Else
            DataGridView1.Columns(18).Visible = False
        End If
        If (CheckBox22.Checked = True) Then
            DataGridView1.Columns(19).Visible = True
        Else
            DataGridView1.Columns(19).Visible = False
        End If
        If (CheckBox25.Checked = True) Then
            DataGridView1.Columns(20).Visible = True
        Else
            DataGridView1.Columns(20).Visible = False
        End If
        If (CheckBox26.Checked = True) Then
            DataGridView1.Columns(21).Visible = True
        Else
            DataGridView1.Columns(21).Visible = False
        End If
        If (CheckBox23.Checked = True) Then
            DataGridView1.Columns(14).Visible = True
        Else
            DataGridView1.Columns(14).Visible = False
        End If
        If (CheckBox24.Checked = True) Then
            DataGridView1.Columns(15).Visible = True
        Else
            DataGridView1.Columns(15).Visible = False
        End If
        If (CheckBox11.Checked = True) Then
            DataGridView1.Columns(6).Visible = True
        Else
            DataGridView1.Columns(6).Visible = False
        End If
        If (CheckBox18.Checked = True) Then
            DataGridView1.Columns(2).Visible = True
        Else
            DataGridView1.Columns(2).Visible = False
        End If
        If (CheckBox19.Checked = True) Then
            DataGridView1.Columns(12).Visible = True
        Else
            DataGridView1.Columns(12).Visible = False
        End If
        If (CheckBox20.Checked = True) Then
            DataGridView1.Columns(13).Visible = True
        Else
            DataGridView1.Columns(13).Visible = False
        End If

        Dim co As New SqlConnection
        Try
            co.ConnectionString = "Data Source=PC-MARWA\SQLEXPRESS;Initial Catalog=GestionRH;Integrated Security=True"
            co.Open()
            MsgBox("okkkk")
        Catch ex As Exception
            MsgBox("Erreur de connexion")
        End Try
        rq = "select * from الموظف where المصلحة= '" & ComboBox1.SelectedItem.ToString() & "' "
        cmd = New SqlCommand(rq, co)
        Dim dta As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As New DataTable

        dta.Fill(ds, "الموظف")
        dt = ds.Tables("الموظف")
        Dim c As Integer
        c = dt.Rows.Count() - 1

        For i As Integer = 0 To c

            DataGridView1.Rows.Add(dt.Rows(i).ToString())
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub العطلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles العطلToolStripMenuItem.Click
       
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub
End Class