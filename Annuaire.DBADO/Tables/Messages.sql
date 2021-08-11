CREATE TABLE [dbo].[Messages]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[ConversationId] int not null,
	[UserId] int not null default(1),
	[Date_envoi] DateTime not null default(getdate()),
	[Message] text not null,
	[Alerte] bit default(0),
	constraint FK_messages_conversation foreign key(ConversationId) references Conversations(Id),
	constraint FK_messages_user foreign key(UserId) references Users(Id)
)
