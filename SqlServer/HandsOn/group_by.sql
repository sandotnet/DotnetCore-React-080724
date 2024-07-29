--Grouping data
select * from sales.customers
select state,count(customer_id) as 'Customers' from sales.customers group by state
select city,count(customer_id) as 'customers' from sales.customers group by city
--Count no of cities in each state
select state,count(distinct(city))  as 'cities' from sales.customers group by state
--Group the Cities using state and minium cities in each state should be >24
--having use to filter the group by data
select state,count(distinct(city)) as 'cities' from sales.customers group by state 
having count(distinct(city))>24
--display no of orders per year and order count shouble be >10
select * from sales.orders
select year(order_date) as 'Year',count(order_Id) from sales.orders where year(Order_Date)!=2016 group by year(order_date)
having COUNT(order_Id)>300 order by Year(order_Date)
select * from sales.order_items
--display no of order for each product
select product_id,count(Order_id) as 'Orders' from sales.order_items 
group by product_id having count(order_id)>1 order by Orders
--display sum of quntuty of each order
select order_id,sum(quantity) as 'Total Quantity' from sales.order_items
group by order_id
--calculte discount of each order
select order_id,sum(discount) as 'Total Discount' from sales.order_items
group by order_id