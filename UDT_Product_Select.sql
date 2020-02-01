create database onlineshopping
Go
use OnlineShopping
go
Create  Type dbo.UDT_Product_Select as Table(
ProcuctID   int  ,
ProductCode int ,
ProductName nvarchar(50),
CategoryId  int,
Quantity  int,
UnitPrice  money,
Discount  money,
Picture image,
Descriptions nvarchar(100)
)
