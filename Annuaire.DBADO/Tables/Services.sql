CREATE TABLE [dbo].[Services]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[CategorieId] int not null,
	[UserId] int not null,
	[EstDemande] bit default(0),
	[RegionId] int,
	[Adresse] nvarchar(100),
	[Pourquoi] text not null,
	[QuandCombien] text,
	[Prix] nvarchar(25),
	[Alerte] bit default(0),
	constraint FK_services_categories foreign key([CategorieId]) references Categories([Id]),
	constraint FK_services_users foreign key([UserId]) references Users([Id]),
	constraint FK_services_regions foreign key([RegionId]) references Regions(Id)
)
