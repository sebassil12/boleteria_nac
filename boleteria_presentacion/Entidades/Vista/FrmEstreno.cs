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
    public partial class FrmEstreno : Form
    {
        private EstrenoLogica estrenoLogica = new EstrenoLogica();

        public FrmEstreno()
        {
            InitializeComponent();
        }

        private new void Refresh()
        {
            DataTable dt = estrenoLogica.ListarEstreno();
            DgvEstreno.DataSource = dt;
        }
        private void FrmEstreno_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProcesoEstreno frmProcesoEstreno = new FrmProcesoEstreno();
            frmProcesoEstreno.ShowDialog();
            Refresh();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdEstreno();

            FrmProcesoEstreno frmProcesoEstreno = new FrmProcesoEstreno((int)Id);
            frmProcesoEstreno.ShowDialog();
            Refresh();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdEstreno();
            try
            {
                estrenoLogica.EliminarEstreno((int)Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al eliminar entrada: " + ex.Message);
            }
            Refresh();
        }

        #region HELPER
        private int? GetIdEstreno()
        {
            try
            {

                return int.Parse(DgvEstreno.Rows[DgvEstreno.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
