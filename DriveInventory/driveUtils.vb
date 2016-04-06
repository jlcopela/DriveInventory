Imports System
Imports System.IO
Public Class driveUtils
    Public Sub DisplayDriveInfo()
        Dim allDrives() As DriveInfo
        allDrives = DriveInfo.GetDrives()
        Dim d As DriveInfo
        Dim sizeGB As Decimal
        Dim driveMessage As String = ""
        For Each d In allDrives
            driveMessage = driveMessage + "Drive Name = " + d.Name + vbCrLf
            driveMessage = driveMessage + "Drive Volume = " + d.VolumeLabel + vbCrLf
            driveMessage = driveMessage + "Drive Size = " + Format(d.TotalSize, "n") + vbCrLf
            driveMessage = driveMessage + " ================== " + vbCrLf

        Next

        Dim Result As DialogResult = MessageBox.Show(driveMessage, "Drive Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
    End Sub

End Class
