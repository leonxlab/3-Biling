Imports System.Data.SQLite

Public Class CustomerDashboard
    Public CustomerId As Integer ' ← ini set dari LoginForm setelah login

    Private Sub CustomerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBillingData()
    End Sub

    Private Sub LoadBillingData()
        Using conn As New SQLiteConnection("Data Source=ebilling.db;Version=3;")
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT id, amount, description, due_date, status FROM billings WHERE customer_id = @cid", conn)
            cmd.Parameters.AddWithValue("@cid", CustomerId)
            Dim da As New SQLiteDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvBillings.DataSource = dt
        End Using
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If dgvBillings.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih billing terlebih dahulu.", "Info")
            Return
        End If

        Dim billingId As Integer = dgvBillings.SelectedRows(0).Cells("id").Value

        ' Tandai status sebagai "PAID"
        Using conn As New SQLiteConnection("Data Source=ebilling.db;Version=3;")
            conn.Open()
            Dim cmd As New SQLiteCommand("UPDATE billings SET status = 'PAID' WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", billingId)
            cmd.ExecuteNonQuery()
        End Using

        LoadBillingData()
        MessageBox.Show("Pembayaran berhasil.")
    End Sub

    Private Sub btnSubmitComplaint_Click(sender As Object, e As EventArgs) Handles btnSubmitComplaint.Click
        Dim complaint = txtComplaint.Text.Trim()

        If complaint = "" Then
            MessageBox.Show("Tulis pengaduan terlebih dahulu.", "Peringatan")
            Return
        End If

        Using conn As New SQLiteConnection("Data Source=ebilling.db;Version=3;")
            conn.Open()
            Dim cmd As New SQLiteCommand("INSERT INTO complaints (customer_id, message, created_at) VALUES (@cid, @msg, CURRENT_TIMESTAMP)", conn)
            cmd.Parameters.AddWithValue("@cid", CustomerId)
            cmd.Parameters.AddWithValue("@msg", complaint)
            cmd.ExecuteNonQuery()
        End Using

        txtComplaint.Clear()
        MessageBox.Show("Pengaduan telah dikirim.")
    End Sub
End Class
