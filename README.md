## Fifth Practical Work of the .Net Programming Course

From the given database, create an application that makes a connection to SQL Server in order to read and persist employee information.

### You must meet the following:

1. Display employee (Empleados) information in the format that the student consider appropriate.

2. Implement the aggregate functionality.

Note: the student is free to choose a console type program or a WinForm program.

Considerations: make the Employee (Empleado) class with the corresponding attributes according to the proposed table.


### DB script (paste in SQL Management and run).
use master

go

Create database EMPLEADOS_DB

GO

Use EMPLEADOS_DB

Go

Create Table Empleados (

Id int IDENTITY(1,1) PRIMARY KEY,

NombreCompleto varchar(100) not null,

DNI varchar(10) not null,

Edad int not null,

Casado bit not null,

Salario decimal(12,2)

);  

GO

Insert into Empleados(NombreCompleto,DNI,Edad,Casado,Salario)

values ('Juan Topo','12345633',55,1,2500.02)

Go

Insert into Empleados(NombreCompleto,DNI,Edad,Casado,Salario)

values ('Mirta Grand','100000',85,1,99989989.12)

Go

Insert into Empleados(NombreCompleto,DNI,Edad,Casado,Salario)

values ('Marcos Pereira','36154214',18,0,10000)

Go

Insert into Empleados(NombreCompleto,DNI,Edad,Casado,Salario)

values ('Josefina Fausto','54653756',45,1,1111152.45)

Go

Insert into Empleados(NombreCompleto,DNI,Edad,Casado,Salario)

values ('Raul Portal','23152478',65,0,1000)

Go

Insert into Empleados(NombreCompleto,DNI,Edad,Casado,Salario)

values ('Lizy Gaga','91235487',35,1,2556600.22)
