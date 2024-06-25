CREATE TABLE [dbo].[Claims] (
    [UCR]           VARCHAR (20)    NULL,
    [CompanyId]     INT             NULL,
    [ClaimDate]     DATETIME        NULL,
    [LossDate]      DATETIME        NULL,
    [Assured Name]  VARCHAR (100)   NULL,
    [Incurred Loss] DECIMAL (15, 2) NULL,
    [Closed]        BIT             NULL
);

