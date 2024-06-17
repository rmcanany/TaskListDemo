Imports System.Runtime.InteropServices

Public Class TaskControlForm

    Dim TaskList As List(Of cTask)

    Private Sub TaskControlForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        InitializeTasks()

        For Each tmpTask As cTask In TaskList

            Dim tmpTC = New TaskControl

            tmpTC.Task_Name = tmpTask.Task_Name
            tmpTC.Image_Name = tmpTask.Image_Name

            tmpTC.Task_Enabled = tmpTask.Task_Enabled
            tmpTC.asm = tmpTask.asm
            tmpTC.par = tmpTask.par
            tmpTC.psm = tmpTask.psm
            tmpTC.dft = tmpTask.dft

            tmpTC.HelpText = tmpTask.HelpText

            tmpTC.Option_1 = tmpTask.Option_1
            tmpTC.Option_2 = tmpTask.Option_2

            tmpTC.Option_1_Name = tmpTask.Option_1_Name
            tmpTC.Option_2_Name = tmpTask.Option_2_Name

            tmpTC.Initialize()

            tmpTC.Dock = DockStyle.Top

            Panel3.Controls.Add(tmpTC)

            'tmpTC.Width = FLP.Width - 2
            ''AddHandler tmpTC.UserClick, AddressOf Me.tmpTC_Click

            'FLP.Controls.Add(tmpTC)
            'SetupAnchors()

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

        Dim tmpTask As New cTask

        For i = 10 To 0 Step -1
            tmpTask = New cTask
            tmpTask.Task_Name = String.Format("Task number {0}", i)
            tmpTask.Image_Name = "Drill_16"

            tmpTask.Task_Enabled = True
            tmpTask.asm = True
            tmpTask.par = True
            tmpTask.psm = True
            tmpTask.dft = False

            tmpTask.HelpText = tmpTask.Task_Name

            tmpTask.Option_1 = True
            tmpTask.Option_2 = True

            tmpTask.Option_1_Name = "Option 1"
            tmpTask.Option_2_Name = "Option 2"

            TaskList.Add(tmpTask)
        Next

        tmpTask.Task_Name = "Open\Save"
        tmpTask.Image_Name = "Save_16"

        tmpTask.Task_Enabled = True
        tmpTask.asm = True
        tmpTask.par = True
        tmpTask.psm = True
        tmpTask.dft = True

        tmpTask.HelpText = "Open and saves the file"

        tmpTask.Option_1 = False
        tmpTask.Option_2 = False

        tmpTask.Option_1_Name = ""
        tmpTask.Option_2_Name = ""

        TaskList.Add(tmpTask)

        tmpTask = New cTask
        tmpTask.Task_Name = "Activate and update all"
        tmpTask.Image_Name = "Update_16"

        tmpTask.Task_Enabled = True
        tmpTask.asm = True
        tmpTask.par = False
        tmpTask.psm = False
        tmpTask.dft = False

        tmpTask.HelpText = "Activate and update all"

        tmpTask.Option_1 = False
        tmpTask.Option_2 = False

        tmpTask.Option_1_Name = ""
        tmpTask.Option_2_Name = ""

        TaskList.Add(tmpTask)

        tmpTask = New cTask
        tmpTask.Task_Name = "Property find\replace"
        tmpTask.Image_Name = "Synchronize_16"

        tmpTask.Task_Enabled = True
        tmpTask.asm = True
        tmpTask.par = True
        tmpTask.psm = True
        tmpTask.dft = False

        tmpTask.HelpText = "Property find\replace"

        tmpTask.Option_1 = False
        tmpTask.Option_2 = False

        tmpTask.Option_1_Name = ""
        tmpTask.Option_2_Name = ""

        TaskList.Add(tmpTask)

        tmpTask = New cTask
        tmpTask.Task_Name = "Update physical properties"
        tmpTask.Image_Name = "skull_16"

        tmpTask.Task_Enabled = True
        tmpTask.asm = True
        tmpTask.par = True
        tmpTask.psm = True
        tmpTask.dft = False

        tmpTask.HelpText = "Update physical properties"

        tmpTask.Option_1 = True
        tmpTask.Option_2 = True

        tmpTask.Option_1_Name = "Show center of mass"
        tmpTask.Option_2_Name = "Hide center of mass"

        TaskList.Add(tmpTask)

        tmpTask = New cTask
        tmpTask.Task_Name = "Variable add\edit\expose"
        tmpTask.Image_Name = "Drill_16"

        tmpTask.Task_Enabled = True
        tmpTask.asm = True
        tmpTask.par = True
        tmpTask.psm = True
        tmpTask.dft = False

        tmpTask.HelpText = "Variable add\edit\expose"

        tmpTask.Option_1 = False
        tmpTask.Option_2 = False

        tmpTask.Option_1_Name = ""
        tmpTask.Option_2_Name = ""

        TaskList.Add(tmpTask)


    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.CacheText, True)
        'Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.CacheText Or ControlStyles.AllPaintingInWmPaint, True)
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or NativeMethods.WS_EX_COMPOSITED
            Return cp
        End Get
    End Property

    Public Sub BeginUpdate()
        NativeMethods.SendMessage(Me.Handle, NativeMethods.WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero)
    End Sub

    Public Sub EndUpdate()
        NativeMethods.SendMessage(Me.Handle, NativeMethods.WM_SETREDRAW, New IntPtr(1), IntPtr.Zero)
        Parent.Invalidate(True)
    End Sub



End Class

Module NativeMethods
    Public WM_SETREDRAW As Integer = &HB
    Public WS_EX_COMPOSITED As Integer = &H2000000
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    End Function

End Module
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
