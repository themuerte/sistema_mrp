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
            Host = "ec2-52-72-65-76.compute-1.amazonaws.com";
            Database = "d15ljbcj7f07q1";
            User = "vxiievzjdxcafz";
            Port = "5432";
            Password = "541953b00714c02e021c29f7dc0e8fa7df08791c485ebb61943d4ba449f9290c";
            ConexionString = "Host=" + Host + ";Port=" + Port + ";Username=" + User + ";Password=" + Password + ";Database=" + Database + ";SSL Mode=Prefer;Trust Server Certificate=true";
        }

        public NpgsqlConnection getConexion()
        {
            return new NpgsqlConnection(conexionString);
        }
    }
}
