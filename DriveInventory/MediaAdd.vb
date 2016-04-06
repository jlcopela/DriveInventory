Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class MediaAdd
    Dim selectedDrive As String = ""


    Sub loadDriveList()
        Dim record(5) As String


        'set default view
        driveListView.View = View.Details
        driveListView.CheckBoxes = False
        driveListView.BorderStyle = BorderStyle.Fixed3D
        driveListView.MultiSelect = False

        'Add columns
        driveListView.Columns.Add("Drive", 15, HorizontalAlignment.Left)
        driveListView.Columns.Add("Volume", 25, HorizontalAlignment.Left)
        driveListView.Columns.Add("Size (GB)", 15, HorizontalAlignment.Left)
        driveListView.Columns.Add("Type", 15, HorizontalAlignment.Left)
        driveListView.Columns.Add("MediaKey", 15, HorizontalAlignment.Left)

        'Get System Drive Information
        Dim allDrives() As DriveInfo
        allDrives = DriveInfo.GetDrives()
        Dim d As DriveInfo

        Dim itm As ListViewItem

        For Each d In allDrives
            record(0) = d.Name
            record(1) = d.VolumeLabel
            record(2) = Format((d.TotalSize / 1000000000), "n").ToString

            Select Case d.DriveType
                Case 0
                    record(3) = "Unknown"
                Case 1
                    record(3) = "No Root Directory"
                Case 2
                    record(3) = "Removable"
                Case 3
                    record(3) = "Fixed"
                Case 4
                    record(3) = "Remote Drive"
                Case 5
                    record(3) = "CD-ROM"
                Case 6
                    record(3) = "RAM Disk"

            End Select
            record(4) = d.DriveFormat

            'Define a List View Item to add to the ListView grid
            itm = New ListViewItem(record)
            driveListView.Items.Add(itm)
        Next

        ' Size the columns to match data.  -1 parameter on width matches data length.
        For i As Integer = 0 To driveListView.Columns.Count - 1
            driveListView.Columns(i).Width = -1
        Next
    End Sub

    Private Sub MediaAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MediaDatabaseDataSet.Media' table. You can move, or remove it, as needed.
        Me.MediaTableAdapter.Fill(Me.MediaDatabaseDataSet.Media)

        loadDriveList()
        'GetFiles()


    End Sub
    Private Sub GetFilesandDirectories(selectedDrive As String)
        Dim jlcDirectoryInfo
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        Dim selectedDrive As String = driveListView.SelectedItems(0).Text
        saveSelectedDriveInfo()

    End Sub

    Sub saveSelectedDriveInfo()
        Dim selectedDrive As String = driveListView.SelectedItems(0).Text
        Dim selectedVolume As String = driveListView.SelectedItems(0).SubItems(1).Text

        MediaTableAdapter.Insert("Test Description", selectedVolume, "USB1")
        MediaDatabaseDataSet.AcceptChanges()
        Me.MediaTableAdapter.Fill(Me.MediaDatabaseDataSet.Media)

    End Sub

    Private Sub MediaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MediaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MediaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MediaDatabaseDataSet)

    End Sub

    Private Sub btnRefreshDG_Click(sender As Object, e As EventArgs) Handles btnRefreshDG.Click
        Me.MediaTableAdapter.Fill(Me.MediaDatabaseDataSet.Media)

    End Sub
End Class