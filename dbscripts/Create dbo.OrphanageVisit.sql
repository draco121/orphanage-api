USE [ActionLearning]
GO

/****** Object: Table [dbo].[OrphanageVisit] Script Date: 9/22/2021 5:44:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrphanageVisit] (
    [aId]            UNIQUEIDENTIFIER NOT NULL,
    [aName]          NVARCHAR (50)    NOT NULL,
    [aAddress]       NVARCHAR (50)    NOT NULL,
    [aContactNumber] NVARCHAR (50)    NOT NULL,
    [aCurrenntDate]  DATETIME2 (7)    NOT NULL,
    [aScheduleDate]  DATETIME2 (7)    NOT NULL,
    [aScheduleTime]  DATETIME2 (7)    NOT NULL,
    [oId]            INT              NOT NULL
);


