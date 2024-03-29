﻿using boleteria_logica;
using boleteria_presentacion.Entidades.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boleteria_presentacion.Entidades.Vista
{
    public partial class FrmPelicula : Form
    {
        private PeliculaLogica peliculaLogica = new PeliculaLogica();
        public FrmPelicula()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProcesoPelicula frmProcesoPelicula = new FrmProcesoPelicula();
            frmProcesoPelicula.ShowDialog();
            Refresh();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdPelicula();
            FrmProcesoPelicula frmProcesoPelicula = new FrmProcesoPelicula((int)Id);
            frmProcesoPelicula.ShowDialog();
            Refresh();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdPelicula();
            try
            {
                peliculaLogica.EliminarPelicula((int)Id);
            }catch(Exception ex)
            {
                throw new Exception("Error al eliminar pelicula" + ex.Message);
            }
            Refresh();
        }

        private void FrmPelicula_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private new void Refresh()
        {
            DataTable dt = peliculaLogica.ListarPelicula();
            DgvPelicula.DataSource = dt;
        }

        #region HELPER
        private int? GetIdPelicula()
        {
            try
            {

                return int.Parse(DgvPelicula.Rows[DgvPelicula.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
