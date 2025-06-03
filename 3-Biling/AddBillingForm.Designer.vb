<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddBillingForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmbCompany = New ComboBox()
        Me.txtAmount = New TextBox()
        Me.txtDescription = New TextBox()
        Me.dtpDueDate = New DateTimePicker()
        Me.btnSave = New Button()

        ' Company Dropdown
        Me.cmbCompany.Location = New Point(20, 20)
        Me.cmbCompany.Size = New Size(300, 25)

        ' Amount
        Me.txtAmount.Location = New Point(20, 60)
        'Me.txtAmount.PlaceholderText = "Jumlah Pembayaran"

        ' Description
        Me.txtDescription.Location = New Point(20, 100)
        'Me.txtDescription.PlaceholderText = "Keterangan"

        ' Due Date
        Me.dtpDueDate.Location = New Point(20, 140)

        ' Save Button
        Me.btnSave.Text = "Simpan"
        Me.btnSave.Location = New Point(20, 180)

        ' Form
        Me.Controls.Add(cmbCompany)
        Me.Controls.Add(txtAmount)
        Me.Controls.Add(txtDescription)
        Me.Controls.Add(dtpDueDate)
        Me.Controls.Add(btnSave)

        Me.Text = "Tambah Billing"
        Me.ClientSize = New Size(360, 240)
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub

    Friend WithEvents cmbCompany As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents btnSave As Button
End Class
