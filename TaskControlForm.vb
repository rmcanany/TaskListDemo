Public Class TaskControlForm

    Dim TaskList As List(Of cTask)

    Private Sub TaskControlForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        InitializeTasks()

        For Each tmpTask As cTask In TaskList

            Dim tmpTC = New TaskControl
            tmpTC.Task = tmpTask

            tmpTC.Initialize()
            tmpTC.Width = FLP.Width - 2

            'AddHandler tmpTC.UserClick, AddressOf Me.tmpTC_Click

            FLP.Controls.Add(tmpTC)
            SetupAnchors()

        Next

    End Sub

    Private Sub SetupAnchors()
        If FLP.Controls.Count > 0 Then
            For i = 0 To FLP.Controls.Count - 1
                Dim c As Control = FLP.Controls(i)
                If i = 0 Then
                    ' Its the first control, all subsequent controls follow
                    ' the anchor behavior of this control.
                    'c.Anchor = AnchorStyles.Left + AnchorStyles.Top
                    'c.Width = FLP_Richieste.Width - 10
                    'If FLP_Richieste.VerticalScroll.Visible Then c.Width += -SystemInformation.VerticalScrollBarWidth
                Else
                    ' It is not the first control. Set its anchor to
                    ' copy the width of the first control in the list.
                    c.Anchor = AnchorStyles.Left + AnchorStyles.Right
                End If
            Next
        End If
    End Sub

    Private Sub InitializeTasks()

        TaskList = New List(Of cTask)

        Dim tmpTask As New cTask With {
            .Task_Name = "Open\Save",
            .Image_Name = "Save_16",
            .Task_Enabled = True,
            .asm = True,
            .par = True,
            .psm = True,
            .dft = True,
            .HelpText = "Open and saves the file"
        }

        TaskList.Add(tmpTask)

        tmpTask = New cTask With {
            .Task_Name = "Save as",
            .Image_Name = "Update_16",
            .Task_Enabled = True,
            .dft = True,
            .HelpText = "Save as",
            .Combo = True,
            .ComboValue = New List(Of String)(New String() {".dxf", ".dwg", ".pdf"})
        }

        TaskList.Add(tmpTask)

        tmpTask = New cTask With {
            .Task_Name = "Save as",
            .Image_Name = "Update_16",
            .Task_Enabled = True,
            .asm = True,
            .par = True,
            .psm = True,
            .HelpText = "Save as",
            .Combo = True,
            .ComboValue = New List(Of String)(New String() {".x_t", ".stp", ".igs", ".stl", ".ifc"})
        }

        TaskList.Add(tmpTask)

        tmpTask = New cTask With {
            .Task_Name = "Activate and update all",
            .Image_Name = "Update_16",
            .Task_Enabled = True,
            .asm = True,
            .HelpText = "Activate and update all"
        }

        TaskList.Add(tmpTask)

        tmpTask = New cTask With {
            .Task_Name = "Property find\replace",
            .Image_Name = "Synchronize_16",
            .Task_Enabled = True,
            .asm = True,
            .par = True,
            .psm = True,
            .HelpText = "Property find\replace"
        }

        TaskList.Add(tmpTask)

        tmpTask = New cTask With {
            .Task_Name = "Update physical properties",
            .Image_Name = "skull_16",
            .Task_Enabled = True,
            .asm = True,
            .par = True,
            .psm = True,
            .HelpText = "Update physical properties",
            .Option_1 = True,
            .Option_2 = True,
            .Option_1_Name = "Show center of mass",
            .Option_2_Name = "Hide center of mass"
        }

        TaskList.Add(tmpTask)

        tmpTask = New cTask With {
            .Task_Name = "Variable add\edit\expose",
            .Image_Name = "Drill_16",
            .Task_Enabled = True,
            .asm = True,
            .par = True,
            .psm = True,
            .HelpText = "Variable add\edit\expose",
            .Configurable = True,
            .Configuration = "example configuration text"
        }

        TaskList.Add(tmpTask)

    End Sub

End Class


