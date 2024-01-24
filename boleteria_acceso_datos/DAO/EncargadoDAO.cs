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
    public class EncargadoDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarEncargado(Encargado nuevoEncargado)
        {

            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into encargado(nombre,apellido)" +
                    "values('" + nuevoEncargado.nombre + "' , '" + nuevoEncargado.apellido+ 
                    ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar cliente: " + e.Message);
            }
        }
        public DataTable ListarEncargado()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM encargado";
                transaccion = ejecutarSql.ExecuteReader();

                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar cliente: " + ex.Message);
            }
        }

        public DataTable BuscarEncargado(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "select * from encargado where nombre= '" + nombre + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar encargado: " + ex.Message);
            }
        }


    }
}
