Public Class TaskControl

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

    Public Sub Initialize()

        CB_Enabled.Checked = Task_Enabled
        CB_Assembly.Enabled = asm
        CB_Part.Enabled = par
        CB_SheetMetal.Enabled = psm
        CB_Draft.Enabled = dft

        LB_Name.Text = Task_Name
        LB_Image.Image = ImageList1.Images.Item(Image_Name)

        CB_Option_1.Enabled = Option_1
        CB_Option_2.Enabled = Option_2

        CB_Option_1.Text = Option_1_Name
        CB_Option_2.Text = Option_2_Name

        If Not Option_2 Then
            TLP.RowStyles.Item(2).Height = 0
        End If

        If Not Option_1 Then
            TLP.RowStyles.Item(1).Height = 0
        End If

        Me.Height = 30 - 31 * Option_1 - 31 * Option_2

    End Sub


End Class
