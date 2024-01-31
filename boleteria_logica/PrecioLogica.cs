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
        public void InsertarPrecio(Precio precio)
        {
            precioDAO.InsertarPrecio(precio);

        }
        public DataTable ListarPrecio()
        {
            return precioDAO.ListarPrecio();
        }

        public Precio ObtenerUnPrecio(int Id)
        {
            return precioDAO.ObtenerUnPrecio(Id);
        }
        public void ActualizarPrecio(Precio precio, int Id)
        {
            precioDAO.ActualizarPrecio(precio, Id);
        }
        public void EliminarPrecio(int Id)
        {
            precioDAO.EliminarPrecio(Id);
        }
    }
}
