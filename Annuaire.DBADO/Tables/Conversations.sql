CREATE TABLE [dbo].[Conversations]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[Titre] nvarchar(50) not null,
	[ServiceId] int,
	[PrestationId] int,
	constraint FK_conversations_services foreign key(ServiceId) references [Services](Id),
	constraint FK_conversations_prestations foreign key(PrestationId) references Prestations(Id)
)
