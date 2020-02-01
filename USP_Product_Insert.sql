create database onlineshopping
Go
use OnlineShopping
go
Create PROCEDURE dbo.USP_Product_Insert
  @InsertProduct as dbo.UDT_Product_Insert readonly
AS
begin tran 
begin try
insert into dbo.Product(ProductCode , ProductName , CategoryId ,
                        Quantity , UnitPrice , Discount , Picture , Descriptions)
select p.ProductCode , p.ProductName , p.CategoryId , p.Quantity , p.UnitPrice ,
       p.Discount , p.Picture , p.Descriptions from @InsertProduct p

commit tran 
end try
begin catch 

rollback tran 
end catch 
go
exec dbo.USP_Product_Insert