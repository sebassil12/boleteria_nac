using boleteria_logica;
using boleteria_presentacion.Entidades.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boleteria_presentacion.Entidades.Vista
{
    public partial class FrmEntrada : Form
    {
        private EntradaLogica entradaLogica = new EntradaLogica();
        public FrmEntrada()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProcesoEntrada frmProcesoEntrada = new FrmProcesoEntrada();
            frmProcesoEntrada.ShowDialog();
            Refresh();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdEntrada();
            FrmProcesoEntrada frmProcesoEntrada = new FrmProcesoEntrada((int)Id);
            frmProcesoEntrada.ShowDialog();
            Refresh();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdEntrada();
            try
            {
                entradaLogica.EliminarEntrada((int)Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al eliminar entrada: " + ex.Message);
            }
        }
        private new void Refresh()
        {
            DataTable dt = entradaLogica.ListarEntrada();
            DgvEntrada.DataSource = dt;
        }
        #region HELPER
        private int? GetIdEntrada()
        {
            try
            {

                return int.Parse(DgvEntrada.Rows[DgvEntrada.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
