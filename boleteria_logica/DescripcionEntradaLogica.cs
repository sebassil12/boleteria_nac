using boleteria_acceso_datos.bolteria_tablas;
using descripcion_entrada.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boleteria_logica
{
    public class DescripcionEntradaLogica
    {
        private DescripcionEntradaDAO descripcionEntradaDAO = new DescripcionEntradaDAO();
        public void InsertarDescripcionEntrada(DescripcionEntrada descripcionEntrada)
        {
            descripcionEntradaDAO.InsertarDescripcionEntrada(descripcionEntrada);
        }
        public DataTable ListarDescripcionEntrada()
        {
            return descripcionEntradaDAO.ListarDescripcionEntrada();
        }
        public DescripcionEntrada ObtenerUnDescripcionEntrada(int Id)
        {
            return descripcionEntradaDAO.ObtenerUnDescripcionEntrada(Id);
        }
        public void ActualizarDescripcionEntrada(DescripcionEntrada descripcionEntrada, int Id)
        {
            descripcionEntradaDAO.ActualizarDescripcionEntrada(descripcionEntrada, Id);
        }
        public void EliminarDescripcionEntrada(int Id)
        {
            descripcionEntradaDAO.EliminarDescripcionEntrada(Id);
        }

    }
}
