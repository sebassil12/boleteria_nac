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
    public partial class FrmFormaPago : Form
    {
        private FormaPagoLogica formaPagoLogica = new FormaPagoLogica();
        public FrmFormaPago()
        {
            InitializeComponent();
        }

        private void FrmFormaPago_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            DataTable dt = formaPagoLogica.ListarFormaPago();
            DgvFormaPago.DataSource = dt;
        }

        #region HELPER
        private int? GetIdFormaPago()
        {
            try
            {

                return int.Parse(DgvFormaPago.Rows[DgvFormaPago.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void EliminarFormaPago(int Id)
        {
            try
            {
                formaPagoLogica.EliminarFormaPago(Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la forma de pago: " + ex.Message);
            }

            Refresh();
        }


        private void BtnNuevoFormaPago_Click(object sender, EventArgs e)
        {
            FrmProcesoFormaPago frmProcesoFormaPago = new FrmProcesoFormaPago();
            frmProcesoFormaPago.ShowDialog();
            Refresh();
        }

        private void BtnEditFormaPago_Click(object sender, EventArgs e)
        {
            int? Id = GetIdFormaPago();
            FrmProcesoFormaPago frmProcesoFormaPago = new FrmProcesoFormaPago(Id);
            frmProcesoFormaPago.ShowDialog();
            Refresh();
        }

        private void BtnEliminarFormaPago_Click(object sender, EventArgs e)
        {
            int? Id = GetIdFormaPago();
            EliminarFormaPago((int)Id);
        }
    }
}
