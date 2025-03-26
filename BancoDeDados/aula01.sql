CREATE TABLE IF NOT EXISTS produtos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    produto VARCHAR(50) NOT NULL,
    valor INT NOT NULL,
    quantidade INT NOT NULL
);

INSERT INTO produtos (produto, valor, quantidade) VALUES
('Shampoo Hidratante', 30, 57),
('Condicionador Nutritivo', 40, 40), 
('Sabonete Líquido', 50, 60), 
('Creme para Mãos', 60, 35), 
('Óleo Corporal', 70, 25), 
('Protetor Solar FPS 50', 30, 29), 
('Base Líquida', 60, 20), 
('Batom Matte', 20, 45), 
('Perfume Floral', 90, 15), 
('Máscara Capilar', 50, 30), 
('Esfoliante Facial', 30, 50), 
('Hidratante Corporal', 50, 40), 
('Delineador Líquido', 80, 88), 
('Sérum Facial', 100, 10), 
('Blush Compacto', 90, 31); 

SELECT 
    *
FROM
    produtos
WHERE
      valor = 30;
      



















