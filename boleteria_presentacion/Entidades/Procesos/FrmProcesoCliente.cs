using boleteria_acceso_datos.bolteria_tablas;
using boleteria_acceso_datos.DAO;
using boleteria_logica;
using boleteria_presentacion.Entidades.Vista;
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
    public partial class FrmProcesoCliente : Form
    {
        private ClienteLogica clienteLogica = new ClienteLogica();
        private int? Id;

        public FrmProcesoCliente(int? Id = null)
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
            ClienteLogica clienteLogica = new ClienteLogica();
            Cliente cliente = clienteLogica.ObtenerUnCliente((int)Id);
            TxtName.Text = cliente.Nombre;
            TxtLastname.Text = cliente.Apellido;
            TxtEmail.Text = cliente.Correo;
            TxtCI.Text = cliente.CiRuc;
            TxtAge.Text = cliente.Edad.ToString();

            
        }
        private void InsertarCliente(Cliente cliente)
        {          
            try
            {
                clienteLogica.InsertarCliente(cliente);
            }catch(Exception ex)
            {
                throw new Exception("Error al insertar cliente: " + ex.Message);
            }

        }

        private void ActualizarCliente(Cliente cliente)
        {
            try
            {
                clienteLogica.ActualizarCliente(cliente, (int)Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message);
            }
        }

        private void FrmProcesoCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();
            cliente.Nombre = TxtName.Text;
            cliente.Apellido = TxtLastname.Text;
            cliente.Edad = int.Parse(TxtAge.Text);
            cliente.Correo = TxtEmail.Text;
            cliente.CiRuc = TxtCI.Text;
            if (Id == null)
            {
                InsertarCliente(cliente);
            }
            else
            {
                ActualizarCliente(cliente);
            }
           
            
            this.Close();
        }
    }
}
