create procedure GetAllEmployees
as
begin
select * from EmployeeDetails
end
--invoke procedure
exec GetAllEmployees
