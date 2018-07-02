CREATE TABLE [dbo].[ras_umi]
(
	[rasa] char(50) NOT NULL foreign KEY references rasy(nazwa),
	[umiejetnosc] char(50) not null foreign key references umiejetnosci(nazwa),
	[dod_inf] ntext,
	primary key(rasa, umiejetnosc)
)
