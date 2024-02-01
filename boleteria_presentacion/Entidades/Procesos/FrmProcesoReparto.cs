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
    public partial class FrmProcesoReparto : Form
    {
        RepartoLogica repartoLogica = new RepartoLogica();
        private int? Id;
        public FrmProcesoReparto(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if (this.Id != null)
            {
                Load_Data();
            }
        }
        private void Load_Data() {
            Reparto reparto = new Reparto();
            reparto = repartoLogica.ObtenerUnReparto((int)Id);
            TxtNombre.Text = reparto.Nombre;
            TxtApellido.Text = reparto.Apellido;
            TxtEstreno.Text = reparto.IdEstreno.ToString();
        }
        private void InsertarReparto(Reparto reparto)
        {
            try
            {
                repartoLogica.InsertarReparto(reparto);
            }catch(Exception ex)
            {
                throw new Exception("Error al insertar reparto: " + ex.Message);
            }
        }
        private void ActualizarReparto(Reparto reparto, int Id)
        {
            try
            {
                repartoLogica.ActualizarReparto(reparto, Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al actualizar reparto: " + ex.Message);
            }
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Reparto reparto = new Reparto();
            reparto.Nombre = TxtNombre.Text;
            reparto.Apellido = TxtApellido.Text;
            reparto.IdEstreno = int.Parse(TxtEstreno.Text);
            try
            {
                if (Id == null)
                {
                    InsertarReparto(reparto);
                }
                else
                {
                    ActualizarReparto(reparto, (int)Id);
                }

            }catch(Exception ex)
            {
                throw new Exception("Error en el proceso CU: " + ex.Message);
            }
            this.Close();
        }

        private void FrmProcesoReparto_Load(object sender, EventArgs e)
        {

        }
    }
}
