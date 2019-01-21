<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
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
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtVoltage = New System.Windows.Forms.TextBox()
        Me.txtRPMs = New System.Windows.Forms.TextBox()
        Me.txtMotorID = New System.Windows.Forms.TextBox()
        Me.radNa = New System.Windows.Forms.RadioButton()
        Me.radMnt = New System.Windows.Forms.RadioButton()
        Me.radOff = New System.Windows.Forms.RadioButton()
        Me.radOn = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtVoltage)
        Me.GroupBox1.Controls.Add(Me.txtRPMs)
        Me.GroupBox1.Controls.Add(Me.txtMotorID)
        Me.GroupBox1.Controls.Add(Me.radNa)
        Me.GroupBox1.Controls.Add(Me.radMnt)
        Me.GroupBox1.Controls.Add(Me.radOff)
        Me.GroupBox1.Controls.Add(Me.radOn)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 187)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Record"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(109, 64)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(151, 20)
        Me.txtDescription.TabIndex = 12
        '
        'txtVoltage
        '
        Me.txtVoltage.Location = New System.Drawing.Point(109, 133)
        Me.txtVoltage.Name = "txtVoltage"
        Me.txtVoltage.Size = New System.Drawing.Size(100, 20)
        Me.txtVoltage.TabIndex = 11
        '
        'txtRPMs
        '
        Me.txtRPMs.Location = New System.Drawing.Point(109, 98)
        Me.txtRPMs.Name = "txtRPMs"
        Me.txtRPMs.Size = New System.Drawing.Size(100, 20)
        Me.txtRPMs.TabIndex = 10
        '
        'txtMotorID
        '
        Me.txtMotorID.Location = New System.Drawing.Point(109, 33)
        Me.txtMotorID.Name = "txtMotorID"
        Me.txtMotorID.Size = New System.Drawing.Size(100, 20)
        Me.txtMotorID.TabIndex = 9
        '
        'radNa
        '
        Me.radNa.AutoSize = True
        Me.radNa.Location = New System.Drawing.Point(349, 146)
        Me.radNa.Name = "radNa"
        Me.radNa.Size = New System.Drawing.Size(40, 17)
        Me.radNa.TabIndex = 8
        Me.radNa.TabStop = True
        Me.radNa.Text = "NA"
        Me.radNa.UseVisualStyleBackColor = True
        '
        'radMnt
        '
        Me.radMnt.AutoSize = True
        Me.radMnt.Location = New System.Drawing.Point(349, 113)
        Me.radMnt.Name = "radMnt"
        Me.radMnt.Size = New System.Drawing.Size(49, 17)
        Me.radMnt.TabIndex = 7
        Me.radMnt.TabStop = True
        Me.radMnt.Text = "MNT"
        Me.radMnt.UseVisualStyleBackColor = True
        '
        'radOff
        '
        Me.radOff.AutoSize = True
        Me.radOff.Location = New System.Drawing.Point(349, 80)
        Me.radOff.Name = "radOff"
        Me.radOff.Size = New System.Drawing.Size(45, 17)
        Me.radOff.TabIndex = 6
        Me.radOff.TabStop = True
        Me.radOff.Text = "OFF"
        Me.radOff.UseVisualStyleBackColor = True
        '
        'radOn
        '
        Me.radOn.AutoSize = True
        Me.radOn.Location = New System.Drawing.Point(349, 47)
        Me.radOn.Name = "radOn"
        Me.radOn.Size = New System.Drawing.Size(41, 17)
        Me.radOn.TabIndex = 5
        Me.radOn.TabStop = True
        Me.radOn.Text = "ON"
        Me.radOn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(346, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Motor Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Voltage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Motor RPMs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Motor ID"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(90, 223)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(207, 223)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(327, 223)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(97, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 273)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AddForm"
        Me.Text = "Add New Motor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radNa As RadioButton
    Friend WithEvents radMnt As RadioButton
    Friend WithEvents radOff As RadioButton
    Friend WithEvents radOn As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtVoltage As TextBox
    Friend WithEvents txtRPMs As TextBox
    Friend WithEvents txtMotorID As TextBox
End Class
