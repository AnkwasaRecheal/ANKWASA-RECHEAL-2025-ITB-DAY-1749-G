<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbCarType = New System.Windows.Forms.ComboBox()
        Me.txtRentalDuration = New System.Windows.Forms.TextBox()
        Me.txtTotalRentalCost = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblRentalDuration = New System.Windows.Forms.Label()
        Me.lblCarType = New System.Windows.Forms.Label()
        Me.lblTotalRentalCost = New System.Windows.Forms.Label()
        Me.lblDailyCharge = New System.Windows.Forms.Label()
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtDailyCharge = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbCarType
        '
        Me.cmbCarType.FormattingEnabled = True
        Me.cmbCarType.Location = New System.Drawing.Point(316, 89)
        Me.cmbCarType.Name = "cmbCarType"
        Me.cmbCarType.Size = New System.Drawing.Size(266, 21)
        Me.cmbCarType.TabIndex = 0
        '
        'txtRentalDuration
        '
        Me.txtRentalDuration.Location = New System.Drawing.Point(318, 201)
        Me.txtRentalDuration.Name = "txtRentalDuration"
        Me.txtRentalDuration.Size = New System.Drawing.Size(264, 20)
        Me.txtRentalDuration.TabIndex = 1
        '
        'txtTotalRentalCost
        '
        Me.txtTotalRentalCost.Location = New System.Drawing.Point(318, 252)
        Me.txtTotalRentalCost.Name = "txtTotalRentalCost"
        Me.txtTotalRentalCost.Size = New System.Drawing.Size(264, 20)
        Me.txtTotalRentalCost.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(316, 314)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(144, 61)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblRentalDuration
        '
        Me.lblRentalDuration.AutoSize = True
        Me.lblRentalDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalDuration.Location = New System.Drawing.Point(101, 201)
        Me.lblRentalDuration.Name = "lblRentalDuration"
        Me.lblRentalDuration.Size = New System.Drawing.Size(207, 20)
        Me.lblRentalDuration.TabIndex = 4
        Me.lblRentalDuration.Text = "RENTAL DURATION (days)"
        '
        'lblCarType
        '
        Me.lblCarType.AutoSize = True
        Me.lblCarType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarType.Location = New System.Drawing.Point(200, 92)
        Me.lblCarType.Name = "lblCarType"
        Me.lblCarType.Size = New System.Drawing.Size(88, 20)
        Me.lblCarType.TabIndex = 5
        Me.lblCarType.Text = "CAR TYPE"
        '
        'lblTotalRentalCost
        '
        Me.lblTotalRentalCost.AutoSize = True
        Me.lblTotalRentalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRentalCost.Location = New System.Drawing.Point(139, 252)
        Me.lblTotalRentalCost.Name = "lblTotalRentalCost"
        Me.lblTotalRentalCost.Size = New System.Drawing.Size(173, 20)
        Me.lblTotalRentalCost.TabIndex = 6
        Me.lblTotalRentalCost.Text = "TOTAL RENTAL COST"
        '
        'lblDailyCharge
        '
        Me.lblDailyCharge.AutoSize = True
        Me.lblDailyCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDailyCharge.Location = New System.Drawing.Point(179, 147)
        Me.lblDailyCharge.Name = "lblDailyCharge"
        Me.lblDailyCharge.Size = New System.Drawing.Size(131, 20)
        Me.lblDailyCharge.TabIndex = 7
        Me.lblDailyCharge.Text = "DAILY CHARGE"
        '
        'lblFastLogisticsCompanyRentalChargesTrackingSystem
        '
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.AutoSize = True
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Location = New System.Drawing.Point(101, 34)
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Name = "lblFastLogisticsCompanyRentalChargesTrackingSystem"
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Size = New System.Drawing.Size(672, 24)
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.TabIndex = 9
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Text = "FAST LOGISTICS COMPANY RENTAL CHARGES TRACKING SYSTEM"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(513, 314)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 61)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtDailyCharge
        '
        Me.txtDailyCharge.Location = New System.Drawing.Point(316, 149)
        Me.txtDailyCharge.Name = "txtDailyCharge"
        Me.txtDailyCharge.Size = New System.Drawing.Size(266, 20)
        Me.txtDailyCharge.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDailyCharge)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblFastLogisticsCompanyRentalChargesTrackingSystem)
        Me.Controls.Add(Me.lblDailyCharge)
        Me.Controls.Add(Me.lblTotalRentalCost)
        Me.Controls.Add(Me.lblCarType)
        Me.Controls.Add(Me.lblRentalDuration)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTotalRentalCost)
        Me.Controls.Add(Me.txtRentalDuration)
        Me.Controls.Add(Me.cmbCarType)
        Me.Name = "Form1"
        Me.Text = "Car_rental system"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCarType As ComboBox
    Friend WithEvents txtRentalDuration As TextBox
    Friend WithEvents txtTotalRentalCost As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblRentalDuration As Label
    Friend WithEvents lblCarType As Label
    Friend WithEvents lblTotalRentalCost As Label
    Friend WithEvents lblDailyCharge As Label
    Friend WithEvents lblFastLogisticsCompanyRentalChargesTrackingSystem As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtDailyCharge As TextBox
End Class
