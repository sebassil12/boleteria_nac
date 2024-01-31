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
        public void InsertarReparto(Reparto reparto)
        {
            repartoDAO.InsertarReparto(reparto);
     
        }
        public DataTable ListarReparto()
        {
            return repartoDAO.ListarReparto();
        }
        public Reparto ObtenerUnReparto(int Id)
        {
            return repartoDAO.ObtenerUnReparto(Id);
        }
        public void ActualizarReparto(Reparto reparto, int Id)
        {
            repartoDAO.ActualizarReparto(reparto, Id);
        }
        public void EliminarReparto(int Id)
        {
            repartoDAO.EliminarReparto(Id);
        }
    }
}
