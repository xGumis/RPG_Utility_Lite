CREATE TABLE [dbo].[pro_zdo]
(
	[profesja] char(50) NOT NULL foreign KEY references profesje(nazwa),
	[zdolnosc] char(50) not null foreign key references zdolnosci(nazwa),
	[dod_inf] ntext,
	primary key(profesja, zdolnosc)
)
