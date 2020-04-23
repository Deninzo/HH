select Product.Id, Product.Name, Category.Name 
	from Product
	left join CategoryOfProduct
	on Product.Id = CategoryOfProduct.Product_Id
	left join Category
	on Category.Id = CategoryOfProduct.Category_Id

