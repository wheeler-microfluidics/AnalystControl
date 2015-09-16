Public Class AnalystControl
    Dim theAnalyst
    Dim theQueueDir As QueueDirLib.QMDirector ' used to get "theQueue"
    Dim theQueue As QueueManagerLib.QueueManager ' object to get

    Public Function Connect()
        theAnalyst = GetObject(, "Analyst.Application")
        Return Not IsNothing(theAnalyst)
    End Function

    Public Sub Ready()
        theQueue.Ready()
    End Sub

    Public Sub Start()
        theQueue.StartAcquisition()
    End Sub

    Public Sub StopQueue()
        theQueue.StopQueue()
    End Sub

    Public Function QueueConnect(Optional createIfDoesNotExist As Boolean = False)
        ' Get the Queue director object from Analyst.
        theQueueDir = theAnalyst.Queue
        ' Get the QueueManager object from the Queue director.
        ' Note that it is essential that we make "Acquire" mode
        ' active before doing this.
        theAnalyst.Mode = 2

        Dim tempQueue = theQueueDir.GetIUnknownQMan(createIfDoesNotExist)

        If Not IsNothing(tempQueue) Then
            theQueue = tempQueue
            Return True
        Else
            Return False
        End If
    End Function
End Class