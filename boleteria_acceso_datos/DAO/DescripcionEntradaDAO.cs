using boleteria_acceso_datos;
using boleteria_acceso_datos.bolteria_tablas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descripcion_entrada.DAO
{
    public class DescripcionEntradaDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarDescripcionEntrada(DescripcionEntrada nuevoDescripcionEntrada)
        {

            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into descripcionentrada(descripcion,cantidad,codigo,id_precio,id_cliente) values (descripcion, cantidad, codigo, id_precio, id_cliente)";
                ejecutarSql.Parameters.AddWithValue("@descripcion", nuevoDescripcionEntrada.descripcion);
                ejecutarSql.Parameters.AddWithValue("@cantidad", nuevoDescripcionEntrada.cantidad);
                ejecutarSql.Parameters.AddWithValue("@codigo", nuevoDescripcionEntrada.codigo);
                ejecutarSql.Parameters.AddWithValue("@id_precio", nuevoDescripcionEntrada.idPrecio);
                ejecutarSql.Parameters.AddWithValue("@id_cliente", nuevoDescripcionEntrada.idCliente);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar descripcion_entrada: " + e.Message);
            }
        }

        public DataTable ListarDescripcionEntrada()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM descripcion_entrada";
                transaccion = ejecutarSql.ExecuteReader();

                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar descripcion_entrada: " + ex.Message);
            }
        }

        public DataTable BuscarDescripcionEntrada(string idDescripcionEntrada)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "select * from descripcion_entrada where descripcion= '" + idDescripcionEntrada + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar descripcion_entrada: " + ex.Message);
            }
        }
        public DescripcionEntrada ObtenerUnDescripcionEntrada(int Id)
        {

            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM descripcion_entrada WHERE id_descripcion_entrada = " + Id;
                transaccion = ejecutarSql.ExecuteReader();

                transaccion.Read();

                DescripcionEntrada descripcionEntrada = new DescripcionEntrada();
                descripcionEntrada.idDescripcionEntrada = transaccion.GetInt32(0);
                descripcionEntrada.descripcion = transaccion.GetString(1);
                descripcionEntrada.cantidad = transaccion.GetInt32(2);
                descripcionEntrada.codigo = transaccion.GetInt32(3);
                descripcionEntrada.idPrecio = transaccion.GetInt32(4);
                descripcionEntrada.idCliente = transaccion.GetInt32(5);

                transaccion.Close();
                conexion.CerrarConexion();

                return descripcionEntrada;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el cliente solicitado: " + ex.Message);
            }

        }
        public void ActualizarDescripcionEntrada(DescripcionEntrada actualizarDescripcionEntrada, int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE descripcion_entrada SET descripcion = @descripcion, " +
                "cantidad = @cantidad, " +
                "codigo = @codigo, "+
                "id_precio = @id_precio, "+
                "id_cliente = @id_cliente "+
                "WHERE id_descripcion_entrada = @id_descripcion_entrada";

                ejecutarSql.Parameters.AddWithValue("@descripcion", actualizarDescripcionEntrada.descripcion);
                ejecutarSql.Parameters.AddWithValue("@cantidad", actualizarDescripcionEntrada.cantidad);
                ejecutarSql.Parameters.AddWithValue("@codigo", actualizarDescripcionEntrada.codigo);
                ejecutarSql.Parameters.AddWithValue("@id_precio", actualizarDescripcionEntrada.idPrecio);
                ejecutarSql.Parameters.AddWithValue("@id_cliente", actualizarDescripcionEntrada.idCliente);
                ejecutarSql.Parameters.AddWithValue("@id_descripcion_entrada", Id);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception("Error al actualizar descripcion_entrada: " + e.Message);
            }
        }
        public void EliminarDescripcionEntrada(int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM descripcion_entrada WHERE id_descripcion_entrada = @id_descripcion_entrada";
                ejecutarSql.Parameters.AddWithValue("@id_descripcion_entrada", Id);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar descripcion_entrada: " + ex.Message);
            }
        }

    }
}