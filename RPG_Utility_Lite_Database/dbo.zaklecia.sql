CREATE TABLE [dbo].[zaklecia]
(
	[nazwa] char(50) NOT NULL PRIMARY KEY,
	[wymagana_zdolnosc] char(50) not null,
	[opis] ntext,
	[typ_magii] char(50),
	[wymagany_poziom_magii] int,
	[czas_rzucania] float,
	[czas_trwania] float
)
