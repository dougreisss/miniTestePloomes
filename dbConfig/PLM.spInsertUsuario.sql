create procedure PLM.spInsertUsuario
@EmailUsuario varchar(255),
@NomeUsuario varchar(255)
as
begin

	insert into PLM.Usuario values (@EmailUsuario, @NomeUsuario)

end