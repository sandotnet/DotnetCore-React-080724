create trigger emp_delete
on emp
after delete
as
rollback transaction
print 'deny the action'
print 'u cant delete a record'
go