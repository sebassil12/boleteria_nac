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
        
        public int InsertarCliente(Cliente cliente)
        {
            clienteDAO.InsertarCliente(cliente);
            DataTable resultado = clienteDAO.BuscarCliente(cliente.CiRuc);
            return int.Parse(resultado.Rows[0]["idCliente"].ToString());
        }
        public DataTable ListarCliente()
        {
            return clienteDAO.ListarCliente();
        }
    }
}
