create database onlineshopping
Go
use OnlineShopping
go
create PROCEDURE dbo.USP_Category_Delete
  @DeleteCategory as dbo.UDT_Category_Delete readonly,
  @DbExceptionResult  varchar(50) output

AS
begin tran 
begin try
--declare @ProductDefinedCount int
--set @ProductDefinedCount=(select count(1) from dbo.Product p where p.CategoryId in (select dc.CategoryId from @DeleteCategory dc))

--if @ProductDefinedCount=0
--begin
 delete from dbo.Category where CategoryId in (select dc.CategoryId from @DeleteCategory dc)
--end
--else
--begin
-- print 'A Product Already Has Defined With This Category Id.'
--end
commit tran
end try
begin catch 
select @DbExceptionResult = @@ERROR
print 'Error'
rollback tran 
end catch 
go
exec dbo.USP_Category_Delete