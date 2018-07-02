CREATE TABLE [dbo].[pos_prz] (
    [id_postaci]    INT       NOT NULL,
    [id_przedmiotu] INT       NOT NULL foreign key references przedmioty(id),
    [jakosc]        CHAR (30) NULL,
    [ilosc]         INT       NULL,
    PRIMARY KEY CLUSTERED ([id_postaci] ASC, [id_przedmiotu] ASC),
    FOREIGN KEY ([id_postaci]) REFERENCES [dbo].[postacie] ([id])
);

