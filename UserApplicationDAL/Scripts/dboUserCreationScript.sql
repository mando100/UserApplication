CREATE TABLE [dbo].[User] (
    [UserId]   INT            IDENTITY (1, 1) NOT NULL,
    [UserName] NVARCHAR (MAX) NOT NULL,
    [Name]     NVARCHAR (MAX) NOT NULL,
    [Email]    NVARCHAR (MAX) NOT NULL,
    [Phone]    NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

