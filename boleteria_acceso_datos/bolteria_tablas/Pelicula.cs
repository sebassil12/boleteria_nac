using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boleteria_acceso_datos.bolteria_tablas
{
    public class Pelicula
    {
        public int IdPelicula { get; set; }
        public string Nombre { get; set; }
        public TimeSpan Duracion { get; set; }
        public int Anio { get; set; }
        public string Clasificacion { get; set; }
        public int IdEncargado { get; set; }
        public int IdSala { get; set; }
    }
}
