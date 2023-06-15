CREATE TABLE [dbo].[TransactionDetail](
	TransactionID INT NOT NULL,
	AlbumID INT NOT NULL,
	Qty INT NOT NULL,
	FOREIGN KEY (TransactionID) REFERENCES [dbo].[TransactionHeader](TransactionID) ON DELETE CASCADE,
	FOREIGN KEY (AlbumID) REFERENCES [dbo].[Album](AlbumID) ON DELETE CASCADE,
	PRIMARY KEY(TransactionID, AlbumID)
)