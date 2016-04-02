﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MediaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaDatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaDatabaseDataSet = New DriveInventory.MediaDatabaseDataSet()
        Me.MediaTableAdapter = New DriveInventory.MediaDatabaseDataSetTableAdapters.MediaTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MediaDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MediaVolumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MediaLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Get Drive Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.MediaDescriptionDataGridViewTextBoxColumn, Me.MediaVolumeDataGridViewTextBoxColumn, Me.MediaLabel})
        Me.DataGridView1.DataSource = Me.MediaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(102, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(443, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'MediaBindingSource
        '
        Me.MediaBindingSource.DataMember = "Media"
        Me.MediaBindingSource.DataSource = Me.MediaDatabaseDataSetBindingSource
        '
        'MediaDatabaseDataSetBindingSource
        '
        Me.MediaDatabaseDataSetBindingSource.DataSource = Me.MediaDatabaseDataSet
        Me.MediaDatabaseDataSetBindingSource.Position = 0
        '
        'MediaDatabaseDataSet
        '
        Me.MediaDatabaseDataSet.DataSetName = "MediaDatabaseDataSet"
        Me.MediaDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MediaTableAdapter
        '
        Me.MediaTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Media ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MediaDescriptionDataGridViewTextBoxColumn
        '
        Me.MediaDescriptionDataGridViewTextBoxColumn.DataPropertyName = "MediaDescription"
        Me.MediaDescriptionDataGridViewTextBoxColumn.HeaderText = "Media Description"
        Me.MediaDescriptionDataGridViewTextBoxColumn.Name = "MediaDescriptionDataGridViewTextBoxColumn"
        '
        'MediaVolumeDataGridViewTextBoxColumn
        '
        Me.MediaVolumeDataGridViewTextBoxColumn.DataPropertyName = "MediaVolume"
        Me.MediaVolumeDataGridViewTextBoxColumn.HeaderText = "Volume Name"
        Me.MediaVolumeDataGridViewTextBoxColumn.Name = "MediaVolumeDataGridViewTextBoxColumn"
        '
        'MediaLabel
        '
        Me.MediaLabel.DataPropertyName = "MediaLabel"
        Me.MediaLabel.HeaderText = "Media Label"
        Me.MediaLabel.Name = "MediaLabel"
        Me.MediaLabel.ToolTipText = "This is the identifier you want to use for this media. For example, it could be a" &
    " sticker on a USB key."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 344)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MediaDatabaseDataSetBindingSource As BindingSource
    Friend WithEvents MediaDatabaseDataSet As MediaDatabaseDataSet
    Friend WithEvents MediaBindingSource As BindingSource
    Friend WithEvents MediaTableAdapter As MediaDatabaseDataSetTableAdapters.MediaTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MediaDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MediaVolumeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MediaLabel As DataGridViewTextBoxColumn
End Class
