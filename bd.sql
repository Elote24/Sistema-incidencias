
create database ProyectoGestion
go
use ProyectoGestion
go

CREATE TABLE Departamento(
	Id int  identity (1,1) primary key NOT NULL,
	Nombre varchar (40) NOT NULL,
)
go
CREATE TABLE Edificio(
	Id int IDENTITY(1,1) primary key NOT NULL,
	Nombre varchar(40) NOT NULL,
	Id_Departamento int Foreign key (Id_Departamento) references Departamento (Id)
)
go
CREATE TABLE Cubiculo(
	Id int IDENTITY(1,1) primary key NOT NULL,
	Nombre varchar(40) NOT NULL,
	Id_Edificio int Foreign key (Id_Edificio) references Edificio (Id)
	)
go

CREATE TABLE Empleado(
	Id int  identity (1,1) primary key NOT NULL,
	Nombre varchar(30) NOT NULL,
	Apellido_Paterno varchar(30) NOT NULL,
	Apellido_Materno varchar(30) NOT NULL,
	Correo varchar(40) NOT NULL,
	Contraseña char(10) NOT NULL,
	Celular char(10) NULL,
	Puesto varchar(40) NOT NULL,
	Departamento int Foreign key (Departamento) references Departamento (Id),
	)
go
CREATE TABLE Equipo(
	Id int  identity (1,1) primary key NOT NULL,
	Equipo varchar(20) NOT NULL,
	Marca varchar(20) NOT NULL,
	Modelo varchar(20) NOT NULL,
	Descripcion [varchar](100) NOT NULL,
	Años_Garantia int NOT NULL,
	FechaCompra date NOT NULL,
	Id_Empleado int Foreign key (Id_Empleado) references Empleado (Id),
	Departamento int Foreign key (Departamento) references Departamento (Id),
	Edificio int Foreign key (Edificio) references Edificio (Id),
	Cubiculo int Foreign key (Cubiculo) references Cubiculo (Id)
)
go
CREATE TABLE Tecnico(
	Id int  identity (1,1) primary key NOT NULL,
	Especializacion varchar(30) NOT NULL,
	Certificaciones varchar(200) NOT NULL,
	Incidencias_Asignadas int,
	Id_Empleado int Foreign key (Id_Empleado) references Empleado (Id)
	)

	
	go
CREATE TABLE Incidencia(
	Id int  identity (1,1) primary key NOT NULL,
	Descripcion varchar(300) NOT NULL,
	Tipo varchar(15) NULL,
	Prioridad varchar (20)  NULL,
	Fecha_Levantamiento datetime,
	Fecha_Inicio datetime ,
	Fecha_Terminacion datetime,
	Servicio varchar(100),
	Cambio varchar(5),
	Detalles_de_cambio varchar(160),
	Estatus_Cambio varchar(20)  ,
	Estatus varchar(20)  ,
	Calificacion [char](1),
	Id_Empleado int Foreign key (Id_Empleado) references Empleado (Id),
	Id_Equipo int Foreign key (Id_Equipo) references Equipo (Id),
	Id_Departamento int Foreign key (Id_Departamento) references Departamento (Id)
	)
	go


create table asignaIncidencias(
	Id_Tecnico int Foreign key (Id_Tecnico) references Tecnico (Id),
	Id_Incidencia int Foreign key (Id_Incidencia) references Incidencia (Id)
	primary key(Id_Tecnico,Id_Incidencia)
)
	go

 --Borrar tabla servicio
 --Campo para incidencias de detalles 
