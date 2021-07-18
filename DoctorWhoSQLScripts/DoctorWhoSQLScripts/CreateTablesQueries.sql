-- 1) This statement create Enemy table 
CREATE TABLE tblEnemy (
	EnemyId int IDENTITY(1,1) PRIMARY KEY,
	EnemyName varchar(50) NOT NULL,
	Description varchar(1800) NULL
);

-- 2) This statement create Author table 
CREATE TABLE tblAuthor (
	AuthorId int IDENTITY(1,1) PRIMARY KEY,
	AuthorName varchar(50) NOT NULL
);

-- 3) This statement create Doctor table
CREATE TABLE tblDoctor (
	DoctorId int IDENTITY(1,1) PRIMARY KEY,
	DoctorNumber int NOT NULL UNIQUE,
	DoctorName varchar(50) NOT NULL,
	BirthDate date NOT NULL,
	FirstEpisodeDate date NULL,
	LastEpisodeDate date NULL
);

-- 4) This statement create Companion table
CREATE TABLE tblCompanion (
	CompanionId int IDENTITY(1,1) PRIMARY KEY,
	CompanionName varchar(50) NOT NULL,
	WhoPlayed varchar(200) NULL
);

-- 5) This statement crate Episode table
CREATE TABLE tblEpisode (
	EpisodeId int IDENTITY(1,1) PRIMARY KEY,
	SeriesNumber int NOT NULL,
	EpisodeNumber int NOT NULL,
	EpisodeType varchar(30) NOT NULL,
	EpisodeTitle varchar(200) NOT NULL,
	EpisodeDate date NOT NULL,
	AuthorId int FOREIGN KEY REFERENCES tblAuthor(AuthorId),
	DoctorId int FOREIGN KEY REFERENCES tblDoctor(DoctorId),
	Notes varchar(1800) NULL
);

-- 6) This statement crate Episode Companion table
CREATE TABLE tblEpisodeCompanion (
	EpisodeCompanionId int IDENTITY(1,1) PRIMARY KEY,
	EpisodeId int FOREIGN KEY REFERENCES tblEpisode(EpisodeId),
	CompanionId int FOREIGN KEY REFERENCES tblCompanion(CompanionId)
);

-- 7) This statement crate Episode Companion table
CREATE TABLE tblEpisodeEnemy (
	EpisodeEmenyId int IDENTITY(1,1) PRIMARY KEY,
	EpisodeId int FOREIGN KEY REFERENCES tblEpisode(EpisodeId),
	EnemyId int FOREIGN KEY REFERENCES tblEnemy(EnemyId)
);