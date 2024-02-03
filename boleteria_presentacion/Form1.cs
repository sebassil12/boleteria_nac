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

namespace boleteria_presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CmbMain.SelectedIndexChanged += CmbMain_Selected;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CmbMain_Selected(object sender, EventArgs e)
        {
            string selectedText = CmbMain.Text;
            switch (selectedText)
            {
                case "Cliente":
                    FrmCliente frmCliente = new FrmCliente();
                    frmCliente.ShowDialog();
                    CmbMain.SelectedIndex = -1;
                    break;
                case "Encargado":
                    FrmEncargado frmEncargado = new FrmEncargado();
                    frmEncargado.ShowDialog();
                    CmbMain.SelectedIndex = -1;
                    break;
                case "Cliente_Estreno":
                    FrmClienteEstreno frmClienteEstreno = new FrmClienteEstreno();
                    frmClienteEstreno.ShowDialog();
                    CmbMain.SelectedIndex = -1;
                    break;
                case "Descripcion_Entrada":
                    FrmDescripcionEntrada frmDescripcionEntrada = new FrmDescripcionEntrada();
                    frmDescripcionEntrada.ShowDialog();
                    CmbMain.SelectedIndex = -1;
                    break;
                case "Entrada":
                    FrmEntrada frmEntrada = new FrmEntrada();
                    frmEntrada.ShowDialog();
                    CmbMain.SelectedIndex = -1;
                    break;
                case "Estreno":
                    FrmEstreno frmEstreno = new FrmEstreno();
                    frmEstreno.ShowDialog();
                    CmbMain.SelectedIndex = -1;
                    break;

                //Insertar los casos restantes
                case "Fecha Tentativa":
                    FrmFechaTentativa frmFechaTentativa = new FrmFechaTentativa();
                    frmFechaTentativa.ShowDialog();
                    CmbMain.SelectedIndex = -1;
                    break;
                case "Forma Pago":
                    FrmFormaPago frmFormaPago = new FrmFormaPago();
                    frmFormaPago.ShowDialog();
                    CmbMain.SelectedIndex = -1;
                    break;
                case "Pelicula":
                    FrmPelicula frmPelicula = new FrmPelicula();
                    frmPelicula.ShowDialog();
                    CmbMain.SelectedIndex = -1;
                    break;
                case "Precio":
                    FrmPrecio frmPrecio = new FrmPrecio();
                    frmPrecio.ShowDialog();
                    CmbMain.SelectedIndex = -1;
                    break;
                case "Reparto":
                    FrmReparto frmReparto = new FrmReparto();
                    frmReparto.ShowDialog();
                    CmbMain.SelectedIndex = -1;
                    break;
                case "Sala":
                    FrmSala frmSala = new FrmSala();
                    frmSala.ShowDialog();
                    CmbMain.SelectedIndex = -1;
                    break;
                case "Trailer":
                    FrmTrailer frmTrailer = new FrmTrailer();
                    frmTrailer.ShowDialog();
                    CmbMain.SelectedIndex = -1;
                    break;
            }

        }
    }
}
