--2
create proc GetEmployeesByDep
   @depId int
as
   select * from Employees where DepId=@depId;
go
--
exec GetEmployeesByDep 3;
go
