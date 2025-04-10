CREATE TABLE cliente (
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL, 
nome_social VARCHAR (100) NULL,
data_nascimento DATE NOT NULL,
email VARCHAR(50) NOT NULL UNIQUE,
telefone VARCHAR(11) NOT NULL UNIQUE,
tipo INT NOT NULL,
etnia INT NOT NULL,
genero INT NOT NULL,
estrangeiro BIT NOT NULL,
id_endereco INT NOT NULL,
FOREIGN KEY (id_endereco)
   REFERENCES endereco (id)
);

INSERT INTO cliente
(nome, data_nascimento, email, telefone, tipo, etnia, genero, estrangeiro, id_endereco)
VALUES
('Yasmine Lamark', '1998-11-20', 'yasmine@email.com', '11123456896', 0, 0, 1, 0, (SELECT id FROM endereco WHERE logradouro = 'Endereco da Yasmine'));

INSERT INTO cliente
(nome, data_nascimento, email, telefone, tipo, etnia, genero, estrangeiro, id_endereco)
VALUES
('Maria Cicera', '2002-07-28', 'maria@email.com', '1155551212', 0, 1, 1, 1, (SELECT id FROM endereco WHERE logradouro = 'Endereco da Maria'));
