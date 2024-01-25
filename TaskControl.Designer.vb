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
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLP
        '
        Me.TLP.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TLP.ColumnCount = 8
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TLP.Controls.Add(Me.LB_Image, 0, 0)
        Me.TLP.Controls.Add(Me.CB_Option_2, 6, 2)
        Me.TLP.Controls.Add(Me.BT_Help, 7, 0)
        Me.TLP.Controls.Add(Me.CB_Draft, 5, 0)
        Me.TLP.Controls.Add(Me.CB_SheetMetal, 4, 0)
        Me.TLP.Controls.Add(Me.CB_Part, 3, 0)
        Me.TLP.Controls.Add(Me.CB_Assembly, 2, 0)
        Me.TLP.Controls.Add(Me.CB_Enabled, 1, 0)
        Me.TLP.Controls.Add(Me.LB_Name, 6, 0)
        Me.TLP.Controls.Add(Me.CB_Option_1, 6, 1)
        Me.TLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TLP.Location = New System.Drawing.Point(0, 0)
        Me.TLP.Name = "TLP"
        Me.TLP.RowCount = 3
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLP.Size = New System.Drawing.Size(640, 94)
        Me.TLP.TabIndex = 0
        '
        'LB_Image
        '
        Me.LB_Image.AutoSize = True
        Me.LB_Image.BackColor = System.Drawing.Color.Transparent
        Me.LB_Image.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LB_Image.Image = Global.TaskListDemo.My.Resources.Resources.Drill_16
        Me.LB_Image.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LB_Image.Location = New System.Drawing.Point(4, 1)
        Me.LB_Image.Name = "LB_Image"
        Me.LB_Image.Size = New System.Drawing.Size(24, 30)
        Me.LB_Image.TabIndex = 10
        Me.LB_Image.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CB_Option_2
        '
        Me.CB_Option_2.AutoSize = True
        Me.CB_Option_2.BackColor = System.Drawing.Color.Transparent
        Me.CB_Option_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Option_2.Location = New System.Drawing.Point(190, 66)
        Me.CB_Option_2.Name = "CB_Option_2"
        Me.CB_Option_2.Size = New System.Drawing.Size(413, 24)
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
        Me.BT_Help.Location = New System.Drawing.Point(610, 4)
        Me.BT_Help.Name = "BT_Help"
        Me.BT_Help.Size = New System.Drawing.Size(26, 24)
        Me.BT_Help.TabIndex = 7
        Me.BT_Help.UseVisualStyleBackColor = False
        '
        'CB_Draft
        '
        Me.CB_Draft.AutoSize = True
        Me.CB_Draft.BackColor = System.Drawing.Color.Transparent
        Me.CB_Draft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Draft.FlatAppearance.BorderSize = 0
        Me.CB_Draft.Location = New System.Drawing.Point(159, 4)
        Me.CB_Draft.Name = "CB_Draft"
        Me.CB_Draft.Size = New System.Drawing.Size(24, 24)
        Me.CB_Draft.TabIndex = 5
        Me.CB_Draft.UseVisualStyleBackColor = False
        '
        'CB_SheetMetal
        '
        Me.CB_SheetMetal.AutoSize = True
        Me.CB_SheetMetal.BackColor = System.Drawing.Color.Transparent
        Me.CB_SheetMetal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_SheetMetal.FlatAppearance.BorderSize = 0
        Me.CB_SheetMetal.Location = New System.Drawing.Point(128, 4)
        Me.CB_SheetMetal.Name = "CB_SheetMetal"
        Me.CB_SheetMetal.Size = New System.Drawing.Size(24, 24)
        Me.CB_SheetMetal.TabIndex = 4
        Me.CB_SheetMetal.UseVisualStyleBackColor = False
        '
        'CB_Part
        '
        Me.CB_Part.AutoSize = True
        Me.CB_Part.BackColor = System.Drawing.Color.Transparent
        Me.CB_Part.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Part.FlatAppearance.BorderSize = 0
        Me.CB_Part.Location = New System.Drawing.Point(97, 4)
        Me.CB_Part.Name = "CB_Part"
        Me.CB_Part.Size = New System.Drawing.Size(24, 24)
        Me.CB_Part.TabIndex = 3
        Me.CB_Part.UseVisualStyleBackColor = False
        '
        'CB_Assembly
        '
        Me.CB_Assembly.AutoSize = True
        Me.CB_Assembly.BackColor = System.Drawing.Color.Transparent
        Me.CB_Assembly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Assembly.FlatAppearance.BorderSize = 0
        Me.CB_Assembly.Location = New System.Drawing.Point(66, 4)
        Me.CB_Assembly.Name = "CB_Assembly"
        Me.CB_Assembly.Size = New System.Drawing.Size(24, 24)
        Me.CB_Assembly.TabIndex = 2
        Me.CB_Assembly.UseVisualStyleBackColor = False
        '
        'CB_Enabled
        '
        Me.CB_Enabled.AutoSize = True
        Me.CB_Enabled.BackColor = System.Drawing.Color.Transparent
        Me.CB_Enabled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Enabled.FlatAppearance.BorderSize = 0
        Me.CB_Enabled.Location = New System.Drawing.Point(35, 4)
        Me.CB_Enabled.Name = "CB_Enabled"
        Me.CB_Enabled.Size = New System.Drawing.Size(24, 24)
        Me.CB_Enabled.TabIndex = 1
        Me.CB_Enabled.UseVisualStyleBackColor = False
        '
        'LB_Name
        '
        Me.LB_Name.AutoSize = True
        Me.LB_Name.BackColor = System.Drawing.Color.Transparent
        Me.LB_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LB_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LB_Name.Location = New System.Drawing.Point(190, 1)
        Me.LB_Name.Name = "LB_Name"
        Me.LB_Name.Size = New System.Drawing.Size(413, 30)
        Me.LB_Name.TabIndex = 6
        Me.LB_Name.Text = "Task name"
        Me.LB_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CB_Option_1
        '
        Me.CB_Option_1.AutoSize = True
        Me.CB_Option_1.BackColor = System.Drawing.Color.Transparent
        Me.CB_Option_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CB_Option_1.Location = New System.Drawing.Point(190, 35)
        Me.CB_Option_1.Name = "CB_Option_1"
        Me.CB_Option_1.Size = New System.Drawing.Size(413, 24)
        Me.CB_Option_1.TabIndex = 8
        Me.CB_Option_1.Text = "Option 1"
        Me.CB_Option_1.UseVisualStyleBackColor = False
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
        Me.Size = New System.Drawing.Size(640, 94)
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
End Class
