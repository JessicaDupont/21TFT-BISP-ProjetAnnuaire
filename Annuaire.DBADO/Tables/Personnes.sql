CREATE TABLE [dbo].[Personnes]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[UserId] int not null,
	[Nom] nvarchar(50) not null, /*reccord a 47*/
	[Prenom] nvarchar(50) not null, /*reccord a 50*/
	[Ddn] DateTime not null,
	[Description] text,
	[Alerte] bit default(0),
	constraint FK_personne_user foreign key([UserId]) references Users([Id])
)
