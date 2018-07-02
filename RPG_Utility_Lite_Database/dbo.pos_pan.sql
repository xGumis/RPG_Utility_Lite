CREATE TABLE [dbo].[pos_pan] (
    [id_postaci]   INT       NOT NULL,
    [jakosc]       CHAR (30) not NULL,
    [pancerz]  char(50)       NOT NULL foreign key references pancerze(nazwa),
    [zaekwipowany] BIT       NULL,
    [ilosc]        INT       NULL,
    PRIMARY KEY CLUSTERED ([id_postaci] ASC, [jakosc] ASC, [pancerz] ASC),
    FOREIGN KEY ([id_postaci]) REFERENCES [dbo].[postacie] ([id])
);

