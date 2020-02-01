create database onlineshopping
Go
use OnlineShopping
go
Create PROCEDURE dbo.USP_Product_Edit
  @EditProduct as dbo.UDT_Product_Edit readonly
AS
begin tran 
begin try
update dbo.Product set  ProductCode = (select p.ProductCode from @EditProduct p),
                        ProductName = (select p.ProductName from @EditProduct p),
						CategoryId = (select p.CategoryId from @EditProduct p),
						Quantity = (select p.Quantity from @EditProduct p),
						UnitPrice = (select p.UnitPrice from @EditProduct p),
						Discount = (select p.Discount from @EditProduct p),
						Picture = (select p.Picture from @EditProduct p),
                        Descriptions = (select p.Descriptions from @EditProduct p) where
						ProductID = (select p.ProcuctID from @EditProduct p)

commit tran 
end try
begin catch 

rollback tran 
end catch 
go
exec dbo.USP_Product_Edit