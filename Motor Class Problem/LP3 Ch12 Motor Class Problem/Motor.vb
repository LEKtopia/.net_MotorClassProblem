Public Class Motor
    Private strId As String             ' Holds the ID number
    Private strDescription As String    ' Holds the description
    Private sngRpm As Single            ' Holds the RPMs
    Private sngVoltage As Single        ' Holds the voltage
    Private strStatus As String         ' Holds the status

    ' Constructor
    Public Sub New()
        strId = String.Empty
        strDescription = String.Empty
        sngRpm = 0
        sngVoltage = 0
        strStatus = String.Empty
    End Sub

    Public Property MotorId() As String
        Get
            Return strId
        End Get
        Set(ByVal value As String)
            strId = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return strDescription
        End Get
        Set(ByVal value As String)
            strDescription = value
        End Set
    End Property

    Public Property RPM() As Single
        Get
            Return sngRpm
        End Get
        Set(ByVal value As Single)
            sngRpm = value
        End Set
    End Property

    Public Property Voltage() As Single
        Get
            Return sngVoltage
        End Get
        Set(ByVal value As Single)
            sngVoltage = value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return strStatus
        End Get
        Set(ByVal value As String)
            strStatus = value
        End Set
    End Property
End Class
