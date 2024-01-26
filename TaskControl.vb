Imports System.Windows.Forms.VisualStyles

Public Class TaskControl

    Public Task As cTask

    'Public Task_Name As String = ""
    'Public Image_Name As String = ""

    'Public Task_Enabled As Boolean = True
    'Public asm As Boolean = False
    'Public par As Boolean = False
    'Public psm As Boolean = False
    'Public dft As Boolean = False

    'Public HelpText As String = ""

    'Public Option_1 As Boolean = False
    'Public Option_2 As Boolean = False

    'Public Option_1_Name As String = ""
    'Public Option_2_Name As String = ""

    Public Sub Initialize()

        'TLP.BorderStyle = BorderStyle.FixedSingle

        CB_Enabled.Checked = Task.Task_Enabled
        CB_Assembly.Enabled = Task.asm
        CB_Part.Enabled = Task.par
        CB_SheetMetal.Enabled = Task.psm
        CB_Draft.Enabled = Task.dft

        LB_Name.Text = Task.Task_Name
        LB_Image.Image = ImageList1.Images.Item(Task.Image_Name)

        'CB_Option_1.Enabled = Task.Option_1
        'CB_Option_2.Enabled = Task.Option_2

        If Not Task.Option_2 Then
            TLP.RowStyles.Item(4).Height = 0
        Else
            CB_Option_2.Text = Task.Option_2_Name
        End If

        If Not Task.Option_1 Then
            TLP.RowStyles.Item(3).Height = 0
        Else
            CB_Option_1.Text = Task.Option_1_Name
        End If

        If Not Task.Combo Then
            CB_Options.Visible = False
            TLP.RowStyles.Item(2).Height = 0
        Else
            For Each item In Task.ComboValue
                CB_Options.Items.Add(item)
            Next
        End If

        If Not Task.Configurable Then
            BT_Configure.Visible = False
            TB_Configuration.Visible = False
            TLP.RowStyles.Item(1).Height = 0
        Else
            TB_Configuration.Text = Task.Configuration
        End If

        Me.Height = 25 - 24 * Task.Option_1 - 24 * Task.Option_2 - 24 * Task.Combo - 24 * Task.Configurable

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

    Public Configurable As Boolean = False
    Public Configuration As String = ""

    Public Combo As Boolean = False
    Public ComboValue As New List(Of String)

    Public Option_1 As Boolean = False
    Public Option_2 As Boolean = False

    Public Option_1_Name As String = ""
    Public Option_2_Name As String = ""

End Class