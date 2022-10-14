CREATE TABLE [dbo].[fahrten] (
[fahrt_Id] INT NOT NULL,
[fahren] INT NOT NULL,
[zweck] INT NOT NULL,
[fahrzeug] INT NOT NULL,
[fahrzeug_kennzeichen] CHAR (10) NOT NULL,
[fahrt_date] DATETIME NOT NULL,
[fahrt_km_start] FLOAT (53) NOT NULL,
[fahrt_km_ende] FLOAT (53) NULL,
[fahrt_private] BIT NOT NULL,
[ort_von] INT NOT NULL,
[ort_bis] INT NOT NULL,
CONSTRAINT [PK_fahrt] PRIMARY KEY NONCLUSTERED ([fahrt_Id] ASC)
);
CREATE TABLE [dbo].[orte] (
[ort_Id] INT NOT NULL,
[ort_name] NVARCHAR (25) NOT NULL,
CONSTRAINT [PK_ort] PRIMARY KEY NONCLUSTERED ([ort_Id] ASC)
);
CREATE TABLE [dbo].[zwecke] (
[zweck_Id] INT IDENTITY (1, 1) NOT NULL,
[zweck_desc] NVARCHAR (20) NULL,
CONSTRAINT [PK_zweck] PRIMARY KEY NONCLUSTERED ([zweck_Id] ASC)
);
 
CREATE TABLE [dbo].[fahrzeuge] (     [fahrzeug_Id]             INT           NOT NULL IDENTITY,     [fahrzeug_kennzeichen_id] CHAR (10)     NOT NULL,     [fahrzeug_typ]            NVARCHAR (20) NOT NULL,     CONSTRAINT [PK_fahrzeug] PRIMARY KEY CLUSTERED ([fahrzeug_Id] ASC, [fahrzeug_kennzeichen_id] ASC)
);
CREATE TABLE [dbo].[fahrer] (
[fahrer_Id] INT IDENTITY (1, 1) NOT NULL,
[fahrer_name1] NVARCHAR (20) NOT NULL,
[fahrer_name2] NVARCHAR (30) NOT NULL,
CONSTRAINT [PK_fahrer] PRIMARY KEY NONCLUSTERED ([fahrer_Id] ASC)
);