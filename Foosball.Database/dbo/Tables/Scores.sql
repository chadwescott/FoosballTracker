CREATE TABLE [dbo].[Scores] (
    [Id]        UNIQUEIDENTIFIER CONSTRAINT [DF_Score_Id] DEFAULT (newsequentialid()) NOT NULL,
    [GameId]    UNIQUEIDENTIFIER NOT NULL,
    [Timestamp] DATETIME         CONSTRAINT [DF_Score_Timestamp] DEFAULT (getdate()) NOT NULL,
    [Scorer]    UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Score] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Score_Game] FOREIGN KEY ([GameId]) REFERENCES [dbo].[Games] ([Id]),
    CONSTRAINT [FK_Score_Player] FOREIGN KEY ([Scorer]) REFERENCES [dbo].[Players] ([Id])
);

