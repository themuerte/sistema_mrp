CREATE SCHEMA prod;

create table prod.producto
(
	"idProducto" serial not null constraint producto_pk primary key,
	nombre text not null,
	descripcion text,
	inventario real not null,
	costo_unitario real not null,
	costo_pedir real,
	costo_mantenimiento real default 0,
	desviacion_demanda real,
	demanda_diaria real,
	probabilidad_demanda real,
	plazo_entrega_dias real,
	inventario_inicial real,
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
    dias_trabajados_por_anio real,
    costo_contratacion real,
    costo_subcontratacion real,
    costo_despido real,
    fuerza_laboral real

);

INSERT INTO prod.producto("idProducto", nombre, descripcion, inventario, costo_unitario, costo_pedir, costo_mantenimiento, desviacion_demanda, demanda_diaria, probabilidad_demanda, plazo_entrega_dias, inventario_inicial, horas_requeridas, stock_seguridad, costo_faltante, costo_hrs, costo_hrs_extras) VALUES ()

UPDATE prod.producto SET nombre = '' WHERE  "idProducto" = 0