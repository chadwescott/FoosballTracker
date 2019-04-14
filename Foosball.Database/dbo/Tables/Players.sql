CREATE TABLE [dbo].[Players] (
    [Id]        UNIQUEIDENTIFIER CONSTRAINT [DF_User_Id] DEFAULT (newsequentialid()) NOT NULL,
    [UserName]  NVARCHAR (50)    NOT NULL,
    [FirstName] NVARCHAR (50)    NOT NULL,
    [LastName]  NVARCHAR (50)    NOT NULL,
    [Rating]    FLOAT (53)       NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Players]
    ON [dbo].[Players]([UserName] ASC);

