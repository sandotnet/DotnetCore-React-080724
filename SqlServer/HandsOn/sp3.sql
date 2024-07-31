create procedure GetEmployeesByDept(@dept varchar(20))
as
begin
select * from EmployeeDetails where Dept_Code=
(select Dept_Code from Department where Dept_Name=@dept)
end

exec GetEmployeesByDept 'IT'
exec GetEmployeesByDept @dept='Admin'