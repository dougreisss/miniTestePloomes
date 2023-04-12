create procedure PLM.spGetClientes
as
begin

	select IdCliente, EmailUsuario, NomeCliente, DataCriacaoUsuario from PLM.Cliente with (nolock)

end