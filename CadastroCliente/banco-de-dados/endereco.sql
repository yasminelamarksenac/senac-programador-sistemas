CREATE TABLE endereco (
     id INT PRIMARY KEY AUTO_INCREMENT,
     logradouro VARCHAR(100) NOT NULL,
     numero VARCHAR(10) NOT NULL,
     complemento VARCHAR(50) NULL,
     bairro VARCHAR(50) NOT NULL,
     municipio VARCHAR(50) NOT NULL,
     estado VARCHAR(2) NOT NULL,
     cep VARCHAR(8) NOT NULL
 );
 
 INSERT INTO endereco
 (logradouro, numero, bairro, municipio, estado, cep, complemento)
 VALUES
 ('Endereco da Yasmine', '7', 'Jardim da natureza', 'São Paulo', 'SP', 'casa', NULL),
 ('Endereco da Maria', '78', 'Vila Leopoldina', 'São Paulo', 'SP', 'apartamento', NULL);
 