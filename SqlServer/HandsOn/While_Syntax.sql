declare @id int
set @id=1
declare @n varchar(20)='Virat'
while(@id<100)
begin
print @id
print 'Hello '+@n
set @id=@id+1
end