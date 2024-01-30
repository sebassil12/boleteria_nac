using boleteria_acceso_datos.bolteria_tablas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boleteria_acceso_datos.DAO
{
    public class ClienteDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarCliente(Cliente nuevoCliente)
        {
            
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into cliente(nombre,apellido, edad, correo, ci_ruc)" +
                    "values('" + nuevoCliente.Nombre + "' , '" + nuevoCliente.Apellido + "','" + nuevoCliente.Edad + "','" + nuevoCliente.Correo + "','" + nuevoCliente.CiRuc + "')";
                    ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();  
            }catch(Exception e)
            {
                throw new Exception("Error al insertar cliente: " + e.Message);
            }
        }

        public DataTable ListarCliente()
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
            }catch(Exception ex)
            {
                throw new Exception("Error al listar cliente: " + ex.Message);
            }
        }

        public Cliente ObtenerUnCliente(int Id)
        {
          
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM cliente WHERE id_cliente = " + Id;
                transaccion = ejecutarSql.ExecuteReader();

                transaccion.Read();
                
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = transaccion.GetInt32(0);
                    cliente.Nombre = transaccion.GetString(1);
                    cliente.Apellido = transaccion.GetString(2);
                    cliente.Correo = transaccion.GetString(3);
                    cliente.CiRuc = transaccion.GetString(4);
                    cliente.Edad = transaccion.GetInt32(5);
                transaccion.Close();
                conexion.CerrarConexion();

                    return cliente;
                  
            }catch(Exception ex)
            {
                throw new Exception("Error al obtener el cliente solicitado: " + ex.Message);
            }

        }
        
        public void ActualizarCliente(Cliente actualizarCliente, int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE cliente SET nombre = @nombre, " +
                "apellido = @apellido, " +
                "edad = @edad, " +
                "correo = @correo, " +
                "ci_ruc = @ci_ruc " +
                "WHERE id_cliente = @id_cliente";

                ejecutarSql.Parameters.AddWithValue("@nombre", actualizarCliente.Nombre);
                ejecutarSql.Parameters.AddWithValue("@apellido", actualizarCliente.Apellido);
                ejecutarSql.Parameters.AddWithValue("@edad", actualizarCliente.Edad);
                ejecutarSql.Parameters.AddWithValue("@correo", actualizarCliente.Correo);
                ejecutarSql.Parameters.AddWithValue("@ci_ruc", actualizarCliente.CiRuc);
                ejecutarSql.Parameters.AddWithValue("@id_cliente", Id);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception("Error al actualizar cliente: " + e.Message);
            }
        }
        public void EliminarCliente(int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM cliente WHERE id_cliente = @id_cliente";
                ejecutarSql.Parameters.AddWithValue("@id_cliente", Id);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();

            }catch(Exception ex)
            {
                throw new Exception("Error al eliminar cliente: " + ex.Message);
            }
        }
        public DataTable BuscarCliente(string numeroCI)
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
            }catch(Exception ex)
            {
                throw new Exception("Error al listar cliente: " + ex.Message);
            }
        }
    }
}
