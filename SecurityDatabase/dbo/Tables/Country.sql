CREATE TABLE [dbo].[Country] (
    [CountryId] INT           NOT NULL,
    [Name]      NVARCHAR (60) NOT NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([CountryId] ASC)
);

