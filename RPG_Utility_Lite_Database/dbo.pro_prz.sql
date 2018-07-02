CREATE TABLE [dbo].[pro_prz]
(
	[profesja] char(50) NOT NULL foreign KEY references profesje(nazwa),
	[id_przedmiotu] int not null foreign key references przedmioty(id),
	primary key(profesja, id_przedmiotu)
)
