Public Class MessageHandler
    Dim context As NetMQ.NetMQContext
    Dim poller As NetMQ.Poller
    Dim repSocket As NetMQ.NetMQSocket

    Public Sub New(rep_uri As String)
        setUris(rep_uri)
    End Sub

    Public Sub setUris(rep_uri As String)
        Try
            poller.CancelAndJoin()
            repSocket.Close()
            context.Terminate()
        Catch nullRefEx As NullReferenceException
        End Try

        context = NetMQ.NetMQContext.Create()
        repSocket = context.CreateResponseSocket()
        repSocket.Bind(rep_uri)
        AddHandler repSocket.SendReady, AddressOf repSocket_SendReady
        AddHandler repSocket.ReceiveReady, AddressOf repSocket_ReceiveReady

        poller = New NetMQ.Poller()
        poller.AddSocket(repSocket)
        poller.PollTillCancelledNonBlocking()
        Console.WriteLine("Polling...")
    End Sub

    Private Sub DisplayRepMsg(message As String)
        System.Console.WriteLine(message)
    End Sub

    Private Sub repSocket_ReceiveReady(ByVal sender As Object, ByVal e As NetMQ.NetMQSocketEventArgs)
        Dim reqMsg = NetMQ.ReceivingSocketExtensions.ReceiveFrameString(e.Socket)
        DisplayRepMsg("REP, received: " + reqMsg)
    End Sub

    Private Sub repSocket_SendReady(ByVal sender As Object, ByVal e As NetMQ.NetMQSocketEventArgs)
        DisplayRepMsg("REP, sending: Sync OK")
        NetMQ.OutgoingSocketExtensions.SendFrame(e.Socket, "Sync OK")
    End Sub
End Class
