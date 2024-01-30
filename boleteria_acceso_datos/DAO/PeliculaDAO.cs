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
            ejecutarSql.CommandText = "insert into pelicula(nombre, duracion, anio, clasificacion, id_encargado, id_sala)" +
                "values('" + pelicula.Nombre + "','" + pelicula.Duracion + "','" + pelicula.Clasificacion + "','" + pelicula.IdEncargado + "','" + pelicula.IdSala +
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

    }   
}
