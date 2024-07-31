declare @id int=2;
select case @id
when 1 then 'First Message'
when 2 then 'Second Message'
when 3 then 'Third Message'
else 'other message'
end as message