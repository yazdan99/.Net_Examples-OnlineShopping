use OnlineShopping
go
create PROCEDURE dbo.USP_Category_List
AS
begin tran 
begin try
	select c.CategoryId, c.CategoryName , c.Descriptions
	from dbo.Category c 
	print'Successful'
commit tran 
end try
begin catch 
	print 'Error'
rollback tran 
end catch 
go
exec dbo.USP_Category_List