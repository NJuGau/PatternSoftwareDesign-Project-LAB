﻿CREATE TABLE [dbo].[Album](
	AlbumID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	ArtistID INT NOT NULL,
	AlbumName VARCHAR(50) NOT NULL,
	AlbumImage VARCHAR(50) NOT NULL,
	AlbumPrice INT NOT NULL,
	AlbumStock INT NOT NULL,
	AlbumDescription VARCHAR(255) NOT NULL,
	FOREIGN KEY (ArtistID) REFERENCES [dbo].[Artist](ArtistID)
)