--demo on after insert trigger
create trigger tri_prod_inset
on products
after insert
as
print 'Record added successfully'
print getdate()
go
insert into Products 
values('P0009','opticalMouse',500,12)