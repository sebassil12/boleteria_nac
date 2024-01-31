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
    public class TrailerDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarTrailer(Trailer trailer)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into trailer(trailer) values (@trailer)";
                ejecutarSql.Parameters.AddWithValue("@trailer", trailer.LinkTrailer);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar trailer: " + ex.Message);
            }
        }
        public DataTable ListarTrailer()
        {
            DataTable dt = new DataTable();
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "select * from trailer";
                transaccion = ejecutarSql.ExecuteReader();

                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar trailer: " + ex.Message);
            }

        }

        public DataTable BuscarTrailer(string trailer)
        {
            DataTable dt = new DataTable();
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "select * from trailer where trailer= '" + trailer + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar trailer: " + ex.Message);
            }
        }
        public Trailer ObtenerUnTrailer(int Id)
        {

            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM trailer WHERE id_trailer = " + Id;
                transaccion = ejecutarSql.ExecuteReader();

                transaccion.Read();

                Trailer trailer = new Trailer();
                trailer.IdTrailer = transaccion.GetInt32(0);
                trailer.LinkTrailer = transaccion.GetString(1);
                transaccion.Close();
                conexion.CerrarConexion();

                return trailer;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el trailer: " + ex.Message);
            }

        }

        public void ActualizarTrailer(Trailer actualizarTrailer, int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE trailer SET trailer = @trailer " +
                    "WHERE id_trailer = @id_trailer";

                ejecutarSql.Parameters.AddWithValue("@trailer", actualizarTrailer.LinkTrailer);
                ejecutarSql.Parameters.AddWithValue("@id_trailer", Id);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar trailer: " + ex.Message);
            }
        }
        public void EliminarTrailer(int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM trailer WHERE id_trailer = @id_trailer_eliminar";
                ejecutarSql.Parameters.AddWithValue("@id_trailer_eliminar", Id);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar trailer : " + ex.Message);
            }
        }
    }
}
