--1
create proc GetAllDepartments
as
    select * from Departments;
go
--
exec GetAllDepartments;
go
