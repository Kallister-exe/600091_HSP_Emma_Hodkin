CREATE PROCEDURE UpdateTimerType
(
    @timerType as INT,
    @timerID as VARCHAR (255)
)
AS
UPDATE Timers
SET
    timerType = @timerType
WHERE timerID = @timerID