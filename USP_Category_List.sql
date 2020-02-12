Create database onlineshopping
Go
use OnlineShopping
go
Create PROCEDURE dbo.USP_Category_List
AS
begin tran 
begin try
	select c.CategoryId, c.CategoryName , c.Descriptions
	from dbo.Category c 
commit tran 
end try
begin catch 
rollback tran 
end catch 
go
exec dbo.USP_Category_List