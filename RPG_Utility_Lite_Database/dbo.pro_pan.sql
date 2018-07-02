CREATE TABLE [dbo].[pro_pan]
(
	[profesja] char(50) NOT NULL foreign KEY references profesje(nazwa),
	[id_pancerza] char(50) not null foreign key references pancerze(nazwa),
	primary key(profesja, id_pancerza)
)
