Public Class dataform
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim basicPay As Decimal
        Dim medicalAllowances As Decimal
        If Not Decimal.TryParse(txtBasicPay.Text, basicPay) Or Not Decimal.TryParse(txtMedicalAllowance.Text, medicalAllowances) Then
            MessageBox.Show("Please enter the valid numeric values for Basic Pay and Medical Allowance.")
            Exit Sub
        End If
        Dim grossPay As Decimal = basicPay + medicalAllowances
        Dim nssfContribution As Decimal = grossPay * 0.05D
        Dim netPay As Decimal = grossPay - nssfContribution

        Dim reportForm As New reportform(grossPay, netPay)
        reportForm.Show()
        Me.Hide()

    End Sub
End Class
