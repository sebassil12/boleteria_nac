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
    public class EstrenoDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarEstreno(Estreno nuevoEstreno)
        {

            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into entrada(sinopsis,idFechaTentativa, idTrailer) values (@sinopsis, @id_fecha_tentativa,@id_trailer )";
                ejecutarSql.Parameters.AddWithValue("@sinopsis", nuevoEstreno.sinopsis);
                ejecutarSql.Parameters.AddWithValue("@id_fecha_tentativa", nuevoEstreno.idFechaTentativa);
                ejecutarSql.Parameters.AddWithValue("@id_trailer", nuevoEstreno.idTrailer);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar estreno: " + e.Message);
            }
        }
        public DataTable ListarEstreno()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM estreno";
                transaccion = ejecutarSql.ExecuteReader();

                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar estreno: " + ex.Message);
            }
        }

        public DataTable BuscarEstreno(string idEstreno)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "select * from estreno where id_estreno= '" + idEstreno + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar estreno: " + ex.Message);
            }
        }
        public Estreno ObtenerUnEstreno(int Id)
        {

            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM estreno WHERE id_estreno = " + Id;
                transaccion = ejecutarSql.ExecuteReader();

                transaccion.Read();

                Estreno estreno = new Estreno();
                estreno.idEstreno = transaccion.GetInt32(0);
                estreno.sinopsis = transaccion.GetString(1);
                estreno.idFechaTentativa = transaccion.GetInt32(2);
                estreno.idTrailer = transaccion.GetInt32(3);

                transaccion.Close();
                conexion.CerrarConexion();

                return estreno;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el cliente solicitado: " + ex.Message);
            }

        }
        public void ActualizarEstreno(Estreno actualizarEstreno, int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE estreno SET sinopsis = @sinopsis, " +
                "id_fecha_tentativa = @id_fecha_tentativa, " +
                "id_trailer = @id_trailer "+
                "WHERE id_estreno = @id_estreno";

                ejecutarSql.Parameters.AddWithValue("@sinopsis", actualizarEstreno.sinopsis);
                ejecutarSql.Parameters.AddWithValue("@id_fecha_tentativa", actualizarEstreno.idFechaTentativa);
                ejecutarSql.Parameters.AddWithValue("@id_trailer", actualizarEstreno.idTrailer);
                ejecutarSql.Parameters.AddWithValue("@id_estreno", Id);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception("Error al actualizar estreno: " + e.Message);
            }
        }
        public void EliminarEstreno(int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM estreno WHERE id_estreno = @id_estreno";
                ejecutarSql.Parameters.AddWithValue("@id_estreno", Id);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar estreno: " + ex.Message);
            }
        }

    }


}