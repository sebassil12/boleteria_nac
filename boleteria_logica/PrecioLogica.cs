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
    public class PrecioLogica
    {
        private PrecioDAO precioDAO = new PrecioDAO();
        public int InsertarPrecio(Precio precio)
        {
            precioDAO.InsertarPrecio(precio);
            DataTable resultado = precioDAO.BuscarPrecio(precio.Fecha);
            return int.Parse(resultado.Rows[0]["idPrecio"].ToString());
        }
        public DataTable ListarPrecio()
        {
            return precioDAO.ListarPrecio();
        }
    }
}
