CREATE TABLE [dbo].[ras_cec]
(
	[rasa] char(50) NOT NULL foreign KEY references rasy(nazwa),
	[cecha] char(50) not null foreign key references cechy(nazwa),
	[wartosc] int,
	primary key(rasa, cecha)
)
