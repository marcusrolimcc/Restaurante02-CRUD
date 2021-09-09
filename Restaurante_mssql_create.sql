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

alter table Ingrediente alter column validade datetime not null

update Funcionario set nome = 'Joao da Silva', cpf = '25147896321'

insert into Funcionario(nome, email, cpf, salario, id_restaurante) values ('Joao da Silva', 'joao@gmail.com', '25147896321', 900, 2)
insert into Funcionario(nome, email, cpf, salario, id_restaurante) values ('Paula Rocha', 'paula@gmail.com', '25415456321', 1100, 2)
insert into Funcionario(nome, email, cpf, salario, id_restaurante) values ('Fernando Oliveira', 'feroli@gmail.com', '85412532214', 1200, 2)
insert into Funcionario(nome, email, cpf, salario, id_restaurante) values ('Leonardo Figueiredo', 'leonardo@gmail.com', '98541235412', 980, 2)
insert into Funcionario(nome, email, cpf, salario, id_restaurante) values ('Beatriz Siqueira', 'bea@gmail.com', '12547896523', 1450.20, 2)
insert into Funcionario(nome, email, cpf, salario, id_restaurante) values ('Luciana Rodrigues', 'lucirodrigues@gmail.com', '45215421254', 1325.80, 2)
insert into Funcionario(nome, email, cpf, salario, id_restaurante) values ('Daniela Benitez', 'danib@gmail.com', '54123658412', 1150, 2)
insert into Funcionario(nome, email, cpf, salario, id_restaurante) values ('Maria Izabela', 'maria@gmail.com', '12452365874', 1752.90, 2)
insert into Funcionario(nome, email, cpf, salario, id_restaurante) values ('Marcos Vinicius', 'mvinicius@gmail.com', '25412452154', 2500, 2)
insert into Funcionario(nome, email, cpf, salario, id_restaurante) values ('Lucas da Rosa', 'lucas@gmail.com', '00021547896', 3000, 2)

insert into Cliente(nome, email, telefone) values ('Marcus Rolim','marcus@gmail.com', '67984731178')
insert into Cliente(nome, email, telefone) values ('Misael Lima','misael@gmail.com', '67889541212')

insert into Venda(id_funcionario, id_cliente) values ('9', '1')
insert into Venda(id_funcionario, id_cliente) values ('8', '2')

insert into Prato(descricao) values ('Risoto de presunto')
insert into Prato(descricao) values ('Espeto de carne')
insert into Prato(descricao) values ('Espaguete')

insert into Item_Venda(id_prato, id_venda) values (1,1) 
insert into Item_Venda(id_prato, id_venda) values (3,2)

insert into Ingrediente(descricao, validade, quantidade) values ('Presunto', '20/08/2021', 5)
insert into Ingrediente(descricao, validade, quantidade) values ('Arroz', '25/08/2021', 10)
insert into Ingrediente(descricao, validade, quantidade) values ('Macarrao', '20/12/2021', 15)
insert into Ingrediente(descricao, validade, quantidade) values ('Pomarola', '25/12/2021', 25)

insert into Item_Prato(id_prato, id_ingrediente) values (1,7)
insert into Item_Prato(id_prato, id_ingrediente) values (1,14)
insert into Item_Prato(id_prato, id_ingrediente) values (3,15)
insert into Item_Prato(id_prato, id_ingrediente) values (1,16)

select * from Restaurante
select * from Funcionario
select * from Cliente
select * from Venda
select * from Prato
select * from Ingrediente
select * from Item_Venda
select * from Item_Prato

