-- SCRIPT INSERT VENDA ITEM
USE TecnoShopDB
GO
INSERT INTO venda_item(venda_id, item_id, produto_id, quantidade, preco_listado, desconto) 
   VALUES
        (9,	1,	9, 2512, 62600, 10),
        (10,2,	6, 25434, 141400, 5),
        (1,	3,	1, 8737, 254300, 3),
        (4,	4,	3, 876	, 34500, 22),
        (5,	5,	10,	6876, 36500, 77),
        (6,	6,	2, 6786, 8880,	3),
        (3,	7,	5, 67867, 77700, 5),
        (7,	8,	4, 7678, 66200, 5),
        (8,	9,	7, 6876, 515100, 9),
        (2,	10,	8, 8888, 695200, 7)
GO

