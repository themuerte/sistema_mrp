using Npgsql;
using System;
using System.Collections.Generic;

namespace sistema_mrp.controlador
{
    class Componente
    {
        int idComponente;
        string nombre;
        string descripcion;
        double precioUnit;
        double plazo;
        char tipoPlazo;
       

        public int IdComponente { get => idComponente; set => idComponente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double PrecioUnit { get => precioUnit; set => precioUnit = value; }
        public double Plazo { get => plazo; set => plazo = value; }
        public char TipoPlazo { get => tipoPlazo; set => tipoPlazo = value; }

        public Componente(int idComponente, string nombre, string descripcion, double precioUnit, double plazo, char tipoPlazo)
        {
            IdComponente = idComponente;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            PrecioUnit = precioUnit;
            Plazo = plazo;
            TipoPlazo = tipoPlazo;
        }
        public static List<Componente> GetComponentes()
        {
            NpgsqlConnection con = new Conexion().getConexion();
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM mrp.componente", con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<Componente> componentes = new List<Componente>();
            while (reader.Read())
            {
                Componente componente = new Componente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), Decimal.ToDouble(reader.GetDecimal(3)), reader.GetDouble(4), reader.GetChar(5));
                componentes.Add(componente);
            }
            con.Close();
            return componentes;
        }
        public static int AddComponente(Componente c)
        {
            NpgsqlConnection con = new Conexion().getConexion();
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO mrp.componente VALUES('{c.Nombre}','{c.Descripcion}',{c.PrecioUnit}::money, {c.Plazo}::real, {c.TipoPlazo})", con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public static int UpdateComponente(Componente c)
        {
            NpgsqlConnection con = new Conexion().getConexion();
            con.Open();
            NpgsqlCommand command = new NpgsqlCommand($"UPDATE mrp.componente SET nombre = '{c.Nombre}', descripcion = '{c.Descripcion}', precio_unit = {c.PrecioUnit}::money, plazo = {c.Plazo}::real, tipo_plazo = '{c.TipoPlazo}' WHERE id_componente = {c.IdComponente}", con);
            int res = command.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public static int DeleteComponente(Componente c)
        {
            NpgsqlConnection con = new Conexion().getConexion();
            con.Open();
            NpgsqlCommand command = new NpgsqlCommand($"DELETE  FROM mrp.componente WHERE id_componente = {c.IdComponente};", con);
            int res = command.ExecuteNonQuery();
            con.Close();
            return res;

        }
        public int UpdateNombre(string nombre)
        {
            return 0;
        }
        public int UpdateDescripcion(string descripcion)
        {
            return 0;
        }
        public int UpdatePrecio(double precio)
        {
            return 0;
        }
        public int UpdatePlazo(double plazo)
        {
            return 0;
        }
        public int UpdateTipoPlazo(char tipoPlazo)
        {
            return 0;
        }
    }
}
