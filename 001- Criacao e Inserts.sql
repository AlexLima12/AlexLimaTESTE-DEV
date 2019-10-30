CREATE DATABASE [Teste2] 
GO

USE [Teste2]
GO


CREATE TABLE Tbl_Cliente (ID_Cliente int identity primary key,
						  Nome varchar(200),
						  UF varchar(2),
						  Celular varchar(20))

						
CREATE TABLE Tbl_financiamento (ID_Fianciamento int identity primary key, ID_Cliente int, 
								Tipo_Financiamento varchar(100), 
								Valor_Total decimal, 
								Data_Vencimento DateTime,
								constraint ID_Cliente_Finaciamento foreign key (ID_Cliente) references Tbl_Cliente(ID_Cliente))



CREATE TABLE Tbl_Parcela (ID_Parcela int identity primary key,
							ID_Fianciamento int,
							NumeroParcela int, Valor_Parcela decimal, Vencimento DateTime, Data_Pagamento DateTime,
								constraint ID_Fianciamento_Parcela foreign key (ID_Fianciamento) references Tbl_financiamento(ID_Fianciamento))


	insert into tbl_cliente
	select			'Alfredo Silva',	'SP',	'11989541254'
	union select	'Bruna Eduarda',	'SP',	'1192224254'
	union select	'Debora Castro',	'RJ',	'21989965214'
	union select	'Pedro Lima',		'PB',	'83987441154'
	union select	'Josefa Sabino',	'SP',	'11989321454'
	union select	'Guilherme Santos',	'MG',	'35974136554'


	insert into  Tbl_financiamento 
	select      '1','Credito Direto',			'8500',		'2020-12-25 00:00:00.000'
	union select'2','Credito Consignado',		'95000',	'2021-12-25 00:00:00.000'
	union select'3','Credito Pessoa Jurídica','150000',	'2025-12-25 00:00:00.000'
	union select'4','Credito Pessoa Física',	'13000',	'2022-12-25 00:00:00.000'
	union select'5','Credito Imobiliário',	'1800000',	'2040-12-25 00:00:00.000'
	union select'6','Credito Imobiliário',	'2300000',	'2052-12-25 00:00:00.000'

	insert into Tbl_Parcela
	select			'1',	'1', '500',		'2019-01-25 00:00:00.000',	'2019-01-24 00:00:00.000'
	union select	'1',	'2'	,'500',		'2019-02-25 00:00:00.000',	'2019-02-24 00:00:00.000'
	union select	'1',	'3'	,'500',		'2019-02-25 00:00:00.000',	'2019-02-24 00:00:00.000'
	union select	'2',	'1'	,'874',		'2018-02-25 00:00:00.000',	'2018-02-24 00:00:00.000'
	union select	'2',	'2'	,'874',		'2018-03-25 00:00:00.000',	'2018-03-24 00:00:00.000'
	union select	'2',	'3'	,'874',		'2018-04-25 00:00:00.000',	'2018-04-24 00:00:00.000'
	union select	'3',	'2'	,'1050',	'2018-03-25 00:00:00.000',	'2018-04-24 00:00:00.000'
	union select	'3',	'3'	,'1050',	'2018-04-25 00:00:00.000',	'2018-04-30 00:00:00.000'
	union select	'3',	'4', '1050',	'2018-05-25 00:00:00.000',	'2018-05-30 00:00:00.000'
	union select	'1',	'4', '500',		'2019-03-25 00:00:00.000',	NULL
	union select	'5',	'1', '795',		'2017-01-25 00:00:00.000', '2017-01-24 00:00:00.000'
	union select    '5',	'2', '795',		'2017-02-25 00:00:00.000', '2017-02-24 00:00:00.000'
	union select    '5',	'3', '795',		'2017-03-25 00:00:00.000', NULL
	union select    '5',	'4', '795',		'2017-04-25 00:00:00.000', NULL
	union select    '5',	'4', '795',		'2017-05-25 00:00:00.000', '2017-06-25 00:00:00.000'
	union select    '5',	'4', '795',		'2017-06-25 00:00:00.000', '2017-07-08 00:00:00.000'
	union select    '5',	'4', '795',		'2017-07-25 00:00:00.000', '2017-08-08 00:00:00.000'
	union select    '5',	'4', '795',		'2017-08-25 00:00:00.000', '2017-09-08 00:00:00.000'
	UNION select	'3',	'5', '1050',	'2018-06-25 00:00:00.000',	'2018-07-07 00:00:00.000'
	UNION select  	'3',	'6', '1050',	'2018-07-25 00:00:00.000',	'2018-08-15 00:00:00.000'
	UNION select  	'3',	'7', '1050',	'2018-08-25 00:00:00.000',	'2018-09-15 00:00:00.000'
	UNION select  	'3',	'8', '1050',	'2018-09-25 00:00:00.000',	'2018-10-15 00:00:00.000'



	 