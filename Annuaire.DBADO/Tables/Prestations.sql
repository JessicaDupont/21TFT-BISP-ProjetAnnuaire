CREATE TABLE [dbo].[Prestations]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[CategorieId] int not null,
	[ClientId] int not null,
	[PrestataireId] int not null,
	[RegionId] int not null,
	[Adresse] nvarchar(100) not null,
	[PrixHeure] money not null,
	[Date_Debut] DateTime,
	[Duree] Time,
	[Alerte] bit default(0),
	constraint FK_prestations_categories foreign key(CategorieId) references Categories(Id),
	constraint FK_prestations_personnes foreign key(ClientId) references Personnes(Id),
	constraint FK_prestations_pros foreign key(PrestataireId) references Pros(Id),
	constraint FK_prestations_regions foreign key(RegionId) references Regions(Id),
	constraint C_prestations_min_prix check(PrixHeure >= 0)
)
