--Datos Generales de la BD Labtec
--Estados generales de los Laboratorios
USE LabTec
INSERT INTO Estado_Lab(ID_EstLab,Nombre) VALUES(1,'Disponible')
INSERT INTO Estado_Lab(ID_EstLab,Nombre) VALUES(2,'Fuera de Servicio')
INSERT INTO Estado_Lab(ID_EstLab,Nombre) VALUES(3,'Mantenimiento')
GO
--Estados generales de los Proyectores
INSERT INTO Estado_Proyector(ID_EstadoProyector,Nombre) VALUES(1,'Disponible')
INSERT INTO Estado_Proyector(ID_EstadoProyector,Nombre) VALUES(2,'Extraviado')
INSERT INTO Estado_Proyector(ID_EstadoProyector,Nombre) VALUES(3,'Fuera de Servicio')
INSERT INTO Estado_Proyector(ID_EstadoProyector,Nombre) VALUES(4,'Reposo')
GO
--Departamentos
INSERT INTO Departamento(ID_Dep,Nombre) VALUES(1,'Sistemas Computacionales')
INSERT INTO Departamento(ID_Dep,Nombre) VALUES(2,'Informatica')
INSERT INTO Departamento(ID_Dep,Nombre) VALUES(3,'TICS')
GO
--Tipos de roles
INSERT INTO Rol(ID_Rol,Nombre) VALUES(1,'Administrador')
INSERT INTO Rol(ID_Rol,Nombre) VALUES(2,'Maestro')
GO

SELECT*FROM Usuario
SELECT*FROM Proyectores
--Usuarios
INSERT INTO Usuario(ID_Usuario, Nombre, Ape_P, Ape_M, ID_Rol, Genero, Clave, Correo, Estado) VALUES(17210550,'Joel','Cortez','Ortega',1,'M',1234,'joel.ortega17@tectijuana.edu.mx','T')
INSERT INTO Usuario(ID_Usuario, Nombre, Ape_P, Ape_M, ID_Rol, Genero, Clave, Correo, Estado) VALUES(17210000,'Rogelio','Mitre','Perez',2,'M',1234,'rogelio.mitre17@tectijuana.edu.mx','T')
INSERT INTO Usuario(ID_Usuario, Nombre, Ape_P, Ape_M, ID_Rol, Genero, Clave, Correo, Estado) VALUES(17210001,'Juan','Lopez','Lopez',2,'M',1234,'juan.perez17@tectijuana.edu.mx','T')
INSERT INTO Usuario(ID_Usuario, Nombre, Ape_P, Ape_M, ID_Rol, Genero, Clave, Correo, Estado) VALUES(18210844,'Fernando','Amador','Garcia',1,'M',1234,'fernanddo.amador18@tectijuana.edu.mx','T')
INSERT INTO Usuario(ID_Usuario, Nombre, Ape_P, Ape_M, ID_Rol, Genero, Clave, Correo, Estado) VALUES(17211525,'Javier Ernesto','Garcia','Gomez',1,'M',1234,'javier.garcia1717@tectijuana.edu.mx','T')
GO
Select * from Proyectores

--Proyectores
INSERT INTO Proyectores(ID_Proyector,Nombre,Descripcion,ID_EstadoProyector)
VALUES (1000,'Equal Eq Py02','- Extensión polarizada de 3 contactos, para uso rudo, de 8 m
- Cable hdmi de 1 m
- Entradas: VGA, HDMI, USB, tarjeta SD
- Cargador, Funda de transporte, Control',1)
INSERT INTO Proyectores(ID_Proyector,Nombre,Descripcion,ID_EstadoProyector)
VALUES (1001,'Acer C202I','- Extensión polarizada de 3 contactos, para uso rudo, de 8 m
- Cable hdmi de 1 m
- Entradas: USB, HDMI. 
- Cargador, Funda de transporte.',1)
INSERT INTO Proyectores(ID_Proyector,Nombre,Descripcion,ID_EstadoProyector)
VALUES (1002,'EVL RD-802','- Extensión polarizada de 3 contactos, para uso rudo, de 8 m
- Cable hdmi de 1 m
- Entradas: hdmi, usb, av, vga, atv, sd, audio out
- Cargador, Funda de transporte.',1)
GO

INSERT INTO Laboratorios(ID_Lap,Nombre,ID_EstLab) VALUES(1000,'Laboratorio A',1)
INSERT INTO Laboratorios(ID_Lap,Nombre,ID_EstLab) VALUES(1001,'Laboratorio B',1)
INSERT INTO Laboratorios(ID_Lap,Nombre,ID_EstLab) VALUES(1002,'Laboratorio C',1)
INSERT INTO Laboratorios(ID_Lap,Nombre,ID_EstLab) VALUES(1003,'Laboratorio D',1)
GO