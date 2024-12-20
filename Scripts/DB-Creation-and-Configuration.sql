CREATE DATABASE MyFinance;

USE MyFinance;

CREATE TABLE PlanoConta(
    Id INT NOT NULL IDENTITY(1,1),
    Nome VARCHAR(50) NOT NULL,
    Tipo CHAR(1) NOT NULL,
    PRIMARY KEY(Id)
);

CREATE TABLE Transacao(
    Id INT NOT NULL IDENTITY(1,1),
    Data DATETIME NOT NULL,
    Valor DECIMAL(9,2),
    Historico VARCHAR(100),
    Tipo CHAR(1) NOT NULL,
    PlanoContaId INT NOT NULL,
    PRIMARY KEY(Id),
    FOREIGN KEY (PlanoContaId) REFERENCES PlanoConta(Id)
);