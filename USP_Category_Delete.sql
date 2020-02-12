Create database onlineshopping
Go
use OnlineShopping
go
Create PROCEDURE dbo.USP_Category_Delete
  @DeleteCategory as dbo.UDT_Category_Delete readonly,
  @OutputResult  varchar(max) output

AS
begin tran 
begin try
delete from dbo.Category where CategoryId in (select dc.CategoryId from @DeleteCategory dc)
select @OutputResult = 'Category Delete is Done.'
commit tran
end try
begin catch
declare @@Message varchar(50)= @@ERROR 
select @OutputResult =  'Error Code: ' + @@Message + '    ' + 'Error Message: ' + ERROR_MESSAGE()
rollback tran 
end catch