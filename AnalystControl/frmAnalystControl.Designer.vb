<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalystControl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.grpAnalyst = New System.Windows.Forms.GroupBox()
        Me.lblAnalystStatus = New System.Windows.Forms.Label()
        Me.lblAnalystStatusTag = New System.Windows.Forms.Label()
        Me.grpQueue = New System.Windows.Forms.GroupBox()
        Me.btnQueueStopAcquisition = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblStatusTag = New System.Windows.Forms.Label()
        Me.btnQueueConnect = New System.Windows.Forms.Button()
        Me.btnQueueStop = New System.Windows.Forms.Button()
        Me.btnQueueStart = New System.Windows.Forms.Button()
        Me.btnQueueReady = New System.Windows.Forms.Button()
        Me.grpRemoteControl = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRemoteOnOff = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.grpAnalyst.SuspendLayout()
        Me.grpQueue.SuspendLayout()
        Me.grpRemoteControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(136, 20)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(56, 20)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'grpAnalyst
        '
        Me.grpAnalyst.Controls.Add(Me.lblAnalystStatus)
        Me.grpAnalyst.Controls.Add(Me.lblAnalystStatusTag)
        Me.grpAnalyst.Controls.Add(Me.grpQueue)
        Me.grpAnalyst.Controls.Add(Me.btnConnect)
        Me.grpAnalyst.Location = New System.Drawing.Point(9, 10)
        Me.grpAnalyst.Margin = New System.Windows.Forms.Padding(2)
        Me.grpAnalyst.Name = "grpAnalyst"
        Me.grpAnalyst.Padding = New System.Windows.Forms.Padding(2)
        Me.grpAnalyst.Size = New System.Drawing.Size(321, 186)
        Me.grpAnalyst.TabIndex = 3
        Me.grpAnalyst.TabStop = False
        Me.grpAnalyst.Text = "Analyst"
        '
        'lblAnalystStatus
        '
        Me.lblAnalystStatus.AutoSize = True
        Me.lblAnalystStatus.ForeColor = System.Drawing.Color.Orange
        Me.lblAnalystStatus.Location = New System.Drawing.Point(56, 23)
        Me.lblAnalystStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAnalystStatus.Name = "lblAnalystStatus"
        Me.lblAnalystStatus.Size = New System.Drawing.Size(86, 15)
        Me.lblAnalystStatus.TabIndex = 7
        Me.lblAnalystStatus.Text = "Not connected"
        Me.lblAnalystStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnalystStatusTag
        '
        Me.lblAnalystStatusTag.AutoSize = True
        Me.lblAnalystStatusTag.Location = New System.Drawing.Point(15, 23)
        Me.lblAnalystStatusTag.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAnalystStatusTag.Name = "lblAnalystStatusTag"
        Me.lblAnalystStatusTag.Size = New System.Drawing.Size(44, 15)
        Me.lblAnalystStatusTag.TabIndex = 6
        Me.lblAnalystStatusTag.Text = "Status:"
        Me.lblAnalystStatusTag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpQueue
        '
        Me.grpQueue.Controls.Add(Me.btnQueueStopAcquisition)
        Me.grpQueue.Controls.Add(Me.lblStatus)
        Me.grpQueue.Controls.Add(Me.lblStatusTag)
        Me.grpQueue.Controls.Add(Me.btnQueueConnect)
        Me.grpQueue.Controls.Add(Me.btnQueueStop)
        Me.grpQueue.Controls.Add(Me.btnQueueStart)
        Me.grpQueue.Controls.Add(Me.btnQueueReady)
        Me.grpQueue.Enabled = False
        Me.grpQueue.Location = New System.Drawing.Point(10, 54)
        Me.grpQueue.Margin = New System.Windows.Forms.Padding(2)
        Me.grpQueue.Name = "grpQueue"
        Me.grpQueue.Padding = New System.Windows.Forms.Padding(2)
        Me.grpQueue.Size = New System.Drawing.Size(301, 74)
        Me.grpQueue.TabIndex = 3
        Me.grpQueue.TabStop = False
        Me.grpQueue.Text = "Queue"
        '
        'btnQueueStopAcquisition
        '
        Me.btnQueueStopAcquisition.Enabled = False
        Me.btnQueueStopAcquisition.Location = New System.Drawing.Point(127, 49)
        Me.btnQueueStopAcquisition.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQueueStopAcquisition.Name = "btnQueueStopAcquisition"
        Me.btnQueueStopAcquisition.Size = New System.Drawing.Size(107, 19)
        Me.btnQueueStopAcquisition.TabIndex = 6
        Me.btnQueueStopAcquisition.Text = "Stop acquisition"
        Me.btnQueueStopAcquisition.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.Orange
        Me.lblStatus.Location = New System.Drawing.Point(45, 22)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(86, 15)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Not connected"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatusTag
        '
        Me.lblStatusTag.AutoSize = True
        Me.lblStatusTag.Location = New System.Drawing.Point(4, 22)
        Me.lblStatusTag.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatusTag.Name = "lblStatusTag"
        Me.lblStatusTag.Size = New System.Drawing.Size(44, 15)
        Me.lblStatusTag.TabIndex = 4
        Me.lblStatusTag.Text = "Status:"
        Me.lblStatusTag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQueueConnect
        '
        Me.btnQueueConnect.Location = New System.Drawing.Point(135, 17)
        Me.btnQueueConnect.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQueueConnect.Name = "btnQueueConnect"
        Me.btnQueueConnect.Size = New System.Drawing.Size(56, 19)
        Me.btnQueueConnect.TabIndex = 3
        Me.btnQueueConnect.Text = "Connect"
        Me.btnQueueConnect.UseVisualStyleBackColor = True
        '
        'btnQueueStop
        '
        Me.btnQueueStop.Enabled = False
        Me.btnQueueStop.Location = New System.Drawing.Point(238, 49)
        Me.btnQueueStop.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQueueStop.Name = "btnQueueStop"
        Me.btnQueueStop.Size = New System.Drawing.Size(56, 19)
        Me.btnQueueStop.TabIndex = 2
        Me.btnQueueStop.Text = "Stop"
        Me.btnQueueStop.UseVisualStyleBackColor = True
        '
        'btnQueueStart
        '
        Me.btnQueueStart.Enabled = False
        Me.btnQueueStart.Location = New System.Drawing.Point(67, 49)
        Me.btnQueueStart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQueueStart.Name = "btnQueueStart"
        Me.btnQueueStart.Size = New System.Drawing.Size(56, 19)
        Me.btnQueueStart.TabIndex = 1
        Me.btnQueueStart.Text = "Start"
        Me.btnQueueStart.UseVisualStyleBackColor = True
        '
        'btnQueueReady
        '
        Me.btnQueueReady.Enabled = False
        Me.btnQueueReady.Location = New System.Drawing.Point(6, 49)
        Me.btnQueueReady.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQueueReady.Name = "btnQueueReady"
        Me.btnQueueReady.Size = New System.Drawing.Size(56, 19)
        Me.btnQueueReady.TabIndex = 0
        Me.btnQueueReady.Text = "Ready"
        Me.btnQueueReady.UseVisualStyleBackColor = True
        '
        'grpRemoteControl
        '
        Me.grpRemoteControl.Controls.Add(Me.Label1)
        Me.grpRemoteControl.Controls.Add(Me.Label2)
        Me.grpRemoteControl.Controls.Add(Me.btnRemoteOnOff)
        Me.grpRemoteControl.Controls.Add(Me.Button2)
        Me.grpRemoteControl.Controls.Add(Me.Button3)
        Me.grpRemoteControl.Controls.Add(Me.Button4)
        Me.grpRemoteControl.Location = New System.Drawing.Point(10, 203)
        Me.grpRemoteControl.Margin = New System.Windows.Forms.Padding(2)
        Me.grpRemoteControl.Name = "grpRemoteControl"
        Me.grpRemoteControl.Padding = New System.Windows.Forms.Padding(2)
        Me.grpRemoteControl.Size = New System.Drawing.Size(252, 74)
        Me.grpRemoteControl.TabIndex = 4
        Me.grpRemoteControl.TabStop = False
        Me.grpRemoteControl.Text = "Remote control"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(45, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Disabled"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Status:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRemoteOnOff
        '
        Me.btnRemoteOnOff.Location = New System.Drawing.Point(153, 20)
        Me.btnRemoteOnOff.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemoteOnOff.Name = "btnRemoteOnOff"
        Me.btnRemoteOnOff.Size = New System.Drawing.Size(56, 19)
        Me.btnRemoteOnOff.TabIndex = 3
        Me.btnRemoteOnOff.Text = "Enable"
        Me.btnRemoteOnOff.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(187, 49)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 19)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(126, 49)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 19)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Start"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(65, 49)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 19)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Ready"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmAnalystControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 306)
        Me.Controls.Add(Me.grpRemoteControl)
        Me.Controls.Add(Me.grpAnalyst)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAnalystControl"
        Me.Text = "AnalystControl"
        Me.grpAnalyst.ResumeLayout(False)
        Me.grpAnalyst.PerformLayout()
        Me.grpQueue.ResumeLayout(False)
        Me.grpQueue.PerformLayout()
        Me.grpRemoteControl.ResumeLayout(False)
        Me.grpRemoteControl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConnect As Button
    Friend WithEvents grpAnalyst As GroupBox
    Friend WithEvents grpQueue As GroupBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblStatusTag As Label
    Friend WithEvents btnQueueConnect As Button
    Friend WithEvents btnQueueStop As Button
    Friend WithEvents btnQueueStart As Button
    Friend WithEvents btnQueueReady As Button
    Friend WithEvents lblAnalystStatus As Label
    Friend WithEvents lblAnalystStatusTag As Label
    Friend WithEvents grpRemoteControl As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRemoteOnOff As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnQueueStopAcquisition As Button
End Class
