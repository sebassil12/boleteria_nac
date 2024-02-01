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
    public partial class FrmSala : Form
    {
        SalaLogica salaLogica = new SalaLogica();
        public FrmSala()
        {
            InitializeComponent();
        }

        private new void Refresh() {
            DataTable dt = salaLogica.ListarSala();
            DgvSala.DataSource = dt;

        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProcesoSala frmProcesoSala = new FrmProcesoSala();
            frmProcesoSala.ShowDialog();
            Refresh();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdSala();
            FrmProcesoSala frmProcesoSala = new FrmProcesoSala((int)Id);
            frmProcesoSala.ShowDialog();
            Refresh();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdSala();
            try
            {
                salaLogica.EliminarSala((int)Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al eliminar la sala: "+ ex.Message);
            }
            Refresh();
        }

        private void FrmSala_Load(object sender, EventArgs e)
        {
     
            Refresh();
        }

        #region HELPER
        private int? GetIdSala()
        {
            try
            {

                return int.Parse(DgvSala.Rows[DgvSala.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
