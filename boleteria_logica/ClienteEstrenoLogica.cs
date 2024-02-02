using boleteria_acceso_datos.bolteria_tablas;
using cliente_estreno.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boleteria_logica
{
    public class ClienteEstrenoLogica
    {
        private ClienteEstrenoDAO clienteEstrenoDAO = new ClienteEstrenoDAO(); 

        public void InsertarClienteEstreno(ClienteEstreno clienteEstreno)
        {
            clienteEstrenoDAO.InsertarClienteEstreno(clienteEstreno);
        }

        public DataTable ListarClienteEstreno()
        {
            return clienteEstrenoDAO.ListarClienteEstreno();
        }
        public ClienteEstreno ObtenerUnClienteEstreno(int Id)
        {
            return clienteEstrenoDAO.ObtenerUnClienteEstreno(Id);
        }
        public void ActualizarClienteEstreno(ClienteEstreno clienteEstreno, int Id)
        {
            clienteEstrenoDAO.ActualizarClienteEstreno(clienteEstreno, Id);
        }
        public void EliminarClienteEstreno(int Id) {
            clienteEstrenoDAO.EliminarClienteEstreno( Id);
        }
    }
}
