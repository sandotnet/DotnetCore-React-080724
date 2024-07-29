select * from sales.customers
select count(*) as 'Customer Count' from sales.customers
select count(*) as 'Customer From CA' from sales.customers where state='CA' 
select * from production.products
select AVG(list_price) as 'Avg Price' from production.products
select Max(list_price) as 'Max Price' from production.products
select Min(list_price) as 'Min Price' from production.products
select SUm(list_Price) as 'Total Price' from production.products
select * from sales.orders
select Max(order_date) as 'latest order' from sales.orders
select Min(order_date) as 'first order' from sales.orders
