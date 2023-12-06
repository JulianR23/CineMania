 CREATE DATABASE CINEMANIA
 GO 
 USE CINEMANIA
 GO

 CREATE TABLE SECCION
 (
 CODIGO INT PRIMARY KEY,
 GENERO VARCHAR(30),
 )
 
 CREATE TABLE PELICULA
 (
 CODIGO INT PRIMARY KEY,
 NOMBRE VARCHAR(30),
 VALOR MONEY,
 CODSECCION INT
 )
 CREATE TABLE PRESTAMO
 (
 FECHAPRESTAMO DATETIME ,
 FECHAENTREGA DATETIME,
 CODPELICULA INT,
 CORREO Nvarchar(250)
 PRIMARY KEY(CODPELICULA, CORREO)
 )
 CREATE TABLE PERSONA
 (
 NOMBRE VARCHAR(30),
 TELEFONO VARCHAR(10),
 CORREO Nvarchar(250) PRIMARY KEY,
 CONTRASE�A VARCHAR(500),
 ACCESO INT
 )
 GO
CREATE TRIGGER ValidarCorreoElectronico
ON PERSONA
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE NOT (CORREO LIKE '%@%.%' AND CORREO NOT LIKE '%@%@%')
    )
    BEGIN
        PRINT('Direcci�n de correo electr�nico no v�lida')
        ROLLBACK TRANSACTION
    END
END
GO
ALTER TABLE PELICULA ADD FOREIGN KEY(CODSECCION)
REFERENCES SECCION (CODIGO) ON UPDATE CASCADE ON DELETE CASCADE

ALTER TABLE PRESTAMO ADD FOREIGN KEY(CODPELICULA)
REFERENCES PELICULA(CODIGO) ON UPDATE CASCADE ON DELETE CASCADE

ALTER TABLE PRESTAMO ADD FOREIGN KEY(CORREO)
REFERENCES PERSONA(CORREO) ON UPDATE CASCADE ON DELETE CASCADE 

GO

INSERT INTO PERSONA VALUES
(
'ADMIN', '123456789', 'admin@cinemania.com', '123*', 1),
('CAJERO', '100025487', 'caja@cinemania.com', '100', 2),
('JULIAN', '300110014', 'julian@cinemania.com', '1023', 3)

GO

INSERT INTO SECCION VALUES
(1, 'CIENCIA FICCION'),
(2, 'COMEDIA'),
(3, 'ACCION'),
(4, 'DRAMA'),
(5, 'SUSPENSO')
GO
INSERT INTO PELICULA VALUES
(10, 'LA VIEJA GUARDIA', 3200, 3),
(20, 'TENET', 5000, 1),
(30, 'SON COMO NI�OS', 3000, 2),
(40, 'LOS ILUSIONISTAS', 2700, 5),
(50, 'CREPUSCULO AMANECER PARTE 2', 4100, 4),
(60, 'OPPENHEIMER', 4500, 1),
(70, 'EL DIABLO SE VISTE A LA MODA', 1800, 2),
(80, 'LA NOCHE DEL DEMONIO', 3900, 5),
(90, 'ESCUADRON 6', 5000, 3),
(100, 'BIRDBOX', 4600, 4)
GO
CREATE VIEW PELICULASDISPONIBLES AS
SELECT
    S.GENERO,
    P.NOMBRE,
    AVG(P.VALOR) AS PRECIO
FROM
    PELICULA P
    JOIN SECCION S ON P.CODSECCION = S.CODIGO
GROUP BY
    S.GENERO, P.NOMBRE