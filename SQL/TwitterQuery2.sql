use Twitter
go

select * from Userr

update dbo.Userr
	set Descripc = 'La chichona del grupo'
	where IdUser = 3
go

create procedure registroUsuario
(
	@Nombre nvarchar(max),
	@Correo nvarchar(max),
	@Contraseña nvarchar(max),
	@hasError bit out
)
as
begin try
	set @hasError = 0;
	insert into Userr
	values
	(@Nombre, @Correo, @Contraseña)
end try
begin catch
	set @hasError = 1;
end catch
go



create procedure registroChido
(
	@Nombre nvarchar(max),
	@Correo nvarchar(max),
	@Contraseña nvarchar(max),
	@Ciudad nvarchar(max),
	@Fecha datetime,
	@hasError bit out
)
as
begin try
	set @hasError = 0;
	insert into Userr
	values
	(@Nombre, @Correo, @Contraseña, @Ciudad, @Fecha)
end try
begin catch
	set @hasError = 1;
end catch
go

create procedure jalarDatos @usuario nvarchar(max), @hasError bit out
as
begin try
	set @hasError = 0
	select * from Userr where Nombre = @usuario
end try
begin catch
	set @hasError = 1;
end catch
go

create procedure registroFinal
(
	@Nombre nvarchar(max),
	@Correo nvarchar(max),
	@Contraseña nvarchar(max),
	@Ciudad nvarchar(max),
	@Fecha datetime,
	@FechaRegistro datetime,
	@Descripc nvarchar(max),
	@hasError bit out
)
as
begin try
	set @hasError = 0;
	insert into Userr
	values
	(@Nombre, @Correo, @Contraseña, @Ciudad, @Fecha, @FechaRegistro, @Descripc)
end try
begin catch
	set @hasError = 1;
end catch
go

exec dbo.registroUsuario
	@Nombre = 'Ivan Renteria',
	@Correo = 'ivan18ro@gmail.com',
	@Contraseña = 'MLDarker',
	@hasError = '0'

exec dbo.jalarDatos
	@usuario = 'Ivan',
	@hasError = '0'

select * from Userr