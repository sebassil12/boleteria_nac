using System;
using boleteria_logica;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using boleteria_presentacion.Entidades.Procesos;

namespace boleteria_presentacion.Entidades.Vista
{
    public partial class FrmClienteEstreno : Form
    {
        private ClienteEstrenoLogica clienteEstrenoLogica = new ClienteEstrenoLogica();
        public FrmClienteEstreno()
        {
            InitializeComponent();
        }

        private void FrmClienteEstreno_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        private new void Refresh()
        {
            DataTable dt = clienteEstrenoLogica.ListarClienteEstreno();
            DgvClienteEstreno.DataSource = dt;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProcesoClienteEstreno frmProcesoClienteEstreno = new FrmProcesoClienteEstreno();
            frmProcesoClienteEstreno.ShowDialog();
            Refresh();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdClienteEstreno();
            FrmProcesoClienteEstreno frmProcesoClienteEstreno = new FrmProcesoClienteEstreno((int) Id);
            frmProcesoClienteEstreno.ShowDialog();
            Refresh();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdClienteEstreno();
            try
            {
                clienteEstrenoLogica.EliminarClienteEstreno((int)Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al Eliminar cliente estreno: " + ex.Message);
            }
            Refresh();

        }

        #region HELPER
        private int? GetIdClienteEstreno()
        {
            try
            {

                return int.Parse(DgvClienteEstreno.Rows[DgvClienteEstreno.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}
