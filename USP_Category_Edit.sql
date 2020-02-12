Create database onlineshopping
Go
use OnlineShopping
go
Create PROCEDURE dbo.USP_Category_Edit
  @EditCategory as dbo.UDT_Category_Edit readonly,
  @OutputResult  varchar(max) output

AS
begin tran 
begin try
update dbo.Category set CategoryName = (select dc.CategoryName from @EditCategory dc),
                        Descriptions = (select dc.Descriptions from @EditCategory dc) where
						CategoryId = (select dc.CategoryId from @EditCategory dc)
select @OutputResult = 'Category Edit is Done.'
commit tran 
end try
begin catch
declare @@Message varchar(50)= @@ERROR 
select @OutputResult =  'Error Code: ' + @@Message + '    ' + 'Error Message: ' + ERROR_MESSAGE()
rollback tran 
end catch