CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[Inscription] DateTime not null default(Getdate()),
	[Connexion] DateTime,
	[Role] int not null,
	[MethodeDeConnexion] int not null,
	[Login] nvarchar(25),
	[Mdp] binary,
	[CommentaireModeration] text
)