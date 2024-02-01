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
    public partial class FrmProcesoTrailer : Form
    {
        int? Id;
        TrailerLogica trailerLogica = new TrailerLogica();
        public FrmProcesoTrailer(int? Id =null)
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
            Trailer trailer = new Trailer();
            trailer = trailerLogica.ObtenerUnTrailer((int)Id);
            TxtLinkTrailer.Text = trailer.LinkTrailer;
        }
        
        private void InsertarTrailer(Trailer trailer)
        {
            try
            {
                trailerLogica.InsertarTrailer(trailer);
            }catch(Exception ex)
            {
                throw new Exception("Error al insertar trailer: " + ex.Message);
            }
        }
        private void ActualizarTrailer(Trailer trailer, int Id)
        {
            try
            {
                trailerLogica.ActualizarTrailer(trailer, Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al actualizar trailer: "+ex.Message);
            }
        }

       

        private void FrmProcesoTrailer_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Trailer trailer = new Trailer();
            trailer.LinkTrailer = TxtLinkTrailer.Text;
            try
            {
                if(Id == null)
                {
                    InsertarTrailer(trailer);
                }
                else
                {
                    ActualizarTrailer(trailer, (int)Id);
                }

            }catch(Exception ex)
            {
                throw new Exception("Error en el proceso CU: " + ex.Message);
            }
            this.Close();
        }
    }
}
