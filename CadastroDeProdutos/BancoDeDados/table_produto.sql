create table produto (
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
preco DECIMAL(10,2) NOT NULL,
data_produto DATE NOT NULL
);
 
INSERT INTO produto (nome,preco, data_produto) VALUES (@nome,@preco, @data_produto);

