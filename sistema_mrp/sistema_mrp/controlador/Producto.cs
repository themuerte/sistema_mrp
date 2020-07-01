using Npgsql;
using System;
using System.Collections.Generic;

namespace sistema_mrp.controlador
{
    public class Producto
    {
        int idProducto;
        string nombre;
        string descripcion;
        double inventario, costoUnitario, costoPedir,costoMantenimiento,desviacionDemanda, demandaDiaria, probabilidadDemanda, plazoEntregaDias, inventarioInicial, horasRequeridas, stockSeguridad, costoFaltante, costoHrs, costoHrsExtras, periodoRevision;

        public Producto(string nombre, double inventario, double costoUnitario)
        {
            Nombre = nombre;
            Inventario = inventario;
            CostoUnitario = costoUnitario;
        }
        public Producto()
        {

        }

        public Producto(int idProducto, string nombre, string descripcion, double inventario, double costoUnitario, double costoPedir, double costoMantenimiento, double desviacionDemanda, double demandaDiaria, double probabilidadDemanda, double plazoEntregaDias, double inventarioInicial, double horasRequeridas, double stockSeguridad, double costoFaltante, double costoHrs, double costoHrsExtras, double periodoRevision)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Descripcion = descripcion;
            Inventario = inventario;
            CostoUnitario = costoUnitario;
            CostoPedir = costoPedir;
            CostoMantenimiento = costoMantenimiento;
            DesviacionDemanda = desviacionDemanda;
            DemandaDiaria = demandaDiaria;
            ProbabilidadDemanda = probabilidadDemanda;
            PlazoEntregaDias = plazoEntregaDias;
            InventarioInicial = inventarioInicial;
            HorasRequeridas = horasRequeridas;
            StockSeguridad = stockSeguridad;
            CostoFaltante = costoFaltante;
            CostoHrs = costoHrs;
            CostoHrsExtras = costoHrsExtras;
            PeriodoRevision = periodoRevision;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Inventario { get => inventario; set => inventario = value; }
        public double CostoUnitario { get => costoUnitario; set => costoUnitario = value; }
        public double CostoPedir { get => costoPedir; set => costoPedir = value; }
        public double CostoMantenimiento { get => costoMantenimiento; set => costoMantenimiento = value; }
        public double DesviacionDemanda { get => desviacionDemanda; set => desviacionDemanda = value; }
        public double DemandaDiaria { get => demandaDiaria; set => demandaDiaria = value; }
        public double ProbabilidadDemanda { get => probabilidadDemanda; set => probabilidadDemanda = value; }
        public double PlazoEntregaDias { get => plazoEntregaDias; set => plazoEntregaDias = value; }
        public double InventarioInicial { get => inventarioInicial; set => inventarioInicial = value; }
        public double HorasRequeridas { get => horasRequeridas; set => horasRequeridas = value; }
        public double StockSeguridad { get => stockSeguridad; set => stockSeguridad = value; }
        public double CostoFaltante { get => costoFaltante; set => costoFaltante = value; }
        public double CostoHrs { get => costoHrs; set => costoHrs = value; }
        public double CostoHrsExtras { get => costoHrsExtras; set => costoHrsExtras = value; }
        public double PeriodoRevision { get => periodoRevision; set => periodoRevision = value; }

