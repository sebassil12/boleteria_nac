using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boleteria_acceso_datos.bolteria_tablas
{
    public class DescripcionEntrada
    {
        public int idDescripcionEntrada { get; set;}
        public string descripcion { get; set;}
        public int cantidad { get; set; }
        public int codigo { get; set; }
        public int idPrecio { get; set; }
        public int idCliente { get; set; }


    }
}
