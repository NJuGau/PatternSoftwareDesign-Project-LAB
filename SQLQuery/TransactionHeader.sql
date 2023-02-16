CREATE TABLE [dbo].[TransactionHeader](
	TransactionID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	TransactionDate DATE NOT NULL,
	CustomerID INT NOT NULL,
	FOREIGN KEY (CustomerID) REFERENCES [dbo].[Customer](CustomerID)
)