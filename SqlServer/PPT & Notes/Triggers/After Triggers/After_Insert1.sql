create trigger Emp_insert1
on Emp
after insert
as
Rollback Transaction
print 'Insertion is Denied for Emp'
go
