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
    public class FormaPagoLogica
    {
        private FormaPagoDAO formaPagoDAO = new FormaPagoDAO();

        public void InsertarFormaPago(FormaPago formaPago)
        {
            formaPagoDAO.InsertarFormaPago(formaPago);
        }
        public DataTable ListarFormaPago()
        {
            return formaPagoDAO.ListarFormaPago();
        }
        public void ActualizarFormaPago(FormaPago formaPago, int Id)
        {
            formaPagoDAO.ActualizarFormaPago(formaPago, Id);
        }
        public FormaPago ObtenerUnaFormaPago(int Id)
        {
            return formaPagoDAO.ObtenerUnaFormaPago(Id);
        }
        public void EliminarFormaPago(int Id)
        {
            formaPagoDAO.EliminarFormaPago(Id);
        }

    }
}
