sp_helpindex EmployeeDetails
sp_helpindex Department
select * from sales.orders
sp_helpindex [sales.orders]
sp_tables
--apply clustered index
create clustered index dept_id_cluster on Department(dept_id)
--apply clustered index
create nonclustered index dept_name_noncluster on Department(dept_name)
sp_helpindex Department
--drop index
drop index dept_id_cluster on Department
create table Person(Pid int,Name varchar(20))