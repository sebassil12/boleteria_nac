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
    public partial class FrmDescripcionEntrada : Form
    {
        private DescripcionEntradaLogica descripcionEntradaLogica = new DescripcionEntradaLogica();

        public FrmDescripcionEntrada()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProcesoDescripcionEntrada frmProcesoDescripcionEntrada = new FrmProcesoDescripcionEntrada();
            frmProcesoDescripcionEntrada.ShowDialog();
            Refresh();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmProcesoDescripcionEntrada frmProcesoDescripcionEntrada = new FrmProcesoDescripcionEntrada();
            frmProcesoDescripcionEntrada.ShowDialog();
            Refresh();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdDescripcionEntrada();
            try
            {
                descripcionEntradaLogica.EliminarDescripcionEntrada((int)Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar descripcion entrada:" + ex.Message);
            }
            Refresh();
        }

        private void FrmDescripcionEntrada_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private new void Refresh()
        {
            DataTable dt = descripcionEntradaLogica.ListarDescripcionEntrada();
            DgvDescripcionEntrada.DataSource = dt;
        }

        #region HELPER
        private int? GetIdDescripcionEntrada()
        {
            try
            {

                return int.Parse(DgvDescripcionEntrada.Rows[DgvDescripcionEntrada.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
