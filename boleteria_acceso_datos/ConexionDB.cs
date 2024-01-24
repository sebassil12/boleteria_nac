using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace boleteria_acceso_datos
{
    public class ConexionDB
    {
        private SqlConnection connection = new SqlConnection("Server=DESKTOP-9PS5PG2\\SQLEXPRESS; Database=db_cinema; Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public SqlConnection CerrarConexion()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }

    
}
