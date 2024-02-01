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
    public partial class FrmProcesoSala : Form
    {
        SalaLogica salaLogica = new SalaLogica();
        int? Id;
        public FrmProcesoSala(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if (this.Id != null)
            {
                Load_Data();
            }
        }

        private void Load_Data() {
            Sala sala = new Sala();
            sala = salaLogica.ObtenerUnaSala((int)Id);
            TxtNumeroSala.Text = sala.NumeroSala.ToString();
            TxtBloque.Text = sala.Bloque;
        }
        private void InsertarSala(Sala sala)
        {
            try
            {
                salaLogica.InsertarSala(sala);
            }catch(Exception ex)
            {
                throw new Exception("Error al insertar sala: "+ex.Message);
            }
        }
        private void ActualizarSala(Sala sala, int Id)
        {
            try
            {
                salaLogica.ActualizarSala(sala, Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al actualizar la sala: " + ex.Message);
            }
        }
        private void FrmProcesoSala_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala();
            sala.NumeroSala = int.Parse(TxtNumeroSala.Text);
            sala.Bloque = TxtBloque.Text;
            try
            {
                if (Id == null)
                {
                    InsertarSala(sala);
                }
                else
                {
                    ActualizarSala(sala, (int)Id);
                }
            }catch(Exception ex)
            {
                throw new Exception("Error en el proceso CU: "+ex.Message);
            }
            this.Close();
        }
    }
}
