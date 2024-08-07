create procedure InsertProduct(@PName varchar(20),@Price int,@Stock int)
as
begin
declare @Pid int
if(exists(Select * from Product))
begin
select @Pid=Max(Pid) from Product
set @Pid=@Pid+1
end
else
begin
set @Pid=1
end
insert into Product values(@Pid,@PName,@Price,@Stock)
end

Exec InsertProduct 'Mouse',400,10
Exec InsertProduct 'Keyboard',400,10

Select * from Product