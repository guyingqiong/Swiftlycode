# Product Catalog
A simple MVC application consuming a Web API

 
A solution for managing product catalog. Users use an ASP.NET MVC web application to add, edit, remove, view and search and export (Excel) product catalog items, information about product catalog entities are exposed through RESTful service. 
 
Product Catalog Model

Product 
{
ProductID,
ProductDescription,
RegularDisplayPrice,
RegularCalculatorPrice,
SaleDisplayPrice,
SaleCalculatorPrice,
UnitofMeasure,
Productsize,
Taxrate
}

RESTful service:
- ASP.NET Web.API
- MS SQL & Entity Framework
- Web.API Help pages as API Documentation
- Ninject as Dependency Injection
 
Web application:
- ASP.NET MVC

TODO List
- Unit tests
- Integration tests
