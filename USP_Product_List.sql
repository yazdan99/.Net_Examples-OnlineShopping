use OnlineShopping
go
create PROCEDURE dbo.USP_Product_List
AS
begin tran 
begin try
	select p.ProductID , p.ProductCode , p.ProductName , p.CategoryId , p.Quantity , p.UnitPrice ,
       p.Discount , p.Picture , p.Descriptions from dbo.Product p
	print'Successful'
commit tran 
end try
begin catch 
	print 'Error'
rollback tran 
end catch 
go
exec dbo.USP_Product_List