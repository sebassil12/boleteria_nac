using boleteria_acceso_datos.DAO;
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
    public partial class FrmEncargado : Form
    {
        private EncargadoDAO encargadoDAO = new EncargadoDAO();
        public FrmEncargado()
        {
            InitializeComponent();
        }

        private void FrmEncargado_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            DataTable dt = encargadoDAO.ListarEncargado();
            DgvEncargado.DataSource = dt;

        }

        private void NewEncargado_Click(object sender, EventArgs e)
        {
            FrmProcesoEncargado frmProcesoEncargado = new FrmProcesoEncargado();
            frmProcesoEncargado.ShowDialog();
            Refresh();
        }

        #region HELPER
        private int? GetIdEncargado()
        {
            try
            {

                return int.Parse(DgvEncargado.Rows[DgvEncargado.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        #endregion

        private void EditEncargado_Click(object sender, EventArgs e)
        {
            int? Id = GetIdEncargado();
            FrmProcesoEncargado frmProcesoEncargado = new FrmProcesoEncargado((int) Id);
            frmProcesoEncargado.ShowDialog();
            Refresh();
      }

        private void DeleteEncargado_Click(object sender, EventArgs e)
        {
            int? Id = GetIdEncargado();
            encargadoDAO.EliminarEncargado((int)Id);
            Refresh();
        }
    }
}
