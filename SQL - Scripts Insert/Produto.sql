-- SCRIPT INSERT PRODUTO
USE TecnoShopDB
GO
INSERT INTO produto(produto_nome, marca_id, categoria_id, ano_modelo, preco_listado) 
   VALUES
 ('Headset Gamer Havit', 3, 7, 2022, 626),
 ('Mousepad Gamer Havit', 2, 1,	2022, 1414),
 ('Teclado Mecânico Kumara', 1,	9, 2022, 2543),
 ('GTX 1660 Super Twin Fan Zotac', 9, 3, 2022, 345),
 ('Gamer Corsair T3 Rush',  5, 8, 2022, 365),
 ('Gigabyte AMD Radeon RX 6700 XT Eagle', 7, 6,	2022, 888),
 ('Lenovo Gaming 3i Intel Core i5-11300H', 7,  5, 2022, 777),
 ('SSD 240 GB Kingston A400',8 , 2, 2022, 662),
 ('Cabo Adaptador Conversor Displayport',  4, 4, 2022, 5151),
 ('TV Samsung 65 Polegadas', 10,  10 , 2022, 6952)	
GO
