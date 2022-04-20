select * from Empleado


KILL  ProyectoGestion

select *from asignaIncidencias

select*from Tecnico

select * from Edificio where Id_Departamento=1

select e.Id,e.Equipo,e.Marca,e.Modelo,e.Descripcion,e.Años_Garantia,e.FechaCompra,e.Id_Empleado,d.Nombre,ED.Nombre,c.Nombre from Equipo e,Departamento d,Edificio ED,Cubiculo C where  e.Departamento=d.id and d.id=ED.Id_Departamento and ED.id=C.Id_Edificio

select * from asignaIncidencias

UPDATE Empleado set correo=1 ,Contraseña=1
where id=1

select *from Incidencia

select A.Id_Incidencia from asignaIncidencias A,Incidencia I where A.Id_Tecnico=(select T.id from Tecnico T where T.Id_Empleado =34) and A.Id_Incidencia=I.Id and I.Estatus!='Terminada'



select Descripcion from equipo where Id = (select id_equipo from Incidencia where id=2)
select A.Id_Incidencia from asignaIncidencias A where A.Id_Tecnico=(select T.id from Tecnico T where T.Id_Empleado =34)

select I.*,(select D.Nombre from Departamento D where D.Id=I.Id_Departamento),(select E.Nombre+' '+E.Apellido_Paterno+' '+E.Apellido_Materno from Empleado E where E.Id=I.Id_Empleado) from Incidencia I where I.Id in (select A.Id_Incidencia from asignaIncidencias A where A.Id_Tecnico=(select T.id from Tecnico T where T.Id_Empleado =35))


select id from incidencia where Calificacion is null and Estatus='Terminada' and Id_Empleado=1 

select I.*,(select D.Nombre from Departamento D where D.Id=I.Id_Departamento),(select E.Nombre+' '+E.Apellido_Paterno+' '+E.Apellido_Materno from Empleado E where E.Id=I.Id_Empleado) from Incidencia I where I.Id=(select A.Id_Incidencia from asignaIncidencias A where A.Id_Tecnico=(select T.id from Tecnico T where T.Id_Empleado =35));