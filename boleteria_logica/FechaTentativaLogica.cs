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
    public class FechaTentativaLogica
    {
        private FechaTentativaDAO fechaTentativaDAO = new FechaTentativaDAO();

        public void InsertarFechaTentativa(FechaTentativa fechaTentativa)
        {
            fechaTentativaDAO.InsertarFechaTentativa(fechaTentativa);
  
        }
        public DataTable ListarFechaTentativa()
        {
            return fechaTentativaDAO.ListarFechaTentativa();
        }

        public void ActualizarFechaTentativa(FechaTentativa fechaTentativa, int Id)
        {
            fechaTentativaDAO.ActualizarFechaTentativa(fechaTentativa, Id);
        }

        public FechaTentativa ObtenerUnaFechaTentativa(int Id)
        {
            return fechaTentativaDAO.ObtenerUnaFechaTentativa(Id);
        }
        public void EliminarFechaTentativa(int Id)
        {
            fechaTentativaDAO.EliminarFechaTentativa(Id);
        }
    }
}
