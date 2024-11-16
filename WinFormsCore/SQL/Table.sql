CREATE DATABASE DataLapTrinhTrucQuan;
GO

USE DataLapTrinhTrucQuan;
GO
CREATE TABLE Customers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    City NVARCHAR(100),
    Country NVARCHAR(100),
    Phone NVARCHAR(20)
);
CREATE TABLE Orders (
    Id INT PRIMARY KEY IDENTITY(1,1),
    OrderDate DATETIME NOT NULL,
    OrderNumber NVARCHAR(50),
    CustomerId INT NOT NULL,
    TotalAmount DECIMAL(18, 2),
    CONSTRAINT FK_Orders_Customers FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
);
CREATE TABLE OrderItems (
    Id INT PRIMARY KEY IDENTITY(1,1),
    OrderId INT NOT NULL,
    ProductId INT NOT NULL,
    UnitPrice DECIMAL(18, 2) NOT NULL,
    Quantity INT NOT NULL,
    CONSTRAINT FK_OrderItems_Orders FOREIGN KEY (OrderId) REFERENCES Orders(Id),
    CONSTRAINT FK_OrderItems_Products FOREIGN KEY (ProductId) REFERENCES Products(Id)
);
CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100) NOT NULL,
    SupplierId INT NOT NULL,
    UnitPrice DECIMAL(18, 2),
    Package NVARCHAR(50),
    IsDiscontinued BIT NOT NULL,
    CONSTRAINT FK_Products_Suppliers FOREIGN KEY (SupplierId) REFERENCES Suppliers(Id)
);
CREATE TABLE Suppliers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    CompanyName NVARCHAR(100) NOT NULL,
    ContactName NVARCHAR(100),
    ContactTitle NVARCHAR(50),
    City NVARCHAR(100),
    Country NVARCHAR(100),
    Phone NVARCHAR(20),
    Fax NVARCHAR(20)
);
CREATE TABLE Account (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(100) NOT NULL,
    FullName NVARCHAR(100),
    PassWord NVARCHAR(50),
    Role NVARCHAR(100),
   
);
INSERT INTO Account (UserName, FullName, PassWord, Role)
VALUES ('TrungTin', N'Nguyễn Trung Tin', '123', 'Admin');

