CREATE TABLE [dbo].[State] (
    [StateId]   INT           IDENTITY (1, 1) NOT NULL,
    [CountryId] INT           NULL,
    [Code]      NVARCHAR (10) NULL,
    [Name]      NVARCHAR (60) NOT NULL,
    CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED ([StateId] ASC),
    CONSTRAINT [FK_State_Country_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([CountryId])
);

