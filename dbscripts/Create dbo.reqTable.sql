USE [ActionLearning]
GO

/****** Object: Table [dbo].[reqTable] Script Date: 9/22/2021 5:45:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[reqTable] (
    [Id]          NVARCHAR (50)   NOT NULL,
    [amount]      DECIMAL (10, 2) NULL,
    [description] NVARCHAR (MAX)  NOT NULL,
    [status]      NVARCHAR (50)   NOT NULL,
    [date]        DATETIME2 (7)   NOT NULL,
    [oId]         INT             NOT NULL,
    [Deposited]   DECIMAL (10, 2) NULL
);


