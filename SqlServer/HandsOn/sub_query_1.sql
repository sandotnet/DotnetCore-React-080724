select * from EmployeeDetails
select * from Department
select * from EmployeeDetails where Dept_Code=
(Select Dept_Code from Department where Dept_Name='Admin')
select * from EmployeeDetails where Dept_Code in
(Select Dept_Code from Department where Dept_Name in('Admin','IT'))
select * from EmployeeDetails where Dept_Code in
(Select Dept_Code from Department where Dept_Name not in('Admin','IT'))
select * from EmployeeDetails where JoinDate=(select Min(joindate) from EmployeeDetails)
-- Get employee who are having min exp than employees working in D003
select * from EmployeeDetails where JoinDate > 
All(Select JoinDate from EmployeeDetails where Dept_Code='D003') and Dept_Code!='D003'
Select JoinDate from EmployeeDetails where Dept_Code='D003'
-- Get employee who are having max exp than employees working in D003
select * from EmployeeDetails where JoinDate <
All(Select JoinDate from EmployeeDetails where Dept_Code='D003') and Dept_Code!='D003'
select * from EmployeeDetails where JoinDate <
any(Select JoinDate from EmployeeDetails where Dept_Code='D003') and Dept_Code!='D003'