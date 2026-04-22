CREATE PROCEDURE AddCosmetic
(
    @themeID AS VARCHAR (255),
    @mainColour AS VARCHAR (8),
    @highlight AS VARCHAR (8),
    @lowlight AS VARCHAR (8),
    @contrast AS VARCHAR (8)
)
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
INSERT INTO Cosmetics
(
    themeID,
    mainColour,
    highlight,
    lowlight,
    contrast
)
VALUES
(
    @themeID,
    @mainColour,
    @highlight,
    @lowlight,
    @contrast
)
COMMIT TRANSACTION;
END TRY
BEGIN CATCH
PRINT 'Add cosmetic occured'
ROLLBACK TRANSACTION
THROW
END CATCH
END;