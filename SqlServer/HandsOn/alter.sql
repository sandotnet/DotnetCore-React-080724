sp_tables 
--add new column
alter table Student add std int 
--drop column
alter table Student drop column tel_no
--chage datatype
alter table Student alter column stud_fname varchar(40)
--add primary key
alter table Student add constraint stud_Id_pk primary key(stud_id)