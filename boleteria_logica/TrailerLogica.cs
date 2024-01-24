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
    public class TrailerLogica
    {
        private TrailerDAO trailerDAO = new TrailerDAO();
        public int InsertarTrailer(Trailer trailer)
        {
            trailerDAO.InsertarTrailer(trailer);
            DataTable resultado = trailerDAO.BuscarTrailer(trailer.LinkTrailer);
            return int.Parse(resultado.Rows[0]["idTrailer"].ToString());
        }
        public DataTable ListarTrailer()
        {
            return trailerDAO.ListarTrailer();
        }
    }
}
