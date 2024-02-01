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
    public partial class FrmPrecio : Form
    {
        PrecioLogica precioLogica = new PrecioLogica();
        public FrmPrecio()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProcesoPrecio frmProcesoPrecio = new FrmProcesoPrecio();
            frmProcesoPrecio.ShowDialog();
            Refresh();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdPrecio();
            FrmProcesoPrecio frmProcesoPrecio = new FrmProcesoPrecio((int)Id);
            frmProcesoPrecio.ShowDialog();
            Refresh();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdPrecio();
            try {
                precioLogica.EliminarPrecio((int)Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al eliminar precio: "+ex.Message);
            }
            Refresh();

        }

        private void FrmPrecio_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        #region HELPER
        private int? GetIdPrecio()
        {
            try
            {

                return int.Parse(DgvPrecio.Rows[DgvPrecio.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
        private new void Refresh()
        {
            DataTable dt = precioLogica.ListarPrecio();
            DgvPrecio.DataSource = dt;
        }
    }
}
