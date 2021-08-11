CREATE TABLE [dbo].[Regions]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[Ville] nvarchar(60) not null, /*reccord 58*/
	[Code_Postal] int not null,
	[Pays] int not null,
	constraint U_regions unique([Code_Postal], [Pays]),
	constraint FK_regions_pays foreign key([Pays]) references Pays(Id)
)