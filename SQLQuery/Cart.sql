CREATE TABLE [dbo].[Cart](
	CustomerID INT NOT NULL,
	AlbumID INT NOT NULL,
	Qty INT NOT NULL,
	FOREIGN KEY (CustomerID) REFERENCES [dbo].[Customer](CustomerID) ON DELETE CASCADE,
	FOREIGN KEY (AlbumID) REFERENCES [dbo].[Album](AlbumID) ON DELETE CASCADE,
	PRIMARY KEY(CustomerID, AlbumID)
)