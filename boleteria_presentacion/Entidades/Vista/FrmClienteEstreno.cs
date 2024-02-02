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
    }
}
