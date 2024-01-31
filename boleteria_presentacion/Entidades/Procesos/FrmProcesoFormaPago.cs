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
    public partial class FrmProcesoFormaPago : Form
    {
        private FormaPagoLogica formaPagoLogica = new FormaPagoLogica();
        private int? Id;
        public FrmProcesoFormaPago(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if (this.Id !=null)
            {
                Load_Data();
            }
        }

        private void Load_Data()
        {
            FormaPago formaPago = formaPagoLogica.ObtenerUnaFormaPago((int)Id);
            TxtNombre.Text = formaPago.Nombre;
            TxtDescripcion.Text = formaPago.Descripcion;
            ChkEstado.Checked = Convert.ToBoolean(formaPago.Estado);
        }
        private void InsertarFormaPago(FormaPago formaPago)
        {
            try
            {
                formaPagoLogica.InsertarFormaPago(formaPago);
            }catch(Exception ex)
            {
                throw new Exception("Error al insertar forma pago: " + ex.Message);
            }
        }
        private void ActualizarFormaPago(FormaPago formaPago, int Id)
        {
            try
            {
                formaPagoLogica.ActualizarFormaPago(formaPago, Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al actualizar forma de pago: " + ex.Message);
            }
        }
        private void FrmProcesoFormaPago_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            FormaPago formaPago = new FormaPago();
            formaPago.Nombre = TxtNombre.Text;
            formaPago.Descripcion = TxtDescripcion.Text;
            formaPago.Estado = ChkEstado.Checked ? (byte) 1 : (byte) 0;
            try
            {

            if(Id == null)
            {
                InsertarFormaPago(formaPago);
            }
            else
            {
               ActualizarFormaPago(formaPago, (int)Id);
            }
            
            }catch(Exception ex)
            {
                throw new Exception("Error en el proceso CU " + ex.Message);
            }
            this.Close();
        }
    }
}
