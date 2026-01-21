USE lesson19

DROP TABLE Teams;
DROP TABLE Players;
DROP TABLE Trainers;

CREATE TABLE Players(
	PlayerId int NOT NULL PRIMARY KEY,
	Name varchar(32) NOT NULL
	);

CREATE TABLE Trainers(
	TrainerId int NOT NULL PRIMARY KEY,
	Name varchar(32) NOT NULL
	);

CREATE TABLE Teams(
	TeamId int NOT NULL PRIMARY KEY,
	Name varchar(64) NOT NULL
	);

CREATE TABLE Teams_Players(
	TeamId int NOT NULL, FOREIGN KEY(TeamId) REFERENCES Teams(TeamId),
	PlayerId int NOT NULL UNIQUE, FOREIGN KEY(PlayerId) REFERENCES Players(PlayerId)
	);

CREATE TABLE Teams_Trainers(
	TeamId int NOT NULL UNIQUE, FOREIGN KEY(TeamId) REFERENCES Teams(TeamId),
	TrainerId int NOT NULL, FOREIGN KEY(TrainerId) REFERENCES Trainers(TrainerId)
	);

INSERT INTO Teams(TeamId,Name)
VALUES (1,'Bulls'),(2,'Hawks'),(3,'Rabbits');

INSERT INTO Players(PlayerId,Name)
VALUES (1,'Bill'),(2,'Tom'),(3,'Rick'),(4,'Petr'),(5,'Bob'),(6,'Ron'),(7,'Tod'),(8,'Frenk'),(9,'Kit'),(10,'German'),(11,'Karen'),(12,'Rita'),(13,'Lora'),(14,'Mishel'),(15,'Judi');

INSERT INTO Trainers(TrainerId,Name)
VALUES (1,'Garold'),(2,'Katrin');

INSERT INTO Teams_Players(TeamId,PlayerId)
VALUES (1,1),(1,2),(1,3),(1,4),(1,5),(2,11),(2,12),(2,13),(2,14),(2,15),(3,6),(3,7),(3,8),(3,9),(3,10);

INSERT INTO Teams_Trainers(TeamId,TrainerId)
VALUES (1,1),(2,2),(3,1);

