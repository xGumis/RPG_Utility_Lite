CREATE TABLE [dbo].[pos_zdo] (
    [id_postaci] INT       NOT NULL,
    [zdolnosc]   CHAR (50) NOT NULL foreign key references zdolnosci(nazwa),
    [dod_info]   NTEXT     NULL,
    PRIMARY KEY CLUSTERED ([id_postaci] ASC, [zdolnosc] ASC),
    FOREIGN KEY ([id_postaci]) REFERENCES [dbo].[postacie] ([id])
);

