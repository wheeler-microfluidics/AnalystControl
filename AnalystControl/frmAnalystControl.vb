﻿Public Class frmAnalystControl
    Dim analystControl As AnalystControl
    Dim message_handler As AnalystRemoteHandler

    Private Sub frmAnalystControl_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        message_handler.Close()
    End Sub

    Private Sub frmAnalystControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        analystControl = New AnalystControl()
        message_handler = New AnalystRemoteHandler(analystControl)
        AddHandler analystControl.Analyst_Initialized, AddressOf EnableAnalystUI
        AddHandler analystControl.Queue_Initialized, AddressOf EnableQueueUI
        AddHandler message_handler.Handler_Connected, AddressOf ShowRemoteEnabled
        AddHandler message_handler.Handler_Closed, AddressOf ShowRemoteDisabled
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        analystControl.Connect()
    End Sub

    Private Sub btnQueueReady_Click(sender As Object, e As EventArgs) Handles btnQueueReady.Click
        analystControl.Ready()
    End Sub

    Private Sub btnQueueStart_Click(sender As Object, e As EventArgs) Handles btnQueueStart.Click
        analystControl.StartAcquisition()
    End Sub

    Private Sub btnStopAcquisition_Click(sender As Object, e As EventArgs) Handles btnQueueStopAcquisition.Click
        analystControl.StopAcquisition()
    End Sub

    Private Sub btnQueueStop_Click(sender As Object, e As EventArgs) Handles btnQueueStop.Click
        analystControl.StopQueue()
    End Sub

    Private Sub btnQueueConnect_Click(sender As Object, e As EventArgs) Handles btnQueueConnect.Click
        analystControl.QueueConnect(True)
    End Sub

    Delegate Sub EnableAnalystUICallback()

    Public Sub EnableAnalystUI()
        If Me.btnConnect.InvokeRequired Then
            Dim d As New EnableAnalystUICallback(AddressOf EnableAnalystUI)
            Me.Invoke(d)
        Else
            ' Connected to Analyst successfully.
            btnConnect.Enabled = False
            lblAnalystStatus.Text = "Connected"
            lblAnalystStatus.ForeColor = Color.FromName("DarkGreen")
            grpQueue.Enabled = True
        End If
    End Sub

    Delegate Sub EnableQueueUICallback()

    Public Sub EnableQueueUI()
        If Me.lblStatus.InvokeRequired Then
            Dim d As New EnableQueueUICallback(AddressOf EnableQueueUI)
            Me.Invoke(d)
        Else
            ' Connected to Analyst queue successfully.
            lblStatus.Text = "Connected"
            lblStatus.ForeColor = Color.FromName("DarkGreen")
            For Each button In {btnQueueReady, btnQueueStart, btnQueueStop,
                                btnQueueStopAcquisition}
                button.Enabled = True
            Next
        End If
    End Sub

    Private Sub btnRemoteOnOff_Click(sender As Object, e As EventArgs) Handles btnRemoteOnOff.Click
        If message_handler.Connected() Then
            message_handler.Close()
        Else
            message_handler.setUris(txtRemoteResponseUri.Text, txtRemotePublishUri.Text)
        End If
    End Sub

    Private Sub ShowRemoteEnabled()
        btnRemoteOnOff.Text = "Disable"
        lblRemoteStatus.Text = "Enabled"
        lblRemoteStatus.ForeColor = Color.FromName("DarkGreen")
        txtRemoteResponseUri.Enabled = False
        txtRemotePublishUri.Enabled = False
    End Sub

    Private Sub ShowRemoteDisabled()
        btnRemoteOnOff.Text = "Enable"
        lblRemoteStatus.Text = "Disabled"
        lblRemoteStatus.ForeColor = Color.FromName("Orange")
        txtRemoteResponseUri.Enabled = True
        txtRemotePublishUri.Enabled = True
    End Sub
End Class
