select * from sales.customers
select * from sales.customers where city='Campbell' and state='CA'
select * from sales.customers where state='CA'
select distinct(State) from sales.customers
select * from sales.customers where state='CA' or state='NY'
select * from sales.customers where state in('CA','NY')
select * from sales.customers where state='CA' or City='Buffalo'
select * from sales.customers order by state
select * from sales.customers where state='CA' order by first_name asc
select * from sales.customers where state='CA' order by first_name desc
select * from sales.customers order by [state],city
select * from production.stocks
select * from production.stocks where quantity between 10 and 25
select * from production.stocks where quantity not between 10 and 25
select * from sales.order_items
select * from sales.orders
select * from sales.orders where order_date between '04-01-2016' and '06-30-2016'
select * from sales.customers where city in('Buffalo','Monsey','New York')
select * from sales.orders where customer_id in(259,175,94,324)
select * from sales.orders where shipped_date in('2016-01-03','2016-01-05')
select * from sales.orders where shipped_date not in('2016-01-03','2016-01-05')

select * from sales.customers where phone is null