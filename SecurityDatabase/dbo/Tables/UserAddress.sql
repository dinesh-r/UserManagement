CREATE TABLE [dbo].[UserAddress] (
    [UserAddressId] INT            IDENTITY (1, 1) NOT NULL,
    [Address1]      NVARCHAR (250) NULL,
    [Address2]      NVARCHAR (250) NULL,
    [Phone]         NVARCHAR (20)  NULL,
    [Fax]           NVARCHAR (20)  NULL,
    [City]          NVARCHAR (60)  NULL,
    [CountryId]     INT            NULL,
    [Zip]           NVARCHAR (10)  NULL,
    [StateId]       INT            NULL,
    [IsDeleted]     BIT            NOT NULL,
    [CreatedBy]     INT            NOT NULL,
    [CreatedDate]   DATETIME2 (7)  NOT NULL,
    [UpdatedBy]     INT            NULL,
    [UpdatedDate]   DATETIME2 (7)  NULL,
    CONSTRAINT [PK_UserAddress] PRIMARY KEY CLUSTERED ([UserAddressId] ASC),
    CONSTRAINT [FK_UserAddress_Country_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([CountryId]),
    CONSTRAINT [FK_UserAddress_State_StateId] FOREIGN KEY ([StateId]) REFERENCES [dbo].[State] ([StateId])
);

