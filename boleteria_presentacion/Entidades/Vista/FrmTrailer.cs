using boleteria_logica;
using boleteria_presentacion.Entidades.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boleteria_presentacion.Entidades.Vista
{
    public partial class FrmTrailer : Form
    {
        TrailerLogica trailerLogica = new TrailerLogica();
        public FrmTrailer()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProcesoTrailer frmProcesoTrailer = new FrmProcesoTrailer();
            frmProcesoTrailer.ShowDialog();
            Refresh();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdTrailer();
            FrmProcesoTrailer frmProcesoTrailer = new FrmProcesoTrailer((int)Id);
            frmProcesoTrailer.ShowDialog(); 
            Refresh();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdTrailer();
            try
            {
                trailerLogica.EliminarTrailer((int)Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al eliminar Trailer: "+ ex.Message);
            }
            Refresh();
        }

        private void FrmTrailer_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private new void Refresh()
        {
            DataTable dt = trailerLogica.ListarTrailer();
            DgvTrailer.DataSource = dt;

        }

        #region HELPER
        private int? GetIdTrailer()
        {
            try
            {
                return int.Parse(DgvTrailer.Rows[DgvTrailer.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
