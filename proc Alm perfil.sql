use ProyectoGestion
go
CREATE PROC CambiaPerfil
@Nombre varchar(30),
@ApellidoPat varchar(30),
@ApellidoMat varchar(30),
@correo varchar(40),
@Contraseña char(10),
@celular char(10)
as
if not exists (select * from Empleado where correo = @correo)
begin
	raiserror('El empleado no existe',16,1)
	return 1
end
begin tran 
	update Empleado set Nombre = @Nombre where correo = @correo

	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end

	update Empleado set Apellido_Paterno = @ApellidoPat where correo = @correo

	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end
	
	update Empleado set Apellido_Materno = @ApellidoMat where correo = @correo

	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end

	update Empleado set Celular = @celular where correo = @correo

	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end

	update Empleado set Contraseña = @contraseña where correo = @correo

	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end

	update Empleado set Correo = @correo where correo = @correo

	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end
commit tran
return 0

go

CREATE PROC AltaEmpleado
@Nombre varchar(30),
@ApellidoPat varchar(30),
@ApellidoMat varchar(30),
@Correo varchar(40),
@Contraseña char(10),
@Celular char(10),
@Puesto varchar(40),
@Departamento int,
@Especializacion varchar(30) null,
@Certificaciones varchar(200) null
as
begin tran
	insert into Empleado(Nombre,Apellido_Paterno,Apellido_Materno,Correo,Contraseña,Celular,Puesto,Departamento)
	values (@Nombre,@ApellidoPat,@ApellidoMat,@Correo,@Contraseña,@Celular,@Puesto,@Departamento)

	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end

	
	 
	If @Puesto = 'Tecnico'
	begin
		insert into Tecnico(Especializacion, Certificaciones, Id_Empleado)
		 values (@Especializacion,@Certificaciones,IDENT_CURRENT('Empleado'))
	end
commit tran
return 0

go


create proc AsignarIncidencias
@IdTecnico int,
@Idincidencia int,
@Tipo varchar(15),
@prioridad varchar (20),
@FechaInicio datetime 
as 
begin tran

	insert into asignaIncidencias(Id_Tecnico,Id_Incidencia)
	values(@IdTecnico, @Idincidencia)

	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end

	update Tecnico set Incidencias_Asignadas = (select count(*) from asignaIncidencias as a where a.Id_Tecnico = @IdTecnico)
	where Id = @IdTecnico

	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end

	
	update Incidencia set Fecha_Inicio = @FechaInicio,Tipo=@Tipo, Prioridad=@prioridad,Estatus='Asignada'
	where Id = @Idincidencia

	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end

commit tran
return 0



go

create proc CalificaIncidencia
@idincidencia int,
@calificacion char(1)
as 
begin tran
	update Incidencia set Calificacion = @calificacion
where Id = @idincidencia;
	
	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end

	
commit tran
return 0
go



create proc DetalleSolucion
@idincidencia int,
@Servicio varchar(100),
@Descripcion varchar(100),
@Cambio varchar(5),
@DetalleCambio varchar (160),
@fechaterminacion datetime,
@idEmpleado int
as 
begin tran
	update Incidencia set Servicio = @Servicio, Cambio=@Cambio, Detalles_de_cambio=@DetalleCambio
where Id = @idincidencia;
	
	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end

	update Incidencia set Estatus = 'Terminada',Fecha_Terminacion=@fechaterminacion
where Id = @idincidencia;
	
	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end

	update Incidencia set Estatus = 'Solicitud'
where Id = @idincidencia and cambio='Si';
	
	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end


	update Equipo set Descripcion = @Descripcion
where Id = (select id_equipo from Incidencia where id=@idincidencia);
	
	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end

	--jjj

	update Tecnico set Incidencias_Asignadas = (Incidencias_Asignadas - 1)
where Id_Empleado = @idEmpleado;

	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end

commit tran
return 0

go


create proc Solicitudes
@idincidencia int,
@Descripcion varchar(100),
@Solicitud varchar(5)

as 
begin tran
	update Incidencia set  Estatus='Terminada',Estatus_Cambio='Aceptada'
where Id = @idincidencia and @Solicitud='Si';
	
	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end

	update Incidencia set  Estatus='Terminada',Estatus_Cambio='Rechazada'
where Id = @idincidencia and @Solicitud='No';
	
	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end


	update Equipo set Descripcion = @Descripcion
where Id = (select id_equipo from Incidencia where id=@idincidencia);
	
	if @@ERROR <> 0
	begin 
		raiserror('ERROR',16,1)
	    return 1
	end
	
commit tran
return 0


go

create trigger CambiaEstatus
on [dbo].[Incidencia] after update
as
begin
declare @fecha datetime = '1999-09-13'
select @fecha = Fecha_Inicio from Incidencia

declare @Estatus varchar(20) = ''
select @Estatus = Estatus from Incidencia 

declare @Calificacion char(1) = ''
select @Calificacion = Calificacion from Incidencia

	if @fecha is not null and @Estatus = 'No asignada'
	begin
		update Incidencia set Estatus='Asignada';
	end

	if @Calificacion is not null and @Estatus = 'Asignada'
	begin 
		update Incidencia set Estatus = 'Completada';
	end
end

go

select *  from Empleado

select I.*,(select D.Nombre from Departamento D where D.Id=I.Id_Departamento),(select E.Nombre+' '+E.Apellido_Paterno+' '+E.Apellido_Materno from Empleado E where E.Id=I.Id_Empleado),(select (select ed.Nombre from Edificio ed where ed.Id = eq.Edificio) from Equipo eq where i.Id_Equipo = eq.Id),(select (select cu.Nombre from Cubiculo cu where cu.Id = eq2.Cubiculo) from Equipo eq2 where i.Id_Equipo = eq2.Id) from Incidencia I where I.Id in (select A.Id_Incidencia from asignaIncidencias A where A.Id_Tecnico=(select T.id from Tecnico T where T.Id_Empleado =19))