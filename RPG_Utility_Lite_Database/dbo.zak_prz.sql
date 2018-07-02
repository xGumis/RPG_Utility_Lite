CREATE TABLE [dbo].[zak_prz]
(
	[zaklecie] char(50) not null foreign key references zaklecia(nazwa),
	[id_przedmiotu] int not null foreign key references przedmioty(id),
	[bonus] ntext,
	primary key(zaklecie, id_przedmiotu)
)
