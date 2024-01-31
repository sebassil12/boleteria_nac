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
    public class SalaLogica
    {
        private SalaDAO salaDAO = new SalaDAO();
        public void InsertarSala(Sala sala)
        {
            salaDAO.InsertarSala(sala);
            
        }
        public DataTable ListarSala()
        {
            return salaDAO.ListarSala();
        }

        public Sala ObtenerUnaSala(int Id)
        {
            return salaDAO.ObtenerUnaSala(Id);
        }
        public void ActualizarSala(Sala sala, int Id)
        {
            salaDAO.ActualizarSala(sala, Id);
        }
        public void EliminarSala(int Id)
        {
            salaDAO.EliminarSala(Id);
        }
    }
}
