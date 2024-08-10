// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EF;
using Entitties.Concrete;


ProductManager productManager = new ProductManager(new  ProductDal());
Product product =new Product();
product.PrName = "DivanN3";
product.PrCount = 28;
product.PrPrice = 101;
product.PrDescription = "";
productManager.Add(product);


