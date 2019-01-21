Public Class AddForm

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Saves the data entered on the form.                       

        Dim m As New Motor()                                            ' Save creates a new Motor object
        ' Validate the input.
        If txtMotorID.Text.Length <> 5 Then                             ' CHECKS length of motor ID (must be 5)
            MessageBox.Show("The motor ID must be 5 characters.", "Error")
            txtMotorID.SelectionStart = 0
            txtMotorID.SelectionLength = txtMotorID.Text.Length
            txtMotorID.Focus()
        ElseIf Val(txtRPMs.Text) < 10 Or Val(txtRPMs.Text) > 10000 Then     ' CHECKS value of RPMs
            MessageBox.Show("The RPM value must be in the range 10 - 10000.",
                "Error")
            txtRPMs.SelectionStart = 0
            txtRPMs.SelectionLength = txtRPMs.Text.Length
            txtRPMs.Focus()
        ElseIf Val(txtVoltage.Text) < 1 Or Val(txtVoltage.Text) > 500 Then       ' CHECKS valid range of voltage
            MessageBox.Show("The Voltage value must be in the range 1 - 500.",
                "Error")
            txtVoltage.SelectionStart = 0
            txtVoltage.SelectionLength = txtVoltage.Text.Length
            txtVoltage.Focus()
        Else
            If MainForm.intMotorCount < 10 Then                          ' CHECKS to see if the motor array is full
                CopyToObject(MainForm.motors(MainForm.intMotorCount))    ' If not, call CopyToObject method, copies MainForm fields into the motors array, increments by 1
                MainForm.intMotorCount += 1                              '      Line 27 (refers to the motor in last position in the array that we've used so far)
                ClearForm()
            Else
                MessageBox.Show("The array is full.", "Error")
            End If
        End If
    End Sub

    Private Sub CopyToObject(ByVal m As Motor)                      ' Method (receieves a motor object and copies the textbox values into the fields of the motor object)
        ' Copy the data from the form to m.

        m.MotorId = txtMotorID.Text
        m.Description = txtDescription.Text
        m.RPM = CSng(txtRPMs.Text)
        m.Voltage = CSng(txtVoltage.Text)
        m.Status = GetStatus()
    End Sub

    Private Function GetStatus() As String                          ' Method (special case), called from line 43
        ' Return the motor status selected by the user.
        Dim stat As String = ""

        If radOn.Checked = True Then
            stat = "ON"
        ElseIf radOff.Checked = True Then
            stat = "OFF"
        ElseIf radMnt.Checked = True Then
            stat = "MNT"
        ElseIf radNa.Checked = True Then
            stat = "NA"                                             ' It'll return a status and assign it to that field
        End If
        Return stat
    End Function

    Private Sub btnClear_Click() Handles btnClear.Click
        'Clear the form
        ClearForm()
    End Sub

    Private Sub ClearForm()                                         ' Method (clears all fields), called on line 29 and line 63
        ' Clear the form
        txtMotorID.Clear()
        txtDescription.Clear()
        txtRPMs.Clear()
        txtVoltage.Clear()
        radOn.Checked = True
        txtMotorID.Focus()
    End Sub

    Private Sub btnCancel_Click() Handles btnClose.Click
        ' Close the form without saving the current object to
        ' the array.
        Me.Close()
    End Sub
End Class