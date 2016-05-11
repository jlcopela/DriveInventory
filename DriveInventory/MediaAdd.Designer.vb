<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MediaAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MediaAdd))
        Me.driveListView = New System.Windows.Forms.ListView()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.MediaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.MediaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaDatabaseDataSet = New DriveInventory.MediaDatabaseDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MediaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MediaTableAdapter = New DriveInventory.MediaDatabaseDataSetTableAdapters.MediaTableAdapter()
        Me.TableAdapterManager = New DriveInventory.MediaDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.btnRefreshDG = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnDiskImage = New System.Windows.Forms.Button()
        Me.btnViewFiles = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.MediaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.MediaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MediaBindingNavigator.SuspendLayout()
        CType(Me.MediaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'driveListView
        '
        Me.driveListView.GridLines = True
        Me.driveListView.Location = New System.Drawing.Point(50, 43)
        Me.driveListView.MultiSelect = False
        Me.driveListView.Name = "driveListView"
        Me.driveListView.Size = New System.Drawing.Size(443, 122)
        Me.driveListView.TabIndex = 0
        Me.driveListView.UseCompatibleStateImageBehavior = False
        '
        'btnScan
        '
        Me.btnScan.Location = New System.Drawing.Point(169, 184)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(108, 23)
        Me.btnScan.TabIndex = 1
        Me.btnScan.Text = "Add Selected"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'MediaBindingNavigator
        '
        Me.MediaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MediaBindingNavigator.BindingSource = Me.MediaBindingSource
        Me.MediaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MediaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MediaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MediaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MediaBindingNavigatorSaveItem})
        Me.MediaBindingNavigator.Location = New System.Drawing.Point(0, 490)
        Me.MediaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MediaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MediaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MediaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MediaBindingNavigator.Name = "MediaBindingNavigator"
        Me.MediaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MediaBindingNavigator.Size = New System.Drawing.Size(793, 25)
        Me.MediaBindingNavigator.TabIndex = 2
        Me.MediaBindingNavigator.Text = "BindingNavigator1"
        '
        'MediaBindingSource
        '
        Me.MediaBindingSource.DataMember = "Media"
        Me.MediaBindingSource.DataSource = Me.MediaDatabaseDataSet
        '
        'MediaDatabaseDataSet
        '
        Me.MediaDatabaseDataSet.DataSetName = "MediaDatabaseDataSet"
        Me.MediaDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MediaDataGridView
        '
        Me.MediaDataGridView.AllowUserToAddRows = False
        Me.MediaDataGridView.AutoGenerateColumns = False
        Me.MediaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MediaDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MediaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MediaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MediaDataGridView.DataSource = Me.MediaBindingSource
        Me.MediaDataGridView.Location = New System.Drawing.Point(50, 255)
        Me.MediaDataGridView.Name = "MediaDataGridView"
        Me.MediaDataGridView.Size = New System.Drawing.Size(443, 220)
        Me.MediaDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 41
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MediaDescription"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MediaDescription"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 50
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MediaVolume"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MediaVolume"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 96
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MediaKey"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MediaKey"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 79
        '
        'MediaTableAdapter
        '
        Me.MediaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MediaFilesTableAdapter = Nothing
        Me.TableAdapterManager.MediaTableAdapter = Me.MediaTableAdapter
        Me.TableAdapterManager.UpdateOrder = DriveInventory.MediaDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnRefreshDG
        '
        Me.btnRefreshDG.Location = New System.Drawing.Point(499, 255)
        Me.btnRefreshDG.Name = "btnRefreshDG"
        Me.btnRefreshDG.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshDG.TabIndex = 4
        Me.btnRefreshDG.Text = "Refresh"
        Me.btnRefreshDG.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = """JPEG Files|*.jpg|Portable Network Graphics|*.png|GIFs|*.gif"""
        Me.OpenFileDialog1.InitialDirectory = "Libraries\Pictures"
        '
        'btnDiskImage
        '
        Me.btnDiskImage.Location = New System.Drawing.Point(652, 246)
        Me.btnDiskImage.Name = "btnDiskImage"
        Me.btnDiskImage.Size = New System.Drawing.Size(75, 23)
        Me.btnDiskImage.TabIndex = 6
        Me.btnDiskImage.Text = "Assign Image"
        Me.btnDiskImage.UseVisualStyleBackColor = True
        '
        'btnViewFiles
        '
        Me.btnViewFiles.Location = New System.Drawing.Point(328, 184)
        Me.btnViewFiles.Name = "btnViewFiles"
        Me.btnViewFiles.Size = New System.Drawing.Size(75, 23)
        Me.btnViewFiles.TabIndex = 7
        Me.btnViewFiles.Text = "View Files"
        Me.btnViewFiles.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(599, 275)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'MediaBindingNavigatorSaveItem
        '
        Me.MediaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MediaBindingNavigatorSaveItem.Image = CType(resources.GetObject("MediaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MediaBindingNavigatorSaveItem.Name = "MediaBindingNavigatorSaveItem"
        Me.MediaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MediaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MediaAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 515)
        Me.Controls.Add(Me.btnViewFiles)
        Me.Controls.Add(Me.btnDiskImage)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRefreshDG)
        Me.Controls.Add(Me.MediaDataGridView)
        Me.Controls.Add(Me.MediaBindingNavigator)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.driveListView)
        Me.Name = "MediaAdd"
        Me.Text = "MediaAdd"
        CType(Me.MediaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MediaBindingNavigator.ResumeLayout(False)
        Me.MediaBindingNavigator.PerformLayout()
        CType(Me.MediaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents driveListView As ListView
    Friend WithEvents btnScan As Button
    Friend WithEvents MediaDatabaseDataSet As MediaDatabaseDataSet
    Friend WithEvents MediaBindingSource As BindingSource
    Friend WithEvents MediaTableAdapter As MediaDatabaseDataSetTableAdapters.MediaTableAdapter
    Friend WithEvents TableAdapterManager As MediaDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MediaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MediaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MediaDataGridView As DataGridView
    Friend WithEvents btnRefreshDG As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnDiskImage As Button
    Friend WithEvents btnViewFiles As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
