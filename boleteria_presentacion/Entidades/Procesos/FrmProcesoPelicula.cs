using boleteria_acceso_datos.bolteria_tablas;
using boleteria_logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boleteria_presentacion.Entidades.Procesos
{
    public partial class FrmProcesoPelicula : Form
    {
        PeliculaLogica peliculaLogica = new PeliculaLogica();
        private int? Id;
        public FrmProcesoPelicula(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if(this.Id != null)
            {
                Load_Data();
            }
        }

        private void Load_Data()
        {
            Pelicula pelicula = new Pelicula();
            pelicula = peliculaLogica.ObtenerUnaPelicula((int)Id);
            TxtNombre.Text = pelicula.Nombre;
            Hora.Value = pelicula.Duracion.Hours;
            Minuto.Value = pelicula.Duracion.Minutes;
            Segundo.Value = pelicula.Duracion.Seconds;
            TxtClasificacion.Text = pelicula.Clasificacion;
            TxtAnio.Text = pelicula.Anio.ToString();
            TxtEncargado.Text = pelicula.IdEncargado.ToString();
            TxtSala.Text = pelicula.IdSala.ToString();


        }
        private void InsertarPelicula(Pelicula pelicula)
        {
            try
            {
                peliculaLogica.InsertarPelicula(pelicula);
            }catch(Exception ex)
            {
                throw new Exception("Error al insertar pelicula: "+ex.Message);
            }
        }
        private void ActualizarPelicula(Pelicula pelicula, int Id)
        {
            try
            {
                peliculaLogica.ActualizarPelicula(pelicula, Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al actualizar pelicula: "+ex.Message);
            }
        }

        private void FrmProcesoPelicula_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.Nombre = TxtNombre.Text;
            int hora = (int)Hora.Value;
            int minuto = (int)Minuto.Value;
            int segundo = (int)Segundo.Value;

            TimeSpan duracionPelicula = new TimeSpan(hora, minuto, segundo);
            pelicula.Duracion = duracionPelicula;
            pelicula.Anio = int.Parse(TxtAnio.Text);
            pelicula.Clasificacion = TxtClasificacion.Text;
            pelicula.IdEncargado = int.Parse(TxtEncargado.Text);
            pelicula.IdSala = int.Parse(TxtSala.Text);

            try
            {
                if(Id == null)
                {
                    InsertarPelicula(pelicula);
                }
                else
                {
                    ActualizarPelicula(pelicula, (int)Id);
                }

            }catch(Exception ex)
            {
                throw new Exception("Error en el proceso CU: "+ex.Message);
            }
            this.Close();
        }
    }
}
