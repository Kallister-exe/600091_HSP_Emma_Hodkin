CREATE PROCEDURE UpdateDatestamp
(
    @datestamp as TIMESTAMP,
    @timerID as VARCHAR (255)
)
AS
UPDATE Timers
SET
    datestamp = @datestamp
WHERE timerID = @timerID