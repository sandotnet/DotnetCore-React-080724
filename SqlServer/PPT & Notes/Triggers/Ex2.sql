--demo on after insert trigger
create trigger tri_prod_inset1
on products
after insert
as
rollback transaction
print 'access denied'
go
insert into Products 
values('P0008','opticalMouse',500,12)
select * from Products