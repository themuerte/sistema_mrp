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
            Host = "ec2-54-165-36-134.compute-1.amazonaws.com";
            Database = "d1e322d932ac7t";
            User = "fjqmwedhnpxqla";
            Port = "5432";
            Password = "ed4da7351793e26c7450844e2a6d1c3a53a2f49ca92aee96e9b9622d7d3f8927";
            ConexionString = "Host=" + Host + ";Port=" + Port + ";Username=" + User + ";Password=" + Password + ";Database=" + Database + ";SSL Mode=Prefer;Trust Server Certificate=true";
        }

        public NpgsqlConnection getConexion()
        {
            return new NpgsqlConnection(conexionString);
        }
    }
}
