Imports System.Data.SQLite

Public Class OwnerDashboard
    Private Sub OwnerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCompanies()
    End Sub

    Private Sub btnAddCompany_Click(sender As Object, e As EventArgs) Handles btnAddCompany.Click
        Dim name = txtCompanyName.Text.Trim()
        Dim pic = txtPersonInCharge.Text.Trim()

        If name = "" OrElse pic = "" Then
            MessageBox.Show("Lengkapi data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As New SQLiteConnection("Data Source=ebilling.db;Version=3;")
            conn.Open()
            Dim cmd = New SQLiteCommand("INSERT INTO companies (name, person_in_charge) VALUES (@name, @pic)", conn)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@pic", pic)
            cmd.ExecuteNonQuery()
        End Using

        LoadCompanies()
        txtCompanyName.Clear()
        txtPersonInCharge.Clear()
    End Sub

    Private Sub LoadCompanies()
        Using conn As New SQLiteConnection("Data Source=ebilling.db;Version=3;")
            conn.Open()
            Dim da As New SQLiteDataAdapter("SELECT id, name, person_in_charge FROM companies", conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvCompanies.DataSource = dt
        End Using
    End Sub
End Class
