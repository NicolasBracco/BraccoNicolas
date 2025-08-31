using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioCrud
{
    public partial class FormABM : Form
    {
        private int? Id;
        public FormABM(int? id=null)
        {
            InitializeComponent();
            this.Id = id;

            if(Id != null)
               CargarDatos();
            
        }
        private void CargarDatos()
        {
            Personas oPersonas = new Personas();
            ListaPersonas ListPersonas = oPersonas.ObtenerPersonasPorId(Id);

            txtNombre.Text = ListPersonas.Nombre;
            txtNumTelefono.Text = ListPersonas.NumTelefono.ToString();
            txtMail.Text = ListPersonas.Mail;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Personas oPersonas = new Personas();
            try
            {
                if (Id == null)
                {
                    oPersonas.Agregar(txtNombre.Text, int.Parse(txtNumTelefono.Text), txtMail.Text);
                    MessageBox.Show("Persona agregada con exito");
                }
                else
                { 
                    oPersonas.Editar(txtNombre.Text, int.Parse(txtNumTelefono.Text), txtMail.Text, (int)Id);
                    MessageBox.Show("Persona editada con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al guardar: " + ex.Message);
            }

           
        }
    }
}
