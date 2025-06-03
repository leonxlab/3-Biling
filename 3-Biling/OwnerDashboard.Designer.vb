<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OwnerDashboard
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabCompany = New System.Windows.Forms.TabPage()
        Me.dgvCompanies = New System.Windows.Forms.DataGridView()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtPersonInCharge = New System.Windows.Forms.TextBox()
        Me.btnAddCompany = New System.Windows.Forms.Button()
        Me.TabBilling = New System.Windows.Forms.TabPage()
        Me.TabReport = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabCompany.SuspendLayout()
        CType(Me.dgvCompanies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabCompany)
        Me.TabControl1.Controls.Add(Me.TabBilling)
        Me.TabControl1.Controls.Add(Me.TabReport)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 450)
        Me.TabControl1.TabIndex = 0
        '
        'TabCompany
        '
        Me.TabCompany.Controls.Add(Me.dgvCompanies)
        Me.TabCompany.Controls.Add(Me.txtCompanyName)
        Me.TabCompany.Controls.Add(Me.txtPersonInCharge)
        Me.TabCompany.Controls.Add(Me.btnAddCompany)
        Me.TabCompany.Location = New System.Drawing.Point(4, 26)
        Me.TabCompany.Name = "TabCompany"
        Me.TabCompany.Size = New System.Drawing.Size(792, 420)
        Me.TabCompany.TabIndex = 0
        Me.TabCompany.Text = "Tambah Perusahaan"
        '
        'dgvCompanies
        '
        Me.dgvCompanies.Location = New System.Drawing.Point(20, 150)
        Me.dgvCompanies.Name = "dgvCompanies"
        Me.dgvCompanies.Size = New System.Drawing.Size(740, 250)
        Me.dgvCompanies.TabIndex = 0
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(20, 20)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(300, 25)
        Me.txtCompanyName.TabIndex = 1
        '
        'txtPersonInCharge
        '
        Me.txtPersonInCharge.Location = New System.Drawing.Point(20, 55)
        Me.txtPersonInCharge.Name = "txtPersonInCharge"
        Me.txtPersonInCharge.Size = New System.Drawing.Size(300, 25)
        Me.txtPersonInCharge.TabIndex = 2
        '
        'btnAddCompany
        '
        Me.btnAddCompany.Location = New System.Drawing.Point(20, 95)
        Me.btnAddCompany.Name = "btnAddCompany"
        Me.btnAddCompany.Size = New System.Drawing.Size(100, 30)
        Me.btnAddCompany.TabIndex = 3
        Me.btnAddCompany.Text = "Tambah"
        '
        'TabBilling
        '
        Me.TabBilling.Location = New System.Drawing.Point(4, 26)
        Me.TabBilling.Name = "TabBilling"
        Me.TabBilling.Size = New System.Drawing.Size(792, 420)
        Me.TabBilling.TabIndex = 1
        Me.TabBilling.Text = "Tambah Billing"
        '
        'TabReport
        '
        Me.TabReport.Location = New System.Drawing.Point(4, 26)
        Me.TabReport.Name = "TabReport"
        Me.TabReport.Size = New System.Drawing.Size(792, 420)
        Me.TabReport.TabIndex = 2
        Me.TabReport.Text = "Laporan Pengaduan"
        '
        'OwnerDashboard
        '
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "OwnerDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Owner Dashboard"
        Me.TabControl1.ResumeLayout(False)
        Me.TabCompany.ResumeLayout(False)
        Me.TabCompany.PerformLayout()
        CType(Me.dgvCompanies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabCompany As TabPage
    Friend WithEvents TabBilling As TabPage
    Friend WithEvents TabReport As TabPage
    Friend WithEvents dgvCompanies As DataGridView
    Friend WithEvents btnAddCompany As Button
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents txtPersonInCharge As TextBox
End Class
