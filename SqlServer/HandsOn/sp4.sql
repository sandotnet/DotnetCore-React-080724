create procedure GetEmployeeNameById(@eid int,@ename varchar(20) output)
as
begin
select @ename=EmpName from EmployeeDetails where EmpID=@eid
end
declare @ename varchar(20)
exec GetEmployeeNameById 6,@ename output
print @ename
select * from EmployeeDetails 