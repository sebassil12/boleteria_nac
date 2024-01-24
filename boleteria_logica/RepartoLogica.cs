using boleteria_acceso_datos.bolteria_tablas;
using boleteria_acceso_datos.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boleteria_logica
{
    public class RepartoLogica
    {
        private RepartoDAO repartoDAO = new RepartoDAO();
        public int InsertarReparto(Reparto reparto)
        {
            repartoDAO.InsertarReparto(reparto);
            DataTable resultado = repartoDAO.BuscarReparto(reparto.Nombre);
            return int.Parse(resultado.Rows[0]["idReparto"].ToString());
        }
        public DataTable ListarReparto()
        {
            return repartoDAO.ListarReparto();
        }
    }
}
