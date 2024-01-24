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
    public class FechaTentativaDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarFechaTentativa(FechaTentativa fechaTentativa)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into fecha_tentativa(fecha) values" +
                    "('" + fechaTentativa.Fecha + ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();

            }catch(Exception ex)
            {
                throw new Exception("Error al insertar fecha tentativa: " + ex.Message);
            }
        }

        public DataTable ListarFechaTentativa()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "select * from fecha_tentativa";
                transaccion = ejecutarSql.ExecuteReader();

                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;

            }catch(Exception ex)
            {
                throw new Exception("Error al listar fecha tentativa: " + ex.Message);
            }
        }

        public DataTable BuscarFechaTentativa(DateTime fecha)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "select * from encargado where fecha= '" + fecha + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar encargado: " + ex.Message);
            }
        }

    }
}
