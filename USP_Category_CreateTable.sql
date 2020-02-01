create database onlineshopping
Go
use OnlineShopping
go
Create PROCEDURE dbo.USP_Category_CreateTable
AS
begin tran 
begin try

IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Category') AND type in (N'U'))
		begin
			create table Category
				(	CategoryID int not null identity(1,1) primary key,
					CategoryName nvarchar(50) NOT NULL,
					Descriptions nvarchar(100),
				)
		end
else
        begin
		 print 'Error. There is already a table named "Category" in the database.'
		end
print'Successful'
commit tran 
end try
begin catch 
	print 'Error'
rollback tran 
end catch 
go
exec dbo.USP_Category_CreateTable