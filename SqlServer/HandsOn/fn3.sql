select * from EmployeeDetails
alter table EmployeeDetails add Salary int
update EmployeeDetails set Salary=34000 where Designation='Programmer'
update EmployeeDetails set Salary=86000 where Designation='Project Manager'
update EmployeeDetails set Salary=54000 where Designation='TeamLead'
update EmployeeDetails set Salary=44000 where Designation='Tester'
create function fn_getbonous(@designation varchar(20),@salary int)
returns int
as
begin
declare @bonous int
if(@designation='Programmer')
set @bonous=@salary*0.15
else if(@designation='Tester')
set @bonous=@salary*0.12
else if(@designation='TeamLead')
set @bonous=@salary*0.10
else
set @bonous=@salary*0.05
return @bonous
end
select EmpId,EmpName,Salary,Designation,dbo.fn_getbonous(Designation,Salary) as 'Bonous'
from EmployeeDetails

