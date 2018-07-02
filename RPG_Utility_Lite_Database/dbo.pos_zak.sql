CREATE TABLE [dbo].[pos_zak] (
    [zaklecie]   CHAR (50) NOT NULL foreign key references zaklecia(nazwa),
    [id_postaci] INT       NOT NULL,
    PRIMARY KEY CLUSTERED ([zaklecie] ASC, [id_postaci] ASC),
    FOREIGN KEY ([id_postaci]) REFERENCES [dbo].[postacie] ([id])
);

