CREATE TABLE [dbo].[AccountTbl] (
    [AcNum]        INT           IDENTITY (1, 1) NOT NULL,
    [AcName]       VARCHAR (50)  NOT NULL,
    [AcPhone]      VARCHAR (100) NOT NULL,
    [AcAddress]    VARCHAR (100) NOT NULL,
    [AcGender]     VARCHAR (10)  NOT NULL,
    [AcOccupation] VARCHAR (100) NOT NULL,
    [AcEducation]  VARCHAR (50)  NOT NULL,
    [AcIncome]     VARCHAR (50)  NOT NULL,
    [AcBalance]    INT           NOT NULL,
    [AcDCardNum] INT NULL, 
    PRIMARY KEY CLUSTERED ([AcNum] ASC)
);
