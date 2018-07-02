CREATE TABLE [dbo].[pro_cec]
(
	[profesja] char(50) NOT NULL foreign KEY references profesje(nazwa),
	[cecha] char(50) not null foreign key references cechy(nazwa),
	[wartosc] int,
	primary key(profesja, cecha)
)
