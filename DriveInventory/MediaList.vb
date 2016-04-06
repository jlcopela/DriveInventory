Public Class MediaList
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim getDriveInfo As New driveUtils

        getDriveInfo.DisplayDriveInfo()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MediaDatabaseDataSet.Media' table. You can move, or remove it, as needed.
        Me.MediaTableAdapter.Fill(Me.MediaDatabaseDataSet.Media)


    End Sub

    Private Function GetDataTable() As DataTable


        Return New DataTable()
    End Function

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
