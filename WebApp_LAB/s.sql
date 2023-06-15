CREATE TABLE [dbo].[TransactionDetail](
	TransactionID INT NOT NULL,
	AlbumID INT NOT NULL,
	Qty INT NOT NULL,
	FOREIGN KEY (TransactionID) REFERENCES [dbo].[TransactionHeader](TransactionID) ON DELETE CASCADE,
	FOREIGN KEY (AlbumID) REFERENCES [dbo].[Album](AlbumID) ON DELETE CASCADE,
	PRIMARY KEY(TransactionID, AlbumID)
)
CREATE TABLE [dbo].[TransactionHeader](
	TransactionID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	TransactionDate DATE NOT NULL,
	CustomerID INT NOT NULL,
	FOREIGN KEY (CustomerID) REFERENCES [dbo].[Customer](CustomerID) ON DELETE CASCADE
)
CREATE TABLE [dbo].[Album](
	AlbumID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	ArtistID INT NOT NULL,
	AlbumName VARCHAR(50) NOT NULL,
	AlbumImage VARCHAR(50) NOT NULL,
	AlbumPrice INT NOT NULL,
	AlbumStock INT NOT NULL,
	AlbumDescription VARCHAR(255) NOT NULL,
	FOREIGN KEY (ArtistID) REFERENCES [dbo].[Artist](ArtistID) ON DELETE CASCADE
)