--declare a variable
declare @a int
declare @b int
--set value to the variable
set @a=10
set @b=20
--to initialize the multiple variable values
select @a=10,@b=30
print @a
print @b
