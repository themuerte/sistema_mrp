using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_mrp.controlador
{
    public class PlanAgregado
    {
        int idPlanAgregado;
        string mes;
        double diasHabiles;

        public int IdPlanAgregado { get => idPlanAgregado; set => idPlanAgregado = value; }
        public string Mes { get => mes; set => mes = value; }
        public double DiasHabiles { get => diasHabiles; set => diasHabiles = value; }

        public PlanAgregado(int idPlanAgregado, string mes, double diasHabiles)
        {
            IdPlanAgregado = idPlanAgregado;
            Mes = mes;
            DiasHabiles = diasHabiles;
        }
        public PlanAgregado(string mes, double diasHabiles)
        {
            Mes = mes;
            DiasHabiles = diasHabiles;
        }
        public static List<PlanAgregado> getPlanAgregados()
        {

            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand("SELECT * FROM prod.plan_agregado ORDER BY id_plan_agregado;", con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<PlanAgregado> planAgregado = new List<PlanAgregado>();
            while (reader.Read())
            {
                int vidPlanAgregado= reader.GetInt32(0);
                string vMes = reader.GetString(1);
                double vDiasHabiles= reader.GetDouble(2);

                PlanAgregado plan = new PlanAgregado(vidPlanAgregado, vMes, vDiasHabiles);
                planAgregado.Add(plan);

            }
            con.Close();
            return planAgregado;
        }
        public static PlanAgregado GetPlanAgregadoById(int idPlanAgregado)
        {

            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand($"SELECT * FROM prod.plan_agregado WHERE id_plan_agregado = {idPlanAgregado} ORDER BY id_plan_agregado;", con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            PlanAgregado planAgregado = null;
            while (reader.Read())
            {
                int vidPlanAgregado = reader.GetInt32(0);
                string vMes = reader.GetString(1);
                double vDiasHabiles = reader.GetDouble(2);

                planAgregado = new PlanAgregado(vidPlanAgregado, vMes, vDiasHabiles);
            

            }
            con.Close();
            return planAgregado;
        }
        public int UpdateDiasHabiles(double diasHabiles)
        {
            this.DiasHabiles = diasHabiles;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.plan_agregado SET dias_habiles='{this.DiasHabiles}' WHERE id_plan_agregado={this.IdPlanAgregado}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

    }
}
