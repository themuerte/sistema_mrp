CREATE SCHEMA prod;

create table prod.producto
(
	id_producto serial not null constraint producto_pk primary key,
	nombre text not null,--
	descripcion text,--
	inventario real,--
	costo_unitario real,--
	costo_pedir real,--
	costo_mantenimiento real default 0,--
	desviacion_demanda real,--
	demanda_diaria real,--
	periodo_revision real,--
	probabilidad_demanda real,--
	plazo_entrega_dias real,--
	inventario_inicial real, --
	horas_requeridas real,
	stock_seguridad real,
	costo_faltante real,
	costo_hrs real,
	costo_hrs_extras real
);

comment on column prod.producto.inventario is 'Unidades actuales guardadas en inventario.';

comment on column prod.producto.costo_unitario is 'Costo unitario por producto';

comment on column prod.producto.costo_pedir is 'Lo que me cuesta pedir una unidad del producto.';

comment on column prod.producto.costo_mantenimiento is 'Costo de mantenimiento unitario';

comment on column prod.producto.desviacion_demanda is 'Desviacion de la demanda en unidades';

comment on column prod.producto.demanda_diaria is 'probabilidad de la demanda diaria del producto';

comment on column prod.producto.probabilidad_demanda is 'Probabilidad de cumplir la demanda';

comment on column prod.producto.plazo_entrega_dias is 'Plazo de entrega en días';

comment on column prod.producto.inventario_inicial is 'Inventaria Inicial';

comment on column prod.producto.horas_requeridas is 'Horas requeridas para elaborar un producto';

comment on column prod.producto.stock_seguridad is 'Un dato calculado';

comment on column prod.producto.costo_faltante is 'costo que tengo que cubrir cuando me falta unidades por producir';

CREATE TABLE prod.empresa(
    id_empresa serial not null constraint empresa_pk primary key,
    nombre text not null,
    dias_trabajados_por_anio real,--
    costo_contratacion real,
    costo_subcontratacion real,
    costo_despido real,
    fuerza_laboral real

);

INSERT INTO prod.producto(id_producto, nombre, descripcion, inventario, costo_unitario, costo_pedir, costo_mantenimiento, desviacion_demanda, demanda_diaria, probabilidad_demanda, plazo_entrega_dias, inventario_inicial, horas_requeridas, stock_seguridad, costo_faltante, costo_hrs, costo_hrs_extras) VALUES ()

UPDATE prod.producto SET nombre = '' WHERE  id_producto = 0;

SELECT * FROM  prod.empresa;
SELECT * FROM prod.producto;

SELECT  id_producto, nombre, descripcion FROM prod.producto;

UPDATE prod.empresa set nombre = '', dias_trabajados_por_anio = 0, costo_contratacion = 0, costo_subcontratacion = 0, costo_despido = 0, fuerza_laboral=0 WHERE id_empresa = 0;

alter table prod.producto alter column descripcion set default '';

alter table prod.producto alter column inventario set default 0;

alter table prod.producto alter column costo_unitario set default 0;

alter table prod.producto alter column costo_pedir set default 0;

alter table prod.producto alter column desviacion_demanda set default 0;

alter table prod.producto alter column demanda_diaria set default 0;

alter table prod.producto alter column probabilidad_demanda set default 0;

alter table prod.producto alter column plazo_entrega_dias set default 0;

alter table prod.producto alter column inventario_inicial set default 0;

alter table prod.producto alter column horas_requeridas set default 0;

alter table prod.producto alter column stock_seguridad set default 0;

alter table prod.producto alter column costo_faltante set default 0;

alter table prod.producto alter column costo_hrs set default 0;

alter table prod.producto alter column costo_hrs_extras set default 0;

alter table prod.producto alter column periodo_revision set default 0;

INSERT INTO prod.empresa (nombre, dias_trabajados_por_anio, costo_contratacion, costo_subcontratacion, costo_despido, fuerza_laboral)
VALUES('Empresa el Don Jajas', 300, 250, 350, 150, 900);