select UPPER('Hello Users')
select LOWER('Hello Users')
select LEN('Hello Users') as 'Count'
select REPLACE('Hello Users','e','E')
select SUBSTRING('GoodMorning',0,5)
select LEFT('Rohith',2)
select Right('Rohith',2)

-- Cast Functions
select CAST('10' as int)
select Convert(int,'100')
select Cast('10' as int)+Convert(int,'230') as 'Sum'
select * from sales.customers
select Left(First_Name,2) from sales.customers