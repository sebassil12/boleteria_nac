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
    public partial class FrmProcesoFechaTentativa : Form
    {
        private FechaTentativaLogica fechaTentativaLogica = new FechaTentativaLogica();
        private int? Id;
        public FrmProcesoFechaTentativa(int? Id = null)
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
            FechaTentativaLogica fechaTentativaLogica = new FechaTentativaLogica();
            FechaTentativa fechaTentativa = new FechaTentativa();
            fechaTentativa = fechaTentativaLogica.ObtenerUnaFechaTentativa((int)Id);
            DtpFechaTentativa.Text = fechaTentativa.Fecha.ToString();
        }

        private void InsertarFechaTentativa(FechaTentativa fechaTentativa)
        {
            try
            {
                fechaTentativaLogica.InsertarFechaTentativa(fechaTentativa);
            }catch(Exception ex)
            {
                throw new Exception("Error al insertar la fecha: " + ex.Message);
            }
        }

        private void ActualizarFechaTentativa(FechaTentativa fechaTentativa, int Id)
        {
            try
            {
                fechaTentativaLogica.ActualizarFechaTentativa(fechaTentativa, Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al actualizar la fecha: " + ex.Message);
            }
        }

     

        private void FrmFechaTentativa_Load(object sender, EventArgs e)
        {

        }

        private void BtnAcceptFecha_Click(object sender, EventArgs e)
        {
            FechaTentativa UpdatefechaTentativa = new FechaTentativa();
       

            DateTime FechaSeleccionada = DtpFechaTentativa.Value;

            

            UpdatefechaTentativa.Fecha = FechaSeleccionada;

    

            try
            {
                if(Id == null)
                {
                    InsertarFechaTentativa(UpdatefechaTentativa);
                }
                else
                {
                    ActualizarFechaTentativa(UpdatefechaTentativa, (int)Id);
                }
            }catch(Exception ex)
            {
                throw new Exception("Error en el proceso CU:" + ex.Message);
            }

            this.Close();
        }

     
    }
}
