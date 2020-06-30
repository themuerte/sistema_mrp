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
        double precioActual;
        int cantidadInventario;

        public Producto(int idProducto, string nombre, string descripcion, double precioActual, int cantidadInventario)
        {
            IdProducto = idProducto;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            PrecioActual = precioActual;
            CantidadInventario = cantidadInventario;
        }

        public Producto(string nombre, string descripcion, double precioActual, int cantidadInventario)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            PrecioActual = precioActual;
            CantidadInventario = cantidadInventario;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double PrecioActual { get => precioActual; set => precioActual = value; }
        public int CantidadInventario { get => cantidadInventario; set => cantidadInventario = value; }

        public static List<Producto> GetProductos()
        {
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand("SELECT * FROM mrp.producto ORDER BY id_producto;", con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<Producto> productos = new List<Producto>();
            while (reader.Read())
            {
                Producto producto = new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), Decimal.ToDouble(reader.GetDecimal(3)), reader.GetInt32(4));
                productos.Add(producto);
                
            }
            con.Close();
            return productos;
        }
        public static int AddProducto(Producto p)
        {
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand($"INSERT INTO mrp.producto(nombre, descripcion, precio_actual, cantidad_inventario) VALUES ('{p.Nombre}'::text,'{p.Descripcion}'::text,{p.PrecioActual}::money, {p.cantidadInventario});", con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public static int UpdateProducto(Producto p)
        {
            NpgsqlConnection con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand($"UPDATE mrp.producto SET nombre='{p.Nombre}', descripcion='{p.Descripcion}', precio_actual={p.precioActual}::money, cantidad_inventario={p.CantidadInventario} WHERE id_producto={p.IdProducto}", con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public static int DeleteProducto(Producto p)
        {
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand($"DELETE FROM mrp.producto WHERE id_producto={p.IdProducto}", con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public int UpdateNombre(string nombre)
        {
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand($"UPDATE mrp.producto SET nombre='{this.Nombre}' WHERE id_producto={this.IdProducto}", con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateDescripcion(string descripcion)
        {
            this.Descripcion = descripcion;
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand($"UPDATE mrp.producto SET descripcion='{this.Descripcion}' WHERE id_producto={this.IdProducto}",con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdatePrecio(double precio)
        {
            var con = new Conexion().getConexion();
            this.PrecioActual = precio;
            con.Open();
            var cmd = new NpgsqlCommand($"UPDATE mrp.producto SET precio_actual={this.PrecioActual}::money WHERE id_producto={this.IdProducto}",con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateInventario(int inventario)
        {
            this.CantidadInventario = inventario;
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand($"UPDATE mrp.producto SET cantidad_inventario='{this.CantidadInventario}' WHERE id_producto={this.IdProducto}",con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
    }
}
