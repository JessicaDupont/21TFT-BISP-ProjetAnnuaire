CREATE TABLE [dbo].[Pros]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[UserId] int not null,
	[Nom] nvarchar(100) not null,
	[DdCreation] DateTime,
	[Description] text,
	[NumeroTVA] nvarchar(25),
	[Horaires] text,
	[Alerte] bit default(0),
	constraint FK_pro_user foreign key([UserId]) references Users([Id])
)
