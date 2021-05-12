use Radio

drop table if exists Tracks
drop table if exists UserPlaylists
drop table if exists Playlist
drop table if exists Users
drop table if exists Genre


create table Users
(
	UserID int identity(1,1) Primary Key,
	FirstName varchar(50)  default 'Bongani' not null,
	LastName varchar(50)  default 'Luwemba' not null,
	"PassWord" varchar(50)  default 'qwertyuiop' not null,
	Username varchar(50) default 'bongiboy777' not null,
	Email varchar(80) default 'bongiluwe777@gmail.com',
	DateJoined DateTime default('2021-05-11') not null,
);

create table Genre
(
	GenreID int Identity(1,1) Primary Key,
	"Name" varchar(50)  default 'MercyTunes' not null
);

create table PlayList
(
	PlayListID int Identity(1,1) Primary Key,
	CreatedBy int  Foreign Key References Users(UserID),
	DateCreated DateTime default('2021-05-11') not null,
	GenreID int Foreign Key References Genre(GenreID),
	"Name" varchar(50)  default 'MercyTunes' not null,
);

create table UserPlaylists
(
	ID int identity(1,1) Primary Key,
	UserID int  Foreign Key References Users(UserID),
	PlayListID int Foreign Key References PlayList(PlayListID),
);

create table Tracks
(
	PlayListID int Foreign Key References PlayList(PlayListID),
	Artist varchar(50)  default 'KingKay' not null,
	GenreID int Foreign Key References Genre(GenreID),
	"Name" varchar(50)  default 'Salida' not null,
);





