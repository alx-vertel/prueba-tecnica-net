USE master;

GO

IF EXISTS (SELECT NAME FROM master.dbo.sysdatabases WHERE NAME = 'prueba_tecnica_net')
BEGIN
	DROP TABLE IF EXISTS Usuario;
    DROP TABLE IF EXISTS Persona;
	DROP DATABASE prueba_tecnica_net;
	
END

GO

-- Crear la base de datos
CREATE DATABASE prueba_tecnica_net;

GO

--Usar la base de datos que creamos
USE prueba_tecnica_net;

GO

-- Crear la tabla Persona
CREATE TABLE Persona (
    Identificador VARCHAR(100) PRIMARY KEY,
    Nombres VARCHAR(50),
    Apellidos VARCHAR(50),
    NumeroIdentificacion VARCHAR(20),
    Email VARCHAR(100),
    TipoIdentificacion VARCHAR(20),
    FechaCreacion DATETIME DEFAULT getDate(),
    NumeroIdentificacionConcat AS (TipoIdentificacion + NumeroIdentificacion),
    NombreCompleto AS (Nombres + ' ' + Apellidos)
);

-- Crear la tabla Usuario
CREATE TABLE Usuario (
    Identificador VARCHAR(100),
    Usuario VARCHAR(50),
    Pass VARCHAR(100),
    FechaCreacion DATETIME DEFAULT getdate(),
	FOREIGN KEY (Identificador) REFERENCES Persona(Identificador)
);

GO

SELECT * FROM Persona;

SELECT * FROM Usuario;