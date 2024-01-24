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

        public int InsertarFormaPago(FormaPago formaPago)
        {
            formaPagoDAO.InsertarFormaPago(formaPago);
            DataTable resultado = formaPagoDAO.BuscarFormaPago(formaPago.Nombre);
            return int.Parse(resultado.Rows[0]["idFormaPago"].ToString());
        }
        public DataTable ListarFormaPago()
        {
            return formaPagoDAO.ListarFormaPago();
        }

    }
}
