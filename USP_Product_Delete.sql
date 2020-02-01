create database onlineshopping
Go
use OnlineShopping
go
Create PROCEDURE dbo.USP_Product_Delete
  @DeleteProduct as dbo.UDT_Product_Delete readonly
AS
begin tran 
begin try

delete from dbo.Product where ProductId in (select p.ProductId from @DeleteProduct p)

commit tran 
end try
begin catch 

rollback tran 
end catch 
go
exec dbo.USP_Product_Delete