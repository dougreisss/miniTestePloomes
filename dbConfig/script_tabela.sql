create table PLM.Usuario
(
	EmailUsuario varchar(255) not null,
	NomeUsuario varchar(255),
	constraint pk_Usuario_Email primary key (EmailUsuario)
)

create table PLM.Cliente
(
	IdCliente int not null identity (1, 1),
	EmailUsuario varchar(255) not null,
	NomeCliente varchar(255),
	DataCriacaoUsuario datetime,
	constraint pk_Cliente primary key (IdCliente, EmailUsuario),
	constraint fk_Cliente_Usuario foreign key (EmailUsuario) 
	references PLM.Usuario (EmailUsuario)
)