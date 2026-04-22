CREATE PROCEDURE UpdateName
(
    @userName as VARCHAR (255),
    @userID as VARCHAR (255)
)
AS
UPDATE Users
SET
    userName = @userName
WHERE userID = @userID