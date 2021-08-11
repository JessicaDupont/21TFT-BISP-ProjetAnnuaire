CREATE TABLE [dbo].[Evaluations]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[PrestationId] int not null,
	[AuteurId] int not null,
	[AuteurEstPro] bit default(0),
	[UserId] int not null,
	[Note] smallint not null,
	[Commentaire] text,
	constraint FK_evaluations_prestations foreign key(PrestationId) references Prestations(Id),
	constraint FK_evaluations_auteur foreign key(AuteurId) references Users(Id),
	constraint FK_evaluations_user foreign key(UserId) references Users(Id)
)
