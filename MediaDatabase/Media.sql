CREATE TABLE [dbo].[Media]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MediaDescription] NCHAR(50) NULL, 
    [MediaVolume] NVARCHAR(50) NULL, 
    [MediaKey] NCHAR(10) NULL, 
    [MediaImage] IMAGE NULL
)
