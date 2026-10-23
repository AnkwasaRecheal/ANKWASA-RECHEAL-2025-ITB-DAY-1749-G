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
        Me.cmbBookType = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.btnComputeSales = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblBookType = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnCleart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbBookType
        '
        Me.cmbBookType.FormattingEnabled = True
        Me.cmbBookType.Location = New System.Drawing.Point(208, 18)
        Me.cmbBookType.Name = "cmbBookType"
        Me.cmbBookType.Size = New System.Drawing.Size(216, 21)
        Me.cmbBookType.TabIndex = 0
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(208, 120)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(216, 29)
        Me.txtQuantity.TabIndex = 1
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(208, 177)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(216, 20)
        Me.txtTotalCost.TabIndex = 2
        '
        'btnComputeSales
        '
        Me.btnComputeSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeSales.Location = New System.Drawing.Point(271, 244)
        Me.btnComputeSales.Name = "btnComputeSales"
        Me.btnComputeSales.Size = New System.Drawing.Size(153, 42)
        Me.btnComputeSales.TabIndex = 3
        Me.btnComputeSales.Text = "COMPUTE SALES"
        Me.btnComputeSales.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(123, 184)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(81, 20)
        Me.lblTotalCost.TabIndex = 4
        Me.lblTotalCost.Text = "Total Cost"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(123, 118)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(68, 20)
        Me.lblQuantity.TabIndex = 5
        Me.lblQuantity.Text = "Quantity"
        '
        'lblBookType
        '
        Me.lblBookType.AutoSize = True
        Me.lblBookType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookType.Location = New System.Drawing.Point(123, 26)
        Me.lblBookType.Name = "lblBookType"
        Me.lblBookType.Size = New System.Drawing.Size(84, 20)
        Me.lblBookType.TabIndex = 6
        Me.lblBookType.Text = "Book Type"
        '
        'lblPrice
        '
        Me.lblPrice.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(132, 74)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 20)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(208, 74)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(216, 20)
        Me.txtPrice.TabIndex = 8
        '
        'btnCleart
        '
        Me.btnCleart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCleart.Location = New System.Drawing.Point(464, 244)
        Me.btnCleart.Name = "btnCleart"
        Me.btnCleart.Size = New System.Drawing.Size(161, 44)
        Me.btnCleart.TabIndex = 9
        Me.btnCleart.Text = "CLEAR"
        Me.btnCleart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCleart)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblBookType)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnComputeSales)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cmbBookType)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbBookType As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents btnComputeSales As Button
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblBookType As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnCleart As Button
End Class
