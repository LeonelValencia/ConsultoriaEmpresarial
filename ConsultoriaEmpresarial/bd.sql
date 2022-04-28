use by3x4i2wvwk4hapeirae;
create database consultoria;
create table cliente(
	idC int auto_increment , 
    nomC varchar(40) not null, 
    telC varchar(13) not null, 
    dirEmp varchar(45) not null,
    nomEmp varchar(30) not null,
    emailC varchar(40) not null,
    userC varchar(30) not null,
    passwordC varchar(15) not null,
    primary key(idC));

create table empleado(
	id int auto_increment,
    tipo varchar(40) not null,
    usuario varchar(40),
    contraseña varchar(20),
    nombre varchar(40),
    tel varchar(20),
    fechaInicio varchar(60),
    primary key(id),
    CONSTRAINT cktipo CHECK (tipo IN ('administrador','tecnico','asesor','gerente','analista','cajero')));

create table ordensalida(
	idOT varchar(40) not null, 
    idOR int auto_increment, 
    nomC varchar(40) not null, 
    nomP varchar(13) not null, 
    Pago varchar(2) not null,
    primary key(idOR));

create table solConsultoria(
	idSC int auto_increment,
	idCl int not null,
    necesidad varchar(255) not null,
    cap1 varchar(60),
    presupuesto int,
    pagado boolean,
    idE int,
    estado varchar(50),
    primary key(idSC),
    INDEX fk_idc (idCl),
    FOREIGN KEY (idCl)
        REFERENCES cliente(idC)
        ON DELETE CASCADE,
	INDEX fk_ide (idE),
    FOREIGN KEY (idE)
        REFERENCES empleado(id)
        ON DELETE CASCADE);    

create table quejas(
	idQ int auto_increment,
    idCl int,
    idAS int not null,
    queja varchar(250),
    primary key(idQ),
	INDEX fk_idc (idCl),
    FOREIGN KEY (idCl)
        REFERENCES cliente(idC),
	INDEX fk_ida (idAS),
	FOREIGN KEY (idAS)
        REFERENCES empleado(id)    
    );
    
create table seguimiento(
	idS int auto_increment,
    idCl int not null,
    idAS int not null,
    seguimiento varchar(250),
    primary key(idS),
    FOREIGN KEY (idCl)
        REFERENCES cliente(idC),
	FOREIGN KEY (idAS)
        REFERENCES empleado(id)    
    );    

create table progrmarOT(
	idOT int auto_increment,
    materiales varchar(250),
    cliente varchar(100),
    empleado varchar(100),
    fechaProg varchar(200),
    analista varchar(100),
    primary key (idOt)
	);
