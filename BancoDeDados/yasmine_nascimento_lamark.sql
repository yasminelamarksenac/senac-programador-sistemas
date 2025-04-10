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
(6, 2, '2024-03-10', 1),  -- CELULAR X
(8, 1, '2024-03-11', 2),  -- Mesa de Madeira
(7, 1, '2024-03-15', 3),  -- NOTEBOOK Y
(10, 3, '2024-03-18', 1),  -- TV 50"
(9, 4, '2024-03-20', 4);  -- Cadeira Z

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





-- EXERCÍCIO 4: Recupere os produtos cujo estoque é menor que 10 unidades e exiba em ordem crescente de estoque

SELECT 
    id, nome, categoria, preco, estoque, fornecedor_id
FROM
    produto
WHERE
    estoque < 10
ORDER BY
    estoque ASC;
    
-- EXERCICIO 5: Liste os fornecedores que não estão no Rio de Janeiro e cujo nome começa com "T"
 
SELECT 
    *
FROM
    fornecedor
WHERE
    cidade = 'Rio de Janeiro'
        AND nome LIKE 'T%';

--  Agregação e Agrupamento (COUNT, SUM, AVG, GROUP BY)
 
-- EXERCÍCIO 1:Calcule o preço médio dos produtos para cada categoria.
 
SELECT 
    categoria, AVG(preco) AS preco_medio
FROM
    produto
GROUP BY categoria;
 
-- EXERCICIO 2:  Conte quantos pedidos cada cliente realizou.
 
SELECT 
    cliente_id, COUNT(*) AS total_pedidos
FROM
    pedido
GROUP BY cliente_id;
 
-- EXERCÍCIO 3:  Liste o total de produtos em estoque por categoria.
 
SELECT categoria, SUM(estoque) AS total_estoque
FROM produto
GROUP BY categoria;
 
 
-- EXERCÍCIO 4: Encontre o pedido com a maior quantidade de produtos comprados e exiba o pedido, produto_id e quantidade.
 
SELECT 
    id, produto_id, quantidade
FROM
    pedido
WHERE 
    quantidade = (SELECT MAX(quantidade) FROM pedido);
 
-- EXERCÍCIO 5: Descubra quantos clientes há em cada cidade, ordenando os resultados da cidade com mais clientes para a cidade com menos clientes.
 
SELECT 
    cidade, COUNT(*) AS total_clientes
FROM
    cliente
GROUP BY cidade
ORDER BY total_clientes DESC;
 
-- Junções (INNER JOIN)
 
-- EXERCÍCIO 1: Liste todos os produtos junto com o nome do fornecedor correspondente, ordenados pelo nome do fornecedor.
 
SELECT 
    p.nome AS produto, f.nome AS fornecedor
FROM
    produto p
        INNER JOIN
    fornecedor f ON p.fornecedor_id = f.id
ORDER BY f.nome;
 
 
-- EXERCÍCIO 2: Mostre os pedidos junto com o nome do cliente e o nome do produto comprado, ordenando pela data do pedido.
 
SELECT 
    c.nome AS cliente, pr.nome AS produto, pe.data_pedido
FROM
    pedido pe
        INNER JOIN
    cliente c ON pe.cliente_id = c.id
        INNER JOIN
    produto pr ON pe.produto_id = pr.id
ORDER BY pe.data_pedido;
 
-- EXERCÍCIO 3: Liste todos os pedidos e exiba o nome do cliente, o nome do produto e o nome do fornecedor do produto.
 
SELECT 
    c.nome AS cliente, pr.nome AS produto, f.nome AS fornecedor
FROM
    pedido pe
        INNER JOIN
    cliente c ON pe.cliente_id = c.id
        INNER JOIN
    produto pr ON pe.produto_id = pr.id
        INNER JOIN
    fornecedor f ON pr.fornecedor_id = f.id;
    
-- EXERCÍCIO 4: Mostre a quantidade total de produtos comprados por cada cliente, listando o nome do cliente e a soma total de produtos adquiridos.
 
SELECT 
    c.nome AS cliente, SUM(pe.quantidade) AS total_comprado
FROM
    pedido pe
        INNER JOIN
    cliente c ON pe.cliente_id = c.id
GROUP BY c.nome;
 
 
-- Subconsultas e Modificação de Dados (Subquery, UPDATE, DELETE, INSERT INTO)
 
-- EXERCÍCIO 1: Encontre os produtos cujo preço é superior à média de todos os produtos da mesma categoria.
 
 
SELECT 
    *
FROM
    produto p
WHERE
    preco > (SELECT 
            AVG(preco)
        FROM
            produto
        WHERE
            categoria = p.categoria);
            
-- EXERCÍCIO 2: Aumente o preço dos produtos da categoria "Eletrônicos" em 10%.
 
UPDATE produto 
SET 
    preco = preco * 1.10
WHERE
    categoria = 'Eletrônicos';
 
-- EXERCÍCIO 3: Remova os pedidos de clientes que moram em Curitiba.
 
DELETE FROM pedido 
WHERE
    cliente_id IN (SELECT 
        id
    FROM
        cliente
    WHERE
        cidade = 'Curitiba');
 
-- EXERCÍCIO 4:  Insira um novo cliente chamado "Ricardo Lopes", que mora em Porto Alegre e tem 38 anos.
 
 
INSERT INTO cliente (id, nome, cidade, idade)
VALUES (5, 'Ricardo Lopes', 'Porto Alegre', 38);
 
 
-- EXERCÍCIO 5: Insira um novo pedido para o cliente "João Silva", comprando 2 unidades de "Notebook Y" no dia "2024-03-25".
 
 
INSERT INTO pedido (id, produto_id, quantidade, data_pedido, cliente_id)
VALUES (6, 2, 2, '2024-03-25', 1);
 
-- EXERCÍCIO 6: Crie uma consulta que exiba o nome dos clientes que já compraram produtos da categoria "Móveis".
 
SELECT DISTINCT
    c.nome AS nome_cliente
FROM
    cliente c
        INNER JOIN
    pedido p ON c.id = p.cliente_id
        INNER JOIN
    produto pr ON p.produto_id = pr.id
WHERE
    pr.categoria = 'Móveis';

