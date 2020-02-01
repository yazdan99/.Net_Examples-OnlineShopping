create database onlineshopping
Go
use OnlineShopping
go
Create PROCEDURE dbo.USP_Category_Insert
  @InsertCategory as dbo.UDT_Category_Insert readonly
AS
begin tran 
begin try
insert into dbo.Category(CategoryName , Descriptions)
select c.CategoryName , c.Descriptions from @InsertCategory c

commit tran 
end try
begin catch 

rollback tran 
end catch 
go
exec dbo.USP_Category_Insert