create database onlineshopping
Go
use OnlineShopping
go
create PROCEDURE dbo.USP_Category_Select
   @SelectCategory as dbo.UDT_Category_Select readonly
AS
begin tran 
begin try

    declare @CategoryName varchar(100)= (select sc.CategoryName  from @SelectCategory sc)
	declare @Descriptions varchar(150)= (select sc.Descriptions  from @SelectCategory sc)

	select c.CategoryId, c.CategoryName , c.Descriptions
	from dbo.Category c where (c.CategoryName Like '%' + @CategoryName + '%'  ) and
	                          (c.Descriptions Like '%' + @Descriptions + '%') 

	print'Successful'
commit tran 
end try
begin catch 
	print 'Error'
rollback tran 
end catch 
go
exec dbo.USP_Category_Select