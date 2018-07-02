CREATE TABLE [dbo].[ras_zdo]
(
	[rasa] char(50) NOT NULL foreign KEY references rasy(nazwa),
	[zdolnosc] char(50) not null foreign key references zdolnosci(nazwa),
	[dod_inf] ntext,
	primary key(rasa, zdolnosc)
)
