CREATE TABLE [dbo].[pos_bro] (
    [id_postaci]   INT       NOT NULL,
    [jakosc]       CHAR (30) not NULL,
    [bron]			char(50)       NOT NULL foreign key references bronie(nazwa),
    [zaekwipowany] BIT       NULL,
    [ilosc]        INT       NULL,
    PRIMARY KEY CLUSTERED ([id_postaci] ASC, [jakosc] ASC, [bron] ASC),
    FOREIGN KEY ([id_postaci]) REFERENCES [dbo].[postacie] ([id])
);

