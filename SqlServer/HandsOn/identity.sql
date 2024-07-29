--Identity column
create table Customer(customerId int primary key identity(1,1),customerName varchar(20))
insert into Customer values('Tina')
insert into Customer values('Ram')
insert into Customer values('Sita')
select * from Customer