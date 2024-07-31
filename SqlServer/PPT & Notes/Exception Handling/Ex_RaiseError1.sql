create procedure div(@a int,@b int)
as
begin
declare @c int
set @c=@a/@b
if(@@ERROR<>0)
raiserror('b value should not be zero',14,1)
else
return @c
end

declare @res int
exec @res=div 2,0
print @res