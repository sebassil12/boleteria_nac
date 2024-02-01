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
    public partial class FrmReparto : Form
    {
        RepartoLogica repartoLogica = new RepartoLogica();
        public FrmReparto()
        {
            InitializeComponent();
        }
        private new void Refresh()
        {
            DataTable dt = repartoLogica.ListarReparto();
            DgvReparto.DataSource = dt;

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProcesoReparto frmProcesoReparto = new FrmProcesoReparto();
            frmProcesoReparto.ShowDialog();
            Refresh();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdReparto();
            FrmProcesoReparto frmProcesoReparto = new FrmProcesoReparto(Id);
            frmProcesoReparto.ShowDialog();
            Refresh();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdReparto();
            try
            {
                repartoLogica.EliminarReparto((int)Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al eliminar el reparto: " + ex.Message);
            }
            Refresh();
        }

        private void FrmReparto_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        #region HELPER
        private int? GetIdReparto()
        {
            try
            {

                return int.Parse(DgvReparto.Rows[DgvReparto.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
