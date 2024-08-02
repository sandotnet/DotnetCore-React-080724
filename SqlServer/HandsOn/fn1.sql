create function fn_add(@a int,@b int)
returns int
as
begin
declare @result int
set @result=@a+@b
return @result
end
--invoke function
print dbo.fn_add(34,44)
print dbo.fn_add(31,444)