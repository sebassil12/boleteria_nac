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
    public partial class FrmFechaTentativa : Form
    {
        private FechaTentativaLogica fechaTentativaLogica = new FechaTentativaLogica();
        public FrmFechaTentativa()
        {
            InitializeComponent();
        }

        private void FrmFechaTentativa_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            DataTable dt = fechaTentativaLogica.ListarFechaTentativa();
            DgvFechaTentativa.DataSource = dt;
        }



        #region HELPER
        private int? GetIdFechaTentativa()
        {
            try
            {

                return int.Parse(DgvFechaTentativa.Rows[DgvFechaTentativa.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
        private void EliminarFechaTentativa(int Id)
        {
            try
            {
                fechaTentativaLogica.EliminarFechaTentativa(Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la fecha: " + ex.Message);
            }

            Refresh();
        }
        private void NewDate_Click(object sender, EventArgs e)
        {
            FrmProcesoFechaTentativa frmProcesoFechaTentativa = new FrmProcesoFechaTentativa();
            frmProcesoFechaTentativa.ShowDialog();
            Refresh();
           
        }

        private void DeleteDate_Click(object sender, EventArgs e)
        {
            int? Id = GetIdFechaTentativa();
            EliminarFechaTentativa((int)Id);
        }

        private void EditDate_Click(object sender, EventArgs e)
        {
            int? Id = GetIdFechaTentativa(); 
            FrmProcesoFechaTentativa frmProcesoFechaTentativa = new FrmProcesoFechaTentativa(Id);
            frmProcesoFechaTentativa.ShowDialog();
            Refresh();
        }
    }
}
