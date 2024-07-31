create procedure GetEmployeeCountByDept(@deptcode varchar(20))
as
begin
declare @count int
select @count=Count(*) from EmployeeDetails where Dept_Code=@deptcode
return @count
end
declare @result int
exec @result=GetEmployeeCountByDept 'D003'
print @result