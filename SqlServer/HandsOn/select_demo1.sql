select * from sales.customers
select customer_id,first_name from sales.customers
select customer_id as 'ID',first_name as 'FirstName' 
from sales.customers
select City from sales.customers
select distinct(City) from sales.customers
--sorting records
select * from sales.customers order by city
select * from sales.customers order by customer_id desc
select s.customer_id,s.first_name from sales.customers s
select sales.customers.customer_id,sales.customers.first_name from sales.customers