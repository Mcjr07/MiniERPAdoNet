CREATE DATABASE MiniERP


CREATE TABLE clientes
(
    nome varchar(50) not null,
	cpf int not null primary key,
	endereco varchar(200),
    telefone varchar(20),
);

CREATE TABLE fornecedores
(
    nome varchar(50) not null,
	cnpj varchar(20) not null primary key,
    endereco varchar(200),
    telefone varchar(20)
);

drop table fornecedores
drop table produtos

CREATE TABLE produtos
(
	id integer primary key identity,
	tipo varchar(50) not null,
	preco decimal(4, 2) not null,
    quantidadeEstoque int not null,
    tamanho varchar(5),
    cor varchar(20),
	fk_fornecedor varchar(20) not null,
	foreign key (fk_fornecedor) references fornecedores(cnpj)
);


select * from fornecedores