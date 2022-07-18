/*В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.*/

CREATE DATABASE SampleDB

CREATE TABLE Products (
    ProductID INT IDENTITY PRIMARY KEY NOT NULL,
    ProductName NVARCHAR(30) ,
);
CREATE TABLE Categories (
    CategoryID INT IDENTITY PRIMARY KEY NOT NULL,
    CategoryName NVARCHAR(30),
);
CREATE TABLE ProductsCategories (
    Product INT NOT NULL,
    Category INT NOT NULL,
	PRIMARY KEY (Product, Category),
	FOREIGN KEY (Product) REFERENCES Products (ProductID),
	FOREIGN KEY (Category) REFERENCES Categories (CategoryID),
);

SELECT P.ProductName, C.CategoryName FROM ProductsCategories PC 
	RIGHT OUTER JOIN Categories C ON (C.CategoryID = PC.Category)
	RIGHT OUTER JOIN Products P ON (P.ProductID = PC.Product)