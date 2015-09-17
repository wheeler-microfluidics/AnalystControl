Public Class AnalystControl
    Private theAnalyst
    Private theQueueDir As QueueDirLib.QMDirector ' used to get "theQueue"
    Private theQueue As QueueManagerLib.QueueManager ' object to get
    ' Declare an event. 
    Public Event Analyst_Initialized()
    Public Event Queue_Initialized()

    Public Function Connect()
        theAnalyst = GetObject(, "Analyst.Application")
        If Not IsNothing(theAnalyst) Then
            RaiseEvent Analyst_Initialized()
            Return True
        Else
            Return False
        End If
    End Function

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