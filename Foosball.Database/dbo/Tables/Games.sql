CREATE TABLE [dbo].[Games] (
    [Id]           UNIQUEIDENTIFIER CONSTRAINT [DF_Game_Id] DEFAULT (newsequentialid()) NOT NULL,
    [Timestamp]    DATETIME         CONSTRAINT [DF_Game_Timestamp] DEFAULT (getdate()) NOT NULL,
    [WinnerId]     UNIQUEIDENTIFIER NOT NULL,
    [LoserId]      UNIQUEIDENTIFIER NOT NULL,
    [WinnerScore]  INT              NOT NULL,
    [LoserScore]   INT              NOT NULL,
    [WinnerRating] FLOAT (53)       NOT NULL,
    [LoserRating]  FLOAT (53)       NOT NULL,
    [WinnerDelta]  FLOAT (53)       NOT NULL,
    [LoserDelta]   FLOAT (53)       NOT NULL,
    CONSTRAINT [PK_Game] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Games_Losers] FOREIGN KEY ([LoserId]) REFERENCES [dbo].[Players] ([Id]),
    CONSTRAINT [FK_Games_Winners] FOREIGN KEY ([WinnerId]) REFERENCES [dbo].[Players] ([Id])
);

