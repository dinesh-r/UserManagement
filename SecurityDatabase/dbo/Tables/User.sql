CREATE TABLE [dbo].[User] (
    [UserId]               INT                IDENTITY (1, 1) NOT NULL,
    [UserName]             NVARCHAR (256)     NULL,
    [PasswordHash]         NVARCHAR (250)     NULL,
    [LastName]             NVARCHAR (60)      NOT NULL,
    [MiddleName]           NVARCHAR (60)      NULL,
    [FirstName]            NVARCHAR (60)      NOT NULL,
    [DisplayName]          NVARCHAR (80)      NULL,
    [Email]                NVARCHAR (256)     NULL,
    [PhoneNumber]          NVARCHAR (15)      NULL,
    [IsActive]             BIT                NOT NULL,
    [AccessFailedCount]    INT                NOT NULL,
    [LockoutEnabled]       BIT                NOT NULL,
    [LockoutEnd]           DATETIMEOFFSET (7) NULL,
    [IsDeleted]            BIT                NOT NULL DEFAULT 0,
    [CreatedBy]            INT                NOT NULL,
    [CreatedDate]          DATETIME2 (7)      NOT NULL,
    [UpdatedBy]            INT                NULL,
    [UpdatedDate]          DATETIME2 (7)      NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserId] ASC)
);

