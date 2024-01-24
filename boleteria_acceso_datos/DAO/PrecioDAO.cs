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
    public class PrecioDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;
        
        public void InsertarPrecio(Precio precio)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into precio(valor, fecha)" +
                    "values('" + precio.Valor + "','" + precio.Fecha +
                    ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }catch(Exception ex)
            {
                throw new Exception("Error al insertar precio: " + ex.Message);
            }
        }
        public DataTable ListarPrecio()
        {
            DataTable dt = new DataTable();
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "select * from precio";
                transaccion = ejecutarSql.ExecuteReader();

                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar precio: " + ex.Message);
            }

        }

        public DataTable BuscarPrecio(DateTime fecha)
        {
            DataTable dt = new DataTable();
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "select * from precio where fecha= '" + fecha + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar precio: " + ex.Message);
            }
        }

    }
}
