USE [ActionLearning]
GO

/****** Object: Table [dbo].[TransactionTable] Script Date: 9/22/2021 5:45:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TransactionTable] (
    [tId]    NVARCHAR (50)   NOT NULL,
    [oId]    INT             NOT NULL,
    [Name]   NVARCHAR (50)   NULL,
    [Email]  NVARCHAR (50)   NOT NULL,
    [Amount] DECIMAL (10, 2) NOT NULL,
    [date]   DATETIME2 (7)   NULL,
    [rId]    NVARCHAR (50)   NULL
);


