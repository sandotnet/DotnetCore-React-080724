select * from Product
alter trigger insert_product
on product
after insert
as
print 'record added at:'+cast(getdate() as varchar(100))
Go
insert into product values(8,'AAA',100,10)