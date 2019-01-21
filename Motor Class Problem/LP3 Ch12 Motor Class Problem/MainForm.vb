Public Class MainForm

    Public Shared motors(9) As Motor                ' Array of Motor objects    ' Both are declared shared because there is only one instance of the main form class
    Public Shared intMotorCount As Integer = 0      ' Number of objects stored  ' Both are public because we will be able to access them from the AddForm

    Private Sub frmMain_Load() Handles MyBase.Load

        ' Initialize the array of Motors
        For i As Integer = 0 To 9                   ' Uses a loop to initialize the motors array to New Motor objects
            motors(i) = New Motor()
        Next
    End Sub

    Private Sub UpdateListBox()

        ' Update the lost box contents
        Dim i As Integer
        Dim str As String = ""

        ' Clear the list box
        lstMotors.Items.Clear()
        ' Load the ID numbers in the array
        ' into the list box

        For i = 0 To intMotorCount - 1                  ' Loop through the array of motors
            str = "ID: " & motors(i).MotorId & ", " &  ' (Line 26-28) Concatenates content of the fields and adds it to the motors property to the listbox (Line 29)
                motors(i).Description & ", " & motors(i).RPM & " RPM, " &
                motors(i).Voltage & " volts, status = " & motors(i).Status
            lstMotors.Items.Add(str)                   ' Convert each motor into a string
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Display the add form

        Dim frmAdd As New AddForm()
        frmAdd.ShowDialog()
        UpdateListBox()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class