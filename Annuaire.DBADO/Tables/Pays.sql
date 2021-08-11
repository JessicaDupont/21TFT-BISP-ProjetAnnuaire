CREATE TABLE [dbo].[Pays]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[Nom] nvarchar(50) not null unique, /*reccord 42*/
	[Continent] nvarchar(20) not null,
	constraint C_continents_liste check ([Continent] IN(
			'Afrique', 
			'Europe',
			'Asie', 
			'Océanie', 
			'Amérique du Nord', 
			'Amérique du Sud', 
			'Antarctique', 
			'Zealandia'))
)