CREATE TABLE Player (
    ID int identity(1,1) PRIMARY KEY,
    Name varchar(255),
    Balance int,
    HomePlanet varchar(255),
    Created DATETIME2,
);

CREATE TABLE Spaceship (
    Id int identity(1,1) PRIMARY KEY,
    PlayerId int,
    Name varchar(255),
    Type varchar(255),
    Speed int,
    Armor int,
    Weapons int,
    Capacity int,
    Durability int,
    InitialPrice int,
    ImageLink text,
    Status varchar(255),
    CurrentCargoName varchar(255),
    CurrentTotalCargoValue int,
    CurrentPort varchar(255),
    TargetPort varchar(255),
    MissionStart DATETIME2,
    MissionTime int,
);