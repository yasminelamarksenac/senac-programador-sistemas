CREATE TABLE estoque (
id INT PRIMARY KEY AUTO_INCREMENT,
quantidade INT NOT NULL,
id_produto INT NOT NULL,
data_estoque DATE NOT NULL,
FOREIGN KEY (id_produto)
        REFERENCES produto (id)
);
 
INSERT INTO estoque (quantidade, id_produto, data_estoque)
VALUES (@quantidade, @id_produto, @data_estoque);

SELECT * FROM estoque
