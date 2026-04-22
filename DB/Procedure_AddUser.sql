CREATE PROCEDURE AddUser
(
    @userID AS VARCHAR (255),
    @userName AS VARCHAR (255),
    @email AS VARCHAR (255),
    @password AS VARCHAR (255)
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            INSERT INTO Users
            (
                userID,
                userName,
                email
            )
            VALUES
            (
                @userID,
                @userName,
                @email
            )
            INSERT INTO Passwords -- adds all of the user info together so no user can be saved without a password and vice versa
            (
                [password],
                userID
            )
            VALUES
            (
                @password,
                @userID
            )
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        PRINT 'adduser error'
        ROLLBACK TRANSACTION
        THROW
    END CATCH;
END;