CREATE TABLE [dbo].[Customer](
	CustomerID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	CustomerName VARCHAR(50) NOT NULL,
	CustomerEmail VARCHAR(50) NOT NULL,
	CustomerPassword VARCHAR(50) NOT NULL,
	CustomerGender VARCHAR(6) NOT NULL,
	CustomerAddress VARCHAR(100) NOT NULL,
	CustomerRole VARCHAR(5) NOT NULL
)
