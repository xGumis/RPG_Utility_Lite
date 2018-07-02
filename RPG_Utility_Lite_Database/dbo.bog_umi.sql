CREATE TABLE [dbo].[bog_umi]
(
	[bog] char(50) NOT NULL foreign KEY references bogowie(nazwa),
	[umiejetnosc] char(50) not null foreign key references umiejetnosci(nazwa),
	[dod_inf] ntext,
	primary key(bog, umiejetnosc)
)
