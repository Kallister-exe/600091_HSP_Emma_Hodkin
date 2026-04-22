CREATE PROCEDURE UpdateTimerLength
(
    @timerLength as FLOAT (64),
    @timerID as VARCHAR (255)
)
AS
UPDATE Timers
SET
    timerLength = @timerLength
WHERE timerID = @timerID