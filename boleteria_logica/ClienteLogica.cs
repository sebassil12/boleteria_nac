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
  
    public class ClienteLogica { 

        private ClienteDAO clienteDAO = new ClienteDAO();
        
        public void InsertarCliente(Cliente cliente)
        {
            clienteDAO.InsertarCliente(cliente);
       
        }
        public DataTable ListarCliente()
        {
            return clienteDAO.ListarCliente();
        }

        public void ActualizarCliente(Cliente cliente, int Id)
        {
            clienteDAO.ActualizarCliente(cliente, Id);
        }

        public Cliente ObtenerUnCliente(int Id)
        {
            return clienteDAO.ObtenerUnCliente(Id);
        }

        public void EliminarCliente(int Id)
        {
            clienteDAO.EliminarCliente(Id);
        }
    }
}
