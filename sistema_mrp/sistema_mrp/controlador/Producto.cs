using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_mrp.controlador
{
    class Producto
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

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double PrecioActual { get => precioActual; set => precioActual = value; }
        public int CantidadInventario { get => cantidadInventario; set => cantidadInventario = value; }

        public static List<Producto> mostrarProductos()
        {
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand("SELECT * FROM mrp.producto", con);
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
         
    }
}
