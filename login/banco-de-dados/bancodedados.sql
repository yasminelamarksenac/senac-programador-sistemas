create table usuario (
id int primary key AUTO_INCREMENT,
email VARCHAR(50) NOT NULL UNIQUE,
senha VARCHAR(20) NOT NULL
);

INSERT INTO usuario( email, senha) VALUES
('neymar.jr@email.com', 'Brun@123'),
('pablo.vitar@email.com', '12345Abc!'),
('sukuna.silva@email.com', 'Sete7Sete');


SELECT * FROM USUARIO
WHERE email = 'pablo.vitar@email.com';

