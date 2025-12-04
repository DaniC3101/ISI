SELECT name
FROM sys.procedures

CREATE PROCEDURE RegistrarUtilizador
    @Auth0UserId NVARCHAR(100),
    @Nome NVARCHAR(100),
    @Email NVARCHAR(255),
    @ImgUrl NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NovoId INT;

    -- Inserir o utilizador na tabela Utilizadores
    INSERT INTO Utilizadores (Auth0UserId, Nome, Email, ImgUrl)
    VALUES (@Auth0UserId, @Nome, @Email, @ImgUrl);

    -- Recuperar o Id do utilizador recém-inserido
    SET @NovoId = SCOPE_IDENTITY();

    -- Retornar o Id
    SELECT @NovoId AS Id;
END;
