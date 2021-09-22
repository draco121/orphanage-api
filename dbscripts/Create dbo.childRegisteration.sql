USE [ActionLearning]
GO

/****** Object: Table [dbo].[childRegisteration] Script Date: 9/22/2021 5:43:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[childRegisteration] (
    [CId]          INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (50) NULL,
    [LastName]     NVARCHAR (50) NULL,
    [BirthDate]    DATE          NULL,
    [Gender]       NVARCHAR (10) NULL,
    [oId]          INT           NULL,
    [Nationality]  NVARCHAR (50) NULL,
    [DateAdmitted] DATE          NULL
);


