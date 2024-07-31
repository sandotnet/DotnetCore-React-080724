--error handling in stored procedure
create procedure Dividenum1(@no1 int ,@no2 int)
as
begin
begin try
declare @res int
set @res=@no1/@no2
return @res
end try
begin catch
raiserror('divide by zero',14,1)
end catch
end
declare @res1 int
exec @res1= Dividenum1 2,0
print @res1
