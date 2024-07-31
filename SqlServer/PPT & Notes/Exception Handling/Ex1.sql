-- Demo on Exception Handling
create procedure sp_Div(@a int,@b int)
as
begin
declare @res int
begin try
set @res=@a/@b
end try
begin catch
select ERROR_MESSAGE() as ErrorMessage
select ERROR_PROCEDURE() as procedurename
select ERROR_LINE() as LineNumber
end catch
return @res
end
declare @c int
exec @c=sp_Div 6,0
select @c