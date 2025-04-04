CREATE TABLE IF NOT EXISTS livro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    data_publicacao DATETIME NOT NULL,
    numero_paginas INT NULL,
    preco DECIMAL(10 , 2 ) NULL,
    isbn VARCHAR(17) NOT NULL UNIQUE,
    id_genero INT NOT NULL,
    id_editora INT NOT NULL,
    id_autor INT NOT NULL,
    FOREIGN KEY (id_genero)
        REFERENCES genero (id),
    FOREIGN KEY (id_editora)
        REFERENCES editora (id),
    FOREIGN KEY (id_autor)
        REFERENCES autor (id)
);
INSERT INTO livro (
 titulo, data_publicacao, preco, numero_paginas, isbn, id_genero, id_editora, id_autor
) VALUES 
(
'titulo do meu livro',
'1991-08-31 22:38:48',
129.99,
NULL,
'978-3-16-148410-0',
1,
1,
1
),
(
'titulo do meu livro 2',
'1994-08-31',
87.99,
NULL,
'978-3-16-148410-1',
1,
1,
1
),
(
'titulo do meu livro 3',
'1998-08-31',
209,
93.99,
'978-3-16-148410-2',
1,
1,
1
),
(
'A Sutil Arte de Ligar o Foda-se',
'2017-11-06',
45.00,
224,
'‎855-1-004336-0',
2,
1,
2
),
(
'A lenda do macaco de quinze centímetros e meio',
'1957-11-09 00:00:00',
120.99,
969,
'978-0-06-112008-4',
3,
2,
3
),
(
'16 toneladas: Adaptação novel',
'1989-11-09 00:00:00',
190.99,
1000,
'978-1-4028-9462-6',
4,
3,
4
),
(
'My book',
'2024-06-07 19:30:04',
140.99,
NULL,
'04-16-500045-4',
4,
1,
5
),
(
'Jornalist',
'2015-06-25',
29.00,
105,
'125165651652',
5,
4,
6
),
(
'o diario da perda',
'2024-08-10',
99.99,
NULL,
'856-4-26-457862-2',
4,
1,
7
),
(
'vida de cao - a historia de 3 cachorros',
'2025-01-23',
45.99,
NULL,
'764-1-83-514681-6',
6,
1,
7
),
(
'Harry Potter e a Pedra Filosofal',
'1997-06-26',
40.00,
264,
'978-0-43-955493-0',
7,
5,
8
),
(
'Percy Jackson e os Olimpianos', 
'2005-07-01 12:05:45',
299.50,
245,
'456-4-82-124856-3',
7,
6,
9
),
(
'Homem de Ferro',
'1978-05-30 18:02:25',
125.90,
NULL,
'978-3-16-148491',
8,
7,
10
),
(
'criador de progama',
'2005-12-25 08:03:06',
000.00,
NULL,
'666-666',
1,
1,
11
),
(
'As aventuras de π',
'1999-04-25',
500.99,
1100,
4,
1,
1,
12
),
(
'O Senhor dos Anéis',
'1954-07-29',
89.90,
1178,
'978-0-261-10236-2',
7,
8,
13
),
(
'1984',
'1949-06-08',
45.50,
328,
'978-85-359-0277-2',
9,
9,
14
),
(
'Fogo na Caixa Dagua Edição de Colecionador',
'2025-03-26 19:28:55',
420.69,
24,
'666-9-24-420069-0',
3,
1,
15
),
(
'Titulo 64DD',
'1999-11-13',
129.99,
NULL,
'666-9-16-420069-0',
9,
10,
16
),
(
'Fahrenheit 451',
'2020-10-19',
69.90,
272,
'978-6558300151',
10,
11,
17
);