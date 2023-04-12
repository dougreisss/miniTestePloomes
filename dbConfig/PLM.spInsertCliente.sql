create procedure PLM.spInsertCliente
@EmailUsuario varchar(255),
@NomeCliente varchar(255)
as
begin

	insert into PLM.Cliente (EmailUsuario, NomeCliente, DataCriacaoUsuario) values (@EmailUsuario, @NomeCliente, GETDATE())

end