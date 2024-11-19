SELECT * FROM Transacao WHERE Tipo = 'D'

SELECT * FROM Transacao WHERE Tipo = 'R'

SELECT COUNT(*) FROM Transacao WHERE TIPO = 'D'

SELECT COUNT(*) FROM Transacao WHERE TIPO = 'R'

SELECT SUM(Valor) FROM Transacao WHERE TIPO = 'D'

SELECT SUM(Valor) FROM Transacao WHERE TIPO = 'R'

SELECT AVG(Valor) FROM Transacao WHERE TIPO = 'D'

SELECT AVG(Valor) FROM Transacao WHERE TIPO = 'R'

SELECT * FROM Transacao WHERE Data >= '20240101 00:00:00' AND Data <= '20241031 23:59:59'