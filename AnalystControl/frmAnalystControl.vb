Public Class frmAnalystControl
    Dim analystControl As AnalystControl

    Private Sub frmAnalystControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        analystControl = New AnalystControl()
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If analystControl.Connect() Then
            ' Connected to Analyst successfully.
            btnConnect.Enabled = False
            lblAnalystStatus.Text = "Connected"
            lblAnalystStatus.ForeColor = Color.FromName("DarkGreen")
            grpQueue.Enabled = True
        End If
    End Sub

    Private Sub btnQueueReady_Click(sender As Object, e As EventArgs) Handles btnQueueReady.Click
        analystControl.Ready()
    End Sub

    Private Sub btnQueueStart_Click(sender As Object, e As EventArgs) Handles btnQueueStart.Click
        analystControl.Start()
    End Sub

    Private Sub btnQueueStop_Click(sender As Object, e As EventArgs) Handles btnQueueStop.Click
        analystControl.StopQueue()
    End Sub

    Private Sub btnQueueConnect_Click(sender As Object, e As EventArgs) Handles btnQueueConnect.Click
        If analystControl.QueueConnect(True) Then
            ' Connected to Analyst queue successfully.
            lblStatus.Text = "Connected"
            lblStatus.ForeColor = Color.FromName("DarkGreen")
            btnQueueConnect.Enabled = False
            For Each button In {btnQueueReady, btnQueueStart, btnQueueStop}
                button.Enabled = True
            Next
        End If
    End Sub
End Class
