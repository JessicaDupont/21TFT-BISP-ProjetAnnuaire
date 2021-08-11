CREATE TABLE [dbo].[Categories]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[Nom] nvarchar(100) not null,
	[Description] text,
	[Categorie_Parent] int,
	constraint U_categories unique([Nom], [Categorie_Parent]),
	constraint FK_categories_parent foreign key(Categorie_Parent) references Categories(Id)
)