        public static List<Producto> GetProductos()
        {
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = "SELECT * FROM prod.producto ORDER BY id_producto;";
            var cmd = new NpgsqlCommand(consulta, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<Producto> productos = new List<Producto>();
            while (reader.Read())
            {
                int vidProducto = reader.GetInt32(0); 
                string vnombre = reader.GetString(1); 
                string vdescripcion = reader.GetString(2);
                double vinventario = reader.GetDouble(3);
                double vcostoUnitario = reader.GetDouble(4);
                double vcostoPedir = reader.GetDouble(5);
                double vcostoMantenimiento = reader.GetDouble(6);
                double vdesviacionDemanda = reader.GetDouble(7);
                double vdemandaDiaria = reader.GetDouble(8);
                double vprobabilidadDemanda = reader.GetDouble(9);
                double vplazoEntregaDias = reader.GetDouble(10);
                double vinventarioInicial = reader.GetDouble(11);
                double vhorasRequeridas = reader.GetDouble(12);
                double vstockSeguridad = reader.GetDouble(13);
                double vcostoFaltante = reader.GetDouble(14);
                double vcostoHrs = reader.GetDouble(15);
                double vcostoHrsExtras= reader.GetDouble(16);
                double vperiodoRevision = reader.GetDouble(17);

                Producto producto = new Producto(vidProducto, vnombre, vdescripcion, vinventario, vcostoUnitario, vcostoPedir, vcostoMantenimiento, vdesviacionDemanda, vdemandaDiaria, vprobabilidadDemanda, vplazoEntregaDias, vinventarioInicial, vhorasRequeridas, vstockSeguridad, vcostoFaltante, vcostoHrs, vcostoHrsExtras, vperiodoRevision);
                productos.Add(producto);
                
            }


            con.Close();
            return productos;
        }

        public bool isValid()
        {
                return true;
        }

        public static List<Object[]> GetProductosCorto()
        {
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand("SELECT  id_producto, nombre, descripcion FROM prod.producto ORDER BY id_producto;", con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<Object[]> productos = new List<Object[]>();
            while (reader.Read())
            {
                int vidProducto = reader.GetInt32(0);
                string vnombre = reader.GetString(1);
                string vdescripcion = reader.GetString(2);

                Object[] fila = { vidProducto, vnombre, vdescripcion};
              
                productos.Add(fila);

            }
            con.Close();
            return productos;
        }
        public static Producto GetProductoById(int idProducto)
        {
            var con = new Conexion().getConexion();
            con.Open();
            Producto prod = null;
            string consulta = $"SELECT * FROM prod.producto WHERE id_producto = {idProducto};";
            var cmd = new NpgsqlCommand(consulta, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<Producto> productos = new List<Producto>();
            while (reader.Read())
            {
                int vidProducto = reader.GetInt32(0);
                string vnombre = reader.GetString(1);
                string vdescripcion = reader.GetString(2);
                double vinventario = reader.GetDouble(3);
                double vcostoUnitario = reader.GetDouble(4);
                double vcostoPedir = reader.GetDouble(5);
                double vcostoMantenimiento = reader.GetDouble(6);
                double vdesviacionDemanda = reader.GetDouble(7);
                double vdemandaDiaria = reader.GetDouble(8);
                double vprobabilidadDemanda = reader.GetDouble(9);
                double vplazoEntregaDias = reader.GetDouble(10);
                double vinventarioInicial = reader.GetDouble(11);
                double vhorasRequeridas = reader.GetDouble(12);
                double vstockSeguridad = reader.GetDouble(13);
                double vcostoFaltante = reader.GetDouble(14);
                double vcostoHrs = reader.GetDouble(15);
                double vcostoHrsExtras = reader.GetDouble(16);
                double vperiodoRevision = reader.GetDouble(17);

                prod = new Producto(vidProducto, vnombre, vdescripcion, vinventario, vcostoUnitario, vcostoPedir, vcostoMantenimiento, vdesviacionDemanda, vdemandaDiaria, vprobabilidadDemanda, vplazoEntregaDias, vinventarioInicial, vhorasRequeridas, vstockSeguridad, vcostoFaltante, vcostoHrs, vcostoHrsExtras, vperiodoRevision);
                

            }
            con.Close();
            return prod;
        }

        

        public static int AddProducto(Producto p)
        {
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"INSERT INTO prod.producto(nombre, descripcion, inventario, costo_unitario, costo_pedir, costo_mantenimiento, desviacion_demanda, demanda_diaria, probabilidad_demanda, plazo_entrega_dias, inventario_inicial, horas_requeridas, stock_seguridad, costo_faltante, costo_hrs, costo_hrs_extras) VALUES ('{p.Nombre}','{p.Descripcion}',{p.Inventario},{p.CostoUnitario},{p.CostoPedir},{p.CostoMantenimiento},{p.DesviacionDemanda},{p.DemandaDiaria},{p.ProbabilidadDemanda},{p.PlazoEntregaDias},{p.InventarioInicial},{p.horasRequeridas},{p.StockSeguridad},{p.CostoFaltante},{p.CostoHrs},{p.CostoHrsExtras});";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public static int AddProductoCorto(string nombre, string descripcion)
        {
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"INSERT INTO prod.producto(nombre, descripcion) VALUES ('{nombre}', '{descripcion}');";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        
        public static int DeleteProducto(int idProducto)
        {
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand($"DELETE FROM prod.producto WHERE id_producto={idProducto}", con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public int UpdateNombre(string nombre)
        {
            this.Nombre = nombre;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET nombre ='{this.Nombre}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateDescripcion(string descripcion)
        {
            this.Descripcion = descripcion;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET descripcion ='{this.Descripcion}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateInventario(double inventario)
        {
            this.Inventario = inventario;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET inventario ='{this.Inventario}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateCostoUnitario(double costo_unitario)
        {
            this.CostoUnitario= costo_unitario;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET costo_unitario ='{this.CostoUnitario}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateCostoPedir(double costo_pedir)
        {
            this.CostoPedir = costo_pedir;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET costo_pedir ='{this.CostoPedir}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateCostoMantenimiento(double costo_mantenimiento)
        {
            this.CostoMantenimiento = costo_mantenimiento;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET costo_mantenimiento ='{this.CostoMantenimiento}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateDesviacionDemanda(double desviacion_demanda)
        {
            this.DesviacionDemanda = desviacion_demanda;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET desviacion_demanda ='{this.DesviacionDemanda}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateDemandaDiaria(double demanda_diaria)
        {
            this.DemandaDiaria = demanda_diaria;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET demanda_diaria ='{this.DemandaDiaria}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateProbabilidadDemanda(double probabilidad_demanda)
        {
            this.ProbabilidadDemanda = probabilidad_demanda;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET probabilidad_demanda ='{this.ProbabilidadDemanda}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdatePlazoEntregaDias(double plazo_entrega_dias)
        {
            this.PlazoEntregaDias = plazo_entrega_dias;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET plazo_entrega_dias ='{this.PlazoEntregaDias}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateInventarioInicial(double inventario_inicial)
        {
            this.InventarioInicial = inventario_inicial;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET inventario_inicial ='{this.InventarioInicial}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateHorasRequeridas(double horas_requeridas)
        {
            this.HorasRequeridas = horas_requeridas;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET horas_requeridas ='{this.HorasRequeridas}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateStockSeguridad(double stock_seguridad)
        {
            this.StockSeguridad = stock_seguridad;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET stock_seguridad ='{this.StockSeguridad}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateCostoFaltante(double costo_faltante)
        {
            this.CostoFaltante = costo_faltante;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET costo_faltante ='{this.CostoFaltante}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public int UpdateCostoHrs(double costo_hrs)
        {
            this.CostoHrs = costo_hrs;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET costo_hrs ='{this.CostoHrs}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateCostoHrsEx(double costo_hrs_extras)
        {
            this.CostoHrsExtras = costo_hrs_extras;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET costo_hrs_extras ='{this.CostoHrsExtras}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdatePeriodoRevision(double periodo_revision)
        {
            this.PeriodoRevision = periodo_revision;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.producto SET periodo_revision ='{periodo_revision}' WHERE id_producto={this.IdProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
    }
}
