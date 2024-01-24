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
        public int InsertarSala(Sala sala)
        {
            salaDAO.InsertarSala(sala);
            DataTable resultado = salaDAO.BuscarSala(sala.NumeroSala);
            return int.Parse(resultado.Rows[0]["idSala"].ToString());
        }
        public DataTable ListarSala()
        {
            return salaDAO.ListarSala();
        }
    }
}
