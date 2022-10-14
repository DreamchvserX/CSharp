USE [C:\LOGBOOK_WPF_APP\LOGBOOKVERSION1.0\LB.DACLAYER\LOGBOOKDB.MDF]
GO

ALTER TABLE dbo.fahrer ADD CONSTRAINT PK_fahrer PRIMARY KEY NONCLUSTERED (fahrer_id);
GO



ALTER TABLE dbo.fahrten ADD CONSTRAINT PK_fahrt PRIMARY KEY NONCLUSTERED (fahrt_id);
GO



ALTER TABLE dbo.fahrzeuge ADD CONSTRAINT PK_fahrzeug PRIMARY KEY CLUSTERED (fahrzeug_id, fahrzeug_kennzeichen_id);
GO



ALTER TABLE dbo.zwecke ADD CONSTRAINT PK_zweck PRIMARY KEY NONCLUSTERED (zweck_id);
GO



ALTER TABLE dbo.orte ADD CONSTRAINT PK_ort PRIMARY KEY NONCLUSTERED (ort_id);
GO


ALTER TABLE dbo.fahrten ADD CONSTRAINT DF_created DEFAULT SYSDATETIME() FOR fahrt_date
GO


ALTER TABLE dbo.fahrten ADD CONSTRAINT DF_private DEFAULT 1 FOR fahrt_private
GO


ALTER TABLE dbo.fahrzeuge ADD CONSTRAINT CK_len_kz CHECK (fahrzeug_kennzeichen_id Like '______%')
GO


ALTER TABLE dbo.fahrten ADD CONSTRAINT FK_zweck FOREIGN KEY (zweck) REFERENCES dbo.zwecke(zweck_id);
GO


ALTER TABLE dbo.fahrten ADD CONSTRAINT FK_fahrzeug FOREIGN KEY (fahrzeug, fahrzeug_kennzeichen) REFERENCES dbo.fahrzeuge(fahrzeug_id, fahrzeug_kennzeichen_id);
GO


ALTER TABLE dbo.fahrten ADD CONSTRAINT FK_fahrer FOREIGN KEY (fahren) REFERENCES dbo.fahrer(fahrer_id);
GO


ALTER TABLE dbo.fahrten ADD CONSTRAINT FK_ort_von FOREIGN KEY (ort_von) REFERENCES dbo.orte(ort_id);
GO


ALTER TABLE dbo.fahrten ADD CONSTRAINT FK_ort_bis FOREIGN KEY (ort_bis) REFERENCES dbo.orte(ort_id);
GO


SELECT f.fahrer_name1, ff.fahrzeug_kennzeichen, z.zweck_desc, ov.ort_name, ob.ort_name
FROM fahrer f 
JOIN fahrten ff ON f.fahrer_Id = ff.fahren 
Inner JOIN zwecke z ON z.zweck_Id = ff.zweck
JOIN orte ov ON ov.ort_Id = ff.ort_von
JOIN orte ob ON ob.ort_Id = ff.ort_bis
WHERE f.fahrer_Id=1;


SELECT o.ort_name, f.fahrt_Id, ff.fahrer_name1
FROM orte o
JOIN fahrten f ON f.ort_bis = o.ort_Id
JOIN fahrer ff ON ff.fahrer_Id = f.fahren
WHERE o.ort_name LIKE 'Tauch%' AND f.fahrt_Id=8;
