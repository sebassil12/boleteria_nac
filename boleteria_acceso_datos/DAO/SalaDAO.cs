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
    public class SalaDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarSala(Sala sala)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into sala(numero_sala, bloque) values (@numero_sala, @bloque)";
                ejecutarSql.Parameters.AddWithValue("@numero_sala", sala.NumeroSala);
                ejecutarSql.Parameters.AddWithValue("@bloque", sala.Bloque);
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar sala: " + ex.Message);
            }
        }
        public DataTable ListarSala()
        {
            DataTable dt = new DataTable();
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "select * from sala";
                transaccion = ejecutarSql.ExecuteReader();

                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar sala: " + ex.Message);
            }

        }

        public DataTable BuscarSala(int numero_sala)
        {
            DataTable dt = new DataTable();
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "select * from sala where numero_sala= '" + numero_sala + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar sala: " + ex.Message);
            }
        }

            public Sala ObtenerUnaSala(int Id)
            {

                try
                {
                    ejecutarSql.Connection = conexion.AbrirConexion();
                    ejecutarSql.CommandText = "SELECT * FROM sala WHERE id_sala = " + Id;
                    transaccion = ejecutarSql.ExecuteReader();

                    transaccion.Read();

                    Sala sala = new Sala();
                    sala.IdSala = transaccion.GetInt32(0);
                    sala.NumeroSala = transaccion.GetInt32(1);
                    sala.Bloque = transaccion.GetString(2);
                    transaccion.Close();
                    conexion.CerrarConexion();

                    return sala;

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el sala: " + ex.Message);
                }

            }

            public void ActualizarSala(Sala actualizarSala, int Id)
            {
                try
                {
                    ejecutarSql.Connection = conexion.AbrirConexion();
                    ejecutarSql.CommandText = "UPDATE sala SET numero_sala = @numero_sala, " +
                        "bloque = @bloque " +
                        "WHERE id_sala = @id_sala";

                    ejecutarSql.Parameters.AddWithValue("@numero_sala", actualizarSala.NumeroSala);
                    ejecutarSql.Parameters.AddWithValue("@bloque", actualizarSala.Bloque);
                    ejecutarSql.Parameters.AddWithValue("@id_sala", Id);

                    ejecutarSql.ExecuteNonQuery();
                    conexion.CerrarConexion();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar sala: " + ex.Message);
                }
            }
            public void EliminarSala(int Id)
            {
                try
                {
                    ejecutarSql.Connection = conexion.AbrirConexion();
                    ejecutarSql.CommandText = "DELETE FROM sala WHERE id_sala = @id_sala_eliminar";
                    ejecutarSql.Parameters.AddWithValue("@id_sala_eliminar", Id);
                    ejecutarSql.ExecuteNonQuery();
                    conexion.CerrarConexion();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar sala : " + ex.Message);
                }
            }
        }
        
}
