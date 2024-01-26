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
        Me.Lc13 = New System.Windows.Forms.Label()
        Me.Lc11 = New System.Windows.Forms.Label()
        Me.Lc9 = New System.Windows.Forms.Label()
        Me.Lc7 = New System.Windows.Forms.Label()
        Me.Lc5 = New System.Windows.Forms.Label()
        Me.Lc3 = New System.Windows.Forms.Label()
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
        Me.Lrow = New System.Windows.Forms.Label()
        Me.Lc1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLP
        '
        Me.TLP.ColumnCount = 15
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TLP.Controls.Add(Me.Lc13, 13, 0)
        Me.TLP.Controls.Add(Me.Lc11, 11, 0)
        Me.TLP.Controls.Add(Me.Lc9, 9, 0)
        Me.TLP.Controls.Add(Me.Lc7, 7, 0)
        Me.TLP.Controls.Add(Me.Lc5, 5, 0)
        Me.TLP.Controls.Add(Me.Lc3, 3, 0)
        Me.TLP.Controls.Add(Me.TT, 12, 0)
        Me.TLP.Controls.Add(Me.L4, 10, 0)
        Me.TLP.Controls.Add(Me.L3, 8, 0)
        Me.TLP.Controls.Add(Me.L2, 6, 0)
        Me.TLP.Controls.Add(Me.L1, 4, 0)
        Me.TLP.Controls.Add(Me.BT_Configure, 10, 2)
        Me.TLP.Controls.Add(Me.LB_Image, 0, 1)
        Me.TLP.Controls.Add(Me.CB_Option_2, 12, 5)
        Me.TLP.Controls.Add(Me.BT_Help, 14, 1)
        Me.TLP.Controls.Add(Me.CB_Draft, 10, 1)
        Me.TLP.Controls.Add(Me.CB_SheetMetal, 8, 1)
        Me.TLP.Controls.Add(Me.CB_Part, 6, 1)
        Me.TLP.Controls.Add(Me.CB_Assembly, 4, 1)
        Me.TLP.Controls.Add(Me.CB_Enabled, 2, 1)
        Me.TLP.Controls.Add(Me.LB_Name, 12, 1)
        Me.TLP.Controls.Add(Me.CB_Option_1, 12, 4)
        Me.TLP.Controls.Add(Me.TB_Configuration, 12, 2)
        Me.TLP.Controls.Add(Me.CB_Options, 12, 3)
        Me.TLP.Controls.Add(Me.Lrow, 0, 6)
        Me.TLP.Controls.Add(Me.Lc1, 1, 0)
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
        'Lc13
        '
        Me.Lc13.AutoSize = True
        Me.Lc13.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Lc13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lc13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lc13.Location = New System.Drawing.Point(615, 0)
        Me.Lc13.Margin = New System.Windows.Forms.Padding(0)
        Me.Lc13.Name = "Lc13"
        Me.TLP.SetRowSpan(Me.Lc13, 6)
        Me.Lc13.Size = New System.Drawing.Size(1, 144)
        Me.Lc13.TabIndex = 26
        '
        'Lc11
        '
        Me.Lc11.AutoSize = True
        Me.Lc11.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Lc11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lc11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lc11.Location = New System.Drawing.Point(149, 0)
        Me.Lc11.Margin = New System.Windows.Forms.Padding(0)
        Me.Lc11.Name = "Lc11"
        Me.TLP.SetRowSpan(Me.Lc11, 6)
        Me.Lc11.Size = New System.Drawing.Size(1, 144)
        Me.Lc11.TabIndex = 25
        '
        'Lc9
        '
        Me.Lc9.AutoSize = True
        Me.Lc9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Lc9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lc9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lc9.Location = New System.Drawing.Point(124, 0)
        Me.Lc9.Margin = New System.Windows.Forms.Padding(0)
        Me.Lc9.Name = "Lc9"
        Me.TLP.SetRowSpan(Me.Lc9, 6)
        Me.Lc9.Size = New System.Drawing.Size(1, 144)
        Me.Lc9.TabIndex = 24
        '
        'Lc7
        '
        Me.Lc7.AutoSize = True
        Me.Lc7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Lc7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lc7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lc7.Location = New System.Drawing.Point(99, 0)
        Me.Lc7.Margin = New System.Windows.Forms.Padding(0)
        Me.Lc7.Name = "Lc7"
        Me.TLP.SetRowSpan(Me.Lc7, 6)
        Me.Lc7.Size = New System.Drawing.Size(1, 144)
        Me.Lc7.TabIndex = 23
        '
        'Lc5
        '
        Me.Lc5.AutoSize = True
        Me.Lc5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Lc5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lc5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lc5.Location = New System.Drawing.Point(74, 0)
        Me.Lc5.Margin = New System.Windows.Forms.Padding(0)
        Me.Lc5.Name = "Lc5"
        Me.TLP.SetRowSpan(Me.Lc5, 6)
        Me.Lc5.Size = New System.Drawing.Size(1, 144)
        Me.Lc5.TabIndex = 22
        '
        'Lc3
        '
        Me.Lc3.AutoSize = True
        Me.Lc3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Lc3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lc3.Location = New System.Drawing.Point(49, 0)
        Me.Lc3.Margin = New System.Windows.Forms.Padding(0)
        Me.Lc3.Name = "Lc3"
        Me.TLP.SetRowSpan(Me.Lc3, 6)
        Me.Lc3.Size = New System.Drawing.Size(1, 144)
        Me.Lc3.TabIndex = 21
        '
        'TT
        '
        Me.TT.AutoSize = True
        Me.TT.BackColor = System.Drawing.Color.Transparent
        Me.TT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TT.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT.Location = New System.Drawing.Point(153, 0)
        Me.TT.Name = "TT"
        Me.TT.Size = New System.Drawing.Size(459, 24)
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
        Me.L4.Location = New System.Drawing.Point(128, 0)
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
        Me.L3.Location = New System.Drawing.Point(103, 0)
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
        Me.L2.Location = New System.Drawing.Point(78, 0)
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
        Me.L1.Location = New System.Drawing.Point(53, 0)
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
        Me.BT_Configure.Location = New System.Drawing.Point(125, 48)
        Me.BT_Configure.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_Configure.Name = "BT_Configure"
        Me.BT_Configure.Size = New System.Drawing.Size(24, 24)
        Me.BT_Configure.TabIndex = 11
        Me.BT_Configure.UseVisualStyleBackColor = False
        '
        'LB_Image
        '
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
        Me.CB_Option_2.Location = New System.Drawing.Point(153, 123)
        Me.CB_Option_2.Name = "CB_Option_2"
        Me.CB_Option_2.Size = New System.Drawing.Size(459, 18)
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
        Me.CB_Draft.Location = New System.Drawing.Point(130, 29)
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
        Me.CB_SheetMetal.Location = New System.Drawing.Point(105, 29)
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
        Me.CB_Part.Location = New System.Drawing.Point(80, 29)
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
        Me.CB_Assembly.Location = New System.Drawing.Point(55, 29)
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
        Me.CB_Enabled.Location = New System.Drawing.Point(30, 29)
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
        Me.LB_Name.Location = New System.Drawing.Point(153, 24)
        Me.LB_Name.Name = "LB_Name"
        Me.LB_Name.Size = New System.Drawing.Size(459, 24)
        Me.LB_Name.TabIndex = 6
        Me.LB_Name.Text = "Task name"
        Me.LB_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CB_Option_1
        '
        Me.CB_Option_1.AutoSize = True
        Me.CB_Option_1.BackColor = System.Drawing.Color.Transparent
        Me.CB_Option_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Option_1.Location = New System.Drawing.Point(153, 99)
        Me.CB_Option_1.Name = "CB_Option_1"
        Me.CB_Option_1.Size = New System.Drawing.Size(459, 18)
        Me.CB_Option_1.TabIndex = 8
        Me.CB_Option_1.Text = "Option 1"
        Me.CB_Option_1.UseVisualStyleBackColor = False
        '
        'TB_Configuration
        '
        Me.TB_Configuration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Configuration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TB_Configuration.Location = New System.Drawing.Point(155, 53)
        Me.TB_Configuration.Margin = New System.Windows.Forms.Padding(5)
        Me.TB_Configuration.Name = "TB_Configuration"
        Me.TB_Configuration.Size = New System.Drawing.Size(455, 15)
        Me.TB_Configuration.TabIndex = 12
        Me.TB_Configuration.Text = "Configuration text"
        '
        'CB_Options
        '
        Me.CB_Options.BackColor = System.Drawing.SystemColors.Control
        Me.CB_Options.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Options.FormattingEnabled = True
        Me.CB_Options.Location = New System.Drawing.Point(151, 73)
        Me.CB_Options.Margin = New System.Windows.Forms.Padding(1)
        Me.CB_Options.Name = "CB_Options"
        Me.CB_Options.Size = New System.Drawing.Size(463, 21)
        Me.CB_Options.TabIndex = 13
        '
        'Lrow
        '
        Me.Lrow.AutoSize = True
        Me.Lrow.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TLP.SetColumnSpan(Me.Lrow, 15)
        Me.Lrow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lrow.Location = New System.Drawing.Point(0, 144)
        Me.Lrow.Margin = New System.Windows.Forms.Padding(0)
        Me.Lrow.Name = "Lrow"
        Me.Lrow.Size = New System.Drawing.Size(640, 1)
        Me.Lrow.TabIndex = 14
        '
        'Lc1
        '
        Me.Lc1.AutoSize = True
        Me.Lc1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Lc1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lc1.Location = New System.Drawing.Point(24, 0)
        Me.Lc1.Margin = New System.Windows.Forms.Padding(0)
        Me.Lc1.Name = "Lc1"
        Me.TLP.SetRowSpan(Me.Lc1, 6)
        Me.Lc1.Size = New System.Drawing.Size(1, 144)
        Me.Lc1.TabIndex = 20
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
    Friend WithEvents Lrow As Label
    Friend WithEvents L4 As Label
    Friend WithEvents L3 As Label
    Friend WithEvents L2 As Label
    Friend WithEvents L1 As Label
    Friend WithEvents TT As Label
    Friend WithEvents Lc11 As Label
    Friend WithEvents Lc9 As Label
    Friend WithEvents Lc7 As Label
    Friend WithEvents Lc5 As Label
    Friend WithEvents Lc3 As Label
    Friend WithEvents Lc1 As Label
    Friend WithEvents Lc13 As Label
End Class
