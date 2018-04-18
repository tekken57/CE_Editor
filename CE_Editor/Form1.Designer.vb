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
        Me.ExportScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Mask_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Start_Face = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.End_Face = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Add_Mask = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Del_Mask = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFacesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTxtFile = New System.Windows.Forms.OpenFileDialog()
        Me.SaveCEFile = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ExportScriptToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(648, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ImportFacesToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExportScriptToolStripMenuItem
        '
        Me.ExportScriptToolStripMenuItem.Name = "ExportScriptToolStripMenuItem"
        Me.ExportScriptToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ExportScriptToolStripMenuItem.Text = "Export Faces"
        Me.ExportScriptToolStripMenuItem.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mask_Name, Me.Start_Face, Me.End_Face, Me.Add_Mask, Me.Del_Mask})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(648, 237)
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
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem1.Image = Global.CE_Editor.My.Resources.Resources.thumb_Help_and_Support
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(28, 20)
        '
        'ImportFacesToolStripMenuItem
        '
        Me.ImportFacesToolStripMenuItem.Name = "ImportFacesToolStripMenuItem"
        Me.ImportFacesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImportFacesToolStripMenuItem.Text = "Import Faces"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 261)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "CE Editor"
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
End Class
