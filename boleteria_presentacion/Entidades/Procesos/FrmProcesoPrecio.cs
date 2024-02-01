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
    public partial class FrmProcesoPrecio : Form
    {
        private PrecioLogica precioLogica = new PrecioLogica();
        int? Id;
        public FrmProcesoPrecio(int? Id = null)
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
            Precio precio = new Precio();
            precio = precioLogica.ObtenerUnPrecio((int)Id);
            TxtValor.Text = precio.Valor.ToString();
            DtpFecha.Text = precio.Fecha.ToString();


        }
        private void FrmProcesoPrecio_Load(object sender, EventArgs e)
        {

        }
        private void InsertarPrecio(Precio precio)
        {
            try
            {
                precioLogica.InsertarPrecio(precio);
            }catch(Exception ex)
            {
                throw new Exception("Error al insertar precio: " + ex.Message);
            }

        }
        private void ActualizarPrecio(Precio precio, int Id)
        {
            try
            {
                precioLogica.ActualizarPrecio(precio, Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al actualizar precio: " + ex.Message);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Precio precio = new Precio();
            precio.Valor = decimal.Parse(TxtValor.Text);
            DateTime fechaSeleccionada = DtpFecha.Value;
            precio.Fecha = fechaSeleccionada;

            try
            {
                if(Id == null)
                {
                    InsertarPrecio(precio);
                }
                else
                {
                    ActualizarPrecio(precio, (int)Id);
                }
            }catch(Exception ex)
            {
                throw new Exception("Error en el proceso CU: " + ex.Message);
            }
            this.Close();
        }
    }
}
