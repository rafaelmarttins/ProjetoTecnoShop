-- SCRIPT INSERT FUNCIONÁRIO
USE TecnoShopDB
GO
INSERT INTO funcionario(primeiro_nome, sobrenome_nome, email, telefone, loja_id, gerente_id) 
   VALUES
   ('Maren', 'Facello',	'facello.georgi@acme.com', '(53)99620-2626', 10, 1),
   ('Perry', 'Simmel',	'simmel.bezalel@acme.com', '(96)98255-2934', 4, 2),	
   ('Ewing', 'Bamford',	'bamford.parto@acme.com', '(68)99688-0154',	9, 3),
   ('Yucel', 'Koblick',	'koblick.chirstian@acme.com', '(38)98264-6518',	1, 4),
   ('Shahaf','Maliniak', 'maliniak.kyoichi@acme.com', '(49)99832-9692',	6, 5),
   ('Tzvetan','Preusig', 'preusig.anneke@acme.com',	'(82)99705-8384', 5, 6),
   ('Sakthirel', 'Zielinski', 'zielinski.tzvetan@acme.com', '(73)98801-0887', 2, 7),
   ('Marla', 'Kalloufi', 'kalloufi.saniya@acme.com', '(44)99405-3390',	3, 8),
   ('Akemi', 'Peac', 'peac.sumant@acme.com', '(51)99541-9104',	7, 9),
   ('Chenyi', 'Piveteau', 'piveteau.duangkaew@acme.com', '(42)99489-7185',	8, 10)									
GO