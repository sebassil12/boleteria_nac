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
    public class EntradaDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarEntrada(Entrada nuevoEntrada)
        {

            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into entrada(id_pelicula,id_forma_pago) values ( @id_pelicula, @id_forma_pago)";
               
                ejecutarSql.Parameters.AddWithValue("@id_pelicula", nuevoEntrada.idPelicula);
                ejecutarSql.Parameters.AddWithValue("@id_forma_pago", nuevoEntrada.idFormaPago);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar entrada: " + e.Message);
            }
        }
        public DataTable ListarEntrada()
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM entrada";
                transaccion = ejecutarSql.ExecuteReader();

                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar entrada: " + ex.Message);
            }
        }

        public DataTable BuscarEntrada(string codigo)
        {
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "select * from entrada where codigo= '" + codigo + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar entrada: " + ex.Message);
            }
        }

        public Entrada ObtenerUnEntrada(int Id)
        {

            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "SELECT * FROM entrada WHERE id_entrada = " + Id;
                transaccion = ejecutarSql.ExecuteReader();

                transaccion.Read();

                Entrada entrada = new Entrada();
                entrada.codigo = transaccion.GetInt32(0);
                entrada.idPelicula = transaccion.GetInt32(1);
                entrada.idFormaPago = transaccion.GetInt32(2);

                transaccion.Close();
                conexion.CerrarConexion();

                return entrada;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el cliente solicitado: " + ex.Message);
            }

        }
        public void ActualizarEntrada(Entrada actualizarEntrada, int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE entrada SET " +
                "id_pelicula = @id_pelicula, " +
                "id_forma_pago = id_forma_pago, "+
                "WHERE codigo = @id_entrada";

                ejecutarSql.Parameters.AddWithValue("@id_pelicula", actualizarEntrada.idPelicula);
                ejecutarSql.Parameters.AddWithValue("@id_forma_pago", actualizarEntrada.idFormaPago);
                ejecutarSql.Parameters.AddWithValue("@id_entrada", Id);

                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception("Error al actualizar entrada: " + e.Message);
            }
        }
        public void EliminarEntrada(int Id)
        {
            try
            {
                ejecutarSql.Connection = conexion.AbrirConexion();
                ejecutarSql.CommandText = "DELETE FROM entrada WHERE codigo = @id_entrada";
                ejecutarSql.Parameters.AddWithValue("@id_entrada", Id);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar entrada: " + ex.Message);
            }
        }



    }
}
