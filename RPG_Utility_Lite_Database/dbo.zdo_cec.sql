CREATE TABLE [dbo].[zdo_cec]
(
	[zdolnosc] char(50) NOT NULL foreign KEY references zdolnosci(nazwa),
	[cecha] char(50) not null foreign key references cechy(nazwa),
	[wartosc] int,
	primary key(zdolnosc, cecha)
)
