select p.CustomerNumber, p.FirstName, p.LastName, p.ContactPhone,
	a.SaleID ,a.SaleDate, a.SalesTotalAmount
from dbo.Customers p
left join dbo.Sales a on p.CustomerNumber = a.CustomerNumber;

select *
from dbo.Sales
where CustomerNumber = 3;