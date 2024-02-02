using boleteria_acceso_datos;
using boleteria_acceso_datos.bolteria_tablas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente_estreno.DAO
{
    public class ClienteEstrenoDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarClienteEstreno(ClienteEstreno nuevoClienteEstreno)
        {

            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into cliente_estreno(id_cliente,id_estreno) values (@id_cliente, @id_estreno)";
                ejecutarSql.Parameters.AddWithValue("@id_cliente", nuevoClienteEstreno.IdCliente);
                ejecutarSql.Parameters.AddWithValue("@id_estreno", nuevoClienteEstreno.IdEstreno);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar cliente_estreno: " + e.Message);
            }
        }

        public DataTable ListarClienteEstreno()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM cliente";
                transaccion = ejecutarSql.ExecuteReader();

                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar cliente_estreno: " + ex.Message);
            }
        }

        public DataTable BuscarClienteEstreno(string numeroCI)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "select * from cliente where ci= '" + numeroCI + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar cliente_estreno: " + ex.Message);
            }
        }

        public  ClienteEstreno ObtenerUnClienteEstreno(int Id)
        {

            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM cliente_estreno WHERE id_cliente_estreno = " + Id;
                transaccion = ejecutarSql.ExecuteReader();

                transaccion.Read();

                ClienteEstreno clienteEstreno = new ClienteEstreno();
                clienteEstreno.IdCliente = transaccion.GetInt32(0);
                clienteEstreno.IdEstreno = transaccion.GetInt32(1);
                

                transaccion.Close();
                conexion.CerrarConexion();

                return clienteEstreno;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el cliente estreno solicitado: " + ex.Message);
            }

        }
        public void ActualizarClienteEstreno(ClienteEstreno actualizarClienteEstreno, int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE cliente_estreno SET id_cliente = @id_cliente, " +
                "id_estreno = @id_estreno " +
                "WHERE id_cliente_estreno = @id_cliente_estreno";

                ejecutarSql.Parameters.AddWithValue("@nombre", actualizarClienteEstreno.IdCliente);
                ejecutarSql.Parameters.AddWithValue("@apellido", actualizarClienteEstreno.IdEstreno);
                ejecutarSql.Parameters.AddWithValue("@id_cliente_estreno", Id);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception("Error al actualizar cliente_estreno: " + e.Message);
            }
        }
        public void EliminarClienteEstreno(int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM cliente_estreno WHERE id_cliente_estreno = @id_cliente_estreno";
                ejecutarSql.Parameters.AddWithValue("@id_cliente_estreno", Id);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cliente_estreno: " + ex.Message);
            }
        }

    }
}
