CREATE TABLE [dbo].[bronie]
(
	[nazwa] char(50) NOT NULL primary key,
	[cechy] ntext,
	[opis] ntext,
	[dostepnosc] bit,
	[obciazenie] float,
	[cena] int,
	[zasieg] int,
	[przeladowanie] float,
	[sila] int,
	[kategoria] char(50)
)
