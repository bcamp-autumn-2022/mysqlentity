CREATE TABLE [dbo].[Cake] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (MAX)   NULL,
    [Price]       DECIMAL (18, 2) NULL,
    [Description] VARCHAR (MAX)   NULL
);

insert into Cake (Name,Price,Description) VALUES('FirstCake',55.5,'Good Cake');
insert into Cake (Name,Price,Description) VALUES('SecondCake',65.5,'Basic Cake');

select * from Cake;