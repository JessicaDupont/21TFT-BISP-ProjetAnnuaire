CREATE TABLE [dbo].[Regions_Users]
(
	[UserId] INT NOT NULL,
	[RegionId] INT NOT NULL,
	[frais] money,
	[est_pro] bit default(0),
	constraint PK_regionuser primary key([UserId], [RegionId]),
	constraint FK_regionuser_user foreign key([UserId]) references Users([Id]),
	constraint FK_regionuser_region foreign key([RegionId]) references Regions([Id]),
	constraint C_regionuser_min_frais check([frais] >= 0)
)
