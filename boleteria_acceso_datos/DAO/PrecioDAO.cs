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
                ejecutarSql.CommandText = "insert into precio(valor, fecha) values (@valor, @fecha)";
                ejecutarSql.Parameters.AddWithValue("@valor", precio.Valor);
                ejecutarSql.Parameters.AddWithValue("@fecha", precio.Fecha);
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
        public Precio ObtenerUnPrecio(int Id)
        {

            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM precio WHERE id_precio = " + Id;
                transaccion = ejecutarSql.ExecuteReader();

                transaccion.Read();

                Precio precio = new Precio();
                precio.IdPrecio = transaccion.GetInt32(0);
                precio.Valor = transaccion.GetInt32(1);
                precio.Fecha = transaccion.GetDateTime(2);
                transaccion.Close();
                conexion.CerrarConexion();

                return precio;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el precio: " + ex.Message);
            }

        }

        public void ActualizarPrecio(Precio actualizarPrecio, int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE precio SET valor = @valor, " +
                    "fecha = @fecha " +
                    "WHERE id_precio = @id_precio";

                ejecutarSql.Parameters.AddWithValue("@valor", actualizarPrecio.Valor);
                ejecutarSql.Parameters.AddWithValue("@fecha", actualizarPrecio.Fecha);
                ejecutarSql.Parameters.AddWithValue("@id_precio", Id);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar precio: " + ex.Message);
            }
        }
        public void EliminarPrecio(int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM precio WHERE id_precio = @id_precio_eliminar";
                ejecutarSql.Parameters.AddWithValue("@id_precio_eliminar", Id);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar precio : " + ex.Message);
            }
        }

    }
}
