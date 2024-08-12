create trigger Emp_insert2
on Emp
after insert
as
declare @empid varchar(30)
set @empid=(select empid from inserted)
insert into validate(Empid) values(@empid)
go
