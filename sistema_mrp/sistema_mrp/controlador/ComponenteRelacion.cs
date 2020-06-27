using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_mrp.controlador
{
    class ComponenteRelacion
    {
        int idComponenteRelacion;
        int idComponentePadre;
        int idComponenteHijo;

        public int IdComponenteRelacion { get => idComponenteRelacion; set => idComponenteRelacion = value; }
        public int IdComponentePadre { get => idComponentePadre; set => idComponentePadre = value; }
        public int IdComponenteHijo { get => idComponenteHijo; set => idComponenteHijo = value; }

        public ComponenteRelacion(int idComponenteRelacion, int idComponentePadre, int idComponenteHijo)
        {
            IdComponenteRelacion = idComponenteRelacion;
            IdComponentePadre = idComponentePadre;
            IdComponenteHijo = idComponenteHijo;
        }

        public ComponenteRelacion(int idComponentePadre, int idComponenteHijo)
        {
            IdComponentePadre = idComponentePadre;
            IdComponenteHijo = idComponenteHijo;
        }

        public static int AddComponenteRelacion(ComponenteRelacion cr)
        {
            var con = new Conexion().getConexion();
            con.Open();
            var cmd = new NpgsqlCommand($"INSERT INTO mrp.componente_relacion(id_componente_padre, id_componente_hijo) values ({cr.IdComponentePadre}, {cr.IdComponenteHijo})", con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
    }
}
