create database onlineshopping
Go
use OnlineShopping
go
Create PROCEDURE dbo.USP_Category_Edit
  @EditCategory as dbo.UDT_Category_Edit readonly
AS
begin tran 
begin try
update dbo.Category set CategoryName = (select dc.CategoryName from @EditCategory dc),
                        Descriptions = (select dc.Descriptions from @EditCategory dc) where
						CategoryId = (select dc.CategoryId from @EditCategory dc)

commit tran 
end try
begin catch 

rollback tran 
end catch 
go
exec dbo.USP_Category_Edit