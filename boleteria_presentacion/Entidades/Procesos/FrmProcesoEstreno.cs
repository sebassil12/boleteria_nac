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
   
    public partial class FrmProcesoEstreno : Form
    {
        private EstrenoLogica estrenoLogica = new EstrenoLogica();
        int? Id;
        public FrmProcesoEstreno(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if (this.Id != null)
            {
                Load_Data();
            }
        }
        private void Load_Data(){
            Estreno estreno = new Estreno();
            estreno = estrenoLogica.ObtenerUnEstreno((int)Id);
            TxtSinopsis.Text = estreno.sinopsis;
            TxtFechaTentativa.Text = estreno.idFechaTentativa.ToString();
            TxtTrailer.Text = estreno.idEstreno.ToString();
        }

        private void InsertarEstreno(Estreno estreno)
        {
            try
            {
                estrenoLogica.InsertarEstreno(estreno);
            }catch(Exception ex)
            {
                throw new Exception("Error al insertar estreno: " + ex.Message);
            }
        }
        private void ActualizarEstreno(Estreno estreno, int Id)
        {
            try
            {
                estrenoLogica.ActualizarEstreno(estreno, Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al actualizar estreno: "+ex.Message);
            }
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Estreno estreno = new Estreno();
            estreno.sinopsis = TxtSinopsis.Text;
            estreno.idFechaTentativa = int.Parse(TxtFechaTentativa.Text);
            estreno.idTrailer = int.Parse(TxtTrailer.Text);

            try
            {
                if (Id == null)
                {
                    InsertarEstreno(estreno);
                }
                else
                {
                    ActualizarEstreno(estreno, (int)Id);
                }
            }catch(Exception ex)
            {
                throw new Exception("Error en el proceso CU: " + ex.Message);
            }
            this.Close();
        }
    }
}
