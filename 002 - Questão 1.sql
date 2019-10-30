USE [Teste2]
GO

	---questão 1
	declare @auxiliar table (Nome varchar(200), TotalParcelas int , ParcelasPagas int )

	insert into @auxiliar
	Select a.NOME, Count(c.id_parcela) AS TotalParcelas,
		 SUM(case when C.DATA_PAGAMENTO is NOT NULL then 1 else 0 end) ParcelasPagas
	FROM TBL_CLIENTE A
		INNER JOIN Tbl_financiamento B ON A.ID_Cliente = B.ID_cliente 
		INNER JOIN TBL_Parcela C on B.ID_Fianciamento = c.ID_Fianciamento
	WHERE A.UF = 'SP'
	GROUP BY A.NOME

	select * from @auxiliar a
	where ((a.ParcelasPagas * 100) / a.TotalParcelas ) > 60