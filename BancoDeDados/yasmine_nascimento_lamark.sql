CREATE TABLE fornecedor (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(255),
    cidade VARCHAR(255)
);

INSERT INTO fornecedor (nome, cidade)
VALUES
('TechBrasil', 'São Paulo'),
('Computech', 'Rio de Janeiro'),
('Moveis&Co', 'Curitiba');

CREATE TABLE produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    preco DECIMAL(10, 2),
    estoque INT,
    fornecedor_id INT,
    FOREIGN KEY (fornecedor_id) REFERENCES fornecedor(id)
);

INSERT INTO produto (nome, categoria, preco, estoque, fornecedor_id)
VALUES
('CELULAR X', 'Eletrônicos', 2500.00, 30, 1),
('NOTEBOOK Y', 'Eletrônicos', 4800.00, 15, 2),
('Mesa de Madeira', 'Móveis', 750.00, 10, 3),
('Cadeira Z', 'Móveis', 300.00, 25, 3),
('TV 50"', 'Eletrônicos', 3500.00, 15, 1);

CREATE TABLE cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    idade INT
);

INSERT INTO cliente (nome, cidade, idade) VALUES
('João Silva', 'São Paulo', 35),
('Maria Santos', 'Belo Horizonte', 28),
('Carlos Lima', 'Rio de Janeiro', 42),
('Fernanda Rocha', 'Curitiba', 30);

CREATE TABLE pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    produto_id INT,
    quantidade INT,
    data_pedido DATE,
    cliente_id INT,
    FOREIGN KEY (produto_id) REFERENCES produto(id),
    FOREIGN KEY (cliente_id) REFERENCES cliente(id)
);

INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id) VALUES
(1, 2, '2024-03-10', 1),
(3, 1, '2024-03-11', 2),
(2, 1, '2024-03-15', 3),
(5, 3, '2024-03-18', 1),
(4, 4, '2024-03-20', 4);

-- 2. Exercícios Avançados
-- Consultas e Filtros (WHERE, ORDER BY, LIKE, BETWEEN)

-- EXERCÍCIO 1: Selecione os produtos da categoria "Eletrônicos" cujo preço seja superior a R$3000, ordenados do mais caro para o mais barato
SELECT 
    nome, preco
FROM
    produto
WHERE
    categoria = 'Eletrônicos'
    AND preco > 3000
ORDER BY preco DESC;

-- EXERCÍCIO 2: Encontre os clientes que não moram em São Paulo e têm idade acima de 30 anos
SELECT 
    nome, cidade, idade
FROM
    cliente
WHERE
    cidade <> 'São Paulo'
    AND idade > 30;

-- EXERCÍCIO 3: Liste os pedidos feitos entre "2024-03-10" e "2024-03-15", ordenados pela data em ordem crescente


SELECT 
    id, produto_id, quantidade, data_pedido, cliente_id
FROM
    pedido
WHERE
    data_pedido BETWEEN '2024-03-10' AND '2024-03-15'
ORDER BY data_pedido ASC;



INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id) VALUES
(1, 2, '2024-03-10', 1),  -- CELULAR X
(3, 1, '2024-03-11', 2),  -- Mesa de Madeira
(2, 1, '2024-03-15', 3),  -- NOTEBOOK Y
(5, 3, '2024-03-18', 1),  -- TV 50"
(4, 4, '2024-03-20', 4);  -- Cadeira Z
