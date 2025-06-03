<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerDashboard
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New TabControl()
        Me.TabPayments = New TabPage()
        Me.TabComplaint = New TabPage()

        ' TAB PAYMENT
        Me.dgvBillings = New DataGridView()
        Me.btnPay = New Button()

        ' TAB COMPLAINT
        Me.txtComplaint = New TextBox()
        Me.btnSubmitComplaint = New Button()

        ' --- TabControl
        Me.TabControl1.Controls.Add(Me.TabPayments)
        Me.TabControl1.Controls.Add(Me.TabComplaint)
        Me.TabControl1.Dock = DockStyle.Fill
        Me.TabControl1.Font = New Font("Segoe UI", 10)

        ' --- TabPayments
        Me.TabPayments.Text = "Pembayaran"
        Me.TabPayments.Controls.Add(Me.dgvBillings)
        Me.TabPayments.Controls.Add(Me.btnPay)

        ' --- TabComplaint
        Me.TabComplaint.Text = "Pengaduan"
        Me.TabComplaint.Controls.Add(Me.txtComplaint)
        Me.TabComplaint.Controls.Add(Me.btnSubmitComplaint)

        ' --- dgvBillings
        Me.dgvBillings.Location = New Point(20, 20)
        Me.dgvBillings.Size = New Size(740, 300)

        ' --- btnPay
        Me.btnPay.Text = "Bayar"
        Me.btnPay.Location = New Point(20, 340)
        Me.btnPay.Size = New Size(120, 30)

        ' --- txtComplaint
        Me.txtComplaint.Location = New Point(20, 20)
        Me.txtComplaint.Multiline = True
        Me.txtComplaint.Size = New Size(740, 250)

        ' --- btnSubmitComplaint
        Me.btnSubmitComplaint.Text = "Kirim Pengaduan"
        Me.btnSubmitComplaint.Location = New Point(20, 290)
        Me.btnSubmitComplaint.Size = New Size(150, 30)

        ' --- Form
        Me.Controls.Add(Me.TabControl1)
        Me.Text = "Customer Dashboard"
        Me.ClientSize = New Size(800, 450)
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPayments As TabPage
    Friend WithEvents TabComplaint As TabPage
    Friend WithEvents dgvBillings As DataGridView
    Friend WithEvents btnPay As Button
    Friend WithEvents txtComplaint As TextBox
    Friend WithEvents btnSubmitComplaint As Button
End Class
