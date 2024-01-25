Public Class TaskControlForm

    Dim TaskList As List(Of cTask)

    Private Sub TaskControlForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        InitializeTasks()

        For Each tmpTask As cTask In TaskList

            Dim tmpTC = New TaskControl With {
                .Task_Name = tmpTask.Task_Name,
                .Image_Name = tmpTask.Image_Name,
                .Task_Enabled = tmpTask.Task_Enabled,
                .asm = tmpTask.asm,
                .par = tmpTask.par,
                .psm = tmpTask.psm,
                .dft = tmpTask.dft,
                .HelpText = tmpTask.HelpText,
                .Option_1 = tmpTask.Option_1,
                .Option_2 = tmpTask.Option_2,
                .Option_1_Name = tmpTask.Option_1_Name,
                .Option_2_Name = tmpTask.Option_2_Name
            }

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
            .HelpText = "Open and saves the file",
            .Option_1 = False,
            .Option_2 = False,
            .Option_1_Name = "",
            .Option_2_Name = ""
        }

        TaskList.Add(tmpTask)

        tmpTask = New cTask With {
            .Task_Name = "Activate and update all",
            .Image_Name = "Update_16",
            .Task_Enabled = True,
            .asm = True,
            .par = False,
            .psm = False,
            .dft = False,
            .HelpText = "Activate and update all",
            .Option_1 = False,
            .Option_2 = False,
            .Option_1_Name = "",
            .Option_2_Name = ""
        }

        TaskList.Add(tmpTask)

        tmpTask = New cTask With {
            .Task_Name = "Property find\replace",
            .Image_Name = "Synchronize_16",
            .Task_Enabled = True,
            .asm = True,
            .par = True,
            .psm = True,
            .dft = False,
            .HelpText = "Property find\replace",
            .Option_1 = False,
            .Option_2 = False,
            .Option_1_Name = "",
            .Option_2_Name = ""
        }

        TaskList.Add(tmpTask)

        tmpTask = New cTask With {
            .Task_Name = "Update physical properties",
            .Image_Name = "skull_16",
            .Task_Enabled = True,
            .asm = True,
            .par = True,
            .psm = True,
            .dft = False,
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
            .dft = False,
            .HelpText = "Variable add\edit\expose",
            .Option_1 = False,
            .Option_2 = False,
            .Option_1_Name = "",
            .Option_2_Name = ""
        }

        TaskList.Add(tmpTask)

    End Sub

End Class

Public Class cTask

    Public Task_Name As String = ""
    Public Image_Name As String = ""

    Public Task_Enabled As Boolean = True
    Public asm As Boolean = False
    Public par As Boolean = False
    Public psm As Boolean = False
    Public dft As Boolean = False

    Public HelpText As String = ""

    Public Option_1 As Boolean = False
    Public Option_2 As Boolean = False

    Public Option_1_Name As String = ""
    Public Option_2_Name As String = ""

End Class
