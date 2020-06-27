using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace sistema_mrp.controlador
{
    class ProductoComponente
    {
        int idProductoComponente;
        int idProducto;
        int idComponente;
        int unidadesNecesarias;
        int margenSeguridad;

        public ProductoComponente(int idProductoComponente, int idProducto, int idComponente, int unidadesNecesarias, int margenSeguridad)
        {
            IdProductoComponente = idProductoComponente;
            IdProducto = idProducto;
            IdComponente = idComponente;
            UnidadesNecesarias = unidadesNecesarias;
            MargenSeguridad = margenSeguridad;
        }

        public ProductoComponente(int idProducto, int idComponente, int unidadesNecesarias, int margenSeguridad)
        {
            IdProducto = idProducto;
            IdComponente = idComponente;
            UnidadesNecesarias = unidadesNecesarias;
            MargenSeguridad = margenSeguridad;
        }

        public int IdProductoComponente { get => idProductoComponente; set => idProductoComponente = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdComponente { get => idComponente; set => idComponente = value; }
        public int UnidadesNecesarias { get => unidadesNecesarias; set => unidadesNecesarias = value; }
        public int MargenSeguridad { get => margenSeguridad; set => margenSeguridad = value; }

        public static List<ProductoComponente> GetProductoComponentes()
        {
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand("SELECT * FROM mrp.producto_componente", con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<ProductoComponente> productoComponentes = new List<ProductoComponente>();
            while (reader.Read())
            {
                ProductoComponente pc = new ProductoComponente(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                productoComponentes.Add(pc);

            }
            con.Close();
            return productoComponentes;
        }
        public static int AddProductoComponente(ProductoComponente pc)
        {
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand($"INSERT INTO mrp.producto_componente(id_producto, id_componente, unidades_necesarias, margen_seguridad) VALUES ({pc.idProducto},{pc.IdComponente},{pc.UnidadesNecesarias},{pc.MargenSeguridad})", con);

            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public static int UpdateProductoComponente(ProductoComponente pc)
        {
            NpgsqlConnection connection = new Conexion().getConexion();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand($"UPDATE  mrp.producto_componente SET id_producto = {pc.IdProducto}, id_componente = {pc.IdComponente},unidades_necesarias= {pc.UnidadesNecesarias}, margen_seguridad ={pc.UnidadesNecesarias} WHERE id_producto_componente = {pc.IdProductoComponente};", connection);
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res;
        }

        public static int DeleteProductoComponente(ProductoComponente pc)
        {
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand($"DELETE FROM mrp.producto_componente where id_producto_componente = {pc.IdProductoComponente}", con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public int UpdateUnidadesNecesarias(int cantidadNecesarias)
        {
            NpgsqlConnection connection = new Conexion().getConexion();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand($"UPDATE  mrp.producto_componente SET unidades_necesarias= {cantidadNecesarias} WHERE id_producto_componente = {this.IdProductoComponente};", connection);
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res;
        }
        public int UpdateMargenSeguridad(int margenSeguridad)
        {
            NpgsqlConnection connection = new Conexion().getConexion();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand($"UPDATE  mrp.producto_componente SET margen_seguridad={margenSeguridad} WHERE id_producto_componente = {this.IdProductoComponente};", connection);
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res;
        }
    }
}
