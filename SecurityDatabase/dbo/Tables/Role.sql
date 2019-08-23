CREATE TABLE [dbo].[Role] (
    [RoleId]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (60)  NOT NULL,
    [Description] NVARCHAR (250) NULL,
    [IsDeleted]   BIT            NOT NULL DEFAULT 0,
    [CreatedBy]   INT            NOT NULL,
    [CreatedDate] DATETIME2 (7)  NOT NULL,
    [UpdatedBy]   INT            NULL,
    [UpdatedDate] DATETIME2 (7)  NULL,
    CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED ([RoleId] ASC)
);

