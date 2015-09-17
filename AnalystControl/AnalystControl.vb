Imports SampleStatusServerLib
Imports QueueSvr


Public Class AnalystControl
    Private theAnalyst
    Private theQueueDir As QueueDirLib.QMDirector ' used to get "theQueue"
    Private theQueue As QueueManagerLib.QueueManager
    Dim WithEvents status As SampleStatusSvr

    ' Declare an event. 
    Public Event Analyst_Initialized()
    Public Event Queue_Initialized()
    Public Event Queue_Ready()
    Public Event Queue_SampleWaiting()
    Public Event Queue_Acquiring()
    Public Event Queue_StateUpdate(state As String)

    Public Function Connect()
        theAnalyst = GetObject(, "Analyst.Application")
        If Not IsNothing(theAnalyst) Then
            status = New SampleStatusSvr()
            status.SubscribeToLocalQSD()

            AddHandler status.QServerStateUpdate, AddressOf status_QServerStateUpdate            RaiseEvent Analyst_Initialized()
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub status_QServerStateUpdate(ByVal pdispQServerState As Object)
        Dim objQServerState As QServerState
        objQServerState = pdispQServerState

        Dim enumState As QSERVER_STATUS
        enumState = objQServerState.State
        Dim state
        Select Case enumState
            Case QSERVER_STATUS.QS_UNDEFINED
                state = "Undefined"
            Case QSERVER_STATUS.QS_NOT_READY
                state = "Not Ready"
            Case QSERVER_STATUS.QS_WAITING_SMSETSTATEREADY
                state = "Sync Ready"
            Case QSERVER_STATUS.QS_WAITING_SMSETSTATENOTREADY
                state = "Sync Not Ready"
            Case QSERVER_STATUS.QS_WAITING_SMSTANDBY
                state = "Sync Standby"
            Case QSERVER_STATUS.QS_STANDBY
                state = "Standby"
            Case QSERVER_STATUS.QS_WARMING_UP
                state = "Warming Up"
            Case QSERVER_STATUS.QS_WAITING_SMREADY
                state = "Wait Sync Ready"
            Case QSERVER_STATUS.QS_READY
                state = "Ready"
                RaiseEvent Queue_Ready()
            Case QSERVER_STATUS.QS_WAITING_SAMPLE
                state = "Sample Waiting"
                RaiseEvent Queue_SampleWaiting()
            Case QSERVER_STATUS.QS_DOWNLOADING
                state = "Downloading"
            Case QSERVER_STATUS.QS_ACQUIRING
                state = "Acquiring"
                RaiseEvent Queue_Acquiring()
            Case QSERVER_STATUS.QS_STOPPING
                state = "Stopping"
            Case QSERVER_STATUS.QS_ABORTING
                state = "Aborting"
            Case QSERVER_STATUS.QS_PAUSED
                state = "Paused"
            Case Else
                state = Nothing
        End Select
        Console.WriteLine("Status update received: {0}", state)
        If Not IsNothing(state) Then
            RaiseEvent Queue_StateUpdate(state)
        End If
    End Sub

    Public Sub Ready()
        theQueue.Ready()
    End Sub

    Public Sub StartAcquisition()
        theQueue.StartAcquisition()
    End Sub

    Public Sub StopAcquisition()
        theQueue.StopAcquisition()
    End Sub

    Public Sub StopQueue()
        theQueue.StopQueue()
    End Sub

    Public Function QueueConnect(Optional createIfDoesNotExist As Boolean = False)
        Dim theDeletePane As Object
        Dim i As Integer
        For i = theAnalyst.ControlCount To 1 Step -1
            ' Get rid of the pane...
            theDeletePane = theAnalyst.GetPane(i)
            Console.WriteLine("Closing {0}", TypeName(theDeletePane.GetType()))
            theAnalyst.DeletePane(theDeletePane)
        Next i
        Console.WriteLine("{0} controls open.", theAnalyst.ControlCount)

        ' Get the Queue director object from Analyst.
        theQueueDir = theAnalyst.Queue
        ' Get the QueueManager object from the Queue director.
        ' Note that it is essential that we make "Acquire" mode
        ' active before doing this.
        theAnalyst.Mode = 2

        Dim tempQueue = theQueueDir.GetIUnknownQMan(createIfDoesNotExist)

        If Not IsNothing(tempQueue) Then
            theQueue = tempQueue
            RaiseEvent Queue_Initialized()
            Return True
        Else
            Return False
        End If
    End Function
End Class