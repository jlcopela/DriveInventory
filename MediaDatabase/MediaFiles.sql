CREATE TABLE [dbo].[MediaFiles]
(
	[Id] INT NOT NULL , 
    [FileID] INT NOT NULL IDENTITY, 
    [FileName] NVARCHAR(50) NULL, 
    [Directory] NVARCHAR(100) NULL, 
    [Path] NCHAR(260) NULL, 
    [Extension] NCHAR(30) NULL, 
    PRIMARY KEY ([Id], [FileID])
)
