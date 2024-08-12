-- Demo on Exception Handling
create procedure sp_Div(@a int,@b int)
as
begin
declare @res int
begin try
set @res=@a/@b
end try
begin catch
select ERROR_MESSAGE() as ErrorMessage,
 ERROR_PROCEDURE() as procedurename,
 ERROR_LINE() as LineNumber,
 ERROR_state() as procedurename,
 ERROR_SEVERITY()as Severity
end catch
return @res
end
declare @c int
exec @c=sp_Div 6,0
select @c