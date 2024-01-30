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
    public partial class FrmCliente : Form
    {
        private ClienteDAO clienteDAO = new ClienteDAO();
        public FrmCliente()
        {
            InitializeComponent();
        }

        public void FrmCliente_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            DataTable dt = clienteDAO.ListarCliente();

            DgvCliente.DataSource = dt;
        }

       

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmProcesoCliente frmProcesoCliente = new FrmProcesoCliente();
            frmProcesoCliente.ShowDialog();
            Refresh();
        }

        #region HELPER
        private int? GetIdCliente()
        {
            try
            {

            return int.Parse(DgvCliente.Rows[DgvCliente.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int? Id = GetIdCliente();
            if (Id != null)
            {
                FrmProcesoCliente frmProcesoCliente = new FrmProcesoCliente(Id);
                frmProcesoCliente.ShowDialog();
                Refresh();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int? Id = GetIdCliente();
            clienteDAO.EliminarCliente((int) Id);
            Refresh();
        }
    }
}
