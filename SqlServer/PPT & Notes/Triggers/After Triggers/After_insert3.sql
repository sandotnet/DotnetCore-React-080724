create trigger tr_emp_insert
on emp
after insert
as
print 'Record Inserted at'
print getdate()
go


