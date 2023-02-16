CREATE TABLE [dbo].[TransactionDetail](
	TransactionID INT NOT NULL,
	AlbumID INT NOT NULL,
	Qty INT NOT NULL,
	FOREIGN KEY (TransactionID) REFERENCES [dbo].[TransactionHeader](TransactionID),
	FOREIGN KEY (AlbumID) REFERENCES [dbo].[Album](AlbumID),
	PRIMARY KEY(TransactionID, AlbumID)
)