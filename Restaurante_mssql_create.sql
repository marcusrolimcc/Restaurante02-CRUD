create database restaurante02
use restaurante02

create table Cliente(
	id int not null primary key identity(1,1),
	nome varchar(50) not null,
	email varchar(50) not null,
	telefone varchar(50) not null
)

create table Restaurante(
	id int not null primary key identity(1,1),
	nome varchar(50) not null,
)

create table Ingrediente(
	id int not null primary key identity(1,1),
	descricao varchar(50) not null,
	validade date not null, 
	quantidade int not null
)

create table Prato(
	id int not null primary key identity(1,1),
	descricao varchar(50) not null
)

create table Item_Prato(
	id int not null primary key identity(1,1),
	id_prato int not null references Prato(id),
	id_ingrediente int not null references Ingrediente(id)
)

create table Funcionario(
	id int not null primary key identity(1,1),
	nome varchar(50) not null,
	email varchar(100) not null,
	cpf varchar(20) not null,
	salario numeric(9,2) not null,
	id_restaurante int not null references Restaurante(id)
)

create table Venda(
	id int not null primary key identity(1,1),
	id_funcionario int not null references Funcionario(id),
	id_cliente int not null references Cliente(id)
)

create table Item_Venda(
	id int not null primary key identity(1,1),
	id_prato int not null references Prato(id),
	id_venda int not null references Venda(id)
)

select * from Ingrediente

alter table Ingrediente alter column validade datetime not null