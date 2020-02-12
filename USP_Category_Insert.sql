Create database onlineshopping
Go
use OnlineShopping
go
Create PROCEDURE dbo.USP_Category_Insert
  @InsertCategory as dbo.UDT_Category_Insert readonly,
  @OutputResult  varchar(50) output

AS
begin tran 
begin try
insert into dbo.Category(CategoryName , Descriptions)
select c.CategoryName , c.Descriptions from @InsertCategory c
select @OutputResult = 'Category Add is Done.'
commit tran 
end try
begin catch 
select @OutputResult =  'Category Add has Error ...'
rollback tran 
end catch