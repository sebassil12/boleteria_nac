using boleteria_acceso_datos.bolteria_tablas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boleteria_acceso_datos.DAO
{
    public class RepartoDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarReparto(Reparto reparto)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into reparto(nombre, apellido, id_estreno)" +
                    "values('" + reparto.Nombre + "','" + reparto.Apellido + "','"+reparto.IdEstreno+
                    ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar reparto: " + ex.Message);
            }
        }
        public DataTable ListarReparto()
        {
            DataTable dt = new DataTable();
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "select * from reparto";
                transaccion = ejecutarSql.ExecuteReader();

                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar reparto: " + ex.Message);
            }

        }

        public DataTable BuscarReparto(string nombre)
        {
            DataTable dt = new DataTable();
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "select * from reparto where nombre= '" + nombre + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar reparto: " + ex.Message);
            }
        }
    }
}
