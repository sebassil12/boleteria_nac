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
                ejecutarSql.CommandText = "insert into reparto(nombre, apellido, id_estreno) values(@nombre, @apellido, @id_estreno)";
                ejecutarSql.Parameters.AddWithValue("@nombre", reparto.Nombre);
                ejecutarSql.Parameters.AddWithValue("@apellido", reparto.Apellido);
                ejecutarSql.Parameters.AddWithValue("@id_estreno", reparto.IdEstreno);
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

          public Reparto ObtenerUnReparto(int Id)
            {

            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM reparto WHERE id_reparto = " + Id;
                transaccion = ejecutarSql.ExecuteReader();

                transaccion.Read();

                Reparto reparto = new Reparto();
                reparto.IdReparto = transaccion.GetInt32(0);
                reparto.Nombre = transaccion.GetString(1);
                reparto.Apellido = transaccion.GetString(2);
                reparto.IdEstreno = transaccion.GetInt32(3);
                transaccion.Close();
                conexion.CerrarConexion();

                return reparto;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el reparto: " + ex.Message);
            }

        }

        public void ActualizarReparto(Reparto actualizarReparto, int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE reparto SET nombre = @nombre, " +
                    "apellido = @apellido, " +
                    "id_estreno = @id_estreno "+
                    "WHERE id_reparto = @id_reparto";

                ejecutarSql.Parameters.AddWithValue("@nombre", actualizarReparto.Nombre);
                ejecutarSql.Parameters.AddWithValue("@apellido", actualizarReparto.Apellido);
                ejecutarSql.Parameters.AddWithValue("@id_estreno", actualizarReparto.IdEstreno);
                ejecutarSql.Parameters.AddWithValue("@id_reparto", Id); 

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar reparto: " + ex.Message);
            }
        }
        public void EliminarReparto(int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM reparto WHERE id_reparto = @id_reparto_eliminar";
                ejecutarSql.Parameters.AddWithValue("@id_reparto_eliminar", Id);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar reparto : " + ex.Message);
            }
        }
    }
}
