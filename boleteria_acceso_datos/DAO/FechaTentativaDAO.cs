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
                ejecutarSql.CommandText = "INSERT into fecha_tentativa(fecha) VALUES (@fecha)";

                ejecutarSql.Parameters.AddWithValue("@fecha", fechaTentativa.Fecha);
                    ejecutarSql.ExecuteNonQuery();
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
        public FechaTentativa ObtenerUnaFechaTentativa(int Id)
        {

            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM fecha_tentativa WHERE id_fecha_tentativa = " + Id;
                transaccion = ejecutarSql.ExecuteReader();

                transaccion.Read();

                FechaTentativa fechaTentativa = new FechaTentativa();
                fechaTentativa.IdFechaTentativa = transaccion.GetInt32(0);
                fechaTentativa.Fecha = transaccion.GetDateTime(1);
                transaccion.Close();
                conexion.CerrarConexion();

                return fechaTentativa;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la fecha tentativa: " + ex.Message);
            }

        }

        public void ActualizarFechaTentativa(FechaTentativa actualizarFechaTentativa, int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE fecha_tentativa SET fecha = @fecha " +
                "WHERE id_fecha_tentativa = @id_fecha_tentativa";

                ejecutarSql.Parameters.AddWithValue("@fecha", actualizarFechaTentativa.Fecha);
                ejecutarSql.Parameters.AddWithValue("@id_fecha_tentativa", Id);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar fecha tentativa: " + ex.Message);
            }
        }
            public void EliminarFechaTentativa(int Id)
            {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM fecha_tentativa WHERE id_fecha_tentativa = @id_fecha_eliminar";
                ejecutarSql.Parameters.AddWithValue("@id_fecha_eliminar", Id);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar fecha_tentativa: " + ex.Message);
            }
            }
        

    }
}
