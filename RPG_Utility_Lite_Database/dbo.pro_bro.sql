CREATE TABLE [dbo].[pro_bro]
(
	[profesja] char(50) NOT NULL foreign KEY references profesje(nazwa),
	[id_broni] char(50) not null foreign key references bronie(nazwa),
	primary key(profesja, id_broni)
)
