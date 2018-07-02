CREATE TABLE [dbo].[bog_zdo]
(
	[bog] char(50) NOT NULL foreign KEY references bogowie(nazwa),
	[zdolnosc] char(50) not null foreign key references zdolnosci(nazwa),
	[dod_inf] ntext,
	primary key(bog, zdolnosc)
)
