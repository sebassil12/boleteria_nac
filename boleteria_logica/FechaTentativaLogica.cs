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
    public class FechaTentativaLogica
    {
        private FechaTentativaDAO fechaTentativaDAO = new FechaTentativaDAO();

        public int InsertarFechaTentativa(FechaTentativa fechaTentativa)
        {
            fechaTentativaDAO.InsertarFechaTentativa(fechaTentativa);
            DataTable resultado = fechaTentativaDAO.BuscarFechaTentativa(fechaTentativa.Fecha);
            return int.Parse(resultado.Rows[0]["idFechaTentativa"].ToString());
        }
        public DataTable ListarFechaTentativa()
        {
            return fechaTentativaDAO.ListarFechaTentativa();
        }
    }
}
