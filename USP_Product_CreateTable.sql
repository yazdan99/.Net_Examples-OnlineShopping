create database onlineshopping
Go
use OnlineShopping
go
Create PROCEDURE dbo.USP_Product_CreateTable
AS
begin tran 
begin try

IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Product') AND type in (N'U'))
		begin
			create table Product
				(	ProductID int not null identity(1,1) primary key,
				    ProductCode int,
					ProductName nvarchar(50) Not Null,
					CategoryId int foreign key references Category(CategoryId),
					Quantity int,
					UnitPrice money,
					Discount money,
					Picture image,
					Descriptions nvarchar(100),
				) 
		end
else
        begin
		 print 'Error. There is already a table named "Product" in the database.'
		end
print'Successful'
commit tran 
end try
begin catch 
	print 'Error'
rollback tran 
end catch 
go
exec dbo.USP_Product_CreateTable