CREATE VIEW [dbo].[ServicesProposes]
	AS select s.Id as ServiceId,
	 s.CategorieId as CategorieId,
	 s.UserId as UserId,
	 s.Pourquoi as Pourquoi,
	 s.Prix as Prix,
	 ru.frais as Frais,
	 r.Id as RegionId,
	 r.Code_Postal as Code_Postal,
	 r.Ville as Ville,
	 p.Nom as Pays,
	 p.Continent as Continent,
	 s.Alerte as Alerte
	from[Services] s 
	join[Regions_Users] ru on ru.UserId = s.UserId 
	join[Regions] r on r.Id = ru.UserId 
	join[Pays] p on p.Id = r.Pays 
	where EstDemande = 0
