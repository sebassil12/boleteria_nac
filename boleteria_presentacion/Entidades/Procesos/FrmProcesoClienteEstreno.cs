using boleteria_acceso_datos.bolteria_tablas;
using boleteria_logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boleteria_presentacion.Entidades.Procesos
{
    public partial class FrmProcesoClienteEstreno : Form
    {
        private ClienteEstrenoLogica clienteEstrenoLogica = new ClienteEstrenoLogica();
        int? Id;
        public FrmProcesoClienteEstreno(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if(this.Id != null)
            {
                Load_Data();
            }
        }

        private void Load_Data()
        {
            ClienteEstreno clienteEstreno = new ClienteEstreno();
            clienteEstreno = clienteEstrenoLogica.ObtenerUnClienteEstreno((int)Id);
            TxtCliente.Text = clienteEstreno.IdCliente.ToString();
            TxtEstreno.Text = clienteEstreno.IdEstreno.ToString();
        }
        private void InsertarClienteEstreno(ClienteEstreno clienteEstreno)
        {
            try
            {
                clienteEstrenoLogica.InsertarClienteEstreno(clienteEstreno);
            }catch(Exception ex)
            {
                throw new Exception("Error al insertar cliente estreno:" + ex.Message);
            }
        }

        private void ActualizarClienteEstreno(ClienteEstreno clienteEstreno, int Id)
        {
            try
            {
                clienteEstrenoLogica.ActualizarClienteEstreno(clienteEstreno, Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al actualizar cliente estreno: "+ex.Message);
            }
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ClienteEstreno clienteEstreno = new ClienteEstreno();
            clienteEstreno.IdCliente = int.Parse(TxtCliente.Text);
            clienteEstreno.IdEstreno = int.Parse(TxtEstreno.Text);
            try
            {
                if (Id == null)
                {
                    InsertarClienteEstreno(clienteEstreno);
                }
                else
                {
                    ActualizarClienteEstreno(clienteEstreno, (int)Id);
                }
            }catch(Exception ex)
            {
                throw new Exception("Error en el proceso CU: " + ex.Message);
            }
            this.Close();
        }

        private void FrmProcesoClienteEstreno_Load(object sender, EventArgs e)
        {

        }
    }
}
