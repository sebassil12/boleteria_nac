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
                    "values('" + nuevoCliente.Nombre + "' , '" + nuevoCliente.Apellido + "','" + nuevoCliente.Edad + "','" + nuevoCliente.Correo + "','" + nuevoCliente.CiRuc +
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
