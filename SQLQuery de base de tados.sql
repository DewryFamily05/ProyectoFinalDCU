go
use MyHospital
go


/*DATOS DEL PASIENTES*/
go
create table Paciente(
idPaciente int identity primary key,
Nombres varchar(40) not null,
Apellidos varchar(60)not null,
FechaNacimiento date not null,
TipoSangre nvarchar(10) not null,
Correo nvarchar(40),
Telefono varchar(15) not null,
ContactoEmergencia varchar(15) not null
)
go

insert into Paciente values('Carlos','Fermin Castro','07/12/1987','O+','carlosFerminC@gmail.com','(874)897-5874','(874)568-5878');
insert into Paciente values('Francisco','Crisotomo Herrera','26/01/1997','A+','FranciscoC.He@gmail.com','(829)257-5741','(849)525-1471');
insert into Paciente values('Yina','Perz Rosario','14/08/2000','B-','YinaP.Rosa@gmail.com','(804)147-5887','(829)748-5748');

select * from Paciente;
SELECT * FROM Paciente WHERE Nombres LIKE 'C%' OR Apellidos LIKE 'P%'
UPDATE Paciente SET Nombres = 'Yina', Apellidos = 'Perez Rosario', FechaNacimiento = '14/08/2000', TipoSangre = 'B-', Correo = 'YinaP.Rosa@gmail.com', Telefono = '(804)147-5887', ContactoEmergencia = '(829)748-5748' WHERE idPaciente = 3;
delete from Paciente  where idPaciente = 5
select idPaciente from Paciente;





/*DATOS DEL MEDICO*/
go
create table Medico(
IdMedico int primary key identity,
Nombre varchar(40) not null,
Apellidos Varchar(60) not null,
Cedula varchar(16) not null,
Especialidad varchar(40) not null,
Telefono varchar(15) not null,
Carreo varchar(50),
Estado varchar(10) not null
)
go

insert into Medico values('Alexander','Villalona Riveras','001-5878412-0','Pediatra','(809)258-2474','AlexanderVillaRive@gmail.com','Activo');
insert into Medico values('Daysi','Mueñez Fabian','458-2569874-8','Odontologa','(809)258-7748','DaysiMF@gmail.com','Asueto');
insert into Medico values('Henry','Smith Lincon','147-3698745-4','Ginecologo','(809)258-2474','HenrySL@gmail.com','Retirado');
insert into Medico values('Victoria','Cabral Riveras','001-3698412-0','Medicina General','(809)258-2581','VictoCabralR@gmail.com','Retirado');

select * from Medico;

UPDATE Medico SET Nombre = 'Jeuris', Apellidos = 'Carrasco Javier', Cedula = '001-8456974-2', Especialidad = 'Cirujano', Telefono = '(587)587-8741', Carreo = 'JCasJav@hotmail.com', Estado = 'Activo' WHERE IdMedico = 5;
delete from Medico  where IdMedico = 7;
SELECT * FROM Medico WHERE Nombre LIKE 'J%' OR Apellidos LIKE 's%'








go

create table Alergias(
idAlergias int identity primary key,
idPaciente int foreign key references Paciente(idPaciente),
Nombre nvarchar(40),
Descripcion varchar(60)
)

go

go
create table HistorialMedica(
IdHistorial int primary key identity,
idPaciente int foreign key references Paciente(idPaciente),
idMedico   int foreign key references Medico(IdMedico),
Motivo varchar (50) not null, /*Consulta, Emergencia,Revision,Seguimiento, Terapia ect.*/
Fecha date not null,
Sintomas varchar(256),
Diagnostico varchar(256),
Tratamiento varchar(256),
PresionArterial nvarchar(20),
Temperatura float 
)
go

select * from Medico;