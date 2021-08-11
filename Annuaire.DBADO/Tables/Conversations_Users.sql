CREATE TABLE [dbo].[Conversations_Users]
(
	[UserId] INT NOT NULL,
	[ConversationId] int not null,
	constraint PK_conversationuser primary key(UserId, ConversationId),
	constraint FK_conversationuser_user foreign key(UserId) references Users(Id),
	constraint FK_conversationuser_conversation foreign key(ConversationId) references Conversations(Id)
)
