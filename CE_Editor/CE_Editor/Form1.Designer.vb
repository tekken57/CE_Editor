<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFacesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TekkenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutorialVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DSImportScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DSSelectionScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DSExportScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AznTutorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Mask_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Start_Face = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.End_Face = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Add_Mask = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Del_Mask = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenTxtFile = New System.Windows.Forms.OpenFileDialog()
        Me.SaveCEFile = New System.Windows.Forms.SaveFileDialog()
        Me.DSExportMasksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DSDisplayMasksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DSExportModelScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ExportScriptToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(972, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ImportFacesToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(198, 30)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(198, 30)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ImportFacesToolStripMenuItem
        '
        Me.ImportFacesToolStripMenuItem.Name = "ImportFacesToolStripMenuItem"
        Me.ImportFacesToolStripMenuItem.Size = New System.Drawing.Size(198, 30)
        Me.ImportFacesToolStripMenuItem.Text = "Import Faces"
        '
        'ExportScriptToolStripMenuItem
        '
        Me.ExportScriptToolStripMenuItem.Name = "ExportScriptToolStripMenuItem"
        Me.ExportScriptToolStripMenuItem.Size = New System.Drawing.Size(122, 29)
        Me.ExportScriptToolStripMenuItem.Text = "Export Faces"
        Me.ExportScriptToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TekkenToolStripMenuItem, Me.AznTutorialToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = Global.CE_Editor.My.Resources.Resources.thumb_Help_and_Support
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(36, 29)
        '
        'TekkenToolStripMenuItem
        '
        Me.TekkenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TutorialVideoToolStripMenuItem, Me.DSImportScriptToolStripMenuItem, Me.DSSelectionScriptToolStripMenuItem, Me.DSExportScriptToolStripMenuItem})
        Me.TekkenToolStripMenuItem.Name = "TekkenToolStripMenuItem"
        Me.TekkenToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.TekkenToolStripMenuItem.Text = "Tekken"
        '
        'TutorialVideoToolStripMenuItem
        '
        Me.TutorialVideoToolStripMenuItem.Name = "TutorialVideoToolStripMenuItem"
        Me.TutorialVideoToolStripMenuItem.Size = New System.Drawing.Size(255, 30)
        Me.TutorialVideoToolStripMenuItem.Text = "Tutorial Video"
        '
        'DSImportScriptToolStripMenuItem
        '
        Me.DSImportScriptToolStripMenuItem.Name = "DSImportScriptToolStripMenuItem"
        Me.DSImportScriptToolStripMenuItem.Size = New System.Drawing.Size(255, 30)
        Me.DSImportScriptToolStripMenuItem.Text = "3DS Import Script"
        '
        'DSSelectionScriptToolStripMenuItem
        '
        Me.DSSelectionScriptToolStripMenuItem.Name = "DSSelectionScriptToolStripMenuItem"
        Me.DSSelectionScriptToolStripMenuItem.Size = New System.Drawing.Size(255, 30)
        Me.DSSelectionScriptToolStripMenuItem.Text = "3DS Selection Script"
        '
        'DSExportScriptToolStripMenuItem
        '
        Me.DSExportScriptToolStripMenuItem.Name = "DSExportScriptToolStripMenuItem"
        Me.DSExportScriptToolStripMenuItem.Size = New System.Drawing.Size(255, 30)
        Me.DSExportScriptToolStripMenuItem.Text = "3DS Export Script"
        '
        'AznTutorialToolStripMenuItem
        '
        Me.AznTutorialToolStripMenuItem.Name = "AznTutorialToolStripMenuItem"
        Me.AznTutorialToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.AznTutorialToolStripMenuItem.Text = "Azn Tutorial"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mask_Name, Me.Start_Face, Me.End_Face, Me.Add_Mask, Me.Del_Mask})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 35)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(972, 367)
        Me.DataGridView1.TabIndex = 1
        '
        'Mask_Name
        '
        Me.Mask_Name.HeaderText = "Mask_Name"
        Me.Mask_Name.Name = "Mask_Name"
        Me.Mask_Name.ReadOnly = True
        '
        'Start_Face
        '
        Me.Start_Face.HeaderText = "Start Face"
        Me.Start_Face.Name = "Start_Face"
        '
        'End_Face
        '
        Me.End_Face.HeaderText = "End Face"
        Me.End_Face.Name = "End_Face"
        '
        'Add_Mask
        '
        Me.Add_Mask.HeaderText = "Add"
        Me.Add_Mask.Name = "Add_Mask"
        '
        'Del_Mask
        '
        Me.Del_Mask.HeaderText = "Delete"
        Me.Del_Mask.Name = "Del_Mask"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "00CE.pac"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "CE_mask_list.txt"
        Me.SaveFileDialog1.Filter = "Text File|*.txt|All files (*.*)|*.*"
        '
        'OpenTxtFile
        '
        Me.OpenTxtFile.FileName = "CE_mask_list.txt"
        Me.OpenTxtFile.Filter = "Text File|*.txt|All files (*.*)|*.*"
        '
        'SaveCEFile
        '
        Me.SaveCEFile.FileName = "00CE.pac"
        '
        'DSExportMasksToolStripMenuItem
        '
        Me.DSExportMasksToolStripMenuItem.Name = "DSExportMasksToolStripMenuItem"
        Me.DSExportMasksToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.DSExportMasksToolStripMenuItem.Text = "3DS Export Masks"
        '
        'DSDisplayMasksToolStripMenuItem
        '
        Me.DSDisplayMasksToolStripMenuItem.Name = "DSDisplayMasksToolStripMenuItem"
        Me.DSDisplayMasksToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DSDisplayMasksToolStripMenuItem.Text = "3DS Display Masks"
        '
        'DSExportModelScriptToolStripMenuItem
        '
        Me.DSExportModelScriptToolStripMenuItem.Name = "DSExportModelScriptToolStripMenuItem"
        Me.DSExportModelScriptToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.DSExportModelScriptToolStripMenuItem.Text = "3DS Export Model Script"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 402)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "CE Editor 2.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Mask_Name As DataGridViewTextBoxColumn
    Friend WithEvents Start_Face As DataGridViewTextBoxColumn
    Friend WithEvents End_Face As DataGridViewTextBoxColumn
    Friend WithEvents Add_Mask As DataGridViewButtonColumn
    Friend WithEvents Del_Mask As DataGridViewButtonColumn
    Friend WithEvents ExportScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImportFacesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenTxtFile As OpenFileDialog
    Friend WithEvents SaveCEFile As SaveFileDialog
    Friend WithEvents TekkenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TutorialVideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DSImportScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DSSelectionScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DSExportScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AznTutorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DSExportMasksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DSDisplayMasksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DSExportModelScriptToolStripMenuItem As ToolStripMenuItem
End Class