insert into empleado(tipo,usuario,contraseña,nombre,tel,fechaInicio) values("administrador","empleado1","123","prueba1","141614",'2022-03-30');
insert into empleado(tipo,usuario,contraseña,nombre,tel,fechaInicio) values("tecnico","tecnico1","123","Rodrigo Manzano","11111111",'2022-04-20');
insert into empleado(tipo,usuario,contraseña,nombre,tel,fechaInicio) values("asesor","asesor3","123","Eduardo Najera","22222222",'2022-04-20');
insert into empleado(tipo,usuario,contraseña,nombre,tel,fechaInicio) values("gerente","gerente1","123","Encarnacion Navas","33333333",'2022-04-20');
insert into empleado(tipo,usuario,contraseña,nombre,tel,fechaInicio) values("analista","analista2","123","Dominga Espada","44444444",'2022-04-20');
insert into empleado(tipo,usuario,contraseña,nombre,tel,fechaInicio) values("analista","analista31","123","Estibaliz Hurtado","55555555",'2022-04-20');
insert into empleado(tipo,usuario,contraseña,nombre,tel,fechaInicio) values("cajero","cajero1","123","Ignacia Mayor","66666666",'2022-04-20');
insert into cliente(nomC,telC,dirEmp,nomEmp,emailC,userC,passwordC) values("Leonel", "551659","calle desconocida","VALENCIA","valencia@gmail.com","Leonel Valencia","root123");
insert into cliente(nomC,telC,dirEmp,nomEmp,emailC,userC,passwordC) values("Usuario2", "116142","calle 2","KJDJSFH","usuario1@gmail.com","usuario1","2");
insert into cliente(nomC,telC,dirEmp,nomEmp,emailC,userC,passwordC) values("Luca Vizcaino", "111642","calle Benito Juarez","KCinnamom Overdressed","usuario3@gmail.com","usuario3","1");
insert into cliente(nomC,telC,dirEmp,nomEmp,emailC,userC,passwordC) values("Jamal Vaca", "7341516","calle Emiliano Zapata","InstaClothes.","usuario4@gmail.com","usuario4","1");
insert into cliente(nomC,telC,dirEmp,nomEmp,emailC,userC,passwordC) values("Iria Taboada", "77716161","calle Los huajes","KYes We Fitness","usuario5@gmail.com","usuario5","1");
insert into cliente(nomC,telC,dirEmp,nomEmp,emailC,userC,passwordC) values("Matias Rodríguez", "356449","calle 20 de noviembre","Empresa RODRIGUEZ","usuario6@gmail.com","usuario6","1");
insert into solConsultoria(idCl,necesidad,cap1,pagado,estado) values(6,"Ausencia de trabajo en equipo","Lunes,31 de marzo de 2022",False,"En espera");
insert into quejas(idCl,idAS,queja) values(10,3,"Ejemplo de una queja del cliente");
insert into quejas(idCl,idAS,queja) values(6,3,"Ejemplo de una queja del cliente2");
insert into seguimiento(idCl,idAS,seguimiento) values(6,3,"Las herramientas utilizadas se estan ejecutando correctamente");
insert into progrmarOT(materiales,cliente,empleado,fechaProg,analista) values("programa de gestion fiscal","usuario1","prueba1","26 de abril de 2022","Perez");
select * from cliente;
select * from empleado;
select * from ordensalida;
select * from solConsultoria;
select * from quejas;
select * from seguimiento;
select * from progrmarOT;
update cliente set dirEmp="calle conocida",telC=1010101 where nomC="Leonel";
delete from cliente where nomC="Leonel";
select s.idsc,c.nomC,s.necesidad,s.cap1 from solConsultoria as s inner join cliente as c on s.idCl=c.idC;
update solConsultoria set idE=2 where idCl=6;	-- Asignar Asesor a cliente
select s.idsc,c.nomC,s.necesidad,s.idE from solConsultoria as s inner join cliente as c on s.idCl=c.idC;
select id,nombre from empleado where tipo="asesor";
select s.idCl from solConsultoria as s inner join cliente as c on s.idCl=c.idC where c.nomC="Leonel" group by idcl;
select id from empleado where nombre="Perez";
select queja from quejas where idCl=6;
select idSC from solConsultoria where idCl=6;
select idSC from solConsultoria where idCl=6 and pagado=False; -- idSol que el cliente no ha pagado
select * from solConsultoria where idSC=1; 
update solConsultoria set pagado=True where idSC=1;
select seguimiento from seguimiento where idCl=6;
select nomC from cliente;
select nombre from empleado;
select s.idsc,c.nomC,s.necesidad,s.cap1,s.estado,s.presupuesto,s.pagado,s.idE,e.nombre from solConsultoria as s inner join cliente as c inner join empleado as e on s.idCl=c.idC and s.idE=e.id where s.idCl=6;
select s.idsc,s.necesidad,s.cap1,s.estado,s.presupuesto,s.pagado,s.idE from solConsultoria as s inner join cliente as c on s.idCl=c.idC where s.idCl=6;
select nombre from empleado where id=2;
/* aws rds create-db-parameter-group ^
    --db-parameter-group-name allow-triggers ^
    --db-parameter-group-family mysql8.0 ^
    --description "parameter group allowing triggers"
drop trigger if exists Generar_codigo;
delimiter $
create trigger Generar_codigo before insert on solConsultoria for each row
begin
	declare siguiente_codigo int;
    set siguiente_codigo = (Select ifnull(max(convert(substring(idSC, 3), signed integer)), 0) from solConsultoria) + 1;
    set new.idSC = concat('S ', LPAD( siguiente_codigo, 3, '0'));
end $
*/