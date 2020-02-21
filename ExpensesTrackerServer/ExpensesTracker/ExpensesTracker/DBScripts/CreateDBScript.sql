create table [dbo].[TodoItem] (
	[ID] int IDENTITY (1,1) PRIMARY KEY,
	[Name] nvarchar(255) null,
	[IsComplete] bit null
);