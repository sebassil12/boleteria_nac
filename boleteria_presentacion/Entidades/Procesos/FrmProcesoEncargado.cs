using boleteria_acceso_datos.bolteria_tablas;
using boleteria_acceso_datos.DAO;
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
    public partial class FrmProcesoEncargado : Form
    {
        private EncargadoDAO encargadoDAO = new EncargadoDAO();
        private int? Id;
        public FrmProcesoEncargado(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if (this.Id != null)
            {
                Load_Data();
            }
        }

        public void Load_Data()
        {
            EncargadoDAO encargadoDAO = new EncargadoDAO();
            Encargado encargado = encargadoDAO.ObtenerUnEncargado((int)Id);
            TxtNombreEncargado.Text = encargado.nombre;
            TxtApellidoEncargado.Text = encargado.apellido;

        }

        private void InsertarEncargado(Encargado encargado)
        {
            try
            {
                encargadoDAO.InsertarEncargado(encargado);
            }catch(Exception ex)
            {
                throw new Exception("Problemas al insertar encargado: " + ex.Message);
            }
        }
        private void ActualizarEncargado(Encargado encargado)
        {
            try
            {
                encargadoDAO.ActualizarEncargado(encargado, (int)Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Problemas al insertar encargado: " + ex.Message);
            }
        }


        private void FrmProcesoEncargado_Load(object sender, EventArgs e)
        {

        }

        private void BtnEncargado_Click(object sender, EventArgs e)
        {
            Encargado encargado = new Encargado();
            encargado.nombre = TxtNombreEncargado.Text;
            encargado.apellido = TxtApellidoEncargado.Text;
            if(Id == null)
            {
                try
                {
                    InsertarEncargado(encargado);
                }
                catch (Exception ex)
                {
                    throw new Exception("Problemas:" + ex.Message);
                }
            }
            else
            {
                try
                {
                    ActualizarEncargado(encargado);
                }
                catch (Exception ex)
                {
                    throw new Exception("Problemas:" + ex.Message);
                }
            }
           

            this.Close();
        }
    }
}
