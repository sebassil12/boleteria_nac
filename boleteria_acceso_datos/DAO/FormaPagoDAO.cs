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
    public class FormaPagoDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;
        public void InsertarFormaPago(FormaPago formaPago)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into forma_pago(nombre, descripcion, estado) values (@nombre_pago, @descripcion_pago, @estado_pago)";
                ejecutarSql.Parameters.AddWithValue("@nombre_pago", formaPago.Nombre);
                ejecutarSql.Parameters.AddWithValue("@descripcion_pago", formaPago.Descripcion);
                ejecutarSql.Parameters.AddWithValue("@estado_pago", formaPago.Estado);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar forma pago: " + ex.Message);
            }
        }

        public DataTable ListarFormaPago()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "select * from forma_pago";
                transaccion = ejecutarSql.ExecuteReader();

                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar forma pago: " + ex.Message);
            }
        }

        public DataTable BuscarFormaPago(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "select * from encargado where nombre= '" + nombre + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar forma pago: " + ex.Message);
            }
        }
        public FormaPago ObtenerUnaFormaPago(int Id)
        {

            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM forma_pago WHERE id_forma_pago = " + Id;
                transaccion = ejecutarSql.ExecuteReader();

                transaccion.Read();

                FormaPago formaPago = new FormaPago();
                formaPago.IdFormaPago = transaccion.GetInt32(0);
                formaPago.Nombre = transaccion.GetString(1);
                formaPago.Descripcion = transaccion.GetString(2);
                formaPago.Estado = transaccion.GetByte(3);
                transaccion.Close();
                conexion.CerrarConexion();

                return formaPago;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la forma pago: " + ex.Message);
            }

        }

        public void ActualizarFormaPago(FormaPago actualizarFormaPago, int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE forma_pago SET nombre = @nombre, " +
                    "descripcion = @descripcion, " +
                    "estado = @estado " +
                    "WHERE id_forma_pago = @id_forma_pago";

                ejecutarSql.Parameters.AddWithValue("@nombre", actualizarFormaPago.Nombre);
                ejecutarSql.Parameters.AddWithValue("@descripcion", actualizarFormaPago.Descripcion);
                ejecutarSql.Parameters.AddWithValue("@estado", actualizarFormaPago.Estado);
                ejecutarSql.Parameters.AddWithValue("@id_forma_pago", Id);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar forma pago: " + ex.Message);
            }
        }
        public void EliminarFormaPago(int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM forma_pago WHERE id_forma_pago = @id_pago_eliminar";
                ejecutarSql.Parameters.AddWithValue("@id_pago_eliminar", Id);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar forma pago : " + ex.Message);
            }
        }
    }
}
