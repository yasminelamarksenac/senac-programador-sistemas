CREATE TABLE  IF NOT EXISTS livro (
 id INT PRIMARY KEY AUTO_INCREMENT,
 titulo VARCHAR(100) NOT NULL,
 data_publicacao DATETIME NOT NULL,
 numero_paginas INT NULL,
 preco decimal(10,2) NULL,
 genero VARCHAR (30) NOT NULL,
 editora VARCHAR (50) NOT NULL,
 isbn VARCHAR (17) NOT NULL UNIQUE,
 autor VARCHAR (100) NOT NULL
 );
 
 INSERT INTO livro (
 titulo, data_publicacao, preco, isbn, genero, editora, autor)
 VALUES (
 'A vida de uma cigana',
 '1985-10-25 07:30;55',
 199.99,
 789-8-17-784512-0,
 'biografia',
 'novomundo',
 'Scarlet Monrye'
 );
 
 INSERT INTO livro (titulo, data_publicacao, numero_paginas, preco, genero, editora, isbn, autor) VALUES
('O Senhor dos Anéis', '1954-07-29', 1178, 89.90, 'Fantasia', 'HarperCollins', '978-0-261-10236-2', 'J.R.R. Tolkien'),
('1984', '1949-06-08', 328, 45.50, 'Ficção Científica', 'Companhia das Letras', '978-85-359-0277-2', 'George Orwell'),
('Dom Casmurro', '1899-01-01', 256, 39.90, 'Romance', 'Editora Globo', '978-85-250-4606-1', 'Machado de Assis'),
('O Código Da Vinci', '2003-03-18', 489, 59.99, 'Suspense', 'Arqueiro', '978-85-8041-080-6', 'Dan Brown'),
('Harry Potter e a Pedra Filosofal', '1997-06-26', 223, 49.90, 'Fantasia', 'Rocco', '978-85-325-1400-0', 'J.K. Rowling');



SELECT * FROM livros WHERE genero = 'terror';