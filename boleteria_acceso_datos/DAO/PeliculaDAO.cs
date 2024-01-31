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
    public class PeliculaDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarPelicula(Pelicula pelicula)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into pelicula(nombre, duracion, anio, clasificacion, id_encargado, id_sala) values (@nombre, @duracion, @anio, @clasificacion, @id_encargado, @id_sala)";
                ejecutarSql.Parameters.AddWithValue("@nombre", pelicula.Nombre);
                ejecutarSql.Parameters.AddWithValue("@duracion", pelicula.Duracion);
                ejecutarSql.Parameters.AddWithValue("@anio", pelicula.Anio);
                ejecutarSql.Parameters.AddWithValue("@clasificacion", pelicula.Clasificacion);
                ejecutarSql.Parameters.AddWithValue("@id_encargado", pelicula.IdEncargado);
                ejecutarSql.Parameters.AddWithValue("@id_sala", pelicula.IdSala);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();

            }catch(Exception ex)
            {
                throw new Exception("Error al insertar Pelicula" + ex.Message);
            }
        }

        public DataTable ListarPelicula()
        {
            DataTable dt = new DataTable();
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "select * from pelicula";
                transaccion = ejecutarSql.ExecuteReader();

                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
                
            }catch(Exception ex)
            {
                throw new Exception("Error al listar peliculas: " + ex.Message);
            }

        }

        public DataTable BuscarPelicula(string nombre)
        {
            DataTable dt = new DataTable();
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "select * from pelicula where nombre= '" + nombre + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }catch(Exception ex)
            {
                throw new Exception("Error al buscar pelicula: " + ex.Message);
            }
        }

        public Pelicula ObtenerUnaPelicula(int Id)
        {

            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM pelicula WHERE id_pelicula = " + Id;
                transaccion = ejecutarSql.ExecuteReader();

                transaccion.Read();

                Pelicula pelicula = new Pelicula();
                pelicula.IdPelicula = transaccion.GetInt32(0);
                pelicula.Nombre = transaccion.GetString(1);
                pelicula.Duracion = transaccion.GetTimeSpan(2);
                pelicula.Anio = transaccion.GetInt32(3);
                pelicula.Clasificacion = transaccion.GetString(4);
                pelicula.IdEncargado = transaccion.GetInt32(5);
                pelicula.IdPelicula = transaccion.GetInt32(6);
                transaccion.Close();
                conexion.CerrarConexion();

                return pelicula;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la pelicula: " + ex.Message);
            }

        }

        public void ActualizarPelicula(Pelicula actualizarPelicula, int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE pelicula SET nombre = @nombre, " +
                    "duracion = @duracion, " +
                    "anio = @anio, " +
                    "clasificacion = @clasificacion, " +
                    "id_encargado = @id_encargado, "+
                    "id_sala = @id_sala "+
                    "WHERE id_pelicula = @id_pelicula";

                ejecutarSql.Parameters.AddWithValue("@nombre", actualizarPelicula.Nombre);
                ejecutarSql.Parameters.AddWithValue("@duracion", actualizarPelicula.Duracion);
                ejecutarSql.Parameters.AddWithValue("@anio", actualizarPelicula.Anio);
                ejecutarSql.Parameters.AddWithValue("@clasificacion", actualizarPelicula.Clasificacion);
                ejecutarSql.Parameters.AddWithValue("@id_encargado", actualizarPelicula.IdEncargado);
                ejecutarSql.Parameters.AddWithValue("@id_sala", actualizarPelicula.IdSala);
                ejecutarSql.Parameters.AddWithValue("@id_pelicula", Id);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar pelicula: " + ex.Message);
            }
        }
        public void EliminarPelicula(int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM pelicula WHERE id_pelicula = @id_pelicula";
                ejecutarSql.Parameters.AddWithValue("@id_pelicula", Id);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar pelicula: " + ex.Message);
            }
        }

    }   
}
