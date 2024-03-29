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
	@Contrase�a nvarchar(max),
	@hasError bit out
)
as
begin try
	set @hasError = 0;
	insert into Userr
	values
	(@Nombre, @Correo, @Contrase�a)
end try
begin catch
	set @hasError = 1;
end catch
go



create procedure registroChido
(
	@Nombre nvarchar(max),
	@Correo nvarchar(max),
	@Contrase�a nvarchar(max),
	@Ciudad nvarchar(max),
	@Fecha datetime,
	@hasError bit out
)
as
begin try
	set @hasError = 0;
	insert into Userr
	values
	(@Nombre, @Correo, @Contrase�a, @Ciudad, @Fecha)
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
	@Contrase�a nvarchar(max),
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
	(@Nombre, @Correo, @Contrase�a, @Ciudad, @Fecha, @FechaRegistro, @Descripc)
end try
begin catch
	set @hasError = 1;
end catch
go

exec dbo.registroUsuario
	@Nombre = 'Ivan Renteria',
	@Correo = 'ivan18ro@gmail.com',
	@Contrase�a = 'MLDarker',
	@hasError = '0'

exec dbo.jalarDatos
	@usuario = 'Ivan',
	@hasError = '0'

select * from Userr
select * from tweet 

create table tweet
(
	idtweet int primary key identity(1,1),
	texto nvarchar(max),
	ubicacion nvarchar(max),
	hora datetime,
	likes int,
	idUsuario int
);
go

insert into tweet (texto, ubicacion, hora, likes, idUsuario)
values ('tercer tweet', 'Ciudad de M�xico', '04-12-2019', 0, '3');

create procedure getTweets @hasError bit out
as
begin try
	set @hasError = 0
	select * from tweet 
end try
begin catch
	set @hasError = 1;
end catch
go

exec dbo.getTweets
	@hasError = '0'