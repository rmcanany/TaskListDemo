Public Class TaskControlForm

    Dim TaskList As List(Of cTask)
    Dim VerticalBorders As Boolean = True

    Private Sub TaskControlForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        InitializeTasks()

        For Each tmpTask As cTask In TaskList

            Dim tmpTC = New UCTaskTLP
            tmpTC.Task = tmpTask

            tmpTC.Initialize()
            tmpTC.VerticalBorders(VerticalBorders)

            'AddHandler tmpTC.UserClick, AddressOf Me.tmpTC_Click

            tmpTC.Dock = DockStyle.Top

            Panel3.Controls.Add(tmpTC)
            'FLP.Controls.Add(tmpTC)
            'SetupAnchors()

        Next

    End Sub

    'Private Sub SetupAnchors()
    '    If FLP.Controls.Count > 0 Then
    '        For i = 0 To FLP.Controls.Count - 1
    '            Dim c As Control = FLP.Controls(i)
    '            If i = 0 Then
    '                ' Its the first control, all subsequent controls follow
    '                ' the anchor behavior of this control.

    '                c.Width = FLP.Width - 2
    '                c.Anchor = AnchorStyles.Left + AnchorStyles.Top

    '                'If FLP_Richieste.VerticalScroll.Visible Then c.Width += -SystemInformation.VerticalScrollBarWidth
    '            Else

    '                ' It is not the first control. Set its anchor to
    '                ' copy the width of the first control in the list.
    '                c.Anchor = AnchorStyles.Left + AnchorStyles.Right

    '            End If
    '        Next
    '    End If
    'End Sub

    Private Sub InitializeTasks()

        TaskList = New List(Of cTask)

        Dim tmpTask As cTask

        'tmpTask = New cTask("Title")
        'TaskList.Add(tmpTask)

        tmpTask = New cTask("Open\Save")
        TaskList.Add(tmpTask)

        tmpTask = New cTask("Save as 2D")
        TaskList.Add(tmpTask)

        tmpTask = New cTask("Save as 3D")
        TaskList.Add(tmpTask)

        tmpTask = New cTask("Activate and update all")
        TaskList.Add(tmpTask)

        tmpTask = New cTask("Property find\replace")
        TaskList.Add(tmpTask)

        tmpTask = New cTask("Update physical properties")
        TaskList.Add(tmpTask)

        tmpTask = New cTask("Variable add\edit\expose")
        TaskList.Add(tmpTask)


    End Sub

    'Private Sub FLP_SizeChanged(sender As Object, e As EventArgs)

    '    For i = 0 To FLP.Controls.Count - 1
    '        Dim c As Control = FLP.Controls(i)
    '        If i = 0 Then

    '            c.Width = FLP.Width - 2

    '        End If
    '    Next

    'End Sub

End Class


