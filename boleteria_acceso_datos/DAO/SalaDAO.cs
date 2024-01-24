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
    public class SalaDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarSala(Sala sala)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into sala(numero_sala, bloque)" +
                    "values('" + sala.NumeroSala + "','" + sala.Bloque +
                    ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar sala: " + ex.Message);
            }
        }
        public DataTable ListarSala()
        {
            DataTable dt = new DataTable();
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "select * from sala";
                transaccion = ejecutarSql.ExecuteReader();

                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar sala: " + ex.Message);
            }

        }

        public DataTable BuscarSala(int numero_sala)
        {
            DataTable dt = new DataTable();
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "select * from sala where numero_sala= '" + numero_sala + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar sala: " + ex.Message);
            }
        }
    }
}
