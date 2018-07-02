CREATE TABLE [dbo].[pro_pro]
(
	[profesja] char(50) not null foreign key references profesje(nazwa),
	[profesja_wyjsciowa] char(50) not null foreign key references profesje(nazwa)
	primary key (profesja, profesja_wyjsciowa)
)
