--error handling in stored procedure
create procedure Dividenum(@no1 int ,@no2 int)
as
begin
declare @res int
begin try
set @res=@no1/@no2
end try
begin catch
select ERROR_MESSAGE() as [Message],ERROR_NUMBER()as [ErrorNumber]
end catch
return @res
end
declare @res1 int
exec @res1= Dividenum 12,0
print @res1
