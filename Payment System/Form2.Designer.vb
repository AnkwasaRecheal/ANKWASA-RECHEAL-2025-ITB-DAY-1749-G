<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dataform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblDataEntryForm = New System.Windows.Forms.Label()
        Me.lblBasicPay = New System.Windows.Forms.Label()
        Me.lblMedicalAllowance = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtBasicPay = New System.Windows.Forms.TextBox()
        Me.txtMedicalAllowance = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDataEntryForm
        '
        Me.lblDataEntryForm.AutoSize = True
        Me.lblDataEntryForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataEntryForm.Location = New System.Drawing.Point(318, 23)
        Me.lblDataEntryForm.Name = "lblDataEntryForm"
        Me.lblDataEntryForm.Size = New System.Drawing.Size(228, 31)
        Me.lblDataEntryForm.TabIndex = 0
        Me.lblDataEntryForm.Text = "Data Entry Form"
        '
        'lblBasicPay
        '
        Me.lblBasicPay.AutoSize = True
        Me.lblBasicPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBasicPay.Location = New System.Drawing.Point(116, 141)
        Me.lblBasicPay.Name = "lblBasicPay"
        Me.lblBasicPay.Size = New System.Drawing.Size(78, 20)
        Me.lblBasicPay.TabIndex = 1
        Me.lblBasicPay.Text = "Basic Pay"
        '
        'lblMedicalAllowance
        '
        Me.lblMedicalAllowance.AutoSize = True
        Me.lblMedicalAllowance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicalAllowance.Location = New System.Drawing.Point(90, 193)
        Me.lblMedicalAllowance.Name = "lblMedicalAllowance"
        Me.lblMedicalAllowance.Size = New System.Drawing.Size(139, 20)
        Me.lblMedicalAllowance.TabIndex = 2
        Me.lblMedicalAllowance.Text = "Medical Allowance"
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.Location = New System.Drawing.Point(102, 78)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(125, 20)
        Me.lblEmployeeName.TabIndex = 3
        Me.lblEmployeeName.Text = "Employee Name"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(280, 78)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(232, 20)
        Me.txtEmployeeName.TabIndex = 4
        '
        'txtBasicPay
        '
        Me.txtBasicPay.Location = New System.Drawing.Point(280, 137)
        Me.txtBasicPay.Name = "txtBasicPay"
        Me.txtBasicPay.Size = New System.Drawing.Size(232, 20)
        Me.txtBasicPay.TabIndex = 5
        '
        'txtMedicalAllowance
        '
        Me.txtMedicalAllowance.Location = New System.Drawing.Point(280, 189)
        Me.txtMedicalAllowance.Name = "txtMedicalAllowance"
        Me.txtMedicalAllowance.Size = New System.Drawing.Size(232, 20)
        Me.txtMedicalAllowance.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(321, 255)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(143, 46)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'dataform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtMedicalAllowance)
        Me.Controls.Add(Me.txtBasicPay)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.lblEmployeeName)
        Me.Controls.Add(Me.lblMedicalAllowance)
        Me.Controls.Add(Me.lblBasicPay)
        Me.Controls.Add(Me.lblDataEntryForm)
        Me.Name = "dataform"
        Me.Text = "dataform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDataEntryForm As Label
    Friend WithEvents lblBasicPay As Label
    Friend WithEvents lblMedicalAllowance As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtBasicPay As TextBox
    Friend WithEvents txtMedicalAllowance As TextBox
    Friend WithEvents btnCalculate As Button
End Class
