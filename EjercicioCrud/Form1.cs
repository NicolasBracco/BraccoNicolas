namespace EjercicioCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnConexion_Click(object sender, EventArgs e)
        {
            Personas personas = new Personas();

            if (personas.AgregarBaseDatos())
            {
                MessageBox.Show("Conexion Exitosa");
            }
            else
            {
                MessageBox.Show("Conexion Fallida");
            }
        }

        private void Refrescar()
        {
            Personas oPersonas = new Personas();
            DGVPersonas.DataSource = oPersonas.ObtenerPersonas();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FormABM formABM = new FormABM();
            formABM.ShowDialog();
            Refrescar();
        }

        #region Helper
        private int? GetId()
        {
            try
            {
                return int.Parse(DGVPersonas.Rows[DGVPersonas.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }
        #endregion

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                FormABM formABM = new FormABM(Id);
                formABM.ShowDialog();
                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                Personas personas = new Personas();
                personas.Eliminar((int)Id);
                Refrescar();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar");
            }
        }
    }
}
