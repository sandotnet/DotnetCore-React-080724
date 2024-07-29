--Left outer join
select e.EmpId,e.EmpName,d.dept_code,d.Dept_Name from EmployeeDetails e 
left outer join Department d on d.Dept_Code=e.Dept_Code 
select * from EmployeeDetails
--Right outer join
select e.EmpId,e.EmpName,d.dept_code,d.Dept_Name from EmployeeDetails e 
right outer join Department d on d.Dept_Code=e.Dept_Code 
--full outer join
select e.EmpId,e.EmpName,d.dept_code,d.Dept_Name from EmployeeDetails e 
full outer join Department d on d.Dept_Code=e.Dept_Code 