create database onlineshopping
Go
use OnlineShopping
go
create PROCEDURE dbo.USP_Product_Select
    @SelectProduct as dbo.UDT_Product_Select readonly
AS
begin tran 
begin try

    declare @ProductCode int = (select sp.ProductCode  from @SelectProduct sp)
	declare @ProductName varchar(150)= (select sp.ProductName  from @SelectProduct sp)
	declare @CategoryId int = (select sp.CategoryId  from @SelectProduct sp)
	declare @Quantity int = (select sp.Quantity  from @SelectProduct sp)
	declare @UnitPrice money = (select sp.UnitPrice  from @SelectProduct sp)
	declare @Discount money = (select sp.Discount  from @SelectProduct sp)
	declare @Descriptions varchar(150)= (select sp.Descriptions  from @SelectProduct sp)

	if @ProductCode=0
	begin
	 select p.ProductID , p.ProductCode , p.ProductName , p.CategoryId , p.Quantity , p.UnitPrice ,
       p.Discount , p.Picture , p.Descriptions from dbo.Product p
	   where (p.ProductName  Like '%' + @ProductName + '%'  )
	   and   (p.Descriptions  Like '%' + @Descriptions + '%'  )
	end
	else
	begin
	 select p.ProductID , p.ProductCode , p.ProductName , p.CategoryId , p.Quantity , p.UnitPrice ,
       p.Discount , p.Picture , p.Descriptions from dbo.Product p
	   where (p.ProductCode = @ProductCode    )
	   and (p.ProductName  Like '%' + @ProductName + '%'  )
	   and (p.Descriptions  Like '%' + @Descriptions + '%'  )
	  -- and (p.CategoryId =  @CategoryId   )
	  -- and (p.Quantity =  @Quantity   )
	  -- and (p.UnitPrice =  @UnitPrice   )
	  -- and (p.Discount =  @Discount   ) 
	  -- or (p.Descriptions Like  '%' + @Descriptions + '%' )
	end

	print'Successful'
commit tran 
end try
begin catch 
	print 'Error'
rollback tran 
end catch 
go
exec dbo.USP_Product_Select