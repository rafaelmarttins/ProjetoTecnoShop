-- SCRIPT INSERT VENDA
USE TecnoShopDB
GO
INSERT INTO venda(cliente_id, venda_status,data_venda, data_preparo, data_envio, loja_id, funcionario_id) 
   VALUES
    (5,	4,	'21/11/1998',	'21/11/1998',	'13/01/1969',	3,	3),	
    (3,	3,	'21/11/1998',	'21/11/1998',	'13/01/1969',	5,	5),	
    (6,	4,	'21/11/1998',	'21/11/1998',	'13/01/1969',	7,	9),		
    (9,	1,	'21/11/1998',	'21/11/1998',	'13/01/1969',	6,	10),		
    (7,	4,	'21/11/1998',	'21/11/1998',	'13/01/1969',	9,	8),		
    (8,	4,	'21/11/1998',	'21/11/1998',	'13/01/1969',	8,	6),		
    (4,	1,	'21/11/1998',	'21/11/1998',	'13/01/1969',	1,	4),		
    (2,	1,	'21/11/1998',	'21/11/1998',	'13/01/1969',	2,	2),		
    (1,	4,	'21/11/1998',	'21/11/1998',	'13/01/1969',	10,	7),		
    (10,3,	'21/11/1998',	'21/11/1998',	'13/01/1969',	4,	1)								
GO