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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblStatusTag = New System.Windows.Forms.Label()
        Me.btnQueueConnect = New System.Windows.Forms.Button()
        Me.btnQueueStop = New System.Windows.Forms.Button()
        Me.btnQueueStart = New System.Windows.Forms.Button()
        Me.btnQueueReady = New System.Windows.Forms.Button()
        Me.grpAnalyst.SuspendLayout()
        Me.grpQueue.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(182, 24)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 24)
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
        Me.grpAnalyst.Location = New System.Drawing.Point(12, 12)
        Me.grpAnalyst.Name = "grpAnalyst"
        Me.grpAnalyst.Size = New System.Drawing.Size(425, 229)
        Me.grpAnalyst.TabIndex = 3
        Me.grpAnalyst.TabStop = False
        Me.grpAnalyst.Text = "Analyst"
        '
        'lblAnalystStatus
        '
        Me.lblAnalystStatus.AutoSize = True
        Me.lblAnalystStatus.ForeColor = System.Drawing.Color.Orange
        Me.lblAnalystStatus.Location = New System.Drawing.Point(74, 28)
        Me.lblAnalystStatus.Name = "lblAnalystStatus"
        Me.lblAnalystStatus.Size = New System.Drawing.Size(95, 16)
        Me.lblAnalystStatus.TabIndex = 7
        Me.lblAnalystStatus.Text = "Not connected"
        Me.lblAnalystStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnalystStatusTag
        '
        Me.lblAnalystStatusTag.AutoSize = True
        Me.lblAnalystStatusTag.Location = New System.Drawing.Point(20, 28)
        Me.lblAnalystStatusTag.Name = "lblAnalystStatusTag"
        Me.lblAnalystStatusTag.Size = New System.Drawing.Size(48, 16)
        Me.lblAnalystStatusTag.TabIndex = 6
        Me.lblAnalystStatusTag.Text = "Status:"
        Me.lblAnalystStatusTag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpQueue
        '
        Me.grpQueue.Controls.Add(Me.lblStatus)
        Me.grpQueue.Controls.Add(Me.lblStatusTag)
        Me.grpQueue.Controls.Add(Me.btnQueueConnect)
        Me.grpQueue.Controls.Add(Me.btnQueueStop)
        Me.grpQueue.Controls.Add(Me.btnQueueStart)
        Me.grpQueue.Controls.Add(Me.btnQueueReady)
        Me.grpQueue.Enabled = False
        Me.grpQueue.Location = New System.Drawing.Point(14, 67)
        Me.grpQueue.Name = "grpQueue"
        Me.grpQueue.Size = New System.Drawing.Size(336, 91)
        Me.grpQueue.TabIndex = 3
        Me.grpQueue.TabStop = False
        Me.grpQueue.Text = "Queue"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.Orange
        Me.lblStatus.Location = New System.Drawing.Point(60, 27)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(95, 16)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Not connected"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatusTag
        '
        Me.lblStatusTag.AutoSize = True
        Me.lblStatusTag.Location = New System.Drawing.Point(6, 27)
        Me.lblStatusTag.Name = "lblStatusTag"
        Me.lblStatusTag.Size = New System.Drawing.Size(48, 16)
        Me.lblStatusTag.TabIndex = 4
        Me.lblStatusTag.Text = "Status:"
        Me.lblStatusTag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQueueConnect
        '
        Me.btnQueueConnect.Location = New System.Drawing.Point(6, 60)
        Me.btnQueueConnect.Name = "btnQueueConnect"
        Me.btnQueueConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnQueueConnect.TabIndex = 3
        Me.btnQueueConnect.Text = "Connect"
        Me.btnQueueConnect.UseVisualStyleBackColor = True
        '
        'btnQueueStop
        '
        Me.btnQueueStop.Enabled = False
        Me.btnQueueStop.Location = New System.Drawing.Point(249, 60)
        Me.btnQueueStop.Name = "btnQueueStop"
        Me.btnQueueStop.Size = New System.Drawing.Size(75, 23)
        Me.btnQueueStop.TabIndex = 2
        Me.btnQueueStop.Text = "Stop"
        Me.btnQueueStop.UseVisualStyleBackColor = True
        '
        'btnQueueStart
        '
        Me.btnQueueStart.Enabled = False
        Me.btnQueueStart.Location = New System.Drawing.Point(168, 60)
        Me.btnQueueStart.Name = "btnQueueStart"
        Me.btnQueueStart.Size = New System.Drawing.Size(75, 23)
        Me.btnQueueStart.TabIndex = 1
        Me.btnQueueStart.Text = "Start"
        Me.btnQueueStart.UseVisualStyleBackColor = True
        '
        'btnQueueReady
        '
        Me.btnQueueReady.Enabled = False
        Me.btnQueueReady.Location = New System.Drawing.Point(87, 60)
        Me.btnQueueReady.Name = "btnQueueReady"
        Me.btnQueueReady.Size = New System.Drawing.Size(75, 23)
        Me.btnQueueReady.TabIndex = 0
        Me.btnQueueReady.Text = "Ready"
        Me.btnQueueReady.UseVisualStyleBackColor = True
        '
        'frmAnalystControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 253)
        Me.Controls.Add(Me.grpAnalyst)
        Me.Name = "frmAnalystControl"
        Me.Text = "AnalystControl"
        Me.grpAnalyst.ResumeLayout(False)
        Me.grpAnalyst.PerformLayout()
        Me.grpQueue.ResumeLayout(False)
        Me.grpQueue.PerformLayout()
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
End Class
