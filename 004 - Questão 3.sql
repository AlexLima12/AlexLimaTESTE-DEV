USE [Teste2]
GO

--questão 3
	Select a.NOME 
	FROM TBL_CLIENTE A
		INNER JOIN Tbl_financiamento B ON A.ID_Cliente = B.ID_cliente 
		INNER JOIN TBL_Parcela C on B.ID_Fianciamento = c.ID_Fianciamento
	WHERE B.Valor_Total > 10000 and
		DATEDIFF(DAY, C.VENCIMENTO, C.DATA_PAGAMENTO) > 10
	GROUP BY A.NOME
	HAVING COUNT(A.NOME) > 1