-- CRIANDO  O BANCO DE DADOS
CREATE DATABASE BDProjeto;

USE BDProjeto;

-- CRIANDO AS TABELAS DO BANCO DE DADOS	
CREATE TABLE tbPedido(
	codPedido int primary key auto_increment,
    tamanhoTenis varchar (50),
    valorTenis varchar (50),
    valorQuantidade varchar (50),
    valorTotal varchar (50)
);
-- CONSULTANDO A TABELA DO BANCO DE DADOS
SELECT * FROM tbPedido;
-- 