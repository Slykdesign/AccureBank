CREATE TABLE [dbo].[TransferTbl] (
    [TrId]          INT  IDENTITY (1, 1) NOT NULL,
    [TrSource]      INT  NOT NULL,
    [TrDestination] INT  NOT NULL,
    [TrAmount]      INT  NOT NULL,
    [TrDate]        DATE NULL,
    PRIMARY KEY CLUSTERED ([TrId] ASC)
);
