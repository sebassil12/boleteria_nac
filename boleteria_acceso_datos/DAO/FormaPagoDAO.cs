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
                ejecutarSql.CommandText = "insert into forma_pago(nombre, descripcion, estado) values" +
                    "('" + formaPago.Nombre + "','"+formaPago.Descripcion+ "','"+formaPago.Estado+ 
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
    }
}
