USE [ActionLearning]
GO

/****** Object: Table [dbo].[orphanageRegistration1] Script Date: 9/22/2021 5:44:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[orphanageRegistration1] (
    [oId]              INT            IDENTITY (1, 1) NOT NULL,
    [oName]            NVARCHAR (50)  NULL,
    [oRegistrationNum] NVARCHAR (50)  NULL,
    [addressLine1]     NVARCHAR (50)  NULL,
    [addressLine2]     NVARCHAR (50)  NULL,
    [landmark]         NVARCHAR (50)  NULL,
    [city]             NVARCHAR (50)  NULL,
    [state]            NVARCHAR (50)  NULL,
    [country]          NVARCHAR (50)  NULL,
    [pincode]          NCHAR (10)     NULL,
    [phoneNum]         NVARCHAR (50)  NULL,
    [password]         NVARCHAR (MAX) NULL
);


