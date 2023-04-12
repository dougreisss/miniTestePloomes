create procedure PLM.spGetUsuarios
as
begin

	select EmailUsuario, NomeUsuario from PLM.Usuario with (nolock)

end