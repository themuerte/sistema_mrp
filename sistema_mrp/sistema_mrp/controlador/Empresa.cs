using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_mrp.controlador
{
    class Empresa
    {
        int idEmpresa;
        string nombre;
        double diasTrabajadosPorAnio;
        double costoContratacion;
        double costoSubContratacion;
        double costoDespido;
        double fuerzaLaboral;

        public Empresa()
        {
        }

        public Empresa(int idEmpresa, string nombre, double diasTrabajadosPorAnio, double costoContratacion, double costoSubContratacion, double costoDespido, double fuerzaLaboral)
        {
            IdEmpresa = idEmpresa;
            Nombre = nombre;
            DiasTrabajadosPorAnio = diasTrabajadosPorAnio;
            CostoContratacion = costoContratacion;
            CostoSubContratacion = costoSubContratacion;
            CostoDespido = costoDespido;
            FuerzaLaboral = fuerzaLaboral;
        }
        public Empresa(string nombre, double diasTrabajadosPorAnio, double costoTransaccion, double costoSubContratacion, double costoDespido, double fuerzaLaboral)
        {
            
            Nombre = nombre;
            DiasTrabajadosPorAnio = diasTrabajadosPorAnio;
            CostoContratacion = costoTransaccion;
            CostoSubContratacion = costoSubContratacion;
            CostoDespido = costoDespido;
            FuerzaLaboral = fuerzaLaboral;
        }

        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double DiasTrabajadosPorAnio { get => diasTrabajadosPorAnio; set => diasTrabajadosPorAnio = value; }
        public double CostoContratacion { get => costoContratacion; set => costoContratacion = value; }
        public double CostoSubContratacion { get => costoSubContratacion; set => costoSubContratacion = value; }
        public double CostoDespido { get => costoDespido; set => costoDespido = value; }
        public double FuerzaLaboral { get => fuerzaLaboral; set => fuerzaLaboral = value; }

        public static Empresa GetEmpresa()
        {
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand("SELECT * FROM  prod.empresa", con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            Empresa empresa = null;
            while (reader.Read())
            {
                int idEmpresa = reader.GetInt32(0);
                string nombre = reader.GetString(1);
                double diasTrabajadosPorAño = reader.GetDouble(2);
                double costoContratacion = reader.GetDouble(3);
                double costoSubContratacion = reader.GetDouble(4);
                double costoDespido = reader.GetDouble(5);
                double fuerzaLaboral = reader.GetDouble(6);
                empresa = new Empresa(idEmpresa, nombre, diasTrabajadosPorAño, costoContratacion, costoSubContratacion, costoDespido, fuerzaLaboral);

            }
            con.Close();
            return empresa;
        }
        public static int UpdateEmpresa(Empresa e)
        {
            
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.empresa set nombre = '{e.Nombre}', dias_trabajados_por_anio = {e.DiasTrabajadosPorAnio}, costo_contratacion = {e.CostoContratacion}, costo_subcontratacion = {e.costoSubContratacion}, costo_despido = {e.CostoDespido}, fuerza_laboral={e.FuerzaLaboral} wHERE id_empresa = {e.IdEmpresa} ;";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
            
        }

    }
}
