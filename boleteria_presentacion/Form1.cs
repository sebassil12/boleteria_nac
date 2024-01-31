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


            }

        }
    }
}
