CREATE TABLE [dbo].[pro_umi]
(
	[profesja] char(50) NOT NULL foreign KEY references profesje(nazwa),
	[umiejetnosc] char(50) not null foreign key references umiejetnosci(nazwa),
	[dod_inf] ntext,
	primary key(profesja, umiejetnosc)
)
