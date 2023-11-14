USE prueba_tecnica_net

GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarPersonas')
DROP PROCEDURE ConsultarPersonas

GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'RegistrarPersona')
DROP PROCEDURE RegistrarPersona

GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarUsuarioPersona')
DROP PROCEDURE ConsultarUsuarioPersona

GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'RegistrarUsuario')
DROP PROCEDURE RegistrarUsuario

GO


--**************** PROCEDIMIENTOS ****************--
CREATE PROCEDURE ConsultarPersonas
AS
BEGIN

SELECT * FROM Persona

END;

GO

CREATE PROCEDURE RegistrarPersona(
@Identificador VARCHAR(100),
@Nombres VARCHAR(50), 
@Apellidos VARCHAR(50), 
@NumeroIdentificacion VARCHAR(20),
@Email VARCHAR(100),
@TipoIdentificacion VARCHAR(20)
)
AS
BEGIN

INSERT INTO Persona(Identificador, Nombres, Apellidos, NumeroIdentificacion, Email, TipoIdentificacion) 
VALUES
(
@Identificador,
@Nombres,
@Apellidos,
@NumeroIdentificacion,
@Email,
@TipoIdentificacion
)

END;

GO

CREATE PROCEDURE ConsultarUsuarioPersona(
@Usuario VARCHAR(50), 
@Pass VARCHAR(100))
AS
BEGIN

SELECT p.* 
FROM Usuario u JOIN Persona p 
ON u.Identificador = p.Identificador 
WHERE u.Usuario = @Usuario AND u.Pass = @Pass

END

GO

CREATE PROCEDURE RegistrarUsuario(
@Identificador VARCHAR(100),
@Usuario VARCHAR(50),
@Pass VARCHAR(100)
)
AS
BEGIN

INSERT INTO Usuario(Identificador, Usuario, Pass) 
VALUES
(
@Identificador,
@Usuario,
@Pass
)

END;