CREATE TABLE [dbo].[AdminTbl] (
    [AdId]       INT          IDENTITY (1, 1) NOT NULL,
    [AdName]     VARCHAR (50) NOT NULL,
    [AdPassword] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([AdId] ASC)
);
