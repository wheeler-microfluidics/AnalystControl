Public Class AnalystRemoteHandler
    Dim context As NetMQ.NetMQContext
    Dim poller As NetMQ.Poller
    Dim repSocket As NetMQ.NetMQSocket
    Dim analystControl As AnalystControl
    Dim initialized As Boolean
    Dim responseCode

    Public Sub New(ByRef analystControl_ As AnalystControl)
        analystControl = analystControl_
        responseCode = Nothing
    End Sub

    Public Sub Close()
        If initialized Then
            poller.CancelAndJoin()
            repSocket.Close()
            context.Terminate()
        End If
    End Sub

    Public Sub setUris(rep_uri As String)
        If initialized Then
            Close()
        End If

        context = NetMQ.NetMQContext.Create()
        repSocket = context.CreateResponseSocket()
        repSocket.Bind(rep_uri)
        AddHandler repSocket.SendReady, AddressOf repSocket_SendReady
        AddHandler repSocket.ReceiveReady, AddressOf repSocket_ReceiveReady

        poller = New NetMQ.Poller()
        poller.AddSocket(repSocket)
        initialized = True
        poller.PollTillCancelledNonBlocking()
        Console.WriteLine("Polling...")
    End Sub

    Protected Sub DisplayRepMsg(message As String)
        System.Console.WriteLine(message)
    End Sub

    Protected Overridable Sub repSocket_ReceiveReady(ByVal sender As Object, ByVal e As NetMQ.NetMQSocketEventArgs)
        Dim reqMsg As String
        reqMsg = NetMQ.ReceivingSocketExtensions.ReceiveFrameString(e.Socket)
        Try
            If reqMsg = "Connect" Then
                analystControl.Connect()
                'analystControlForm.Draw()
            ElseIf reqMsg = "QueueConnect" Then
                analystControl.QueueConnect(True)
                'analystControlForm.Draw()
            ElseIf reqMsg = "Ready" Then
                analystControl.Ready()
            ElseIf reqMsg = "StartAcquisition" Then
                analystControl.StartAcquisition()
            ElseIf reqMsg = "StopAcquisition" Then
                analystControl.StopAcquisition()
            ElseIf reqMsg = "StopQueue" Then
                analystControl.StopQueue()
            Else
                responseCode = "UNKNOWN:" + reqMsg
                Return
            End If
            responseCode = "OK:" + reqMsg
        Catch
            responseCode = "ERROR:" + reqMsg
        End Try
    End Sub

    Protected Overridable Sub repSocket_SendReady(ByVal sender As Object, ByVal e As NetMQ.NetMQSocketEventArgs)
        NetMQ.OutgoingSocketExtensions.SendFrame(e.Socket, responseCode)
    End Sub
End Class
