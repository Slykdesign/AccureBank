CREATE TABLE [dbo].[TransactionTbl] (
    [TId]     INT          IDENTITY (1, 1) NOT NULL,
    [TName]   VARCHAR (50) NOT NULL,
    [TDate]   DATE         NOT NULL,
    [TAmount] INT          NOT NULL,
    [TAcNum]  INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([TId] ASC)
);
