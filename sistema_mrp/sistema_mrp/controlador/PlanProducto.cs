using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_mrp.controlador
{
    public class PlanProducto
    {
        int idPlanProducto;
        int idPlanAgregado;
        int idProducto;
        double demandaEstimada;

        public int IdPlanProducto { get => idPlanProducto; set => idPlanProducto = value; }
        public int IdPlanAgregado { get => idPlanAgregado; set => idPlanAgregado = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public double DemandaEstimada { get => demandaEstimada; set => demandaEstimada = value; }

        public PlanProducto(int idPlanProducto, int idPlanAgregado, int idProducto, double demandaEstimada)
        {
            IdPlanProducto = idPlanProducto;
            IdPlanAgregado = idPlanAgregado;
            IdProducto = idProducto;
            DemandaEstimada = demandaEstimada;
        }
        public PlanProducto(int idPlanAgregado, int idProducto, double demandaEstimada)
        {
            IdPlanAgregado = idPlanAgregado;
            IdProducto = idProducto;
            DemandaEstimada = demandaEstimada;
        }
        public static List<PlanProducto> GetPlanProductos()
        {

            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand("SELECT * FROM prod.plan_agregado ORDER BY id_plan_agregado;", con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<PlanProducto> planAgregado = new List<PlanProducto>();
            while (reader.Read())
            {
                int vidPlanProducto = reader.GetInt32(0);
                int vidPlanAgregado= reader.GetInt32(1);
                int vidProducto = reader.GetInt32(2);
                double vDemandaEstimada= reader.GetDouble(3);

                PlanProducto plan = new PlanProducto(vidPlanProducto, vidPlanAgregado, vidProducto, vDemandaEstimada);
                
                planAgregado.Add(plan);

            }
            con.Close();
            return planAgregado;
        }
        public static List<PlanProducto> GetPlanProductosByProducto(int idProdcto)
        {

            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand($"SELECT * FROM prod.plan_producto WHERE id_producto={idProdcto} ORDER BY id_plan_agregado;", con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<PlanProducto> planAgregado = new List<PlanProducto>();
            while (reader.Read())
            {
                int vidPlanProducto = reader.GetInt32(0);
                int vidPlanAgregado = reader.GetInt32(1);
                int vidProducto = reader.GetInt32(2);
                double vDemandaEstimada = reader.GetDouble(3);

                PlanProducto plan = new PlanProducto(vidPlanProducto, vidPlanAgregado, vidProducto, vDemandaEstimada);

                planAgregado.Add(plan);

            }
            con.Close();
            return planAgregado;
        }
        public static double [] GetDemandaEstimadaByProducto(int idProducto)
        {
            double[] demanda = new double[12];
            List<PlanProducto> planAgregado = PlanProducto.GetPlanProductosByProducto(idProducto);
            for (int i = 0; i < demanda.Length; i++)
            {
                demanda[i] = planAgregado[i].demandaEstimada;
            }
            return demanda;
        }
        public static PlanProducto GetPlanProductosById(int idPlanProducto)
        {

            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand($"SELECT * FROM prod.plan_producto WHERE id_plan_producto={idPlanProducto};", con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            PlanProducto plan = null;
            while (reader.Read())
            {
                int vidPlanProducto = reader.GetInt32(0);
                int vidPlanAgregado = reader.GetInt32(1);
                int vidProducto = reader.GetInt32(2);
                double vDemandaEstimada = reader.GetDouble(3);

                 plan= new PlanProducto(vidPlanProducto, vidPlanAgregado, vidProducto, vDemandaEstimada);

                

            }
            con.Close();
            return plan;
        }
        public static int GenerarDemandaDefault(int idProducto)
        {
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"INSERT INTO prod.plan_producto(id_plan_agregado, id_producto,  demanda_estimada) values  (1, {idProducto},100), (2, {idProducto},100), (3, {idProducto},100), (4, {idProducto},100), (5, {idProducto},100), (6, {idProducto},100), (7, {idProducto},100), (8, {idProducto},100), (9, {idProducto},100), (10, {idProducto},100), (11, {idProducto},100), (12, {idProducto},100);";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int UpdateDemanda(double demanda)
        {
            this.DemandaEstimada = demanda;
            var con = new Conexion().getConexion();
            con.Open();
            string consulta = $"UPDATE prod.plan_producto set demanda_estimada = {this.DemandaEstimada} where id_plan_producto = {this.IdPlanProducto}";
            var cmd = new NpgsqlCommand(consulta, con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
    }
}
