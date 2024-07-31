declare @a int
declare @b int
set @a=10
set @b=20
--to initialize the multiple variable values
select @a=10,@b=30
print @a
print @b
print cast(@a as varchar(20))+' '+convert(varchar(20),@b)