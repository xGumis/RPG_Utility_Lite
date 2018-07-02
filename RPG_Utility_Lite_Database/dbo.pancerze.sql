CREATE TABLE [dbo].[pancerze]
(
	[nazwa] char(50) NOT NULL primary key,
	[opis] ntext,
	[dostepnosc] bit,
	[obciazenie] float,
	[chronione_lokacje] ntext,
	[PZ] float
)
