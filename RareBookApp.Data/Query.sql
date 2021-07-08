select p.CustomerNumber, p.FirstName, p.LastName, p.ContactPhone,
	a.SaleID ,a.SaleDate, a.SalesTotalAmount
from dbo.Customers p
left join dbo.Sales a on p.CustomerNumber = a.CustomerNumber;

--Sale left join Customer
select a.SaleID, a.SaleDate, a.SalesTotalAmount,
	b.CustomerNumber, b.FirstName, b.LastName, b.Street, b.City, b.StateProvince, b.ZipCode
from dbo.Sales a
left join dbo.Customers b on a.CustomerNumber = b.CustomerNumber
order by a.SaleID;

-- Customer left join Sale
select a.CustomerNumber, a.FirstName, a.LastName,
		b.SaleID, b.SalesTotalAmount, b.SaleDate
from dbo.Customers a
left join dbo.Sales b on a.CustomerNumber = b.CustomerNumber
order by a.CustomerNumber;

-- Inner join of Customer and Sale
-- return when there is a match in both tables
select a.CustomerNumber, a.FirstName, a.LastName,
		b.SaleID, b.SalesTotalAmount, b.SaleDate
from dbo.Customers a
join dbo.Sales b on a.CustomerNumber = b.CustomerNumber
order by a.CustomerNumber;

-- Join between Customer, Sale, and Inventory
select a.InventoryID, a.ISBN, a.DateAcquired, a.AskingPrice, a.SellingPrice,
	b.SaleID, b.SaleDate, b.SalesTotalAmount,
	c.CustomerNumber, CONCAT(c.FirstName, ' ' , c.LastName) as CustomerName, c.ContactPhone
from dbo.Inventory a
join dbo.Sales b on a.SaleID = b.SaleID
join dbo.Customers c on b.CustomerNumber = c.CustomerNumber
order by a.InventoryID;

select *
from dbo.Sales;