create table Gender(name varchar(30),gender varchar(10))
insert into Gender(name,gender)
select 'latha','f' union
select 'mahesh','m' union
select 'peter','m' union
select 'devi','f'
select * from Gender

select name,gender,case Gender
when 'm' then 'Male'
when 'f' then 'Female'
else 'others' 
end 'gender Info' from Gender  

select * from EmployeeDetails
select EmpId,EmpName,Designation,case Designation
when 'Programmer' then '10%'
when 'Tester' then '12%'
when 'TeamLead' then '15%'
when 'Project Manager' then '20%'
end 'Salary Increment' from EmployeeDetails