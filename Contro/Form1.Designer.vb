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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdtBurkinaFaso = New System.Windows.Forms.RadioButton()
        Me.rdtBenin = New System.Windows.Forms.RadioButton()
        Me.rdtNigeria = New System.Windows.Forms.RadioButton()
        Me.rdtTogo = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdtOvernight = New System.Windows.Forms.RadioButton()
        Me.rdtStandard = New System.Windows.Forms.RadioButton()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShipCharge = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdtBurkinaFaso)
        Me.GroupBox1.Controls.Add(Me.rdtBenin)
        Me.GroupBox1.Controls.Add(Me.rdtNigeria)
        Me.GroupBox1.Controls.Add(Me.rdtTogo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 209)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "State"
        '
        'rdtBurkinaFaso
        '
        Me.rdtBurkinaFaso.AutoSize = True
        Me.rdtBurkinaFaso.Location = New System.Drawing.Point(6, 138)
        Me.rdtBurkinaFaso.Name = "rdtBurkinaFaso"
        Me.rdtBurkinaFaso.Size = New System.Drawing.Size(126, 22)
        Me.rdtBurkinaFaso.TabIndex = 3
        Me.rdtBurkinaFaso.TabStop = True
        Me.rdtBurkinaFaso.Text = "Burkina Faso"
        Me.rdtBurkinaFaso.UseVisualStyleBackColor = True
        '
        'rdtBenin
        '
        Me.rdtBenin.AutoSize = True
        Me.rdtBenin.Location = New System.Drawing.Point(6, 102)
        Me.rdtBenin.Name = "rdtBenin"
        Me.rdtBenin.Size = New System.Drawing.Size(68, 22)
        Me.rdtBenin.TabIndex = 2
        Me.rdtBenin.TabStop = True
        Me.rdtBenin.Text = "Benin"
        Me.rdtBenin.UseVisualStyleBackColor = True
        '
        'rdtNigeria
        '
        Me.rdtNigeria.AutoSize = True
        Me.rdtNigeria.Location = New System.Drawing.Point(6, 68)
        Me.rdtNigeria.Name = "rdtNigeria"
        Me.rdtNigeria.Size = New System.Drawing.Size(79, 22)
        Me.rdtNigeria.TabIndex = 1
        Me.rdtNigeria.TabStop = True
        Me.rdtNigeria.Text = "Nigeria"
        Me.rdtNigeria.UseVisualStyleBackColor = True
        '
        'rdtTogo
        '
        Me.rdtTogo.AutoSize = True
        Me.rdtTogo.Location = New System.Drawing.Point(6, 36)
        Me.rdtTogo.Name = "rdtTogo"
        Me.rdtTogo.Size = New System.Drawing.Size(65, 22)
        Me.rdtTogo.TabIndex = 0
        Me.rdtTogo.TabStop = True
        Me.rdtTogo.Text = "Togo"
        Me.rdtTogo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdtOvernight)
        Me.GroupBox2.Controls.Add(Me.rdtStandard)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(299, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(163, 94)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Delivery "
        '
        'rdtOvernight
        '
        Me.rdtOvernight.AutoSize = True
        Me.rdtOvernight.Location = New System.Drawing.Point(6, 68)
        Me.rdtOvernight.Name = "rdtOvernight"
        Me.rdtOvernight.Size = New System.Drawing.Size(104, 24)
        Me.rdtOvernight.TabIndex = 1
        Me.rdtOvernight.TabStop = True
        Me.rdtOvernight.Text = "Overnight"
        Me.rdtOvernight.UseVisualStyleBackColor = True
        '
        'rdtStandard
        '
        Me.rdtStandard.AutoSize = True
        Me.rdtStandard.Location = New System.Drawing.Point(6, 28)
        Me.rdtStandard.Name = "rdtStandard"
        Me.rdtStandard.Size = New System.Drawing.Size(106, 24)
        Me.rdtStandard.TabIndex = 0
        Me.rdtStandard.TabStop = True
        Me.rdtStandard.Text = "Standard "
        Me.rdtStandard.UseVisualStyleBackColor = True
        '
        'txtResults
        '
        Me.txtResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResults.Location = New System.Drawing.Point(590, 93)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.Size = New System.Drawing.Size(148, 167)
        Me.txtResults.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(586, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Shipping Charge :"
        '
        'btnShipCharge
        '
        Me.btnShipCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShipCharge.Location = New System.Drawing.Point(288, 269)
        Me.btnShipCharge.Name = "btnShipCharge"
        Me.btnShipCharge.Size = New System.Drawing.Size(275, 41)
        Me.btnShipCharge.TabIndex = 4
        Me.btnShipCharge.Text = "Display Shipping Charge"
        Me.btnShipCharge.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(663, 269)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 41)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 348)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShipCharge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "Form1"
        Me.Text = "Gentry Supplies "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdtBurkinaFaso As RadioButton
    Friend WithEvents rdtBenin As RadioButton
    Friend WithEvents rdtNigeria As RadioButton
    Friend WithEvents rdtTogo As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdtOvernight As RadioButton
    Friend WithEvents rdtStandard As RadioButton
    Friend WithEvents txtResults As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShipCharge As Button
    Friend WithEvents btnExit As Button
End Class
