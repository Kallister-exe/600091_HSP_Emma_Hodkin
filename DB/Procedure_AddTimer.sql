CREATE PROCEDURE AddTimer
(
    @timerID AS VARCHAR (255),
    @userID AS VARCHAR (255),
    @routineID AS VARCHAR (255),
    @timerLength AS FLOAT (64),
    @datestamp AS TIMESTAMP,
    @timerType AS INT
)
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
INSERT INTO Timers
(
    timerID,
    userID,
    routineID,
    timerLength,
    datestamp,
    timerType
)
VALUES
(
    @timerID,
    @userID,
    @routineID,
    @timerLength,
    @datestamp,
    @timerType
)
COMMIT TRANSACTION;
END TRY
BEGIN CATCH
PRINT 'Add timer Error'
ROLLBACK TRANSACTION
THROW
END CATCH
END;