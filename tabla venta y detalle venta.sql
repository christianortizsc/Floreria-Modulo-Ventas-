

CREATE TABLE detalle_venta (
    cantidad int,
    nombre varchar(50),
	precio_total decimal(8,2),
	id_producto int,
	id_venta int,

	FOREIGN KEY (id_producto) REFERENCES producto(id_producto),
	FOREIGN KEY (id_venta) REFERENCES venta(id_venta)
);

CREATE TABLE producto (
    id_producto int PRIMARY KEY,
    descripcion varchar(50) NOT NULL,
	tipo varchar(50) NOT NULL,
	stock int NOT NULL,
	precio decimal(8,2)
);

CREATE TABLE venta (
    id_venta int IDENTITY(1,1) PRIMARY KEY,
    fecha_venta datetime NOT NULL,
    nombre_envio varchar(50),
	direccion_envio varchar(100),
	hora_envio varchar(10),
	observaciones varchar(250),
	precio_total decimal(8,2),
	credito int,
	factura int,
	tipo_venta int,
	tipo_arreglo int, 
	id_cliente int,
	id_empleado int,
	id_producto int,
	id_evento int,
	FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente),
	FOREIGN KEY (id_empleado) REFERENCES empleado(id_empleado),
	FOREIGN KEY (id_producto) REFERENCES producto(id_producto),
	FOREIGN KEY (id_evento) REFERENCES evento(id_evento)
);


insert into producto (id_producto,descripcion,tipo,stock,precio) values ('1','rosa',0,0,25.50)
insert into producto (id_producto,descripcion,tipo,stock,precio) values ('2','tulipan',0,0,18.43)
insert into producto (id_producto,descripcion,tipo,stock,precio) values ('3','clavel',0,0,12.45)

