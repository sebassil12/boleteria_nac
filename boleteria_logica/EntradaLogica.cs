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
    public class EntradaLogica
    {
        private EntradaDAO entradaDAO = new EntradaDAO();

        public void InsertarEntrada(Entrada entrada)
        {
            entradaDAO.InsertarEntrada(entrada);
        }
        public DataTable ListarEntrada()
        {
            return entradaDAO.ListarEntrada();
        }
        public Entrada ObtenerUnEntrada(int Id) {
            return entradaDAO.ObtenerUnEntrada(Id);
        }
        public void ActualizarUnEntrada(Entrada entrada, int Id)
        {
            entradaDAO.ActualizarEntrada(entrada, Id);
        }
        public void EliminarEntrada(int Id)
        {
            entradaDAO.EliminarEntrada(Id);
        }
    }
}
