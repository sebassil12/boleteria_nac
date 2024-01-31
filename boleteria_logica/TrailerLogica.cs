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
        public void InsertarTrailer(Trailer trailer)
        {
            trailerDAO.InsertarTrailer(trailer);
            
        }
        public DataTable ListarTrailer()
        {
            return trailerDAO.ListarTrailer();
        }
        public Trailer ObtenerUnTrailer(int Id)
        {
            return trailerDAO.ObtenerUnTrailer(Id);
        }
        public void ActualizarTrailer(Trailer trailer, int Id)
        {
            trailerDAO.ActualizarTrailer(trailer, Id);
        }
        public void EliminarTrailer(int Id)
        {
            trailerDAO.EliminarTrailer(Id);
        }
    }
}
