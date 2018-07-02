CREATE TABLE [dbo].[ras_pro]
(
	[nazwa] char(50) not null foreign key references rasy(nazwa),
	[profesja] char(50) not null foreign key references profesje(nazwa),
	primary key(nazwa, profesja)
)
