<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaskControl))
        Me.TLP = New System.Windows.Forms.TableLayoutPanel()
        Me.TT = New System.Windows.Forms.Label()
        Me.L4 = New System.Windows.Forms.Label()
        Me.L3 = New System.Windows.Forms.Label()
        Me.L2 = New System.Windows.Forms.Label()
        Me.L1 = New System.Windows.Forms.Label()
        Me.BT_Configure = New System.Windows.Forms.Button()
        Me.LB_Image = New System.Windows.Forms.Label()
        Me.CB_Option_2 = New System.Windows.Forms.CheckBox()
        Me.BT_Help = New System.Windows.Forms.Button()
        Me.CB_Draft = New System.Windows.Forms.CheckBox()
        Me.CB_SheetMetal = New System.Windows.Forms.CheckBox()
        Me.CB_Part = New System.Windows.Forms.CheckBox()
        Me.CB_Assembly = New System.Windows.Forms.CheckBox()
        Me.CB_Enabled = New System.Windows.Forms.CheckBox()
        Me.LB_Name = New System.Windows.Forms.Label()
        Me.CB_Option_1 = New System.Windows.Forms.CheckBox()
        Me.TB_Configuration = New System.Windows.Forms.TextBox()
        Me.CB_Options = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLP
        '
        Me.TLP.ColumnCount = 8
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.Controls.Add(Me.TT, 6, 0)
        Me.TLP.Controls.Add(Me.L4, 5, 0)
        Me.TLP.Controls.Add(Me.L3, 4, 0)
        Me.TLP.Controls.Add(Me.L2, 3, 0)
        Me.TLP.Controls.Add(Me.L1, 2, 0)
        Me.TLP.Controls.Add(Me.BT_Configure, 5, 2)
        Me.TLP.Controls.Add(Me.LB_Image, 0, 1)
        Me.TLP.Controls.Add(Me.CB_Option_2, 6, 5)
        Me.TLP.Controls.Add(Me.BT_Help, 7, 1)
        Me.TLP.Controls.Add(Me.CB_Draft, 5, 1)
        Me.TLP.Controls.Add(Me.CB_SheetMetal, 4, 1)
        Me.TLP.Controls.Add(Me.CB_Part, 3, 1)
        Me.TLP.Controls.Add(Me.CB_Assembly, 2, 1)
        Me.TLP.Controls.Add(Me.CB_Enabled, 1, 1)
        Me.TLP.Controls.Add(Me.LB_Name, 6, 1)
        Me.TLP.Controls.Add(Me.CB_Option_1, 6, 4)
        Me.TLP.Controls.Add(Me.TB_Configuration, 6, 2)
        Me.TLP.Controls.Add(Me.CB_Options, 6, 3)
        Me.TLP.Controls.Add(Me.Label1, 0, 6)
        Me.TLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TLP.Location = New System.Drawing.Point(0, 0)
        Me.TLP.Name = "TLP"
        Me.TLP.RowCount = 7
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TLP.Size = New System.Drawing.Size(640, 145)
        Me.TLP.TabIndex = 0
        '
        'TT
        '
        Me.TT.AutoSize = True
        Me.TT.BackColor = System.Drawing.Color.Transparent
        Me.TT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TT.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT.Location = New System.Drawing.Point(147, 0)
        Me.TT.Name = "TT"
        Me.TT.Size = New System.Drawing.Size(466, 24)
        Me.TT.TabIndex = 19
        Me.TT.Text = "TASK LIST"
        Me.TT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'L4
        '
        Me.L4.AutoSize = True
        Me.L4.BackColor = System.Drawing.Color.Transparent
        Me.L4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L4.Image = CType(resources.GetObject("L4.Image"), System.Drawing.Image)
        Me.L4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.L4.Location = New System.Drawing.Point(123, 0)
        Me.L4.Name = "L4"
        Me.L4.Size = New System.Drawing.Size(18, 24)
        Me.L4.TabIndex = 18
        Me.L4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'L3
        '
        Me.L3.AutoSize = True
        Me.L3.BackColor = System.Drawing.Color.Transparent
        Me.L3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L3.Image = CType(resources.GetObject("L3.Image"), System.Drawing.Image)
        Me.L3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.L3.Location = New System.Drawing.Point(99, 0)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(18, 24)
        Me.L3.TabIndex = 17
        Me.L3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.BackColor = System.Drawing.Color.Transparent
        Me.L2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L2.Image = CType(resources.GetObject("L2.Image"), System.Drawing.Image)
        Me.L2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.L2.Location = New System.Drawing.Point(75, 0)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(18, 24)
        Me.L2.TabIndex = 16
        Me.L2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.BackColor = System.Drawing.Color.Transparent
        Me.L1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L1.Image = CType(resources.GetObject("L1.Image"), System.Drawing.Image)
        Me.L1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.L1.Location = New System.Drawing.Point(51, 0)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(18, 24)
        Me.L1.TabIndex = 15
        Me.L1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BT_Configure
        '
        Me.BT_Configure.BackColor = System.Drawing.Color.Transparent
        Me.BT_Configure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_Configure.FlatAppearance.BorderSize = 0
        Me.BT_Configure.Image = CType(resources.GetObject("BT_Configure.Image"), System.Drawing.Image)
        Me.BT_Configure.Location = New System.Drawing.Point(120, 48)
        Me.BT_Configure.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_Configure.Name = "BT_Configure"
        Me.BT_Configure.Size = New System.Drawing.Size(24, 24)
        Me.BT_Configure.TabIndex = 11
        Me.BT_Configure.UseVisualStyleBackColor = False
        '
        'LB_Image
        '
        Me.LB_Image.AutoSize = True
        Me.LB_Image.BackColor = System.Drawing.Color.Transparent
        Me.LB_Image.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LB_Image.Image = Global.TaskListDemo.My.Resources.Resources.skull_16
        Me.LB_Image.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LB_Image.Location = New System.Drawing.Point(3, 24)
        Me.LB_Image.Name = "LB_Image"
        Me.LB_Image.Size = New System.Drawing.Size(18, 24)
        Me.LB_Image.TabIndex = 10
        Me.LB_Image.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CB_Option_2
        '
        Me.CB_Option_2.AutoSize = True
        Me.CB_Option_2.BackColor = System.Drawing.Color.Transparent
        Me.CB_Option_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Option_2.Location = New System.Drawing.Point(147, 123)
        Me.CB_Option_2.Name = "CB_Option_2"
        Me.CB_Option_2.Size = New System.Drawing.Size(466, 18)
        Me.CB_Option_2.TabIndex = 9
        Me.CB_Option_2.Text = "Option 2"
        Me.CB_Option_2.UseVisualStyleBackColor = False
        '
        'BT_Help
        '
        Me.BT_Help.BackColor = System.Drawing.Color.Transparent
        Me.BT_Help.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_Help.FlatAppearance.BorderSize = 0
        Me.BT_Help.Image = CType(resources.GetObject("BT_Help.Image"), System.Drawing.Image)
        Me.BT_Help.Location = New System.Drawing.Point(616, 24)
        Me.BT_Help.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_Help.Name = "BT_Help"
        Me.BT_Help.Size = New System.Drawing.Size(24, 24)
        Me.BT_Help.TabIndex = 7
        Me.BT_Help.UseVisualStyleBackColor = False
        '
        'CB_Draft
        '
        Me.CB_Draft.AutoSize = True
        Me.CB_Draft.BackColor = System.Drawing.Color.Transparent
        Me.CB_Draft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Draft.FlatAppearance.BorderSize = 0
        Me.CB_Draft.Location = New System.Drawing.Point(125, 29)
        Me.CB_Draft.Margin = New System.Windows.Forms.Padding(5)
        Me.CB_Draft.Name = "CB_Draft"
        Me.CB_Draft.Size = New System.Drawing.Size(14, 14)
        Me.CB_Draft.TabIndex = 5
        Me.CB_Draft.UseVisualStyleBackColor = False
        '
        'CB_SheetMetal
        '
        Me.CB_SheetMetal.AutoSize = True
        Me.CB_SheetMetal.BackColor = System.Drawing.Color.Transparent
        Me.CB_SheetMetal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_SheetMetal.FlatAppearance.BorderSize = 0
        Me.CB_SheetMetal.Location = New System.Drawing.Point(101, 29)
        Me.CB_SheetMetal.Margin = New System.Windows.Forms.Padding(5)
        Me.CB_SheetMetal.Name = "CB_SheetMetal"
        Me.CB_SheetMetal.Size = New System.Drawing.Size(14, 14)
        Me.CB_SheetMetal.TabIndex = 4
        Me.CB_SheetMetal.UseVisualStyleBackColor = False
        '
        'CB_Part
        '
        Me.CB_Part.AutoSize = True
        Me.CB_Part.BackColor = System.Drawing.Color.Transparent
        Me.CB_Part.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Part.FlatAppearance.BorderSize = 0
        Me.CB_Part.Location = New System.Drawing.Point(77, 29)
        Me.CB_Part.Margin = New System.Windows.Forms.Padding(5)
        Me.CB_Part.Name = "CB_Part"
        Me.CB_Part.Size = New System.Drawing.Size(14, 14)
        Me.CB_Part.TabIndex = 3
        Me.CB_Part.UseVisualStyleBackColor = False
        '
        'CB_Assembly
        '
        Me.CB_Assembly.AutoSize = True
        Me.CB_Assembly.BackColor = System.Drawing.Color.Transparent
        Me.CB_Assembly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Assembly.FlatAppearance.BorderSize = 0
        Me.CB_Assembly.Location = New System.Drawing.Point(53, 29)
        Me.CB_Assembly.Margin = New System.Windows.Forms.Padding(5)
        Me.CB_Assembly.Name = "CB_Assembly"
        Me.CB_Assembly.Size = New System.Drawing.Size(14, 14)
        Me.CB_Assembly.TabIndex = 2
        Me.CB_Assembly.UseVisualStyleBackColor = False
        '
        'CB_Enabled
        '
        Me.CB_Enabled.AutoSize = True
        Me.CB_Enabled.BackColor = System.Drawing.Color.Transparent
        Me.CB_Enabled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Enabled.FlatAppearance.BorderSize = 0
        Me.CB_Enabled.Location = New System.Drawing.Point(29, 29)
        Me.CB_Enabled.Margin = New System.Windows.Forms.Padding(5)
        Me.CB_Enabled.Name = "CB_Enabled"
        Me.CB_Enabled.Size = New System.Drawing.Size(14, 14)
        Me.CB_Enabled.TabIndex = 1
        Me.CB_Enabled.UseVisualStyleBackColor = False
        '
        'LB_Name
        '
        Me.LB_Name.AutoSize = True
        Me.LB_Name.BackColor = System.Drawing.Color.Transparent
        Me.LB_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LB_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LB_Name.Location = New System.Drawing.Point(147, 24)
        Me.LB_Name.Name = "LB_Name"
        Me.LB_Name.Size = New System.Drawing.Size(466, 24)
        Me.LB_Name.TabIndex = 6
        Me.LB_Name.Text = "Task name"
        Me.LB_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CB_Option_1
        '
        Me.CB_Option_1.AutoSize = True
        Me.CB_Option_1.BackColor = System.Drawing.Color.Transparent
        Me.CB_Option_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Option_1.Location = New System.Drawing.Point(147, 99)
        Me.CB_Option_1.Name = "CB_Option_1"
        Me.CB_Option_1.Size = New System.Drawing.Size(466, 18)
        Me.CB_Option_1.TabIndex = 8
        Me.CB_Option_1.Text = "Option 1"
        Me.CB_Option_1.UseVisualStyleBackColor = False
        '
        'TB_Configuration
        '
        Me.TB_Configuration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Configuration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TB_Configuration.Location = New System.Drawing.Point(149, 53)
        Me.TB_Configuration.Margin = New System.Windows.Forms.Padding(5)
        Me.TB_Configuration.Name = "TB_Configuration"
        Me.TB_Configuration.Size = New System.Drawing.Size(462, 15)
        Me.TB_Configuration.TabIndex = 12
        Me.TB_Configuration.Text = "Configuration text"
        '
        'CB_Options
        '
        Me.CB_Options.BackColor = System.Drawing.SystemColors.Control
        Me.CB_Options.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Options.FormattingEnabled = True
        Me.CB_Options.Location = New System.Drawing.Point(145, 73)
        Me.CB_Options.Margin = New System.Windows.Forms.Padding(1)
        Me.CB_Options.Name = "CB_Options"
        Me.CB_Options.Size = New System.Drawing.Size(470, 21)
        Me.CB_Options.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TLP.SetColumnSpan(Me.Label1, 8)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(640, 1)
        Me.Label1.TabIndex = 14
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Drill_16")
        Me.ImageList1.Images.SetKeyName(1, "Save_16")
        Me.ImageList1.Images.SetKeyName(2, "skull_16")
        Me.ImageList1.Images.SetKeyName(3, "Synchronize_16")
        Me.ImageList1.Images.SetKeyName(4, "Update_16")
        '
        'TaskControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TLP)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "TaskControl"
        Me.Size = New System.Drawing.Size(640, 145)
        Me.TLP.ResumeLayout(False)
        Me.TLP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TLP As TableLayoutPanel
    Friend WithEvents CB_Enabled As CheckBox
    Friend WithEvents CB_Assembly As CheckBox
    Friend WithEvents CB_Draft As CheckBox
    Friend WithEvents CB_SheetMetal As CheckBox
    Friend WithEvents CB_Part As CheckBox
    Friend WithEvents LB_Name As Label
    Friend WithEvents BT_Help As Button
    Friend WithEvents CB_Option_1 As CheckBox
    Friend WithEvents CB_Option_2 As CheckBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents LB_Image As Label
    Friend WithEvents BT_Configure As Button
    Friend WithEvents TB_Configuration As TextBox
    Friend WithEvents CB_Options As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents L4 As Label
    Friend WithEvents L3 As Label
    Friend WithEvents L2 As Label
    Friend WithEvents L1 As Label
    Friend WithEvents TT As Label
End Class
