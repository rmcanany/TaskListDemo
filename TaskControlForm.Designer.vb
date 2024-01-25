<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskControlForm
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
        Me.FLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'FLP
        '
        Me.FLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP.Location = New System.Drawing.Point(0, 0)
        Me.FLP.Margin = New System.Windows.Forms.Padding(0)
        Me.FLP.Name = "FLP"
        Me.FLP.Size = New System.Drawing.Size(800, 450)
        Me.FLP.TabIndex = 0
        Me.FLP.WrapContents = False
        '
        'TaskControlForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FLP)
        Me.Name = "TaskControlForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FLP As FlowLayoutPanel
End Class
