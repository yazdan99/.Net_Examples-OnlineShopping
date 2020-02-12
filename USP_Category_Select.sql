Create database onlineshopping
Go
use OnlineShopping
go
Create PROCEDURE dbo.USP_Category_Select
   @SelectCategory as dbo.UDT_Category_Select readonly,
   @OutputResult  varchar(50) output

AS
begin tran 
begin try

    declare @CategoryName varchar(100)= (select sc.CategoryName  from @SelectCategory sc)
	declare @Descriptions varchar(150)= (select sc.Descriptions  from @SelectCategory sc)

	select c.CategoryId, c.CategoryName , c.Descriptions
	from dbo.Category c where (c.CategoryName Like '%' + @CategoryName + '%'  ) and
	                          (c.Descriptions Like '%' + @Descriptions + '%')
commit tran 
end try
begin catch 
select @OutputResult =  'Category Search has Error ...'
rollback tran 
end catch