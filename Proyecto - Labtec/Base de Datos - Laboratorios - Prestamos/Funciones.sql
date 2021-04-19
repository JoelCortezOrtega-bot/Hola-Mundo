--Funciones para LabTec
USE LabTec
--Creamos una funcion para verficar si la contraseña y usuario son los mismos
CREATE FUNCTION fn_VerificacionUsuario
(
--Va ha recibir la contraseña y el usuario 
	@ID_usuario INT,
	@Clave INT
)
--Va ha devolver un resultado en cadana de texto
RETURNS VARCHAR(50)
AS 
BEGIN
	DECLARE @Mensaje VARCHAR(50)
	IF EXISTS((SELECT ID_Rol FROM Usuario WHERE ID_Usuario = @ID_usuario AND Clave = @Clave)) 
		BEGIN
			SELECT @Mensaje = ID_Rol FROM Usuario WHERE ID_Usuario = @ID_usuario AND Clave = @Clave
		END
	ELSE
		BEGIN
			SET @Mensaje = 'No'
		END
	RETURN @Mensaje
END

SELECT dbo.fn_VerificacionUsuario(17210550,123)

CREATE FUNCTION fn_RecuperarClave
(
	@Correo VARCHAR(50)
)
RETURNS INT
AS
BEGIN 
	DECLARE @Clave VARCHAR(50)
	IF EXISTS((SELECT Clave FROM Usuario WHERE Correo = @Correo)) 
		BEGIN
			SELECT @Clave = Clave FROM Usuario WHERE Correo = @Correo
		END
	ELSE
		BEGIN
			SET @Clave = 'No'
		END
	RETURN @Clave
END

SELECT dbo.fn_RecuperarClave('joel.ortega17@tectijuana.edu.m')

SELECT Clave FROM Usuario WHERE Correo = 'joel.ortega17@tectijuana.edu.mx'
SELECT Correo FROM Usuario WHERE ID_Usuario = 17210550