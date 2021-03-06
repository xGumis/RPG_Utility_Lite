﻿CREATE TABLE [dbo].[postacie] (
    [id]                    INT        IDENTITY (1, 1) NOT NULL,
    [czczone_bostwo]        CHAR (50)  NOT NULL foreign key references bogowie(nazwa),
    [rasa]                  CHAR (50)  NOT NULL foreign key references rasy(nazwa),
    [profesja]              CHAR (50)  NOT NULL foreign key references profesje(nazwa),
    [nazwa]                 CHAR (50)  NOT NULL,
    [plec]                  CHAR (4)   DEFAULT ('m') NOT NULL,
    [kolor_oczu]            CHAR (30)  NULL,
    [kolor_wlosow]          CHAR (30)  NULL,
    [wiek]                  INT        NULL,
    [waga]                  FLOAT (53) NULL,
    [wzrost]                FLOAT (53) NULL,
    [znak_gwiezdny]         CHAR (30)  NULL,
    [znaki_szczegolne]      NTEXT      NULL,
    [miejsce_urodzenia]     CHAR (50)  NULL,
    [rodzina]               CHAR (40)  NULL,
    [zaburzenia_psychiczne] NTEXT      NULL,
    [blizny_i_rany]         NTEXT      NULL,
    [historia]              NTEXT      NULL,
    [dod_inf]               NTEXT      NULL,
    [XP]                    INT        NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CHECK ([plec]='brak' OR [plec]='o' OR [plec]='k' OR [plec]='m')
);

