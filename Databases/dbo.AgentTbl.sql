CREATE TABLE [dbo].[AgentTbl] (
    [AId]       INT          IDENTITY (1, 1) NOT NULL,
    [AName]     VARCHAR (50) NOT NULL,
    [APhone]    VARCHAR (50) NOT NULL,
    [APassword] VARCHAR (50) NOT NULL,
    [AAddress]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([AId] ASC)
);
