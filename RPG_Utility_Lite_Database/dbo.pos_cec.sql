CREATE TABLE [dbo].[pos_cec] (
    [id_postaci]         INT       NOT NULL,
    [cecha]              CHAR (50) NOT NULL foreign key references cechy(nazwa),
    [wartosc_poczatkowa] INT       NULL,
    [schemat_rozwoju]    NTEXT     NULL,
    [aktualna_wartosc]   INT       NULL,
    PRIMARY KEY CLUSTERED ([id_postaci] ASC, [cecha] ASC),
    FOREIGN KEY ([id_postaci]) REFERENCES [dbo].[postacie] ([id])
);

