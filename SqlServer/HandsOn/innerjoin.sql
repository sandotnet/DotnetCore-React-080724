select * from EmployeeDetails
select e.EmpId,e.EmpName,d.dept_code,d.Dept_Name from Department d 
inner join EmployeeDetails e on d.Dept_Code=e.Dept_Code

select e.EmpId,e.EmpName,d.dept_code,d.Dept_Name from Department d 
inner join EmployeeDetails e on d.Dept_Code=e.Dept_Code where e.Designation='Programmer'

select e.EmpId,e.EmpName,d.dept_code,d.Dept_Name from Department d 
inner join EmployeeDetails e on d.Dept_Code=e.Dept_Code where e.Designation='Programmer' 
order by d.Dept_Name

select * from sales.order_items
select * from production.products
select * from production.brands
select * from production.categories
select p.product_id,p.product_name,o.order_id,o.quantity,o.list_price,o.discount
from production.products p join sales.order_items o
on p.product_id=o.product_id

select p.product_id,p.product_name,o.order_id,o.quantity,o.list_price,
b.brand_name,c.category_name
from  sales.order_items o join production.products p 
on p.product_id=o.product_id
join production.brands b on p.brand_id=b.brand_id
join production.categories c on p.category_id=c.category_id