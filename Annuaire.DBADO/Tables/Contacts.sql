CREATE TABLE [dbo].[Contacts]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[Type] int not null,
	[Valeur] nvarchar(50) not null,
	[Visibilite] smallint default(0),
	[EstPro] bit default(0),
	[UserId] int not null,
	constraint FK_contacts_user foreign key([UserId]) references Users(Id)
)
