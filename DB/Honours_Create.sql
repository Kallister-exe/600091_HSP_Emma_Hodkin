CREATE DATABASE Honours;
CREATE TABLE Users
(
    userID VARCHAR (255) PRIMARY KEY, -- all IDs will be stored as GUID values
    userName VARCHAR (255) NOT NULL,
    email VARCHAR (255) NOT NULL,
);

CREATE TABLE Routines
(
    routineID VARCHAR (255) PRIMARY KEY,
    userID VARCHAR (255) NOT NULL,
    CONSTRAINT FK_userID
    FOREIGN KEY (userID)
    REFERENCES Users(userID)
);

CREATE TABLE Timers
(
    timerID VARCHAR (255) PRIMARY KEY,
    userID VARCHAR (255) NOT NULL,
    routineID VARCHAR (255),
    timerLength FLOAT (64) NOT NULL,
    datestamp TIMESTAMP, -- datestamps will be recorded from when the timer was started
    timerType INT NOT NULL, -- gives option of expansion with more options other than rest or work
    CONSTRAINT FK_userID
    FOREIGN KEY (userID)
    REFERENCES Users(userID),
    CONSTRAINT FK_routines
    FOREIGN KEY (routineID)
    REFERENCES Routines(routineID)
);

CREATE TABLE Themes 
(
    themeID VARCHAR (255) PRIMARY KEY,
    mainColour VARCHAR (8) NOT NULL, -- 4 bytes for RGBA colour storage
    highlight VARCHAR (8) NOT NULL,
    lowlight VARCHAR (8) NOT NULL,
    contrast VARCHAR (8) NOT NULL,
);

CREATE TABLE Passwords
(
    [password] VARCHAR (255) PRIMARY KEY, -- stored as a hash value
    userID VARCHAR (255) NOT NULL,
    CONSTRAINT FK_userID
    FOREIGN KEY (userID)
    REFERENCES Users(userID)
);