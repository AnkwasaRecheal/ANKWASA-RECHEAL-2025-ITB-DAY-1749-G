Public Class reportform
    Private grossPay As Decimal
    Private netPay As Decimal
    Public Sub New(gross As Decimal, net As Decimal)
        InitializeComponent()
        grossPay = gross
        netPay = net

    End Sub
    Private Sub reportform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGrossPay.Text = grossPay.ToString("c")
        txtNetPay.Text = netPay.ToString("C")
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dataForm As New dataform()
        dataForm.Show()
        Me.Close()
    End Sub
End Class