
SELECT COUNT(*) FROM usuarios


CREATE DATABASE sql_Server;
go
USE sql_Server;
go

drop table usuarios;


CREATE TABLE usuarios(id uniqueidentifier primary key default NEWID() ,nombre varchar(30) not null,
						apellidoP varchar(30) not null, apellidoM varchar(30) not null, correo varchar(30) not null,
						fecha_nacimeinto date not null, acercaDeMi text not null);


Select * from usuarios;
go
---Datos de prueba

DECLARE @i int = 1

WHILE(@i<=10)
	BEGIN
		
		INSERT INTO usuarios(nombre,apellidoP,apellidoM, correo,fecha_nacimeinto,acercaDeMi) 
		VALUES('Enrique','Sánchez', 'ejeje', 'aldjj@gmail.com','18/09/1999','N/A')
		SET @i = @i+1
	END





CREATE PROC paginacion(@desde int, @hasta int)
as
SELECT t.id,t.fila,t.nombre, t.apellidoP, t.apellidoM, t.correo, t.fecha_nacimeinto, t.acercaDeMi FROM (
SELECT ROW_NUMBER() over(order by id) as 'fila', * FROM USUARIOS) t  WHERE t.fila >=@desde and t.fila <= @hasta
go

DROP PROC paginacion;

EXeCUTE dbo.paginacion 26,30