--Date Functions
select getdate() --return currenct system date and time
select YEAR('12.2.2000')
select Year(getdate())
select Month('12.3.2000')
select Day('12.23.2000')
select Year(Order_Date) as 'Order Year' from sales.orders
select DATEPART(yy,getdate())
select DATEPART(mm,'12.2.2000')
select DatePart(dd,'12.23.2000')
select DatePart(dw,'12.23.2000')
select DATEPART(hh,getdate())
select DATEPART(HH,getdate())
select DATEDIFF(yy,'12.2.2000',getdate()) as 'Age in years'
select DATEDIFF(mm,'12.2.2000',getdate()) as 'Age in months'
select DATEDIFF(dd,'12.2.2000',getdate()) as 'Age in days'
select DATEADD(dd,3,getdate())
select IsDate('23.3.1909') --return 0 when date expression is wrong
select IsDate('1.1.2000') -- return 1 when date expression is right