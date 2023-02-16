CREATE TABLE [dbo].[Cart](
	CustomerID INT NOT NULL,
	AlbumID INT NOT NULL,
	Qty INT NOT NULL,
	FOREIGN KEY (CustomerID) REFERENCES [dbo].[Customer](CustomerID),
	FOREIGN KEY (AlbumID) REFERENCES [dbo].[Album](AlbumID),
	PRIMARY KEY(CustomerID, AlbumID)
)