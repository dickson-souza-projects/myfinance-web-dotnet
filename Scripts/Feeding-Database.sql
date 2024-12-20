SELECT * FROM PlanoConta
SELECT * FROM Transacao

INSERT INTO [dbo].[PlanoConta]([Nome],[Tipo]) VALUES('Combustível','D')
INSERT INTO [dbo].[PlanoConta]([Nome],[Tipo]) VALUES('Alimentação','D')
INSERT INTO [dbo].[PlanoConta]([Nome],[Tipo]) VALUES('Aluguel','D')
INSERT INTO [dbo].[PlanoConta]([Nome],[Tipo]) VALUES('Água','D')
INSERT INTO [dbo].[PlanoConta]([Nome],[Tipo]) VALUES('Luz','D')
INSERT INTO [dbo].[PlanoConta]([Nome],[Tipo]) VALUES('Internet','D')
INSERT INTO [dbo].[PlanoConta]([Nome],[Tipo]) VALUES('Salário','R')
INSERT INTO [dbo].[PlanoConta]([Nome],[Tipo]) VALUES('Crédito de Dividendos','R')

INSERT INTO [dbo].[Transacao] ([Data],[Valor],[Historico],[Tipo],[PlanoContaId]) 
    VALUES(GETDATE(),458,'Gasolina da Blazer','D',1)

INSERT INTO [dbo].[Transacao] ([Data],[Valor],[Historico],[Tipo],[PlanoContaId]) 
    VALUES('2024-11-03 13:05',120.58,'Almoço de Domingo','D',2)

INSERT INTO [dbo].[Transacao] ([Data],[Valor],[Historico],[Tipo],[PlanoContaId]) 
    VALUES('2024-10-01',25,'Padaria','D',2)

INSERT INTO [dbo].[Transacao] ([Data],[Valor],[Tipo],[PlanoContaId]) 
    VALUES('2024-11-05',1000,'R',7)

INSERT INTO [dbo].[Transacao] ([Data],[Valor],[Tipo],[PlanoContaId]) 
    VALUES('2024-10-31',868.32,'R',8)
