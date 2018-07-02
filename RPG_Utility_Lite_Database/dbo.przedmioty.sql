CREATE TABLE [dbo].[przedmioty]
(
	[id] INT NOT NULL primary key,
	[nazwa] char(100),
	[opis] ntext,
	[dostepnosc] bit,
	[obciazenie] float,
	[cena] int
)
