Imports System
Imports System.Data.SqlClient
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

    ''' <summary>
    ''' Function to save an image to a SQL database
    ''' </summary>
    ''' <param name="imgName">Name of the image (Need path as well)
    ''' ex: C:\MyImage.gif
    ''' </param>
    ''' <param name="storedProc">Stored procedure to execute.
    ''' NOTE: I decided to make this a parameter so when using it
    ''' a stored proc doesnt have to be renamed to use this snippet
    ''' </param>
    ''' <returns>True if successful, False is failed</returns>
    ''' <remarks></remarks>
    Public Function InsertImage(ByRef imgName As String, ByRef storedProc As String) As Boolean
        Try
            'First we need to make sure an image name was provided. If
            'none is provided we need to show a message to the user
            'and exit the function
            If (imgName) = vbNull Or imgName = "" Then
                MessageBox.Show("Please provide an image to save.")
                Exit Function
            End If

            'FileInfo instance so we can get all the
            'information we need regarding the image
            Dim fInfo As New FileInfo(imgName)

            'Get the length of the image for the byte array
            'we create later in the function		
            Dim len As Long = fInfo.Length

            'This is the connections tring connecting to your database
            '** NOTE: This needs to be changed to YOUR connection string **
            Dim connString As String = "YourConnectionString"

            'Open a FileStream the length of the image being inserted
            Using stream As New FileStream(imgName.Trim(), FileMode.Open)
                'Create a new byte array the size of the length of the file
                Dim imgData() As Byte = New Byte(Convert.ToInt32(len - 1)) {}

                'Read the byte array into the buffer
                stream.Read(imgData, 0, len)

                'Create our Sql connection
                Using con As New SqlConnection(connString)

                    'Create the command object that will do
                    'the database work
                    Using cmd As New SqlCommand()
                        con.Open()

                        'Set the properties of ouor connection object
                        cmd.Connection = con
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.CommandText = storedProc

                        'Add the parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@image_data", imgData)
                        cmd.Parameters.AddWithValue("@image_name", imgName)

                        'Execute the Stored Procedure
                        cmd.ExecuteNonQuery()

                        Return True
                    End Using
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Function for retrieving images from a SQL Server based on the image name
    ''' </summary>
    ''' <param name="imgName">Name of the image we want to retrieve</param>
    ''' <param name="storedProc">Name of the stored procedure to execute</param>
    ''' <returns>A DataTable with the image information</returns>
    ''' <remarks></remarks>
    Public Function GetImageFromDB(ByRef imgName As String, ByRef storedProc As String) As DataTable
        'This is the connections tring connecting to your database
        '** NOTE: This needs to be changed to YOUR connection string **
        Dim connString As String = "YourConnectionString"

        'MemoryStream that will hold the byte array
        'before converting to a Bitmap
        Dim stream As MemoryStream = Nothing

        Dim img As Image = Nothing

        Dim imgBytes As Byte() = Nothing

        'Table that will hold the data returned
        Dim table As New DataTable("Images")

        'We need to create the columns for the table
        table.Columns.Add("ImageID", GetType(Integer))
        table.Columns.Add("Image", GetType(Byte()))
        table.Columns.Add("ImageName", GetType(String))

        'Need a reader to read the returned data
        Dim reader As SqlDataReader = Nothing

        Try
            Using con As New SqlConnection(connString)
                Using cmd As New SqlCommand()
                    'Set the properties of our connection object
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = storedProc
                    cmd.Parameters.AddWithValue("@image_name", imgName)
                    'Open our connection
                    cmd.Connection.Open()

                    'Read the data
                    reader = cmd.ExecuteReader()

                    'Create a new row for the table
                    Dim row As DataRow

                    'Now loop through the data
                    While reader.Read()
                        row = table.NewRow

                        'Add the id of the image
                        row(0) = reader.GetValue(0)

                        'Here we need to get the binary data and convert
                        'it to an image before we can add it to the table
                        imgBytes = CType(reader.GetValue(1), Byte())

                        'Read the byte array into a MemoryStream
                        stream = New MemoryStream(imgBytes, 0, imgBytes.Length)

                        'Create the new Image from the stream
                        img = Image.FromStream(stream)

                        img.Save(stream, System.Drawing.Imaging.ImageFormat.Gif)

                        'Now add the image to the table
                        row(1) = stream.ToArray()

                        'Add th image name to the table
                        row(2) = reader.GetValue(2)

                        table.Rows.Add(row)
                    End While

                    Return table
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.ToString())
            Return Nothing
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return Nothing
        End Try
    End Function

End Class
