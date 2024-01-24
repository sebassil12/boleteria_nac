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
    public class PeliculaLogica
    {
        private PeliculaDAO peliculaDAO = new PeliculaDAO();
        public int InsertarPelicula(Pelicula pelicula)
        {
            peliculaDAO.InsertarPelicula(pelicula);
            DataTable resultado = peliculaDAO.BuscarPelicula(pelicula.Nombre);
            return int.Parse(resultado.Rows[0]["idPelicula"].ToString());
        }
        public DataTable ListarPelicula()
        {
            return peliculaDAO.ListarPelicula();
        }
    }
}
