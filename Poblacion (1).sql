use ProyectoGestion
go
insert into Departamento(Nombre)
values ('Energias Renovables'),
('Gestion'),
('Sistemas'),
('Industrial'),
('TICS'),
('Ambiental'),
('Bioquimica'),
('Mecanica'),
('Electricidad'),
('Mecatronica'),
('Control Escolar'),
('ExtraEscolares'),
('Electronica')

go
insert into Edificio(Nombre,Id_Departamento)
values ('CC',3),
('A',5),
('B',7),
('C',1),
('D',6),
('E',12),
('J',4),
('N',13),
('O',10),
('P',9),
('UP',8),
('UA',2)

go
insert into Cubiculo(Nombre,Id_Edificio)
values ('CCDM',1),
('CCBD',1),
('SA',2),
('EB01',3),
('EB02',3),
('EB03',3),
('EC01',4),
('EC02',4),
('EC03',4),
('ED01',5),
('ED02',5),
('ED03',5),
('EE01',6),
('EJ01',7),
('EJ02',7),
('EJ03',7),
('EN01',8),
('EN02',8),
('EN03',8),
('EO01',9),
('EO02',9),
('EO03',9),
('EP01',10),
('EP02',10),
('EP03',10),
('UP01',11),
('UP02',11),
('UP03',11),
('UA01',12),
('UA02',12),
('UA03',12)

go
exec AltaEmpleado 'Ramon','Bugarin','Castañeda','buga@gmail.com','buga3405','6677980867','Administrador',1,null,null
go
exec AltaEmpleado 'Jorge','Valles','Osuna','jorgie@gmail.com','jovaos45','6671520877','Usuario',3,null,null
go
exec AltaEmpleado 'Maria','Perez','Contreras','mari@gmail.com','marxd15486','6672543671','Usuario',4,null,null
go
exec AltaEmpleado 'Mercedez','Paez','Garcia','merci@hotmail.com','454sa12','6675341526','Administrador',8,null,null
go
exec AltaEmpleado 'Gabriel','Garcia','Boeta','gg@hotmail.com','d55552','6672863475','Usuario',10,null,null
go
exec AltaEmpleado 'Jose','Lopez','Ibarra','jose@hotmail.com','asd115','6671543368','Administrador',11,null,null
go
exec AltaEmpleado 'Mario','Castaños','Medina','Mario@gmail.com','marioverde','6673665248','Administrador',5,null,null
go
exec AltaEmpleado 'Marcelo','Aispuro','Perez','Marcelo@outlook.com','poaad565','6671554268','Administrador',7,null,null
go
exec AltaEmpleado 'Marcela','Navarro','Sanchez','mar_san@outlook.com','laa4f12','6674578562','Administrador',2,null,null
go
exec AltaEmpleado 'Pedro','Villa','Casas','peter@gmail.com','alld412','6672478896','Usuario',9,null,null
go
exec AltaEmpleado 'Jasiel','Ponce','Flores','elliot@hotmail.com','apd4422s','6671223569','Usuario',11,null,null
go
exec AltaEmpleado 'Eduardo','Ramos','Felix','edu@gmail.com','asjka215','6672236571','Usuario',7,null,null
go
exec AltaEmpleado 'Marco','Lopez','Garcia','marco415@gmail.com','qwq898','594484545','Tecnico',1,'Software','CCNA'
go
exec AltaEmpleado 'Marcos','Garcia','Salazar','marcos@gmail.com','gfd78415','5521457852','Tecnico',2,'Hardware','CCNA'
go
exec AltaEmpleado 'Francisco','Felix','Leon','frank@gmail.com','ddfdfg78','6687542496','Tecnico',3,'Software','Udemy sistemas'
go
exec AltaEmpleado 'Alejandro','Cisneros','Palazuelos','alejandro@gmail.com','dfs878','662145785','Tecnico',4,'Software','Udemy computo'
go
exec AltaEmpleado 'Alejandra','Sanchez','Vega','alejandra@gmail.com','tyfh484','667245102','Tecnico',5,'Software','CCNA 2'
go
exec AltaEmpleado 'Adan','Vazquez','Escobar','adan@gmail.com','sd541hg','667012453','Tecnico',6,'Hardware','Redes'
go
exec AltaEmpleado 'Froilan','Lares','Valenzuela','froi@gmail.com','asda565','6678998524','Tecnico',7,'Hardware','Udemy computo'
go
exec AltaEmpleado 'Victor','Hernandez','Tejada','victor@gmail.com','56s32d20','6671235569','Tecnico',8,'Hardware','Udemy redes'
go
exec AltaEmpleado 'Manuel','Carrillo','Aguilar','manuel45@gmail.com','sada54','6675482133','Tecnico',9,'Software','Google'
go
exec AltaEmpleado 'Felipe','Sainz','Llanes','felipe4@gmail.com','sad845s','6672458963','Tecnico',10,'software','Google'
go
exec AltaEmpleado 'Armando','Valdez','Morales','armando7@gmail.com','s655s11s','5658882233','Tecnico',11,'Software','Next_u sistemas'
go
exec AltaEmpleado 'Isabel','Moreno','Cambero','isabel8@gmail.com','s5d556s','6678963254','Tecnico',12,'Software','Next_u Computo'
go
exec AltaEmpleado 'Josue','Camacho','Marquez','josue6@gmail.com','dc2d1s2','6677985423','Tecnico',13,'Software','CCNA 3'
go
exec AltaEmpleado 'German','Murillo','Velaz','german5@gmail.com','wew89s5','6678442153','Usuario',4,null,null
go
exec AltaEmpleado 'Gerardo','Rusel','Inzunza','Gerardo1@gmail.com','gfg5454','6674521553','Usuario',3,null,null
go
exec AltaEmpleado 'Maribel','Iturrios','Ontiveros','maribel123@gmail.com','asda454','556221511','Usuario',7,null,null
go
exec AltaEmpleado 'Ana','Guzman','Montes','ana54@gmail.com','das4d5','6677981867','Usuario',6,null,null
go
exec AltaEmpleado 'Karen','Torres','Cruz','karen5@gmail.com','sdf54454','668754587','Usuario',10,null,null


