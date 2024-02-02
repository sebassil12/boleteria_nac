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
    public class EstrenoLogica
    {
        private EstrenoDAO estrenoDAO = new EstrenoDAO();

        public void InsertarEstreno(Estreno estreno)
        {
            estrenoDAO.InsertarEstreno(estreno);
        }

        public DataTable ListarEstreno()
        {
            return estrenoDAO.ListarEstreno();
        }
        public Estreno ObtenerUnEstreno(int Id)
        {
            return estrenoDAO.ObtenerUnEstreno(Id);
        }
        public void ActualizarEstreno(Estreno estreno, int Id)
        {
            estrenoDAO.ActualizarEstreno(estreno, Id);
        }
        public void EliminarEstreno(int Id)
        {
            estrenoDAO.EliminarEstreno(Id);
        }
    }
}
