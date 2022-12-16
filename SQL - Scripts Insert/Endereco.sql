-- SCRIPT INSERT ENDEREÇO
USE TecnoShopDB
GO
INSERT INTO endereco (rua, numero, complemento, bairro, cep, cidade_id) 
   VALUES
	('Rua Domingos Olímpio1',7759,'Loja 10','São José','68031-379',3),
	('Rua Serra de Bragança',3062,'Andar 4','Santo Antônio','44403-946',5),
	('Rua Paracatu',8163,'Aeroporto 9','São Cristóvão','57183-000',4),
	('Rua Serra de Bragança',1111,'Aeroporto 1', 'Jardim Sumaré', '47499-271',1),
	('Rua das Fiandeiras',4937,'Quadra 3','Bela Vista',	'25813-359',2),
	('Rua Arlindo Nogueira',1080,'Apartamento 5','Guriri Norte','76924-887',10),
	('Avenida Esbertalina Barbosa Damiani',	3912,'Galpão 10','Planalto','72801-581',6),
	('Rua Serra de Bragança',6906,'Loja 8','Industrial','66012-955',9),
	('Avenida Afonso Pena',	1949,'Loja 7','Boa Viagem',	'37868-132',7),
	('Rua dos Carijós',	8759, 'Fundos 7', 'Vila da Saúde', '77641-980',	8)
GO
