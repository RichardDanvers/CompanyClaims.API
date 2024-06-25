CREATE TABLE [dbo].[Company] (
    [Id]               INT           NULL,
    [Name]             VARCHAR (200) NULL,
    [Address1]         VARCHAR (100) NULL,
    [Address2]         VARCHAR (100) NULL,
    [Address3]         VARCHAR (100) NULL,
    [Postcode]         VARCHAR (20)  NULL,
    [Country]          VARCHAR (50)  NULL,
    [Active]           BIT           NULL,
    [InsuranceEndDate] DATETIME      NULL
);

