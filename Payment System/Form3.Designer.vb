<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reportform
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
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(229, 47)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(78, 20)
        Me.lblGrossPay.TabIndex = 0
        Me.lblGrossPay.Text = "GrossPay"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(229, 122)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(60, 20)
        Me.lblNetPay.TabIndex = 1
        Me.lblNetPay.Text = "NetPay"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(313, 47)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(208, 20)
        Me.txtGrossPay.TabIndex = 2
        '
        'txtNetPay
        '
        Me.txtNetPay.Location = New System.Drawing.Point(313, 119)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.Size = New System.Drawing.Size(208, 20)
        Me.txtNetPay.TabIndex = 3
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(328, 202)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(162, 40)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'reportform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Name = "reportform"
        Me.Text = "reportform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGrossPay As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents txtNetPay As TextBox
    Friend WithEvents btnBack As Button
End Class