go
insert into Equipo(Equipo,Marca,Modelo,Descripcion,Años_Garantia,FechaCompra,Id_Empleado,Departamento,Edificio,Cubiculo)
values ('PC01','HP','s123','1 monitor, fuente de poder h12, AMD R6, 6GB RAM, 1TB ROM',3,'11/29/2020',1,2,1,1),
('PC02','HP','s15132','1 monitor, fuente de poder h12, AMD R6, 6GB RAM, 1TB ROM',3,'11/30/2020',5,6,2,3),
('PC03','HP','s5451','1 monitor, fuente de poder h12, AMD R6, 6GB RAM, 1TB ROM',3,'11/30/2020',10,5,3,4),
('PC04','HP','s454','1 monitor, fuente de poder h12, AMD R6, 6GB RAM, 1TB ROM',3,'11/30/2020',20,4,4,7),
('PC05','HP','s4565','1 monitor, fuente de poder h12, AMD R6, 6GB RAM, 1TB ROM',3,'12/29/2020',21,5,5,10),
('PC06','HP','s48','1 monitor, fuente de poder h12, AMD R6, 6GB RAM, 1TB ROM',3,'12/19/2020',14,6,6,13),
('PC07','HP','s12','1 monitor, fuente de poder h12, AMD R6, 6GB RAM, 1TB ROM',3,'12/22/2020',16,3,7,14),
('IMP01','HP','s123','Tinta de color, impresion laser',3,'12/24/2020',17,1,8,17),
('TEL01','ModernPhone','s220','Telefono del departamento extraescolar',3,'11/29/2020',19,11,9,20),
('TEL02','ModernPhone','s221','Telefono del departamento energias renovables',3,'11/29/2020',8,1,10,21),
('TEL03','ModernPhone','s222','Telefono del departamento gestion',3,'11/29/2020',2,2,11,24),
('TEL04','ModernPhone','s223','Telegono del departamento sistemas',3,'11/29/2020',4,3,12,29),
('TEL05','ModernPhone','s224','Telefono del departamento tics',3,'11/29/2020',3,5,1,2),
('PROYECTOR01','HP','s123','Cable HDMI',3,'11/29/2020',8,12,2,3),
('AP01','Cisco','s30','Access point cisco',3,'12/11/2020',6,13,3,6),
('AP02','Cisco','s31','Access point cisco',3,'12/11/2020',7,9,4,9),
('AP03','Cisco','s32','Access point cisco',3,'12/11/2020',10,8,5,12),
('AP04','Cisco','s33','Access point cisco',3,'12/11/2020',2,12,6,13),
('AP05','Cisco','s35','Access point cisco',3,'12/11/2020',13,7,7,16),
('IMP02','HP','s1234','Tinta de blanco y negro, impresion laser',3,'12/24/2020',20,10,8,19)

go
select * from Empleado
go
select COUNT(*) from Equipo where Id_Empleado = 9
go
select * from Tecnico


select * from Incidencia
/*
insert into Incidencia(Descripcion,Fecha_Levantamiento)
values ('Se descompuso una computadora en el departamento de sistemas','01/24/2021'),
('Se descompuso una impresora en el departamento de extraescolares','01/29/2021'),
('Se descompuso un proyector en el departamento de tics','01/27/2021'),
('Se descompuso un telefono en el departamento de cc','02/01/2021'),
('Se descompuso un telefono en el departamento de control escolar','02/09/2021'),
('Se descompuso una computadora en el departamento de industrial','02/11/2021'),
('Se descompuso un access poin en el departamento de Ambiental','01/28/2021')
*/


drop database ProyectoGestion