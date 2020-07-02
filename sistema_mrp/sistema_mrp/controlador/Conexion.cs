using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_mrp.controlador
{
    class Conexion
    {
        private string host;
        private string database;
        private string user;
        private string port;
        private string password;
        private string conexionString;

        public string Database { get => database; set => database = value; }
        public string User { get => user; set => user = value; }
        public string Port { get => port; set => port = value; }
        public string Password { get => password; set => password = value; }
        public string Host { get => host; set => host = value; }
        public string ConexionString { get => conexionString; set => conexionString = value; }

        public Conexion()
        {
            Host = "ec2-54-161-208-31.compute-1.amazonaws.com";
            Database = "dfolm9hqbsvhdf";
            User = "jdsifucfjvmdxh";
            Port = "5432";
            Password = "cf2094bfe814b2e301ca97945829d80b58fcb5841c5eb7b6529fab69f3370e5a";
            ConexionString = "Host=" + Host + ";Port=" + Port + ";Username=" + User + ";Password=" + Password + ";Database=" + Database + ";SSL Mode=Prefer;Trust Server Certificate=true";
        }

        public NpgsqlConnection getConexion()
        {
            return new NpgsqlConnection(conexionString);
        }
    }
}
