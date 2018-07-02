CREATE TABLE [dbo].[pos_umi] (
    [id_postaci]  INT       NOT NULL,
    [umiejetnosc] CHAR (50) NOT NULL foreign key references umiejetnosci(nazwa),
    [poziom]      INT       NULL,
    [dod_inf]     NTEXT     NULL,
    PRIMARY KEY CLUSTERED ([id_postaci] ASC, [umiejetnosc] ASC),
    FOREIGN KEY ([id_postaci]) REFERENCES [dbo].[postacie] ([id])
);

