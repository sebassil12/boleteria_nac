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
    public partial class FrmProcesoDescripcionEntrada : Form
    {
        private DescripcionEntradaLogica descripcionEntradaLogica = new DescripcionEntradaLogica();
        int? Id;
        public FrmProcesoDescripcionEntrada(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if (this.Id != null)
            {
                Load_Data();
            }
        }
        private void Load_Data()
        {
            DescripcionEntrada descripcionEntrada = new DescripcionEntrada();
            descripcionEntrada = descripcionEntradaLogica.ObtenerUnDescripcionEntrada((int)Id);
            TxtDescripcion.Text = descripcionEntrada.descripcion;
            TxtCantidad.Text = descripcionEntrada.cantidad.ToString();
            TxtCodigo.Text = descripcionEntrada.codigo.ToString();
            TxtPrecio.Text = descripcionEntrada.idPrecio.ToString();
            TxtCliente.Text = descripcionEntrada.idCliente.ToString();

        }
        private void InsertarDescripcionEntrada(DescripcionEntrada descripcionEntrada)
        {
            try
            {
                descripcionEntradaLogica.InsertarDescripcionEntrada(descripcionEntrada);
            }catch(Exception ex)
            {
                throw new Exception("Error al insertar descripcion entrada: " + ex.Message);
            }
        }

        private void ActualizarDescripcionEntrada(DescripcionEntrada descripcionEntrada, int Id)
        {
            try
            {
                descripcionEntradaLogica.ActualizarDescripcionEntrada(descripcionEntrada, Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al actualizar descripcion entrada: " + ex.Message);
            }
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            DescripcionEntrada descripcionEntrada = new DescripcionEntrada();
            descripcionEntrada.descripcion = TxtDescripcion.Text;
            descripcionEntrada.cantidad = int.Parse(TxtCantidad.Text);
            descripcionEntrada.codigo = int.Parse(TxtCodigo.Text);
            descripcionEntrada.idPrecio = int.Parse(TxtPrecio.Text);
            descripcionEntrada.idCliente = int.Parse(TxtCliente.Text);

            try
            {
                if (Id == null)
                {
                    InsertarDescripcionEntrada(descripcionEntrada);
                }
                else
                {
                    ActualizarDescripcionEntrada(descripcionEntrada, (int)Id);
                }
            }catch(Exception ex)
            {
                throw new Exception("Error en el proceso CU: " + ex.Message);
            }
            this.Close();
        }
    }
}
