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
    public partial class FrmProcesoEntrada : Form
    {
        private EntradaLogica entradaLogica = new EntradaLogica();
        int? Id;
        public FrmProcesoEntrada(int? Id = null)
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
            Entrada entrada = new Entrada();
            entrada = entradaLogica.ObtenerUnEntrada((int)Id);
            TxtPelicula.Text = entrada.idPelicula.ToString();
            TxtFormaPago.Text = entrada.idFormaPago.ToString();
        }
        private void InsertarEntrada(Entrada entrada)
        {
            try
            {
                entradaLogica.InsertarEntrada(entrada);
            }catch(Exception ex)
            {
                throw new Exception("Error al insertar entrada: " + ex.Message);
            }
        }

        private void ActualizarEntrada(Entrada entrada, int Id)
        {
            try
            {
                entradaLogica.ActualizarUnEntrada(entrada, Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al actualizar entrada: " + ex.Message);
            }
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            entrada.idPelicula = int.Parse(TxtPelicula.Text);
            entrada.idFormaPago = int.Parse(TxtFormaPago.Text);

            try
            {
                if(Id == null)
                {
                    InsertarEntrada(entrada);
                }
                else
                {
                    ActualizarEntrada(entrada, (int)Id);
                }
            }catch(Exception ex)
            {
                throw new Exception("Error en el proceso CU: " + ex.Message);
            }
            this.Close();
        }
    }
}
