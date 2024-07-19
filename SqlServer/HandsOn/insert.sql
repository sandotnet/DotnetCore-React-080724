select * from Department
insert into Department values('D001','Admin')
insert into Department values('D002','IT')
insert into Department values('D003','Marketing')
insert into Department values('D004','HR')
insert into Department values('D005','LD')
--add multiple records
insert into EmployeeDetails(EmpID,EmpName,Designation,JoinDate,Dept_Code) values
(12,'Manoj','Tester','2.12.2022',null)
(1,'Rohan','Programmer','12.2.2021','D001'),
(2,'Sita','TeamLead','2.12.2020','D003'),
(3,'Ram','Programmer','1.22.2021','D003'),
(4,'Gita','Programmer','2.22.2022','D001'),
(5,'Tina','Programmer','1.23.2023','D002'),
(6,'Meena','TeamLead','2.22.2024','D002'),
(7,'Karan','Programmer','1.20.2021','D002'),
(8,'Rohith','Programmer','2.12.2022','D001'),
(9,'Joy','Programmer','1.2.2023','D003'),
(10,'Mic','TeamLead','1.21.2024',null),
(11,'Peter','Programmer','2.12.2022',null),
(12,'Manoj','Tester','2.12.2022',null)


select * from EmployeeDetails
sp_help EmployeeDetails
alter table EmployeeDetails drop constraint CK__EmployeeD__Desig__398D8EEE