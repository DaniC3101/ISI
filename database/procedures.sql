SELECT name
FROM sys.procedures

CREATE PROCEDURE InserirUtilizador
    @Auth0UserId NVARCHAR(100)
AS
BEGIN
    -- Inserir o utilizador na tabela Utilizadores
    INSERT INTO Utilizadores(Auth0UserId)
    VALUES (@Auth0UserId);
END;