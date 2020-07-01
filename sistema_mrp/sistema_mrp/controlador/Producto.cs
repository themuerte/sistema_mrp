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
        double inventario;
        double costoUnitario;
        double costoPedir;
        double costoMantenimiento;
        double desviacionDemamda;
        double demandaDiaria;
        double probabilidadDemanda;
        double plazoEntregaDias;
        double inventarioInicial;
        double horasRequeridas;
        double stockSeguridad;
        double costoFaltante;
        double costoHrs;
        double costoHrsExtras;

        public Producto(string nombre, double inventario, double costoUnitario)
        {
            Nombre = nombre;
            Inventario = inventario;
            CostoUnitario = costoUnitario;
        }
        public Producto()
        {

        }

        public Producto(int idProducto, string nombre, string descripcion, double inventario, double costoUnitario, double costoPedir, double costoMantenimiento, double desviacionDemamda, double demandaDiaria, double probabilidadDemanda, double plazoEntregaDias, double inventarioInicial, double horasRequeridas, double stockSeguridad, double costoFaltante, double costoHrs, double costoHrsExtras)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Descripcion = descripcion;
            Inventario = inventario;
            CostoUnitario = costoUnitario;
            CostoPedir = costoPedir;
            CostoMantenimiento = costoMantenimiento;
            DesviacionDemamda = desviacionDemamda;
            DemandaDiaria = demandaDiaria;
            ProbabilidadDemanda = probabilidadDemanda;
            PlazoEntregaDias = plazoEntregaDias;
            InventarioInicial = inventarioInicial;
            HorasRequeridas = horasRequeridas;
            StockSeguridad = stockSeguridad;
            CostoFaltante = costoFaltante;
            CostoHrs = costoHrs;
            CostoHrsExtras = costoHrsExtras;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Inventario { get => inventario; set => inventario = value; }
        public double CostoUnitario { get => costoUnitario; set => costoUnitario = value; }
        public double CostoPedir { get => costoPedir; set => costoPedir = value; }
        public double CostoMantenimiento { get => costoMantenimiento; set => costoMantenimiento = value; }
        public double DesviacionDemamda { get => desviacionDemamda; set => desviacionDemamda = value; }
        public double DemandaDiaria { get => demandaDiaria; set => demandaDiaria = value; }
        public double ProbabilidadDemanda { get => probabilidadDemanda; set => probabilidadDemanda = value; }
        public double PlazoEntregaDias { get => plazoEntregaDias; set => plazoEntregaDias = value; }
        public double InventarioInicial { get => inventarioInicial; set => inventarioInicial = value; }
        public double HorasRequeridas { get => horasRequeridas; set => horasRequeridas = value; }
        public double StockSeguridad { get => stockSeguridad; set => stockSeguridad = value; }
        public double CostoFaltante { get => costoFaltante; set => costoFaltante = value; }
        public double CostoHrs { get => costoHrs; set => costoHrs = value; }
        public double CostoHrsExtras { get => costoHrsExtras; set => costoHrsExtras = value; }

        public static List<Producto> GetProductos()
        {
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand("SELECT * FROM prod.producto ORDER BY idProducto;", con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<Producto> productos = new List<Producto>();
            while (reader.Read())
            {
                int    vidProducto                    = reader.GetInt32(0); 
                string vnombre                     = reader.GetString(1); 
                string vdescripcion                = reader.GetString(2);
                double vinventario                 = reader.GetDouble(3);
                double vcostoUnitario              = reader.GetDouble(4);
                double vcostoPedir                 = reader.GetDouble(5);
                double vcostoMantenimiento         = reader.GetDouble(6);
                double vdesviacionDemamda          = reader.GetDouble(7);
                double vdemandaDiaria              = reader.GetDouble(8);
                double vprobabilidadDemanda        = reader.GetDouble(9);
                double vplazoEntregaDias           = reader.GetDouble(10);
                double vinventarioInicial          = reader.GetDouble(11);
                double vhorasRequeridas            = reader.GetDouble(12);
                double vstockSeguridad             = reader.GetDouble(13);
                double vcostoFaltante              = reader.GetDouble(14);
                double vcostoHrs                   = reader.GetDouble(15);
                double vcostoHrsExtras             = reader.GetDouble(16);


                Producto producto = new Producto(vidProducto, vnombre, vdescripcion, vinventario, vcostoUnitario, vcostoPedir, vcostoMantenimiento, vdesviacionDemamda, vdemandaDiaria, vprobabilidadDemanda, vplazoEntregaDias, vinventarioInicial, vhorasRequeridas, vstockSeguridad, vcostoFaltante, vcostoHrs, vcostoHrsExtras);
                productos.Add(producto);
                
            }
            con.Close();
            return productos;
        }
        public static int AddProducto(Producto p)
        {
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"INSERT INTO prod.producto(nombre, descripcion, inventario, costo_unitario, costo_pedir, costo_mantenimiento, desviacion_demanda, demanda_diaria, probabilidad_demanda, plazo_entrega_dias, inventario_inicial, horas_requeridas, stock_seguridad, costo_faltante, costo_hrs, costo_hrs_extras) VALUES ('{p.Nombre}','{p.Descripcion}',{p.Inventario},{p.CostoUnitario},{p.CostoPedir},{p.CostoMantenimiento},{p.DesviacionDemamda},{p.DemandaDiaria},{p.ProbabilidadDemanda},{p.PlazoEntregaDias},{p.InventarioInicial},{p.horasRequeridas},{p.StockSeguridad},{p.CostoFaltante},{p.CostoHrs},{p.CostoHrsExtras});";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public static int AddProductoCorto(string nombre, double inventario, double costoUnitario)
        {
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"INSERT INTO prod.producto(nombre, inventario, costo_unitario) VALUES ({nombre}, {inventario}, {costoUnitario});";
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


    }
}
