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
        public void InsertarPelicula(Pelicula pelicula)
        {
            peliculaDAO.InsertarPelicula(pelicula);

        }
        public DataTable ListarPelicula()
        {
            return peliculaDAO.ListarPelicula();
        }

        public Pelicula ObtenerUnaPelicula(int Id)
        {
            return peliculaDAO.ObtenerUnaPelicula(Id);
        }
        public void ActualizarPelicula(Pelicula pelicula, int Id)
        {
            peliculaDAO.ActualizarPelicula(pelicula, Id);
        }
        public void EliminarPelicula(int Id)
        {
            peliculaDAO.EliminarPelicula(Id);
        }
    }
}
